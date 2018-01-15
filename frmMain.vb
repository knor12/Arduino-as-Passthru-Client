Public Class btnVersionInfo
    Dim arduino As Device_Arduino

    Dim cbDigitalPinsArr() As ComboBox
    Dim cbDigitalConfigValArr() As ComboBox
    Dim cbDigitalValArr() As ComboBox

    Dim cbAnalogPinsArr() As ComboBox
    Dim txtAnalogRefVoltArr() As TextBox
    Dim txtAnalogValReadArr() As TextBox
    Dim txtAnalogReadVoltArr() As TextBox

    Dim cbPWMPinsArr() As ComboBox
    Dim txtPWMValArr() As TextBox
    Dim objINA219 As INA219


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        startUp()



    End Sub

    Private Sub startUp()
        Dim strPorts() As String = System.IO.Ports.SerialPort.GetPortNames()

        cbSerialProts.Items.Add("Auto")
        For Each StrPort As String In strPorts
            cbSerialProts.Items.Add(StrPort)

        Next

        cbSerialProts.SelectedIndex = 0

        Application.DoEvents()
        Application.DoEvents()

        'add the digital pins 
        ReDim cbDigitalPinsArr(3)
        cbDigitalPinsArr(0) = cbDigitalPin1
        cbDigitalPinsArr(1) = cbDigitalPin2
        cbDigitalPinsArr(2) = cbDigitalPin3
        cbDigitalPinsArr(3) = cbDigitalPin4


        cbDigitalPins.Items.Add("Not used")
        cbDigitalPin4.Items.Add("Not used")
        cbDigitalPin3.Items.Add("Not used")
        cbDigitalPin2.Items.Add("Not used")
        cbDigitalPin1.Items.Add("Not used")
        cbDigitalPins.Items.Add("13")
        cbDigitalPin4.Items.Add("13")
        cbDigitalPin3.Items.Add("13")
        cbDigitalPin2.Items.Add("13")
        cbDigitalPin1.Items.Add("13")
        For i As Integer = 22 To 53
            cbDigitalPins.Items.Add(i.ToString)
            cbDigitalPin4.Items.Add(i.ToString)
            cbDigitalPin3.Items.Add(i.ToString)
            cbDigitalPin2.Items.Add(i.ToString)
            cbDigitalPin1.Items.Add(i.ToString)
        Next

        'add digital config val 
        ReDim cbDigitalConfigValArr(3)
        cbDigitalConfigValArr(0) = cbDigitalConfigVal1
        cbDigitalConfigValArr(1) = cbDigitalConfigVal2
        cbDigitalConfigValArr(2) = cbDigitalConfigVal3
        cbDigitalConfigValArr(3) = cbDigitalConfigVal4

        cbDigitalConfigVal.Items.Add("Input")
        cbDigitalConfigVal.Items.Add("Output")

        cbDigitalConfigVal1.Items.Add("Input")
        cbDigitalConfigVal1.Items.Add("Output")

        cbDigitalConfigVal2.Items.Add("Input")
        cbDigitalConfigVal2.Items.Add("Output")

        cbDigitalConfigVal3.Items.Add("Input")
        cbDigitalConfigVal3.Items.Add("Output")

        cbDigitalConfigVal4.Items.Add("Input")
        cbDigitalConfigVal4.Items.Add("Output")

        'add digital values
        ReDim cbDigitalValArr(3)
        cbDigitalValArr(0) = cbDigitalVal1
        cbDigitalValArr(1) = cbDigitalVal2
        cbDigitalValArr(2) = cbDigitalVal3
        cbDigitalValArr(3) = cbDigitalVal4

        cbDigitalVal.Items.Add("Low")
        cbDigitalVal.Items.Add("High")


        cbDigitalVal1.Items.Add("Low")
        cbDigitalVal1.Items.Add("High")


        cbDigitalVal2.Items.Add("Low")
        cbDigitalVal2.Items.Add("High")


        cbDigitalVal3.Items.Add("Low")
        cbDigitalVal3.Items.Add("High")


        cbDigitalVal4.Items.Add("Low")
        cbDigitalVal4.Items.Add("High")


        'add analog pins 
        ReDim cbAnalogPinsArr(3)
        cbAnalogPinsArr(0) = cbAnalogPin1
        cbAnalogPinsArr(1) = cbAnalogPin2
        cbAnalogPinsArr(2) = cbAnalogPin3
        cbAnalogPinsArr(3) = cbAnalogPin4

        For i As Integer = 0 To 15
            cbAnalogPin.Items.Add(i.ToString)
            cbAnalogPin1.Items.Add(i.ToString)
            cbAnalogPin2.Items.Add(i.ToString)
            cbAnalogPin3.Items.Add(i.ToString)
            cbAnalogPin4.Items.Add(i.ToString)
        Next

        'add analog ref mode 
        cbAnalogRef.Items.Add("Default")
        cbAnalogRef.Items.Add("External")

        'add analog text boxes for multiple read
        ReDim txtAnalogRefVoltArr(3)
        txtAnalogRefVoltArr(0) = txtAnalogRefVolt1
        txtAnalogRefVoltArr(1) = txtAnalogRefVolt2
        txtAnalogRefVoltArr(2) = txtAnalogRefVolt3
        txtAnalogRefVoltArr(3) = txtAnalogRefVolt4

        ReDim txtAnalogValReadArr(3)
        txtAnalogValReadArr(0) = txtAnalogValRead1
        txtAnalogValReadArr(1) = txtAnalogValRead2
        txtAnalogValReadArr(2) = txtAnalogValRead3
        txtAnalogValReadArr(3) = txtAnalogValRead4

        ReDim txtAnalogReadVoltArr(3)
        txtAnalogReadVoltArr(0) = txtAnalogReadVolt1
        txtAnalogReadVoltArr(1) = txtAnalogReadVolt2
        txtAnalogReadVoltArr(2) = txtAnalogReadVolt3
        txtAnalogReadVoltArr(3) = txtAnalogReadVolt4

        ' add PWM pins 
        For i As Integer = 2 To 13
            cbPWMPin.Items.Add(i.ToString)
            cbPWMPin1.Items.Add(i.ToString)
            cbPWMPin2.Items.Add(i.ToString)
            cbPWMPin3.Items.Add(i.ToString)
            cbPWMPin4.Items.Add(i.ToString)
        Next

        ReDim cbPWMPinsArr(3)
        cbPWMPinsArr(0) = cbPWMPin1
        cbPWMPinsArr(1) = cbPWMPin2
        cbPWMPinsArr(2) = cbPWMPin3
        cbPWMPinsArr(3) = cbPWMPin4

        ReDim txtPWMValArr(3)
        txtPWMValArr(0) = txtPWMVal1
        txtPWMValArr(1) = txtPWMVal2
        txtPWMValArr(2) = txtPWMVal3
        txtPWMValArr(3) = txtPWMVal4



        'add SPI Mode 
        cbSPIMode.Items.Add(Device_Arduino.SPI_DATA_MODE.SPI_MODE_0)
        cbSPIMode.Items.Add(Device_Arduino.SPI_DATA_MODE.SPI_MODE_1)
        cbSPIMode.Items.Add(Device_Arduino.SPI_DATA_MODE.SPI_MODE_2)
        cbSPIMode.Items.Add(Device_Arduino.SPI_DATA_MODE.SPI_MODE_3)

        'add spi Clock Dividers 
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV2)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV4)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV8)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV16)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV32)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV64)
        cbSPIClockDivider.Items.Add(Device_Arduino.SPI_COCK_DIVIDER.SP_CLOCK_DIV128)


        'add SPI bit order 
        cbSPIBitOrder.Items.Add(Device_Arduino.SPI_BIT_ORDER.MOST_SIGNIFICANT_BIT_FIRST)
        cbSPIBitOrder.Items.Add(Device_Arduino.SPI_BIT_ORDER.LEAST_SIGNIFICANT_BIT_FIRST)

        'add nCS SPI pins 
        cbSPInCS_Pins.Items.Add(13)
        For i As Integer = 22 To 53
            cbSPInCS_Pins.Items.Add(i)
        Next

    End Sub


    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Dim count As Long
    Public Sub sublog(ByVal str As String)
        'textbox.Text = te
        count += 1
        Me.Text = count
        Application.DoEvents()
        txtLog.AppendText(vbNewLine & Now.Hour.ToString("00") & " : " & Now.Minute.ToString("00") & " : " & Now.Second.ToString("00") & " >>> " & str)
        txtLog.Select(txtLog.TextLength, 0)

        Application.DoEvents()
    End Sub


    Private Function log_() As System.Action(Of String)
        Throw New NotImplementedException
    End Function

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try

            If btnConnect.Text = "Connect" Then
                arduino = New Device_Arduino(AddressOf sublog)
                If cbSerialProts.SelectedItem.ToString.ToUpper.Contains("AUTO") Then
                    Dim strPortName As String = Device_Arduino.findDevicePortName(AddressOf sublog)
                    If Not (strPortName Is Nothing) Then
                        arduino.PortName = strPortName
                    Else
                        sublog("Faild to find a valid device")
                        Return
                    End If
                Else
                    arduino.PortName = cbSerialProts.SelectedItem.ToString '"COM7"
                End If


                wait(100)


                arduino.Open()
                objINA219 = New INA219(arduino)
                btnConnect.Text = "Disconnect"

                sublog("Device protocol version " & Device_Arduino.PROTOCOL_VERSION.PROTOCOL_VERSION_MAJOR & "." & _
                       Device_Arduino.PROTOCOL_VERSION.PROTOCOL_VERSION_MINOR)
                sublog("Device firmware version " & Device_Arduino.FIRMWARE_VERSION.FIRMWARE_VERSION_MAJOR & "." & _
                       Device_Arduino.FIRMWARE_VERSION.FIRMWARE_VERSION_MINOR)
                sublog("Now connected")

                'arduino.setLogSubroutine(AddressOf sublog)
                Dim command() As Byte = {0, 0, 1}

                'Dim command_out() As Byte = arduino.writeRead(command)

                'While (btnConnect.Text = "Disconnect")
                '    arduino.writeRead(command)
                '    Application.DoEvents()
                '    wait(1000)
                'End While
            Else
                If arduino.IsOpen Then
                    arduino.Close()
                End If
                btnConnect.Text = "Connect"
                sublog("Now disconnected")
            End If
        Catch ex As Exception
            sublog(ex.Message)
        End Try



    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub


    Private Sub btnRawSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRawSend.Click

        Try
            'get the byte array from the strHex 
            Dim str As String = txtRawDataSend.Text
            Dim byteIn() = New Arduino_Packet().hexToByte(str)
            arduino.writeRead(byteIn)

            'data out read back 
            txtRawKeySend.Text = arduino.Packet_out.getString.Substring(OFFSETS.OFFSET_KEY, 2)
            txtRawChecksumSend.Text = arduino.Packet_out.getString.Substring(OFFSETS.OFFSET_CHECKSUM * 2, 4)
            txtRawLengthSend.Text = arduino.Packet_out.getString.Substring(OFFSETS.OFFSET_LENGTH * 2, 4)
            txtRawErrorSend.Text = arduino.Packet_out.getString.Substring(OFFSETS.OFFSET_ERROR * 2, 4)
            txtRawDataSend.Text = arduino.Packet_out.getString.Substring(OFFSETS.OFFSET_COMMAND * 2)

            'data from the arduino 
            'MessageBox.Show(arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_KEY, 2))

            txtRawKeyReceived.Text = arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_KEY, 2).ToString
            txtrawChecksumReceived.Text = arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_CHECKSUM * 2, 4)
            txtRawLengthReceived.Text = arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_LENGTH * 2, 4)
            txtRawErrorReceived.Text = arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_ERROR * 2, 4)
            txtRawDataReceived.Text = arduino.Packet_in.getString().Substring(OFFSETS.OFFSET_COMMAND * 2)


            txtRawReceivedErrorDesc.Text = CType(arduino.Packet_in.getErrorField(), ERRORS).ToString
            txtReceivedDataIntegrity.Text = CType(arduino.Packet_in.checkPacketIntegrity(), ERRORS).ToString
        Catch ex As Exception
            sublog(ex.Message)
        End Try

    End Sub


    Private Sub cbDigitalConfigVal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalConfigVal.SelectedIndexChanged
        Try
            If cbDigitalPins.SelectedItem.ToString.Equals("") Then
                sublog("Select a digital pin first")
                Return
            End If

            If cbDigitalConfigVal.SelectedItem.ToString.ToUpper.Equals("INPUT") Then

                btnDigitalWriteRead.Text = "Read"
                cbDigitalVal.Enabled = False
                arduino.digitalConfigurePin(CInt(cbDigitalPins.SelectedItem.ToString), Device_Arduino.DIGITAL_DIRECTION.DIGITAL_INPUT)

            ElseIf cbDigitalConfigVal.SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
                btnDigitalWriteRead.Text = "Write"
                cbDigitalVal.Enabled = True
                arduino.digitalConfigurePin(CInt(cbDigitalPins.SelectedItem.ToString), Device_Arduino.DIGITAL_DIRECTION.DIGITAL_OUTPUT)
            End If
        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnDigitalWriteRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigitalWriteRead.Click
        Try
            If btnDigitalWriteRead.Text.ToString.Equals("Read") Then

                'arduino.digitalReadPin(CInt(cbDigitalPins.SelectedItem.ToString))
                cbDigitalVal.SelectedIndex = arduino.digitalReadPin(CInt(cbDigitalPins.SelectedItem.ToString))

            End If

            If btnDigitalWriteRead.Text.ToString.Equals("Write") Then
                If cbDigitalVal.SelectedItem.ToString.Equals("") Then
                    sublog("Select a pin number first")
                    Return
                End If
                Dim val As Device_Arduino.DIGITAL_VALUE
                If cbDigitalVal.SelectedItem.ToString.ToUpper.Equals("HIGH") Then
                    val = Device_Arduino.DIGITAL_VALUE.HIGH
                End If
                If cbDigitalVal.SelectedItem.ToString.ToUpper.Equals("LOW") Then
                    val = Device_Arduino.DIGITAL_VALUE.LOW
                End If
                arduino.digitalWritePin(CInt(cbDigitalPins.SelectedItem.ToString), val)
            End If

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub


    Private Sub cbAnalogRef_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnalogRef.SelectedIndexChanged
        Try
            If cbAnalogRef.SelectedItem.ToString.ToUpper.Equals("EXTERNAL") Then
                arduino.analogConfiguteMode(Device_Arduino.ANALOG_REF_MODE.ANALOG_REF_EXTERNAL)
            ElseIf cbAnalogRef.SelectedItem.ToString.ToUpper.Equals("DEFAULT") Then
                arduino.analogConfiguteMode(Device_Arduino.ANALOG_REF_MODE.ANALOG_REF_DEFAULT)
            End If



        Catch ex As Exception
            sublog(ex.Message)
        End Try

    End Sub

    Private Sub btnAnalogRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalogRead.Click
        Try
            Dim raw As Integer = 0
            Dim rawAcc As Integer
            Dim voltage As Double
            For i As Integer = 1 To 20
                arduino.analogRead(CInt(cbAnalogPin.SelectedItem.ToString), raw, voltage)
                rawAcc += raw
            Next
            raw = rawAcc / 20

            txtAnalogValRead.Text = raw.ToString("0000")
            voltage = (CDbl(txtAnalogRefVolt.Text) * raw) / &H3FF
            txtAnalogReadVolt.Text = voltage.ToString("0.000")
        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnWritePWM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWritePWM.Click
        Try
            Dim pin As Integer = CInt(cbPWMPin.SelectedItem.ToString)
            Dim val = CInt(txtPWMVal.Text)
            If val > 255 Or val < 0 Then
                sublog("PWM needs to be >0 and <255")
                Return
            End If
            arduino.digitalConfigurePin(pin, Device_Arduino.DIGITAL_DIRECTION.DIGITAL_OUTPUT)
            arduino.PWMWrite(pin, val)

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnEPROMWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEPROMWrite.Click
        Try
            Dim intStartAddress = CInt(txtEPROMWriteStartAddress.Text)
            Dim intLength = CInt(txtEPROMWriteLength.Text)
            arduino.EPROMWriteString(intStartAddress, txtEPROMValWrite.Text)

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnEPROMRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEPROMRead.Click
        Try
            Dim intStartAddress = CInt(txtEPROMReadStartAddress.Text)
            Dim intLength = CInt(txtEPROMReadLength.Text)
            txtEPROMValRead.Text = arduino.EPROMReadString(intStartAddress, intLength)

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub



    Private Sub btnSPIConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSPIConfigure.Click
        Try
            Dim nCS_Pin As Integer = CInt(cbSPInCS_Pins.SelectedItem.ToString)
            Dim bit_order As Device_Arduino.SPI_BIT_ORDER = cbSPIBitOrder.SelectedItem '= CType(cbSPIBitOrder.SelectedItem, Device_Arduino.SPI_BIT_ORDER)
            Dim clock_divider As Device_Arduino.SPI_COCK_DIVIDER = cbSPIClockDivider.SelectedItem
            Dim data_mode As Device_Arduino.SPI_DATA_MODE = cbSPIMode.SelectedItem
            arduino.configureSPI(bit_order, clock_divider, data_mode, nCS_Pin)
        Catch ex As Exception
            sublog(ex.Message)
        End Try




    End Sub

    Private Sub btnSPIWriteRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSPIWriteRead.Click
        Try

            Dim str As String = txtSPIHexToSend.Text
            Dim SPI_data_Out() = New Arduino_Packet().hexToByte(str)
            Dim SPI_data_In() = arduino.SPIWriteRead(SPI_data_Out)
            txtSPIHexReceived.Text = New Arduino_Packet().byteToHex(SPI_data_In)
        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnDigitalConfigureMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigitalConfigureMultiple.Click
        Try
            Dim intPinNum As Integer = 0
            Dim Pins() As Integer
            Dim directions() As Device_Arduino.DIGITAL_DIRECTION
            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)
                If cbDigitalPinsArr(i).SelectedItem Is Nothing _
                Or cbDigitalConfigValArr(i).SelectedItem Is Nothing Then

                Else

                    If IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                        intPinNum += 1
                    End If

                End If



            Next

            If intPinNum = 0 Then
                sublog("No pin/direction combination selected ")
                Return
            End If

            ReDim Pins(intPinNum - 1)
            ReDim directions(intPinNum - 1)

            Dim index As Integer = 0
            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)

                If cbDigitalPinsArr(i).SelectedItem Is Nothing Or _
                cbDigitalConfigValArr(i).SelectedItem Is Nothing Then

                Else
                    If IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                        Pins(index) = CInt(cbDigitalPinsArr(i).SelectedItem.ToString())
                        If cbDigitalConfigValArr(i).SelectedItem.ToString.ToUpper.Equals("INPUT") Then
                            directions(index) = Device_Arduino.DIGITAL_DIRECTION.DIGITAL_INPUT
                        ElseIf cbDigitalConfigValArr(i).SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
                            directions(index) = Device_Arduino.DIGITAL_DIRECTION.DIGITAL_OUTPUT
                        Else
                            sublog("Direction of Pin " & _
                                   cbDigitalPinsArr(i).SelectedItem.ToString & " not selected")
                            Return
                        End If
                        index += 1
                    End If
                End If
            Next

            arduino.digitalConfigurePin(Pins, directions)


        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    'arduino.digitalConfigurePin(CInt(cbDigitalPins.SelectedItem.ToString),  _ 
    'Device_Arduino.DIGITAL_DIRECTION.DIGITAL_INPUT)
    'Dim cbDigitalPinsArr() As ComboBox
    'Dim cbDigitalConfigValArr() As ComboBox
    'Dim cbDigitalValArr() As ComboBox

    Private Sub btnDigitalWriteReadMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigitalWriteMultiple.Click
        Try
            Dim intPinNum As Integer = 0
            Dim Pins() As Integer
            Dim values() As Device_Arduino.DIGITAL_VALUE



            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)
                If cbDigitalPinsArr(i).SelectedItem Is Nothing _
                    Or cbDigitalValArr(i).SelectedItem Is Nothing Then

                Else

                    If IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                        intPinNum += 1
                    End If

                End If



            Next

            If intPinNum = 0 Then
                sublog("No pin/direction combination selected ")
                Return
            End If

            ReDim Pins(intPinNum - 1)
            ReDim values(intPinNum - 1)

            Dim index As Integer = 0
            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)
                If cbDigitalPinsArr(i).SelectedItem Is Nothing Or cbDigitalConfigValArr(i).SelectedItem Is Nothing Then
                Else
                    If IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                        Pins(index) = CInt(cbDigitalPinsArr(i).SelectedItem.ToString())
                        If cbDigitalConfigValArr(i).SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
                            If cbDigitalValArr(i).SelectedItem.ToString.ToUpper.Equals("HIGH") Then
                                values(index) = Device_Arduino.DIGITAL_VALUE.HIGH
                                index += 1
                            ElseIf cbDigitalValArr(i).SelectedItem.ToString.ToUpper.Equals("LOW") Then
                                values(index) = Device_Arduino.DIGITAL_VALUE.LOW
                                index += 1
                            Else
                                sublog("Value of Pin " & _
                                       cbDigitalPinsArr(i).SelectedItem.ToString & " not selected")
                                Return
                            End If
                        End If
                    End If
                End If
            Next

            arduino.digitalWritePin(Pins, values)

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub cbDigitalVal1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalVal1.SelectedIndexChanged

    End Sub

    Private Sub cbDigitalConfigVal1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalConfigVal1.SelectedIndexChanged


        If cbDigitalConfigVal1.SelectedItem.ToString.ToUpper.Equals("INPUT") Then
            cbDigitalVal1.SelectedIndex = 0
            cbDigitalVal1.Enabled = False
        ElseIf cbDigitalConfigVal1.SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
            cbDigitalVal1.SelectedIndex = 0
            cbDigitalVal1.Enabled = True
        End If

    End Sub

    Private Sub cbDigitalVal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalVal.SelectedIndexChanged

    End Sub

    Private Sub cbDigitalConfigVal2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalConfigVal2.SelectedIndexChanged

        If cbDigitalConfigVal2.SelectedItem.ToString.ToUpper.Equals("INPUT") Then
            cbDigitalVal2.SelectedIndex = 0
            cbDigitalVal2.Enabled = False
        ElseIf cbDigitalConfigVal2.SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
            cbDigitalVal2.SelectedIndex = 0
            cbDigitalVal2.Enabled = True
        End If

    End Sub

    Private Sub cbDigitalConfigVal3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalConfigVal3.SelectedIndexChanged

        If cbDigitalConfigVal3.SelectedItem.ToString.ToUpper.Equals("INPUT") Then
            cbDigitalVal3.SelectedIndex = 0
            cbDigitalVal3.Enabled = False
        ElseIf cbDigitalConfigVal3.SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
            cbDigitalVal3.SelectedIndex = 0
            cbDigitalVal3.Enabled = True
        End If

    End Sub

    Private Sub cbDigitalConfigVal4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDigitalConfigVal4.SelectedIndexChanged

        If cbDigitalConfigVal4.SelectedItem.ToString.ToUpper.Equals("INPUT") Then
            cbDigitalVal4.SelectedIndex = 0
            cbDigitalVal4.Enabled = False
        ElseIf cbDigitalConfigVal4.SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then
            cbDigitalVal4.SelectedIndex = 0
            cbDigitalVal4.Enabled = True
        End If

    End Sub

    Private Sub btnDigitalReadMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigitalReadMultiple.Click

        Try
            Dim intPinNum As Integer = 0
            Dim Pins() As Integer
            'Dim values() As Integer

            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)
                If cbDigitalPinsArr(i).SelectedItem Is Nothing Or cbDigitalValArr(i).SelectedItem Is Nothing Then

                ElseIf IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                    intPinNum += 1
                End If
            Next

            If intPinNum = 0 Then
                sublog("No pin/direction combination selected ")
                Return
            End If

            ReDim Pins(intPinNum - 1)
            Dim index As Integer = 0

            For i = LBound(cbDigitalPinsArr) To UBound(cbDigitalPinsArr)
                If cbDigitalPinsArr(i).SelectedItem Is Nothing Or cbDigitalConfigValArr(i).SelectedItem Is Nothing Then

                Else
                    If IsNumeric(cbDigitalPinsArr(i).SelectedItem.ToString()) Then
                        Pins(index) = CInt(cbDigitalPinsArr(i).SelectedItem.ToString())
                        If cbDigitalConfigValArr(i).SelectedItem.ToString.ToUpper.Equals("INPUT") Then
                            index += 1
                        ElseIf cbDigitalConfigValArr(i).SelectedItem.ToString.ToUpper.Equals("OUTPUT") Then

                        End If
                    End If
                End If
            Next

            arduino.digitalReadPin(Pins)

        Catch ex As Exception
            sublog(ex.Message)
        End Try
    End Sub

    Private Sub btnAnalogReadMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalogReadMultiple.Click

        Try
            Dim pinArr() As Integer
            Dim numPins As Integer

            For i = LBound(cbAnalogPinsArr) To UBound(cbAnalogPinsArr)
                If cbAnalogPinsArr(i).SelectedItem Is Nothing Or cbAnalogRef.SelectedItem Is Nothing Then

                ElseIf IsNumeric(cbAnalogPinsArr(i).SelectedItem.ToString()) Then
                    numPins += 1
                End If
            Next

            If numPins = 0 Then
                sublog("No pin/reference voltage entered")
                Return
            End If

            ReDim pinArr(numPins - 1)
            Dim rawArr(numPins - 1) As Integer
            Dim rawAcc As Integer = 0
            Dim voltageArr(numPins - 1) As Double

            For i = LBound(cbAnalogPinsArr) To UBound(cbAnalogPinsArr)
                If cbAnalogPinsArr(i).SelectedItem Is Nothing Or cbAnalogRef.SelectedItem Is Nothing Then

                ElseIf IsNumeric(cbAnalogPinsArr(i).SelectedItem.ToString()) And IsNumeric(txtAnalogRefVoltArr(i).Text) Then
                    pinArr(i) = CInt(cbAnalogPinsArr(i).SelectedItem.ToString())
                End If
            Next

            arduino.analogRead(pinArr, rawArr, voltageArr)

            For i As Integer = 0 To numPins - 1
                txtAnalogValReadArr(i).Text = rawArr(i).ToString("0000")
                voltageArr(i) = (CDbl(txtAnalogRefVoltArr(i).Text) * rawArr(i)) / &H3FF
                txtAnalogReadVoltArr(i).Text = voltageArr(i).ToString("0.000")
            Next

        Catch ex As Exception
            sublog(ex.Message)
        End Try

    End Sub

    Private Sub btnWritePWMMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWritePWMMultiple.Click

        Try
            Dim numPins As Integer = 0
            Dim pinArr() As Integer
            Dim valuesArr() As Integer
            Dim directionArr() As Device_Arduino.DIGITAL_DIRECTION

            For i = LBound(cbPWMPinsArr) To UBound(cbPWMPinsArr)
                If cbPWMPinsArr(i).SelectedItem Is Nothing Or txtPWMValArr(i).Text Is Nothing Then

                ElseIf IsNumeric(cbPWMPinsArr(i).SelectedItem.ToString()) Then
                    numPins += 1
                End If
            Next

            If numPins <= 0 Then
                sublog("Select a pin and enter a PWM write value")
                Return
            End If

            ReDim pinArr(numPins - 1)
            ReDim valuesArr(numPins - 1)
            ReDim directionArr(numPins - 1)

            For i = LBound(cbPWMPinsArr) To UBound(cbPWMPinsArr)
                If cbPWMPinsArr(i).SelectedItem Is Nothing Or txtPWMValArr(i).Text Is Nothing Then

                Else
                    If IsNumeric(cbPWMPinsArr(i).SelectedItem.ToString()) And IsNumeric(txtPWMValArr(i).Text) Then

                        pinArr(i) = CInt(cbPWMPinsArr(i).SelectedItem.ToString())
                        valuesArr(i) = CInt(txtPWMValArr(i).Text)
                        directionArr(i) = Device_Arduino.DIGITAL_DIRECTION.DIGITAL_OUTPUT

                        If valuesArr(i) > 255 Or valuesArr(i) < 0 Then
                            sublog("PWM needs to be >0 and <255")
                            Return
                        End If
                    End If
                End If
            Next

            arduino.digitalConfigurePin(pinArr, directionArr)
            arduino.PWMWrite(pinArr, valuesArr)

        Catch ex As Exception
            sublog(ex.Message)
        End Try

    End Sub

    Private Sub btnVersionInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtProtocolVersion.Text = Device_Arduino.PROTOCOL_VERSION.PROTOCOL_VERSION_MAJOR & "." & Device_Arduino.PROTOCOL_VERSION.PROTOCOL_VERSION_MINOR
        txtFirmwareVersion.Text = Device_Arduino.FIRMWARE_VERSION.FIRMWARE_VERSION_MAJOR & "." & Device_Arduino.FIRMWARE_VERSION.FIRMWARE_VERSION_MINOR

    End Sub

    Private Sub btn_INA_219_Read_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_INA_219_Read_All.Click
        Try
            'MsgBox(txt_INA219_I2C_Address.Text)
            Dim i2c_Address As UInt16 = Val(txt_INA219_I2C_Address.Text)
            objINA219.setI2C_Address(i2c_Address)

            objINA219.reset()
            objINA219.setCalibration_32V_2A()
            txt_INA219_Shunt_Voltage.Text = objINA219.getShuntVoltage_mV() & "(mV)"

            txt_INA219_Bus_Voltage.Text = objINA219.getBusVoltage_V() & "(V)"

            txt_INA219_Current.Text = objINA219.getCurrent_mA() & "(mA)"



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Try

            Dim i2c_Address As UInt16 = Val(txt_INA219_I2C_Address.Text)
            objINA219.setI2C_Address(i2c_Address)

            objINA219.reset()
         


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCalibrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalibrate.Click
        Try
            MsgBox(txt_INA219_I2C_Address.Text)
            Dim i2c_Address As UInt16 = Val(txt_INA219_I2C_Address.Text)
            objINA219.setI2C_Address(i2c_Address)


            objINA219.setCalibration_32V_2A()
            



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreadBusVoltage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreadBusVoltage.Click
        Try
            MsgBox(txt_INA219_I2C_Address.Text)
            Dim i2c_Address As UInt16 = Val(txt_INA219_I2C_Address.Text)
            objINA219.setI2C_Address(i2c_Address)

         

            txt_INA219_Bus_Voltage.Text = objINA219.getBusVoltage_V() & "(V)"





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Enabled = False
            'MsgBox(txt_INA219_I2C_Address.Text)
            Dim i2c_Address As UInt16 = Val(txt_INA219_I2C_Address.Text)
            objINA219.setI2C_Address(i2c_Address)

            objINA219.reset()
            objINA219.setCalibration_32V_2A()
            txt_INA219_Shunt_Voltage.Text = objINA219.getShuntVoltage_mV() & "(mV)"

            txt_INA219_Bus_Voltage.Text = objINA219.getBusVoltage_V() & "(V)"

            txt_INA219_Current.Text = objINA219.getCurrent_mA() & "(mA)"

            Timer1.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Interval = 500
        Timer1.Enabled = Not Timer1.Enabled
        Button2.Text = Timer1.Enabled
    End Sub
End Class
