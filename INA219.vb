Public Class INA219

    Dim Arduino As Device_Arduino
    Dim I2C_Address As UInt16

    Dim ina219_calValue As UInt32
    ' The following multipliers are used to convert raw current and power
    'values to mA and mW, taking into account the current config settings
    Dim ina219_currentDivider_mA As UInt32
    Dim ina219_powerDivider_mW As UInt32

    Enum REGISTERS
        INA219_REG_CONFIG = &H0
        INA219_REG_SHUNTVOLTAGE = &H1
        INA219_REG_BUSVOLTAGE = &H2
        INA219_REG_POWER = &H3
        INA219_REG_CURRENT = &H4
        INA219_REG_CALIBRATION = &H5
    End Enum

    Enum BVOLTAGERANGE
        INA219_CONFIG_BVOLTAGERANGE_MASK = &H2000   ' (0x2000)  // Bus Voltage Range Mask
        INA219_CONFIG_BVOLTAGERANGE_16V = &H0    ' (0x0000)  // 0-16V Range
        INA219_CONFIG_BVOLTAGERANGE_32V = &H2000    '  (0x2000)  // 0-32V Range
    End Enum


    Enum GAIN
        INA219_CONFIG_GAIN_MASK = &H1800          '(0x1800)  // Gain Mask
        INA219_CONFIG_GAIN_1_40MV = &H0      '(0x0000)  // Gain 1, 40mV Range
        INA219_CONFIG_GAIN_2_80MV = &H800      '(0x0800)  // Gain 2, 80mV Range
        INA219_CONFIG_GAIN_4_160MV = &H1000   '(0x1000)  // Gain 4, 160mV Range
        INA219_CONFIG_GAIN_8_320MV = &H1800    '(0x1800)  // Gain 8, 320mV Range
    End Enum

    Enum BUS_ADC_RESOLUTION
        INA219_CONFIG_BADCRES_MASK = &H780 '  // Bus ADC Resolution Mask
        INA219_CONFIG_BADCRES_9BIT = &H80 '  // 9-bit bus res = 0..511
        INA219_CONFIG_BADCRES_10BIT = &H100 '  // 10-bit bus res = 0..1023
        INA219_CONFIG_BADCRES_11BIT = &H200 '  // 11-bit bus res = 0..2047
        INA219_CONFIG_BADCRES_12BIT = &H400 '  // 12-bit bus res = 0..4097
    End Enum

    Enum SHUNT_ADC_RESOLUTION
        INA219_CONFIG_SADCRES_MASK = &H78 '  // Shunt ADC Resolution and Averaging Mask
        INA219_CONFIG_SADCRES_9BIT_1S_84US = &H0 '  // 1 x 9-bit shunt sample
        INA219_CONFIG_SADCRES_10BIT_1S_148US = &H8 '  // 1 x 10-bit shunt sample
        INA219_CONFIG_SADCRES_11BIT_1S_276US = &H10 '  // 1 x 11-bit shunt sample
        INA219_CONFIG_SADCRES_12BIT_1S_532US = &H18 '  // 1 x 12-bit shunt sample
        INA219_CONFIG_SADCRES_12BIT_2S_1060US = &H48 '	 // 2 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_4S_2130US = &H50 '  // 4 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_8S_4260US = &H58 '  // 8 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_16S_8510US = &H60 '  // 16 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_32S_17MS = &H68 ' // 32 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_64S_34MS = &H70 '  // 64 x 12-bit shunt samples averaged together
        INA219_CONFIG_SADCRES_12BIT_128S_69MS = &H78 '  // 128 x 12-bit shunt samples averaged together
    End Enum

    Enum OPERATIN_MODE
        INA219_CONFIG_MODE_MASK = &H7 ' // Operating Mode Mask
        INA219_CONFIG_MODE_POWERDOWN = &H0
        INA219_CONFIG_MODE_SVOLT_TRIGGERED = &H1
        INA219_CONFIG_MODE_BVOLT_TRIGGERED = &H2
        INA219_CONFIG_MODE_SANDBVOLT_TRIGGERED = &H3
        INA219_CONFIG_MODE_ADCOFF = &H4
        INA219_CONFIG_MODE_SVOLT_CONTINUOUS = &H5
        INA219_CONFIG_MODE_BVOLT_CONTINUOUS = &H6
        INA219_CONFIG_MODE_SANDBVOLT_CONTINUOUS = &H7
    End Enum

    Public Sub New(ByVal Arduino As Device_Arduino)
        Me.Arduino = Arduino
    End Sub


    Public Sub setI2C_Address(ByVal I2C_Address As UInt16)
        Me.I2C_Address = I2C_Address
    End Sub

    Public Sub writeRegister(ByVal register As REGISTERS, _
                             ByVal value As UInt16)

        Dim I2C_Data(2) As Byte
        I2C_Data(0) = register And &HFF
        I2C_Data(1) = value >> 8 'most significant bit first
        I2C_Data(2) = value And &HFF
        Arduino.I2C_Write(I2C_Address, I2C_Data, 3)
        Threading.Thread.Sleep(5)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.writeRegister()")
        End Try
    End Sub

    Public Function readRegister(ByVal register As REGISTERS) As UInt16

        Try
            Dim value As UInt16 = 0
            Dim I2C_Data_send(2) As Byte
            Dim I2C_Data_Receive() As Byte
            I2C_Data_send(0) = register And &HFF
            Arduino.I2C_Write(I2C_Address, I2C_Data_send, 1)

            Threading.Thread.Sleep(1) 'sleep for one milisecond to wait for conversion

            I2C_Data_Receive = Arduino.I2C_Read(I2C_Address, 2)
            value = I2C_Data_Receive(0)
            value = value << 8 'most significant bit first
            value = value Or I2C_Data_Receive(1)
            Return value
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.readRegister()")
        End Try
    End Function



    Public Sub setCalibration_32V_2A()
        Try
            '        // Calibration which uses the highest precision for 
            '// current measurement (0.1mA), at the expense of 
            '// only supporting 16V at 400mA max.

            '// VBUS_MAX = 16V
            '// VSHUNT_MAX = 0.04          (Assumes Gain 1, 40mV)
            '// RSHUNT = 0.1               (Resistor value in ohms)

            '// 1. Determine max possible current
            '// MaxPossible_I = VSHUNT_MAX / RSHUNT
            '// MaxPossible_I = 0.4A

            '// 2. Determine max expected current
            '// MaxExpected_I = 0.4A

            '// 3. Calculate possible range of LSBs (Min = 15-bit, Max = 12-bit)
            '// MinimumLSB = MaxExpected_I/32767
            '// MinimumLSB = 0.0000122              (12uA per bit)
            '// MaximumLSB = MaxExpected_I/4096
            '// MaximumLSB = 0.0000977              (98uA per bit)

            '// 4. Choose an LSB between the min and max values
            '//    (Preferrably a roundish number close to MinLSB)
            '// CurrentLSB = 0.00005 (50uA per bit)

            '// 5. Compute the calibration register
            '// Cal = trunc (0.04096 / (Current_LSB * RSHUNT))
            '// Cal = 8192 (0x2000)

            'ina219_calValue = 8192;

            '// 6. Calculate the power LSB
            '// PowerLSB = 20 * CurrentLSB
            '// PowerLSB = 0.001 (1mW per bit)

            '// 7. Compute the maximum current and shunt voltage values before overflow
            '//
            '// Max_Current = Current_LSB * 32767
            '// Max_Current = 1.63835A before overflow
            '//
            '// If Max_Current > Max_Possible_I then
            '//    Max_Current_Before_Overflow = MaxPossible_I
            '// Else
            '//    Max_Current_Before_Overflow = Max_Current
            '// End If
            '//
            '// Max_Current_Before_Overflow = MaxPossible_I
            '// Max_Current_Before_Overflow = 0.4
            '//
            '// Max_ShuntVoltage = Max_Current_Before_Overflow * RSHUNT
            '// Max_ShuntVoltage = 0.04V
            '//
            '// If Max_ShuntVoltage >= VSHUNT_MAX
            '//    Max_ShuntVoltage_Before_Overflow = VSHUNT_MAX
            '// Else
            '//    Max_ShuntVoltage_Before_Overflow = Max_ShuntVoltage
            '// End If
            '//
            '// Max_ShuntVoltage_Before_Overflow = VSHUNT_MAX
            '// Max_ShuntVoltage_Before_Overflow = 0.04V

            '// 8. Compute the Maximum Power
            '// MaximumPower = Max_Current_Before_Overflow * VBUS_MAX
            '// MaximumPower = 0.4 * 16V
            '// MaximumPower = 6.4W

            ina219_calValue = 4096
            ' // Set multipliers to convert raw current/power values
            ina219_currentDivider_mA = 10 '  // Current LSB = 50uA per bit (1000/50 = 20)
            ina219_powerDivider_mW = 2 '     // Power LSB = 1mW per bit

            'Set Calibration register to 'Cal' calculated above 
            writeRegister(REGISTERS.INA219_REG_CALIBRATION, ina219_calValue)

            Dim config As UInt16

            config = BVOLTAGERANGE.INA219_CONFIG_BVOLTAGERANGE_32V _
            Or GAIN.INA219_CONFIG_GAIN_8_320MV _
            Or BUS_ADC_RESOLUTION.INA219_CONFIG_BADCRES_12BIT _
            Or SHUNT_ADC_RESOLUTION.INA219_CONFIG_SADCRES_12BIT_1S_532US _
            Or OPERATIN_MODE.INA219_CONFIG_MODE_SANDBVOLT_CONTINUOUS

            writeRegister(REGISTERS.INA219_REG_CONFIG, config)




        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.setCalibration_32V_2A()")
        End Try
    End Sub

    Public Function getBusVoltage_raw() As UInt16
        Try
            Dim value As UInt16
            value = readRegister(REGISTERS.INA219_REG_BUSVOLTAGE)
            value = value >> 3
            value = value * 4
            Return value
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getBusVoltage_raw()")
        End Try

    End Function


    Public Function getShuntVoltage_raw() As UInt16
        Try
            Dim value As UInt16
            value = readRegister(REGISTERS.INA219_REG_SHUNTVOLTAGE)
            Return value
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getShuntVoltage_raw()")
        End Try

    End Function

    Public Function getCurrent_raw() As Int16
        Try
            Dim value As UInt16
            '// Sometimes a sharp load will reset the INA219, which will
            '// reset the cal register, meaning CURRENT and POWER will
            '// not be available ... avoid this by always setting a cal
            '// value even if it's an unfortunate extra step
            writeRegister(REGISTERS.INA219_REG_CALIBRATION, ina219_calValue)
            Threading.Thread.Sleep(5)

            value = readRegister(REGISTERS.INA219_REG_CURRENT)
            'Return DirectCast(value, Int16)
            Dim iValue As Int16 = BitConverter.ToInt16(BitConverter.GetBytes(value), 0)
            Return iValue
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getCurrent_raw()")
        End Try

    End Function

    Public Function reset()
        Try
            writeRegister(REGISTERS.INA219_REG_CONFIG, &H8000)
            Threading.Thread.Sleep(20)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.reset()")
        End Try
    End Function

    Public Function getShuntVoltage_mV() As Single
        Try
            Dim value As UInt16
            Dim sngValue As Single
            value = getShuntVoltage_raw()
            sngValue = value * 0.01
            Return sngValue
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getShuntVoltage_mV()")
        End Try
    End Function

    Public Function getBusVoltage_V() As Single
        Try
            Dim value As UInt16
            Dim sngValue As Single
            value = getBusVoltage_raw()
            sngValue = value * 0.001
            Return sngValue
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getBusVoltage_V()")
        End Try
    End Function


    Public Function getCurrent_mA() As Single
        Try

            Dim sngValue As Single
            sngValue = getCurrent_raw()
            sngValue = sngValue / ina219_currentDivider_mA
            Return sngValue
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & "Error in INA219.getCurrent_mA()")
        End Try
    End Function


End Class
