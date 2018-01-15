Imports System.IO.Ports
Public Class Device_Arduino
    Inherits System.IO.Ports.SerialPort

    'Dim serial As System.IO.Ports.SerialPort
    Dim log As Action(Of String)
    Const msTimeOut As Integer = 2000

    Public Packet_out As Arduino_Packet
    Public Packet_in As Arduino_Packet
    Private analogVoltageReference As Double = 0.0
    Const intBaudRate As Integer = 19200
    Dim dummy As System.IO.Ports.SerialPort


    Enum SPI_BIT_ORDER
        MOST_SIGNIFICANT_BIT_FIRST = 1
        LEAST_SIGNIFICANT_BIT_FIRST = 0
    End Enum

    Enum SPI_COCK_DIVIDER
        SP_CLOCK_DIV2 = &H2
        SP_CLOCK_DIV4 = &H4
        SP_CLOCK_DIV8 = &H8
        SP_CLOCK_DIV16 = &H10
        SP_CLOCK_DIV32 = &H20
        SP_CLOCK_DIV64 = &H40
        SP_CLOCK_DIV128 = &H80
    End Enum

    Enum SPI_DATA_MODE
        SPI_MODE_0 = 0
        SPI_MODE_1 = 1
        SPI_MODE_2 = 2
        SPI_MODE_3 = 3
    End Enum

    Public Sub configureSPI(ByVal bit_order As SPI_BIT_ORDER, _
                            ByVal clock_div As SPI_COCK_DIVIDER, _
                            ByVal mode As SPI_DATA_MODE, _
                            ByVal nCS_Slave_Select_pin As Integer)
        Try



            Dim command(5) As Byte
            command(0) = COMMANDS.COMMAND_SPI
            command(1) = COMMANDS.COMMAND_CONFIGURE
            command(2) = bit_order
            command(3) = clock_div
            command(4) = mode
            command(5) = nCS_Slave_Select_pin

            writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function SPIWriteRead(ByVal SPI_data_to_write() As Byte) As Byte()
        Try
            Dim len As Integer = SPI_data_to_write.Length
            Dim commandReceived() As Byte
            Dim SPI_data_read(len - 1) As Byte
            Dim commandSent(len + 4 - 1) As Byte

            commandSent(0) = COMMANDS.COMMAND_SPI
            commandSent(1) = COMMANDS.COMMAND_WRITE_READ
            commandSent(2) = len And &HFF
            commandSent(3) = (len >> 8) And &HFF
            For i As Integer = 0 To len - 1
                commandSent(4 + i) = SPI_data_to_write(i)
            Next
            commandReceived = writeRead(commandSent)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
            For i As Integer = 0 To len - 1
                SPI_data_read(i) = commandReceived(i + 4)
            Next
            Return SPI_data_read
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & " error in SPIWriteRead()")
        End Try
    End Function


    Public Sub I2C_Write(ByVal I2C_Address As UInt32, _
                              ByRef I2C_Data() As Byte, _
                              Optional ByVal I2C_Data_Length_ As Integer = -9999)
        'if the data length isn't specified, than the whole array I2C_Data() is sent

        Try


            'determine the size of data to be sent
            Dim I2C_Data_Length As UInt32
            If I2C_Data_Length_ = -9999 Then
                I2C_Data_Length = I2C_Data.Length
            Else
                I2C_Data_Length = I2C_Data_Length_
            End If



            Dim commandReceived() As Byte
            Dim commandSent(I2C_Data_Length + 4 - 1) As Byte

            commandSent(0) = COMMANDS.COMMAND_I2C
            commandSent(1) = COMMANDS.COMMAND_WRITE
            commandSent(2) = I2C_Address And &HFF
            commandSent(3) = I2C_Data_Length And &HFF
            For i As Integer = 0 To I2C_Data_Length - 1
                commandSent(4 + i) = I2C_Data(i)
            Next
            commandReceived = writeRead(commandSent)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & " error in I2C_Write()")
        End Try
    End Sub

    Public Function I2C_Read(ByVal I2C_Address As UInt32, _
                             Optional ByVal I2C_Data_Length_ As Integer = -9999) As Byte()
        'if the data length isn't specified, than the number od all available bytes on I2C bus are returned

        Try


            'determine the size of data to be sent
            Dim I2C_Data_Length As UInt32
            If I2C_Data_Length_ = -9999 Then
                I2C_Data_Length = 0 'when sending 0 the protocol returns all available byte 
            Else
                I2C_Data_Length = I2C_Data_Length_
            End If



            Dim commandReceived() As Byte
            Dim commandSent(3) As Byte

            commandSent(0) = COMMANDS.COMMAND_I2C
            commandSent(1) = COMMANDS.COMMAND_READ
            commandSent(2) = I2C_Address And &HFF
            commandSent(3) = I2C_Data_Length And &HFF
            commandReceived = writeRead(commandSent)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If

            'extract the data of bytes returned
            Dim I2C_Data_Received_Length = commandReceived(3) 'determine the number bytes received
            Dim I2C_Data_Received(I2C_Data_Received_Length) As Byte ' initialize an array to store the data received
            For i As Integer = 0 To I2C_Data_Received_Length - 1
                I2C_Data_Received(i) = commandReceived(i + 4)
            Next
            Return I2C_Data_Received
        Catch ex As Exception
            Throw New Exception(ex.Message & vbNewLine & " error in I2C_Read()")
        End Try
    End Function

    Enum DIGITAL_DIRECTION
        DIGITAL_INPUT = &H0
        DIGITAL_OUTPUT = &H1
    End Enum

    Enum DIGITAL_VALUE
        HIGH = 1
        LOW = 0
    End Enum

    Enum COMMANDS
        COMMAND_DIGITAL = &H1
        COMMAND_ANALOG = &H2
        COMMAND_SPI = &H3
        COMMAND_EPROM = &H4
        COMMAND_WRITE = &H5
        COMMAND_READ = &H6
        COMMAND_WRITE_READ = &H7
        COMMAND_CONFIGURE = &H8
        COMMAND_PWM = &H9
        COMMAND_I2C = &HB
    End Enum

    Enum ANALOG_REF_MODE
        ANALOG_REF_DEFAULT = &H1
        ANALOG_REF_EXTERNAL = &H3
    End Enum

    Enum PROTOCOL_VERSION
        PROTOCOL_VERSION_MAJOR = &H1
        PROTOCOL_VERSION_MINOR = &H0
    End Enum

    Enum FIRMWARE_VERSION
        FIRMWARE_VERSION_MAJOR = &H1
        FIRMWARE_VERSION_MINOR = &H0
    End Enum

    Public Sub EPROMWriteBytes(ByVal StartAddress As Integer, ByVal Data() As Byte)

        Try
            'make sure you don't exceed memory space allowed
            If (StartAddress + Data.Length - 1) > 512 Then
                Throw New Exception("You are trying to access EPROM address greater than 512")
                Return
            End If

            Dim command(Data.Length + 3) As Byte
            command(0) = COMMANDS.COMMAND_EPROM
            command(1) = COMMANDS.COMMAND_WRITE
            command(2) = StartAddress
            command(3) = Data.Length
            For i As Integer = 0 To Data.Length - 1
                command(4 + i) = Data(i)
            Next
            writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Public Shared Function findDevicePortName(ByVal log__ As Action(Of String)) As String
        Dim port As New SerialPort
        Dim strPortName As String
        Dim strPorts() As String = System.IO.Ports.SerialPort.GetPortNames()
        Dim bytes() As Byte = {} ' emptry test string
        Dim device As New Device_Arduino(log__)

        For Each strName As String In strPorts
            Try

                device.log("Trying " & strName)
                device.PortName = strName
                If device.IsOpen Then
                    device.Close()
                End If
                device.Open()
                device.writeRead(bytes)
                device.Close()
                If device.Packet_in.checkPacketIntegrity() = ERRORS.ERROR_OK Then
                    device.log("Device found on port " & device.PortName)
                    'device.log("Device protocol version " & PROTOCOL_VERSION.PROTOCOL_VERSION_MAJOR & "." & _
                    '           PROTOCOL_VERSION.PROTOCOL_VERSION_MINOR)
                    'device.log("Device firmware version " & FIRMWARE_VERSION.FIRMWARE_VERSION_MAJOR & "." & _
                    '           FIRMWARE_VERSION.FIRMWARE_VERSION_MINOR)
                    Return strName
                End If

            Catch ex As Exception
                device.log(ex.Message)
            End Try
            If device.IsOpen Then
                device.Close()
            End If
        Next


        Return Nothing

    End Function
    Public Shared Function findDevicePortName() As String

        Dim strPortName As String
        Dim strPorts() As String = System.IO.Ports.SerialPort.GetPortNames()
        Dim bytes() As Byte ' emptry test string
        Dim device As New Device_Arduino()

        For Each strName As String In strPorts
            device.PortName = strName
            'port.BaudRate = intBaudRate
            'port.DataBits = 8
            'port.Parity = IO.Ports.Parity.None
            'port.StopBits = IO.Ports.StopBits.One
            'port.Handshake = IO.Ports.Handshake.None
            ''Encoding = System.Text.Encoding.Default
            'port.ReadTimeout = msTimeOut
            device.WriteTimeout = msTimeOut
            If device.Packet_in.checkPacketIntegrity() = ERRORS.ERROR_OK Then
                Return strName
            End If

            Try
                device.log("Trying " & strName)

            Catch ex As Exception
                device.log(ex.Message)
            End Try
        Next

        Return Nothing

    End Function

    Public Function EPROMReadBytes(ByVal StartAddress As Integer, ByVal numOfBytes As Integer) As Byte()
        Try
            'make sure you don't exceed memory space allowed
            If (StartAddress + numOfBytes) > 512 Then
                Throw New Exception("You are trying to access EPROM address greater than 512")

            End If
            Dim reply() As Byte
            Dim data(numOfBytes - 1) As Byte
            Dim command(4) As Byte
            command(0) = COMMANDS.COMMAND_EPROM
            command(1) = COMMANDS.COMMAND_READ
            command(2) = StartAddress
            command(3) = numOfBytes

            reply = writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If

            For i As Integer = 0 To numOfBytes - 1
                data(i) = reply(4 + i)
            Next
            Return data
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub EPROMWriteString(ByVal StartAddress As Integer, ByVal str As String)
        Try
            Dim data() As Byte = System.Text.Encoding.ASCII.GetBytes(str)
            EPROMWriteBytes(StartAddress, data)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EPROMReadString(ByVal StartAddress As Integer, _
            ByVal strLength As Integer) As String
        Try
            Dim data() As Byte = EPROMReadBytes(StartAddress, strLength)
            Return System.Text.Encoding.ASCII.GetString(data)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub setAnalogVoltageRef(ByVal analogVoltageReference_ As Double)
        analogVoltageReference = analogVoltageReference_
    End Sub

    Public Function getAnalogVoltageRef() As Double
        Return analogVoltageReference
    End Function

    Public Sub analogConfiguteMode(ByVal Mode As ANALOG_REF_MODE)
        Try
            Dim command() As Byte = {COMMANDS.COMMAND_ANALOG, COMMANDS.COMMAND_CONFIGURE, Mode}
            writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub analogRead(ByVal pin As Integer, ByRef RawVal As Integer, ByVal VoltageVal As Double)
        Try
            Dim command() As Byte = {COMMANDS.COMMAND_ANALOG, COMMANDS.COMMAND_READ, pin}
            Dim replay() As Byte
            replay = writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
            RawVal = replay(2)
            RawVal += CUInt(replay(3)) << 8
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub analogRead(ByVal pinArr() As Integer, ByRef RawVal() As Integer, ByVal VoltageVal() As Double)

        Dim numPins As Integer = getMin(pinArr.Length, RawVal.Length) '- 1

        Try
            Dim command(numPins + 1) As Byte
            command(0) = COMMANDS.COMMAND_ANALOG
            command(1) = COMMANDS.COMMAND_READ

            For i As Integer = 0 To numPins - 1
                command(2 + i) = pinArr(i)
            Next

            Dim reply() As Byte
            reply = writeRead(command)
            ReDim RawVal(numPins - 1)
            For i As Integer = 0 To numPins - 1
                RawVal(i) = reply(2 + 3 * i)
                RawVal(i) += CUInt(reply(3 + 3 * i)) << 8
            Next


            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If


        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    Private Function getMin(ByVal int1 As Integer, ByVal int2 As Integer) As Integer
        If int1 < int2 Then
            Return int1
        Else
            Return int2
        End If
    End Function

    Public Sub digitalConfigurePin(ByVal pinArr() As Integer, ByVal directionArr() As DIGITAL_DIRECTION)
        Try
            Dim numPins As Integer = getMin(pinArr.Length, directionArr.Length) '- 1

            Dim command(numPins * 2 + 1) As Byte
            '= {COMMANDS.COMMAND_DIGITAL, COMMANDS.COMMAND_CONFIGURE, pin, direction}
            command(0) = COMMANDS.COMMAND_DIGITAL
            command(1) = COMMANDS.COMMAND_CONFIGURE
            For i As Integer = 0 To numPins - 1
                command(i * 2 + 2) = pinArr(i)
                command(i * 2 + 3) = directionArr(i)
            Next
            Dim replay() As Byte
            replay = writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If



        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub digitalConfigurePin(ByVal pin As Integer, ByVal direction As DIGITAL_DIRECTION)
        Try
            Dim command() As Byte = {COMMANDS.COMMAND_DIGITAL, COMMANDS.COMMAND_CONFIGURE, pin, direction}
            Dim replay() As Byte
            replay = writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function digitalReadPin(ByVal pin As Integer) As DIGITAL_VALUE
        Try
            Dim command() As Byte = {COMMANDS.COMMAND_DIGITAL, COMMANDS.COMMAND_READ, pin}
            Dim reply() As Byte = writeRead(command)

            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
            Return CType(reply(0), DIGITAL_VALUE)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function digitalReadPin(ByVal pinArr() As Integer) As DIGITAL_VALUE

        Try
            Dim numPins As Integer = pinArr.Length
            Dim command(numPins + 1) As Byte
            command(0) = COMMANDS.COMMAND_DIGITAL
            command(1) = COMMANDS.COMMAND_READ

            For i As Integer = 0 To numPins - 1
                command(2 + i) = pinArr(i)
            Next

            Dim reply() As Byte = writeRead(command)
            Return CType(reply(0), DIGITAL_VALUE)

            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub PWMWrite(ByVal pin As Integer, ByVal val As Integer)

        Try
            Dim command() As Byte = {COMMANDS.COMMAND_PWM, pin, val}
            writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub PWMWrite(ByVal pinArr() As Integer, ByVal valArr() As Integer)

        Try
            Dim numPins As Integer = pinArr.Length
            Dim command(2 * numPins) As Byte
            command(0) = COMMANDS.COMMAND_PWM

            For i As Integer = 0 To numPins - 1
                command(1 + 2 * i) = pinArr(i)
                command(2 + 2 * i) = valArr(i)
            Next

            writeRead(command)

            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub digitalWritePin(ByVal pinArr() As Integer, ByVal valueArr() As DIGITAL_VALUE)
        Try
            Dim numPins As Integer = getMin(pinArr.Length, valueArr.Length)

            Dim command(numPins * 2 + 1) As Byte
            command(0) = COMMANDS.COMMAND_DIGITAL
            command(1) = COMMANDS.COMMAND_WRITE
            For i As Integer = 0 To numPins - 1
                command(i * 2 + 2) = pinArr(i)
                command(i * 2 + 3) = valueArr(i)
            Next
            Dim reply() As Byte
            reply = writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub digitalWritePin(ByVal pin As Integer, ByVal val As DIGITAL_VALUE)
        Try
            Dim command() As Byte = {COMMANDS.COMMAND_DIGITAL, COMMANDS.COMMAND_WRITE, pin, val}
            writeRead(command)
            Dim err As Integer = Packet_in.checkPacketIntegrity
            If Not (err = ERRORS.ERROR_OK) Then
                Throw New Exception(CType(Packet_in.getErrorField(), ERRORS).ToString & " error code: " & err)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub Open()
        Try
            MyBase.Open()
            Dim bytesOut() As Byte = {13, 0}
            writeRead(bytesOut)

        Catch ex As Exception
            Throw New Exception("Error opening " & PortName & vbNewLine & ex.Message)
        End Try


    End Sub

    Function writeRead(ByVal byteOut() As Byte) As Byte()


        Try
            DiscardOutBuffer()
            DiscardInBuffer()
            Packet_out = New Arduino_Packet(byteOut)
            Dim strIn As String
            log("write:" & Packet_out.getString())
            WriteLine(Packet_out.getString & vbCr)

            strIn = ReadTo(vbCr)
            log("read:" & strIn)
            While ((Not strIn.Contains("13")) Or strIn.ToLower.Contains("debug"))
                strIn = ReadTo(vbCr)
                log("read:" & strIn)
            End While
            'Dim int As Integer
            'int = Asc(strIn.Substring(0, 1))
            strIn = strIn.Replace(Chr(10), String.Empty)
            Packet_in = New Arduino_Packet(strIn)


            Return Packet_in.getPayLoad()

        Catch ex As Exception
            log(ex.Message)
            ' Throw ' ex

        End Try




    End Function

    Public Sub setLogSubroutine(ByVal log__ As Action(Of String))
        Me.log = log__

    End Sub

    Private Sub log_(ByVal str As String)
        'dummy function 
    End Sub

    Public Sub New(ByVal log__ As Action(Of String))
        Me.log = log__
        BaudRate = intBaudRate
        DataBits = 8
        Parity = IO.Ports.Parity.None
        StopBits = IO.Ports.StopBits.One
        Handshake = IO.Ports.Handshake.None
        Encoding = System.Text.Encoding.Default
        ReadTimeout = msTimeOut
        WriteTimeout = msTimeOut

    End Sub
    Public Sub New()
        BaudRate = intBaudRate
        DataBits = 8
        Parity = IO.Ports.Parity.None
        StopBits = IO.Ports.StopBits.One
        Handshake = IO.Ports.Handshake.None
        Encoding = System.Text.Encoding.Default
        ReadTimeout = msTimeOut
        WriteTimeout = msTimeOut
        Me.log = AddressOf log_
    End Sub

End Class
