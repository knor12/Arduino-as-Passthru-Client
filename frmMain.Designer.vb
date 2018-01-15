<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnVersionInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.cbSerialProts = New System.Windows.Forms.ComboBox
        Me.btnConnect = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.I2C = New System.Windows.Forms.TabControl
        Me.tabRawWriteRead = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtReceivedDataIntegrity = New System.Windows.Forms.TextBox
        Me.txtRawReceivedErrorDesc = New System.Windows.Forms.TextBox
        Me.txtRawDataReceived = New System.Windows.Forms.TextBox
        Me.txtRawDataSend = New System.Windows.Forms.TextBox
        Me.txtRawErrorReceived = New System.Windows.Forms.TextBox
        Me.txtRawErrorSend = New System.Windows.Forms.TextBox
        Me.txtRawLengthReceived = New System.Windows.Forms.TextBox
        Me.txtRawLengthSend = New System.Windows.Forms.TextBox
        Me.txtrawChecksumReceived = New System.Windows.Forms.TextBox
        Me.txtRawChecksumSend = New System.Windows.Forms.TextBox
        Me.txtRawKeyReceived = New System.Windows.Forms.TextBox
        Me.txtRawKeySend = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRawSend = New System.Windows.Forms.Button
        Me.tabDigital = New System.Windows.Forms.TabPage
        Me.btnDigitalReadMultiple = New System.Windows.Forms.Button
        Me.btnDigitalConfigureMultiple = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.cbDigitalVal4 = New System.Windows.Forms.ComboBox
        Me.cbDigitalConfigVal4 = New System.Windows.Forms.ComboBox
        Me.cbDigitalPin4 = New System.Windows.Forms.ComboBox
        Me.cbDigitalVal3 = New System.Windows.Forms.ComboBox
        Me.cbDigitalConfigVal3 = New System.Windows.Forms.ComboBox
        Me.cbDigitalPin3 = New System.Windows.Forms.ComboBox
        Me.cbDigitalVal2 = New System.Windows.Forms.ComboBox
        Me.cbDigitalConfigVal2 = New System.Windows.Forms.ComboBox
        Me.cbDigitalPin2 = New System.Windows.Forms.ComboBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.cbDigitalVal1 = New System.Windows.Forms.ComboBox
        Me.cbDigitalConfigVal1 = New System.Windows.Forms.ComboBox
        Me.cbDigitalPin1 = New System.Windows.Forms.ComboBox
        Me.btnDigitalWriteMultiple = New System.Windows.Forms.Button
        Me.btnDigitalWriteRead = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbDigitalVal = New System.Windows.Forms.ComboBox
        Me.cbDigitalConfigVal = New System.Windows.Forms.ComboBox
        Me.cbDigitalPins = New System.Windows.Forms.ComboBox
        Me.TabAnalog_ = New System.Windows.Forms.TabPage
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.btnAnalogReadMultiple = New System.Windows.Forms.Button
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtAnalogReadVolt4 = New System.Windows.Forms.TextBox
        Me.txtAnalogRefVolt4 = New System.Windows.Forms.TextBox
        Me.txtAnalogValRead4 = New System.Windows.Forms.TextBox
        Me.txtAnalogReadVolt3 = New System.Windows.Forms.TextBox
        Me.txtAnalogRefVolt3 = New System.Windows.Forms.TextBox
        Me.txtAnalogValRead3 = New System.Windows.Forms.TextBox
        Me.txtAnalogReadVolt2 = New System.Windows.Forms.TextBox
        Me.txtAnalogRefVolt2 = New System.Windows.Forms.TextBox
        Me.txtAnalogValRead2 = New System.Windows.Forms.TextBox
        Me.txtAnalogReadVolt1 = New System.Windows.Forms.TextBox
        Me.txtAnalogRefVolt1 = New System.Windows.Forms.TextBox
        Me.txtAnalogValRead1 = New System.Windows.Forms.TextBox
        Me.txtAnalogReadVolt = New System.Windows.Forms.TextBox
        Me.txtAnalogRefVolt = New System.Windows.Forms.TextBox
        Me.txtAnalogValRead = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.cbAnalogPin4 = New System.Windows.Forms.ComboBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.cbAnalogPin3 = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.cbAnalogPin2 = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.cbAnalogPin1 = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnAnalogRead = New System.Windows.Forms.Button
        Me.cbAnalogPin = New System.Windows.Forms.ComboBox
        Me.cbAnalogRef = New System.Windows.Forms.ComboBox
        Me.tabPWM = New System.Windows.Forms.TabPage
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.btnWritePWMMultiple = New System.Windows.Forms.Button
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtPWMVal4 = New System.Windows.Forms.TextBox
        Me.txtPWMVal3 = New System.Windows.Forms.TextBox
        Me.txtPWMVal2 = New System.Windows.Forms.TextBox
        Me.txtPWMVal1 = New System.Windows.Forms.TextBox
        Me.txtPWMVal = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.cbPWMPin4 = New System.Windows.Forms.ComboBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.cbPWMPin3 = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.cbPWMPin2 = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cbPWMPin1 = New System.Windows.Forms.ComboBox
        Me.btnWritePWM = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbPWMPin = New System.Windows.Forms.ComboBox
        Me.tabEPROM = New System.Windows.Forms.TabPage
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnEPROMRead = New System.Windows.Forms.Button
        Me.btnEPROMWrite = New System.Windows.Forms.Button
        Me.txtEPROMValRead = New System.Windows.Forms.TextBox
        Me.txtEPROMReadLength = New System.Windows.Forms.TextBox
        Me.txtEPROMReadStartAddress = New System.Windows.Forms.TextBox
        Me.txtEPROMValWrite = New System.Windows.Forms.TextBox
        Me.txtEPROMWriteLength = New System.Windows.Forms.TextBox
        Me.txtEPROMWriteStartAddress = New System.Windows.Forms.TextBox
        Me.tabSPI = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtSPIHexReceived = New System.Windows.Forms.TextBox
        Me.txtSPIHexToSend = New System.Windows.Forms.TextBox
        Me.btnSPIWriteRead = New System.Windows.Forms.Button
        Me.btnSPIConfigure = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.cbSPInCS_Pins = New System.Windows.Forms.ComboBox
        Me.Mode = New System.Windows.Forms.Label
        Me.cbSPIMode = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.cbSPIClockDivider = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cbSPIBitOrder = New System.Windows.Forms.ComboBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtFirmwareVersion = New System.Windows.Forms.TextBox
        Me.txtProtocolVersion = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txt_I2C_Data_To_Write = New System.Windows.Forms.TextBox
        Me.txt_I2C_Data_Read = New System.Windows.Forms.TextBox
        Me.txt_I2C_Address = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.txt_I2C_Error = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.btn_I2C_Write = New System.Windows.Forms.Button
        Me.btn_I2C_Read = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txt_INA219_I2C_Address = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.voltage = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.txt_INA219_Bus_Voltage = New System.Windows.Forms.TextBox
        Me.txt_INA219_Shunt_Voltage = New System.Windows.Forms.TextBox
        Me.txt_INA219_Current = New System.Windows.Forms.TextBox
        Me.btn_INA_219_Read_All = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnCalibrate = New System.Windows.Forms.Button
        Me.btnreadBusVoltage = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.I2C.SuspendLayout()
        Me.tabRawWriteRead.SuspendLayout()
        Me.tabDigital.SuspendLayout()
        Me.TabAnalog_.SuspendLayout()
        Me.tabPWM.SuspendLayout()
        Me.tabEPROM.SuspendLayout()
        Me.tabSPI.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(10, 19)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(895, 121)
        Me.txtLog.TabIndex = 0
        '
        'cbSerialProts
        '
        Me.cbSerialProts.FormattingEnabled = True
        Me.cbSerialProts.Location = New System.Drawing.Point(6, 19)
        Me.cbSerialProts.Name = "cbSerialProts"
        Me.cbSerialProts.Size = New System.Drawing.Size(121, 21)
        Me.cbSerialProts.TabIndex = 1
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(820, 17)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSerialProts)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(919, 61)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLog)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(919, 146)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.I2C)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(919, 286)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'I2C
        '
        Me.I2C.Controls.Add(Me.tabRawWriteRead)
        Me.I2C.Controls.Add(Me.tabDigital)
        Me.I2C.Controls.Add(Me.TabAnalog_)
        Me.I2C.Controls.Add(Me.tabPWM)
        Me.I2C.Controls.Add(Me.tabEPROM)
        Me.I2C.Controls.Add(Me.tabSPI)
        Me.I2C.Controls.Add(Me.TabPage1)
        Me.I2C.Controls.Add(Me.TabPage2)
        Me.I2C.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.I2C.Location = New System.Drawing.Point(6, 19)
        Me.I2C.Name = "I2C"
        Me.I2C.SelectedIndex = 0
        Me.I2C.Size = New System.Drawing.Size(907, 261)
        Me.I2C.TabIndex = 0
        '
        'tabRawWriteRead
        '
        Me.tabRawWriteRead.Controls.Add(Me.Label9)
        Me.tabRawWriteRead.Controls.Add(Me.txtReceivedDataIntegrity)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawReceivedErrorDesc)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawDataReceived)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawDataSend)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawErrorReceived)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawErrorSend)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawLengthReceived)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawLengthSend)
        Me.tabRawWriteRead.Controls.Add(Me.txtrawChecksumReceived)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawChecksumSend)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawKeyReceived)
        Me.tabRawWriteRead.Controls.Add(Me.txtRawKeySend)
        Me.tabRawWriteRead.Controls.Add(Me.Label8)
        Me.tabRawWriteRead.Controls.Add(Me.Label7)
        Me.tabRawWriteRead.Controls.Add(Me.Label6)
        Me.tabRawWriteRead.Controls.Add(Me.Label5)
        Me.tabRawWriteRead.Controls.Add(Me.Label4)
        Me.tabRawWriteRead.Controls.Add(Me.Label3)
        Me.tabRawWriteRead.Controls.Add(Me.Label2)
        Me.tabRawWriteRead.Controls.Add(Me.Label1)
        Me.tabRawWriteRead.Controls.Add(Me.btnRawSend)
        Me.tabRawWriteRead.Location = New System.Drawing.Point(4, 22)
        Me.tabRawWriteRead.Name = "tabRawWriteRead"
        Me.tabRawWriteRead.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRawWriteRead.Size = New System.Drawing.Size(899, 235)
        Me.tabRawWriteRead.TabIndex = 0
        Me.tabRawWriteRead.Text = "Raw Write/Read"
        Me.tabRawWriteRead.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(95, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Data Received Integrity"
        '
        'txtReceivedDataIntegrity
        '
        Me.txtReceivedDataIntegrity.Location = New System.Drawing.Point(222, 173)
        Me.txtReceivedDataIntegrity.Name = "txtReceivedDataIntegrity"
        Me.txtReceivedDataIntegrity.Size = New System.Drawing.Size(194, 20)
        Me.txtReceivedDataIntegrity.TabIndex = 20
        '
        'txtRawReceivedErrorDesc
        '
        Me.txtRawReceivedErrorDesc.Location = New System.Drawing.Point(222, 130)
        Me.txtRawReceivedErrorDesc.Name = "txtRawReceivedErrorDesc"
        Me.txtRawReceivedErrorDesc.Size = New System.Drawing.Size(194, 20)
        Me.txtRawReceivedErrorDesc.TabIndex = 15
        '
        'txtRawDataReceived
        '
        Me.txtRawDataReceived.Location = New System.Drawing.Point(414, 99)
        Me.txtRawDataReceived.Name = "txtRawDataReceived"
        Me.txtRawDataReceived.Size = New System.Drawing.Size(194, 20)
        Me.txtRawDataReceived.TabIndex = 13
        '
        'txtRawDataSend
        '
        Me.txtRawDataSend.Location = New System.Drawing.Point(414, 61)
        Me.txtRawDataSend.Name = "txtRawDataSend"
        Me.txtRawDataSend.Size = New System.Drawing.Size(194, 20)
        Me.txtRawDataSend.TabIndex = 12
        '
        'txtRawErrorReceived
        '
        Me.txtRawErrorReceived.Location = New System.Drawing.Point(320, 99)
        Me.txtRawErrorReceived.Name = "txtRawErrorReceived"
        Me.txtRawErrorReceived.Size = New System.Drawing.Size(70, 20)
        Me.txtRawErrorReceived.TabIndex = 11
        '
        'txtRawErrorSend
        '
        Me.txtRawErrorSend.Location = New System.Drawing.Point(320, 61)
        Me.txtRawErrorSend.Name = "txtRawErrorSend"
        Me.txtRawErrorSend.Size = New System.Drawing.Size(70, 20)
        Me.txtRawErrorSend.TabIndex = 10
        '
        'txtRawLengthReceived
        '
        Me.txtRawLengthReceived.Location = New System.Drawing.Point(231, 99)
        Me.txtRawLengthReceived.Name = "txtRawLengthReceived"
        Me.txtRawLengthReceived.Size = New System.Drawing.Size(70, 20)
        Me.txtRawLengthReceived.TabIndex = 9
        '
        'txtRawLengthSend
        '
        Me.txtRawLengthSend.Location = New System.Drawing.Point(231, 61)
        Me.txtRawLengthSend.Name = "txtRawLengthSend"
        Me.txtRawLengthSend.Size = New System.Drawing.Size(70, 20)
        Me.txtRawLengthSend.TabIndex = 8
        '
        'txtrawChecksumReceived
        '
        Me.txtrawChecksumReceived.Location = New System.Drawing.Point(138, 99)
        Me.txtrawChecksumReceived.Name = "txtrawChecksumReceived"
        Me.txtrawChecksumReceived.Size = New System.Drawing.Size(70, 20)
        Me.txtrawChecksumReceived.TabIndex = 7
        '
        'txtRawChecksumSend
        '
        Me.txtRawChecksumSend.Location = New System.Drawing.Point(138, 61)
        Me.txtRawChecksumSend.Name = "txtRawChecksumSend"
        Me.txtRawChecksumSend.Size = New System.Drawing.Size(70, 20)
        Me.txtRawChecksumSend.TabIndex = 6
        '
        'txtRawKeyReceived
        '
        Me.txtRawKeyReceived.Location = New System.Drawing.Point(82, 99)
        Me.txtRawKeyReceived.Name = "txtRawKeyReceived"
        Me.txtRawKeyReceived.Size = New System.Drawing.Size(35, 20)
        Me.txtRawKeyReceived.TabIndex = 4
        '
        'txtRawKeySend
        '
        Me.txtRawKeySend.Location = New System.Drawing.Point(82, 61)
        Me.txtRawKeySend.Name = "txtRawKeySend"
        Me.txtRawKeySend.Size = New System.Drawing.Size(35, 20)
        Me.txtRawKeySend.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(317, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Error"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Checksum"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Receive error"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Receive (HEX)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Send (HEX)"
        '
        'btnRawSend
        '
        Me.btnRawSend.Location = New System.Drawing.Point(389, 18)
        Me.btnRawSend.Name = "btnRawSend"
        Me.btnRawSend.Size = New System.Drawing.Size(138, 23)
        Me.btnRawSend.TabIndex = 0
        Me.btnRawSend.Text = "Send/Receive"
        Me.btnRawSend.UseVisualStyleBackColor = True
        '
        'tabDigital
        '
        Me.tabDigital.Controls.Add(Me.btnDigitalReadMultiple)
        Me.tabDigital.Controls.Add(Me.btnDigitalConfigureMultiple)
        Me.tabDigital.Controls.Add(Me.Label37)
        Me.tabDigital.Controls.Add(Me.Label36)
        Me.tabDigital.Controls.Add(Me.Label35)
        Me.tabDigital.Controls.Add(Me.Label34)
        Me.tabDigital.Controls.Add(Me.cbDigitalVal4)
        Me.tabDigital.Controls.Add(Me.cbDigitalConfigVal4)
        Me.tabDigital.Controls.Add(Me.cbDigitalPin4)
        Me.tabDigital.Controls.Add(Me.cbDigitalVal3)
        Me.tabDigital.Controls.Add(Me.cbDigitalConfigVal3)
        Me.tabDigital.Controls.Add(Me.cbDigitalPin3)
        Me.tabDigital.Controls.Add(Me.cbDigitalVal2)
        Me.tabDigital.Controls.Add(Me.cbDigitalConfigVal2)
        Me.tabDigital.Controls.Add(Me.cbDigitalPin2)
        Me.tabDigital.Controls.Add(Me.Label31)
        Me.tabDigital.Controls.Add(Me.Label32)
        Me.tabDigital.Controls.Add(Me.Label33)
        Me.tabDigital.Controls.Add(Me.cbDigitalVal1)
        Me.tabDigital.Controls.Add(Me.cbDigitalConfigVal1)
        Me.tabDigital.Controls.Add(Me.cbDigitalPin1)
        Me.tabDigital.Controls.Add(Me.btnDigitalWriteMultiple)
        Me.tabDigital.Controls.Add(Me.btnDigitalWriteRead)
        Me.tabDigital.Controls.Add(Me.Label12)
        Me.tabDigital.Controls.Add(Me.Label11)
        Me.tabDigital.Controls.Add(Me.Label10)
        Me.tabDigital.Controls.Add(Me.cbDigitalVal)
        Me.tabDigital.Controls.Add(Me.cbDigitalConfigVal)
        Me.tabDigital.Controls.Add(Me.cbDigitalPins)
        Me.tabDigital.Location = New System.Drawing.Point(4, 22)
        Me.tabDigital.Name = "tabDigital"
        Me.tabDigital.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDigital.Size = New System.Drawing.Size(899, 235)
        Me.tabDigital.TabIndex = 1
        Me.tabDigital.Text = "Digital"
        Me.tabDigital.UseVisualStyleBackColor = True
        '
        'btnDigitalReadMultiple
        '
        Me.btnDigitalReadMultiple.Location = New System.Drawing.Point(749, 198)
        Me.btnDigitalReadMultiple.Name = "btnDigitalReadMultiple"
        Me.btnDigitalReadMultiple.Size = New System.Drawing.Size(82, 23)
        Me.btnDigitalReadMultiple.TabIndex = 28
        Me.btnDigitalReadMultiple.Text = "Read Multiple"
        Me.btnDigitalReadMultiple.UseVisualStyleBackColor = True
        '
        'btnDigitalConfigureMultiple
        '
        Me.btnDigitalConfigureMultiple.Location = New System.Drawing.Point(551, 198)
        Me.btnDigitalConfigureMultiple.Name = "btnDigitalConfigureMultiple"
        Me.btnDigitalConfigureMultiple.Size = New System.Drawing.Size(102, 23)
        Me.btnDigitalConfigureMultiple.TabIndex = 27
        Me.btnDigitalConfigureMultiple.Text = "Configure Multiple"
        Me.btnDigitalConfigureMultiple.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(476, 167)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(71, 13)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "Pin Number 4"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(476, 123)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(71, 13)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "Pin Number 3"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(476, 79)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 13)
        Me.Label35.TabIndex = 24
        Me.Label35.Text = "Pin Number 2"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(476, 35)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(71, 13)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "Pin Number 1"
        '
        'cbDigitalVal4
        '
        Me.cbDigitalVal4.FormattingEnabled = True
        Me.cbDigitalVal4.Location = New System.Drawing.Point(756, 164)
        Me.cbDigitalVal4.Name = "cbDigitalVal4"
        Me.cbDigitalVal4.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalVal4.TabIndex = 22
        '
        'cbDigitalConfigVal4
        '
        Me.cbDigitalConfigVal4.FormattingEnabled = True
        Me.cbDigitalConfigVal4.Location = New System.Drawing.Point(653, 164)
        Me.cbDigitalConfigVal4.Name = "cbDigitalConfigVal4"
        Me.cbDigitalConfigVal4.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalConfigVal4.TabIndex = 21
        '
        'cbDigitalPin4
        '
        Me.cbDigitalPin4.FormattingEnabled = True
        Me.cbDigitalPin4.Location = New System.Drawing.Point(553, 164)
        Me.cbDigitalPin4.Name = "cbDigitalPin4"
        Me.cbDigitalPin4.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalPin4.TabIndex = 20
        '
        'cbDigitalVal3
        '
        Me.cbDigitalVal3.FormattingEnabled = True
        Me.cbDigitalVal3.Location = New System.Drawing.Point(756, 120)
        Me.cbDigitalVal3.Name = "cbDigitalVal3"
        Me.cbDigitalVal3.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalVal3.TabIndex = 19
        '
        'cbDigitalConfigVal3
        '
        Me.cbDigitalConfigVal3.FormattingEnabled = True
        Me.cbDigitalConfigVal3.Location = New System.Drawing.Point(653, 120)
        Me.cbDigitalConfigVal3.Name = "cbDigitalConfigVal3"
        Me.cbDigitalConfigVal3.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalConfigVal3.TabIndex = 18
        '
        'cbDigitalPin3
        '
        Me.cbDigitalPin3.FormattingEnabled = True
        Me.cbDigitalPin3.Location = New System.Drawing.Point(553, 120)
        Me.cbDigitalPin3.Name = "cbDigitalPin3"
        Me.cbDigitalPin3.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalPin3.TabIndex = 17
        '
        'cbDigitalVal2
        '
        Me.cbDigitalVal2.FormattingEnabled = True
        Me.cbDigitalVal2.Location = New System.Drawing.Point(756, 76)
        Me.cbDigitalVal2.Name = "cbDigitalVal2"
        Me.cbDigitalVal2.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalVal2.TabIndex = 16
        '
        'cbDigitalConfigVal2
        '
        Me.cbDigitalConfigVal2.FormattingEnabled = True
        Me.cbDigitalConfigVal2.Location = New System.Drawing.Point(653, 76)
        Me.cbDigitalConfigVal2.Name = "cbDigitalConfigVal2"
        Me.cbDigitalConfigVal2.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalConfigVal2.TabIndex = 15
        '
        'cbDigitalPin2
        '
        Me.cbDigitalPin2.FormattingEnabled = True
        Me.cbDigitalPin2.Location = New System.Drawing.Point(553, 76)
        Me.cbDigitalPin2.Name = "cbDigitalPin2"
        Me.cbDigitalPin2.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalPin2.TabIndex = 14
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(753, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "High/Low"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(650, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(38, 13)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "In/Out"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(550, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 13)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Pin Number"
        '
        'cbDigitalVal1
        '
        Me.cbDigitalVal1.FormattingEnabled = True
        Me.cbDigitalVal1.Location = New System.Drawing.Point(756, 32)
        Me.cbDigitalVal1.Name = "cbDigitalVal1"
        Me.cbDigitalVal1.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalVal1.TabIndex = 10
        '
        'cbDigitalConfigVal1
        '
        Me.cbDigitalConfigVal1.FormattingEnabled = True
        Me.cbDigitalConfigVal1.Location = New System.Drawing.Point(653, 32)
        Me.cbDigitalConfigVal1.Name = "cbDigitalConfigVal1"
        Me.cbDigitalConfigVal1.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalConfigVal1.TabIndex = 9
        '
        'cbDigitalPin1
        '
        Me.cbDigitalPin1.FormattingEnabled = True
        Me.cbDigitalPin1.Location = New System.Drawing.Point(553, 32)
        Me.cbDigitalPin1.Name = "cbDigitalPin1"
        Me.cbDigitalPin1.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalPin1.TabIndex = 8
        '
        'btnDigitalWriteMultiple
        '
        Me.btnDigitalWriteMultiple.Location = New System.Drawing.Point(660, 198)
        Me.btnDigitalWriteMultiple.Name = "btnDigitalWriteMultiple"
        Me.btnDigitalWriteMultiple.Size = New System.Drawing.Size(82, 23)
        Me.btnDigitalWriteMultiple.TabIndex = 7
        Me.btnDigitalWriteMultiple.Text = "Write Multiple"
        Me.btnDigitalWriteMultiple.UseVisualStyleBackColor = True
        '
        'btnDigitalWriteRead
        '
        Me.btnDigitalWriteRead.Location = New System.Drawing.Point(179, 84)
        Me.btnDigitalWriteRead.Name = "btnDigitalWriteRead"
        Me.btnDigitalWriteRead.Size = New System.Drawing.Size(75, 23)
        Me.btnDigitalWriteRead.TabIndex = 6
        Me.btnDigitalWriteRead.Text = "Write/Read"
        Me.btnDigitalWriteRead.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(278, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "High/Low"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(175, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "In/Out"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Pins"
        '
        'cbDigitalVal
        '
        Me.cbDigitalVal.FormattingEnabled = True
        Me.cbDigitalVal.Location = New System.Drawing.Point(281, 29)
        Me.cbDigitalVal.Name = "cbDigitalVal"
        Me.cbDigitalVal.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalVal.TabIndex = 2
        '
        'cbDigitalConfigVal
        '
        Me.cbDigitalConfigVal.FormattingEnabled = True
        Me.cbDigitalConfigVal.Location = New System.Drawing.Point(178, 29)
        Me.cbDigitalConfigVal.Name = "cbDigitalConfigVal"
        Me.cbDigitalConfigVal.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalConfigVal.TabIndex = 1
        '
        'cbDigitalPins
        '
        Me.cbDigitalPins.FormattingEnabled = True
        Me.cbDigitalPins.Location = New System.Drawing.Point(78, 29)
        Me.cbDigitalPins.Name = "cbDigitalPins"
        Me.cbDigitalPins.Size = New System.Drawing.Size(76, 21)
        Me.cbDigitalPins.TabIndex = 0
        '
        'TabAnalog_
        '
        Me.TabAnalog_.Controls.Add(Me.Label69)
        Me.TabAnalog_.Controls.Add(Me.Label68)
        Me.TabAnalog_.Controls.Add(Me.Label67)
        Me.TabAnalog_.Controls.Add(Me.Label66)
        Me.TabAnalog_.Controls.Add(Me.btnAnalogReadMultiple)
        Me.TabAnalog_.Controls.Add(Me.Label48)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogReadVolt4)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogRefVolt4)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogValRead4)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogReadVolt3)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogRefVolt3)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogValRead3)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogReadVolt2)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogRefVolt2)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogValRead2)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogReadVolt1)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogRefVolt1)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogValRead1)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogReadVolt)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogRefVolt)
        Me.TabAnalog_.Controls.Add(Me.txtAnalogValRead)
        Me.TabAnalog_.Controls.Add(Me.Label49)
        Me.TabAnalog_.Controls.Add(Me.Label50)
        Me.TabAnalog_.Controls.Add(Me.Label52)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogPin4)
        Me.TabAnalog_.Controls.Add(Me.Label53)
        Me.TabAnalog_.Controls.Add(Me.Label54)
        Me.TabAnalog_.Controls.Add(Me.Label55)
        Me.TabAnalog_.Controls.Add(Me.Label57)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogPin3)
        Me.TabAnalog_.Controls.Add(Me.Label43)
        Me.TabAnalog_.Controls.Add(Me.Label44)
        Me.TabAnalog_.Controls.Add(Me.Label45)
        Me.TabAnalog_.Controls.Add(Me.Label47)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogPin2)
        Me.TabAnalog_.Controls.Add(Me.Label38)
        Me.TabAnalog_.Controls.Add(Me.Label39)
        Me.TabAnalog_.Controls.Add(Me.Label40)
        Me.TabAnalog_.Controls.Add(Me.Label42)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogPin1)
        Me.TabAnalog_.Controls.Add(Me.Label17)
        Me.TabAnalog_.Controls.Add(Me.Label16)
        Me.TabAnalog_.Controls.Add(Me.Label15)
        Me.TabAnalog_.Controls.Add(Me.Label14)
        Me.TabAnalog_.Controls.Add(Me.Label13)
        Me.TabAnalog_.Controls.Add(Me.btnAnalogRead)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogPin)
        Me.TabAnalog_.Controls.Add(Me.cbAnalogRef)
        Me.TabAnalog_.Location = New System.Drawing.Point(4, 22)
        Me.TabAnalog_.Name = "TabAnalog_"
        Me.TabAnalog_.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAnalog_.Size = New System.Drawing.Size(899, 235)
        Me.TabAnalog_.TabIndex = 2
        Me.TabAnalog_.Text = "Analog"
        Me.TabAnalog_.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(485, 8)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(58, 13)
        Me.Label69.TabIndex = 57
        Me.Label69.Text = "Analog Pin"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(485, 56)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(58, 13)
        Me.Label68.TabIndex = 56
        Me.Label68.Text = "Analog Pin"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(485, 149)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(58, 13)
        Me.Label67.TabIndex = 55
        Me.Label67.Text = "Analog Pin"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(485, 101)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(58, 13)
        Me.Label66.TabIndex = 54
        Me.Label66.Text = "Analog Pin"
        '
        'btnAnalogReadMultiple
        '
        Me.btnAnalogReadMultiple.Location = New System.Drawing.Point(613, 191)
        Me.btnAnalogReadMultiple.Name = "btnAnalogReadMultiple"
        Me.btnAnalogReadMultiple.Size = New System.Drawing.Size(147, 23)
        Me.btnAnalogReadMultiple.TabIndex = 53
        Me.btnAnalogReadMultiple.Text = "Read Multiple"
        Me.btnAnalogReadMultiple.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(566, 149)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 13)
        Me.Label48.TabIndex = 52
        Me.Label48.Text = "Analog V Ref"
        '
        'txtAnalogReadVolt4
        '
        Me.txtAnalogReadVolt4.Location = New System.Drawing.Point(781, 165)
        Me.txtAnalogReadVolt4.Name = "txtAnalogReadVolt4"
        Me.txtAnalogReadVolt4.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogReadVolt4.TabIndex = 51
        '
        'txtAnalogRefVolt4
        '
        Me.txtAnalogRefVolt4.Location = New System.Drawing.Point(569, 165)
        Me.txtAnalogRefVolt4.Name = "txtAnalogRefVolt4"
        Me.txtAnalogRefVolt4.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogRefVolt4.TabIndex = 49
        '
        'txtAnalogValRead4
        '
        Me.txtAnalogValRead4.Location = New System.Drawing.Point(675, 165)
        Me.txtAnalogValRead4.Name = "txtAnalogValRead4"
        Me.txtAnalogValRead4.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogValRead4.TabIndex = 45
        '
        'txtAnalogReadVolt3
        '
        Me.txtAnalogReadVolt3.Location = New System.Drawing.Point(781, 117)
        Me.txtAnalogReadVolt3.Name = "txtAnalogReadVolt3"
        Me.txtAnalogReadVolt3.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogReadVolt3.TabIndex = 41
        '
        'txtAnalogRefVolt3
        '
        Me.txtAnalogRefVolt3.Location = New System.Drawing.Point(569, 117)
        Me.txtAnalogRefVolt3.Name = "txtAnalogRefVolt3"
        Me.txtAnalogRefVolt3.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogRefVolt3.TabIndex = 39
        '
        'txtAnalogValRead3
        '
        Me.txtAnalogValRead3.Location = New System.Drawing.Point(675, 117)
        Me.txtAnalogValRead3.Name = "txtAnalogValRead3"
        Me.txtAnalogValRead3.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogValRead3.TabIndex = 35
        '
        'txtAnalogReadVolt2
        '
        Me.txtAnalogReadVolt2.Location = New System.Drawing.Point(781, 72)
        Me.txtAnalogReadVolt2.Name = "txtAnalogReadVolt2"
        Me.txtAnalogReadVolt2.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogReadVolt2.TabIndex = 31
        '
        'txtAnalogRefVolt2
        '
        Me.txtAnalogRefVolt2.Location = New System.Drawing.Point(569, 72)
        Me.txtAnalogRefVolt2.Name = "txtAnalogRefVolt2"
        Me.txtAnalogRefVolt2.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogRefVolt2.TabIndex = 29
        '
        'txtAnalogValRead2
        '
        Me.txtAnalogValRead2.Location = New System.Drawing.Point(675, 72)
        Me.txtAnalogValRead2.Name = "txtAnalogValRead2"
        Me.txtAnalogValRead2.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogValRead2.TabIndex = 25
        '
        'txtAnalogReadVolt1
        '
        Me.txtAnalogReadVolt1.Location = New System.Drawing.Point(781, 24)
        Me.txtAnalogReadVolt1.Name = "txtAnalogReadVolt1"
        Me.txtAnalogReadVolt1.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogReadVolt1.TabIndex = 21
        '
        'txtAnalogRefVolt1
        '
        Me.txtAnalogRefVolt1.Location = New System.Drawing.Point(569, 24)
        Me.txtAnalogRefVolt1.Name = "txtAnalogRefVolt1"
        Me.txtAnalogRefVolt1.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogRefVolt1.TabIndex = 19
        '
        'txtAnalogValRead1
        '
        Me.txtAnalogValRead1.Location = New System.Drawing.Point(675, 24)
        Me.txtAnalogValRead1.Name = "txtAnalogValRead1"
        Me.txtAnalogValRead1.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogValRead1.TabIndex = 15
        '
        'txtAnalogReadVolt
        '
        Me.txtAnalogReadVolt.Location = New System.Drawing.Point(123, 87)
        Me.txtAnalogReadVolt.Name = "txtAnalogReadVolt"
        Me.txtAnalogReadVolt.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogReadVolt.TabIndex = 11
        '
        'txtAnalogRefVolt
        '
        Me.txtAnalogRefVolt.Location = New System.Drawing.Point(204, 39)
        Me.txtAnalogRefVolt.Name = "txtAnalogRefVolt"
        Me.txtAnalogRefVolt.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogRefVolt.TabIndex = 9
        '
        'txtAnalogValRead
        '
        Me.txtAnalogValRead.Location = New System.Drawing.Point(13, 87)
        Me.txtAnalogValRead.Name = "txtAnalogValRead"
        Me.txtAnalogValRead.Size = New System.Drawing.Size(100, 20)
        Me.txtAnalogValRead.TabIndex = 5
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(778, 149)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(84, 13)
        Me.Label49.TabIndex = 50
        Me.Label49.Text = "Analog val (Volt)"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(672, 149)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(88, 13)
        Me.Label50.TabIndex = 48
        Me.Label50.Text = "Analog val (Raw)"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(456, 169)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(31, 13)
        Me.Label52.TabIndex = 46
        Me.Label52.Text = "Pin 4"
        '
        'cbAnalogPin4
        '
        Me.cbAnalogPin4.FormattingEnabled = True
        Me.cbAnalogPin4.Location = New System.Drawing.Point(488, 164)
        Me.cbAnalogPin4.Name = "cbAnalogPin4"
        Me.cbAnalogPin4.Size = New System.Drawing.Size(75, 21)
        Me.cbAnalogPin4.TabIndex = 44
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(566, 101)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(70, 13)
        Me.Label53.TabIndex = 42
        Me.Label53.Text = "Analog V Ref"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(778, 101)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(84, 13)
        Me.Label54.TabIndex = 40
        Me.Label54.Text = "Analog val (Volt)"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(672, 101)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 13)
        Me.Label55.TabIndex = 38
        Me.Label55.Text = "Analog val (Raw)"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(456, 121)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(31, 13)
        Me.Label57.TabIndex = 36
        Me.Label57.Text = "Pin 3"
        '
        'cbAnalogPin3
        '
        Me.cbAnalogPin3.FormattingEnabled = True
        Me.cbAnalogPin3.Location = New System.Drawing.Point(488, 116)
        Me.cbAnalogPin3.Name = "cbAnalogPin3"
        Me.cbAnalogPin3.Size = New System.Drawing.Size(75, 21)
        Me.cbAnalogPin3.TabIndex = 34
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(566, 56)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(70, 13)
        Me.Label43.TabIndex = 32
        Me.Label43.Text = "Analog V Ref"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(778, 56)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(84, 13)
        Me.Label44.TabIndex = 30
        Me.Label44.Text = "Analog val (Volt)"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(672, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 13)
        Me.Label45.TabIndex = 28
        Me.Label45.Text = "Analog val (Raw)"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(456, 75)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(31, 13)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "Pin 2"
        '
        'cbAnalogPin2
        '
        Me.cbAnalogPin2.FormattingEnabled = True
        Me.cbAnalogPin2.Location = New System.Drawing.Point(488, 71)
        Me.cbAnalogPin2.Name = "cbAnalogPin2"
        Me.cbAnalogPin2.Size = New System.Drawing.Size(75, 21)
        Me.cbAnalogPin2.TabIndex = 24
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(566, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 13)
        Me.Label38.TabIndex = 22
        Me.Label38.Text = "Analog V Ref"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(778, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(84, 13)
        Me.Label39.TabIndex = 20
        Me.Label39.Text = "Analog val (Volt)"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(672, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(88, 13)
        Me.Label40.TabIndex = 18
        Me.Label40.Text = "Analog val (Raw)"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(456, 28)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(31, 13)
        Me.Label42.TabIndex = 16
        Me.Label42.Text = "Pin 1"
        '
        'cbAnalogPin1
        '
        Me.cbAnalogPin1.FormattingEnabled = True
        Me.cbAnalogPin1.Location = New System.Drawing.Point(488, 23)
        Me.cbAnalogPin1.Name = "cbAnalogPin1"
        Me.cbAnalogPin1.Size = New System.Drawing.Size(75, 21)
        Me.cbAnalogPin1.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(201, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Analog V Ref"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(120, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Analog val (Volt)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Analog val (Raw)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Analog Ref Mode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(120, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Pins"
        '
        'btnAnalogRead
        '
        Me.btnAnalogRead.Location = New System.Drawing.Point(13, 121)
        Me.btnAnalogRead.Name = "btnAnalogRead"
        Me.btnAnalogRead.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalogRead.TabIndex = 4
        Me.btnAnalogRead.Text = "Read"
        Me.btnAnalogRead.UseVisualStyleBackColor = True
        '
        'cbAnalogPin
        '
        Me.cbAnalogPin.FormattingEnabled = True
        Me.cbAnalogPin.Location = New System.Drawing.Point(123, 38)
        Me.cbAnalogPin.Name = "cbAnalogPin"
        Me.cbAnalogPin.Size = New System.Drawing.Size(75, 21)
        Me.cbAnalogPin.TabIndex = 3
        '
        'cbAnalogRef
        '
        Me.cbAnalogRef.FormattingEnabled = True
        Me.cbAnalogRef.Location = New System.Drawing.Point(13, 38)
        Me.cbAnalogRef.Name = "cbAnalogRef"
        Me.cbAnalogRef.Size = New System.Drawing.Size(104, 21)
        Me.cbAnalogRef.TabIndex = 2
        '
        'tabPWM
        '
        Me.tabPWM.Controls.Add(Me.Label65)
        Me.tabPWM.Controls.Add(Me.Label64)
        Me.tabPWM.Controls.Add(Me.btnWritePWMMultiple)
        Me.tabPWM.Controls.Add(Me.Label59)
        Me.tabPWM.Controls.Add(Me.Label60)
        Me.tabPWM.Controls.Add(Me.txtPWMVal4)
        Me.tabPWM.Controls.Add(Me.txtPWMVal3)
        Me.tabPWM.Controls.Add(Me.txtPWMVal2)
        Me.tabPWM.Controls.Add(Me.txtPWMVal1)
        Me.tabPWM.Controls.Add(Me.txtPWMVal)
        Me.tabPWM.Controls.Add(Me.Label61)
        Me.tabPWM.Controls.Add(Me.cbPWMPin4)
        Me.tabPWM.Controls.Add(Me.Label62)
        Me.tabPWM.Controls.Add(Me.Label63)
        Me.tabPWM.Controls.Add(Me.cbPWMPin3)
        Me.tabPWM.Controls.Add(Me.Label58)
        Me.tabPWM.Controls.Add(Me.Label51)
        Me.tabPWM.Controls.Add(Me.Label56)
        Me.tabPWM.Controls.Add(Me.cbPWMPin2)
        Me.tabPWM.Controls.Add(Me.Label41)
        Me.tabPWM.Controls.Add(Me.Label46)
        Me.tabPWM.Controls.Add(Me.cbPWMPin1)
        Me.tabPWM.Controls.Add(Me.btnWritePWM)
        Me.tabPWM.Controls.Add(Me.Label19)
        Me.tabPWM.Controls.Add(Me.Label18)
        Me.tabPWM.Controls.Add(Me.cbPWMPin)
        Me.tabPWM.Location = New System.Drawing.Point(4, 22)
        Me.tabPWM.Name = "tabPWM"
        Me.tabPWM.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPWM.Size = New System.Drawing.Size(899, 235)
        Me.tabPWM.TabIndex = 3
        Me.tabPWM.Text = "PWM"
        Me.tabPWM.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(638, 59)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(52, 13)
        Me.Label65.TabIndex = 35
        Me.Label65.Text = "PWM Pin"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(638, 147)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(52, 13)
        Me.Label64.TabIndex = 34
        Me.Label64.Text = "PWM Pin"
        '
        'btnWritePWMMultiple
        '
        Me.btnWritePWMMultiple.Location = New System.Drawing.Point(682, 192)
        Me.btnWritePWMMultiple.Name = "btnWritePWMMultiple"
        Me.btnWritePWMMultiple.Size = New System.Drawing.Size(144, 23)
        Me.btnWritePWMMultiple.TabIndex = 33
        Me.btnWritePWMMultiple.Text = "Write Multiple"
        Me.btnWritePWMMultiple.UseVisualStyleBackColor = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(638, 103)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(52, 13)
        Me.Label59.TabIndex = 32
        Me.Label59.Text = "PWM Pin"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(764, 147)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(52, 13)
        Me.Label60.TabIndex = 31
        Me.Label60.Text = "PWM Val"
        '
        'txtPWMVal4
        '
        Me.txtPWMVal4.Location = New System.Drawing.Point(767, 163)
        Me.txtPWMVal4.Name = "txtPWMVal4"
        Me.txtPWMVal4.Size = New System.Drawing.Size(100, 20)
        Me.txtPWMVal4.TabIndex = 30
        '
        'txtPWMVal3
        '
        Me.txtPWMVal3.Location = New System.Drawing.Point(767, 120)
        Me.txtPWMVal3.Name = "txtPWMVal3"
        Me.txtPWMVal3.Size = New System.Drawing.Size(100, 20)
        Me.txtPWMVal3.TabIndex = 26
        '
        'txtPWMVal2
        '
        Me.txtPWMVal2.Location = New System.Drawing.Point(767, 75)
        Me.txtPWMVal2.Name = "txtPWMVal2"
        Me.txtPWMVal2.Size = New System.Drawing.Size(100, 20)
        Me.txtPWMVal2.TabIndex = 21
        '
        'txtPWMVal1
        '
        Me.txtPWMVal1.Location = New System.Drawing.Point(767, 32)
        Me.txtPWMVal1.Name = "txtPWMVal1"
        Me.txtPWMVal1.Size = New System.Drawing.Size(100, 20)
        Me.txtPWMVal1.TabIndex = 17
        '
        'txtPWMVal
        '
        Me.txtPWMVal.Location = New System.Drawing.Point(185, 46)
        Me.txtPWMVal.Name = "txtPWMVal"
        Me.txtPWMVal.Size = New System.Drawing.Size(100, 20)
        Me.txtPWMVal.TabIndex = 12
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(604, 165)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(31, 13)
        Me.Label61.TabIndex = 29
        Me.Label61.Text = "Pin 4"
        '
        'cbPWMPin4
        '
        Me.cbPWMPin4.FormattingEnabled = True
        Me.cbPWMPin4.Location = New System.Drawing.Point(641, 162)
        Me.cbPWMPin4.Name = "cbPWMPin4"
        Me.cbPWMPin4.Size = New System.Drawing.Size(104, 21)
        Me.cbPWMPin4.TabIndex = 28
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(764, 104)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(52, 13)
        Me.Label62.TabIndex = 27
        Me.Label62.Text = "PWM Val"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(604, 123)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(31, 13)
        Me.Label63.TabIndex = 25
        Me.Label63.Text = "Pin 3"
        '
        'cbPWMPin3
        '
        Me.cbPWMPin3.FormattingEnabled = True
        Me.cbPWMPin3.Location = New System.Drawing.Point(641, 119)
        Me.cbPWMPin3.Name = "cbPWMPin3"
        Me.cbPWMPin3.Size = New System.Drawing.Size(104, 21)
        Me.cbPWMPin3.TabIndex = 24
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(638, 15)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(52, 13)
        Me.Label58.TabIndex = 23
        Me.Label58.Text = "PWM Pin"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(764, 59)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(52, 13)
        Me.Label51.TabIndex = 22
        Me.Label51.Text = "PWM Val"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(604, 77)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(31, 13)
        Me.Label56.TabIndex = 20
        Me.Label56.Text = "Pin 2"
        '
        'cbPWMPin2
        '
        Me.cbPWMPin2.FormattingEnabled = True
        Me.cbPWMPin2.Location = New System.Drawing.Point(641, 74)
        Me.cbPWMPin2.Name = "cbPWMPin2"
        Me.cbPWMPin2.Size = New System.Drawing.Size(104, 21)
        Me.cbPWMPin2.TabIndex = 19
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(764, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(52, 13)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "PWM Val"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(604, 35)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(31, 13)
        Me.Label46.TabIndex = 16
        Me.Label46.Text = "Pin 1"
        '
        'cbPWMPin1
        '
        Me.cbPWMPin1.FormattingEnabled = True
        Me.cbPWMPin1.Location = New System.Drawing.Point(641, 31)
        Me.cbPWMPin1.Name = "cbPWMPin1"
        Me.cbPWMPin1.Size = New System.Drawing.Size(104, 21)
        Me.cbPWMPin1.TabIndex = 15
        '
        'btnWritePWM
        '
        Me.btnWritePWM.Location = New System.Drawing.Point(141, 107)
        Me.btnWritePWM.Name = "btnWritePWM"
        Me.btnWritePWM.Size = New System.Drawing.Size(75, 23)
        Me.btnWritePWM.TabIndex = 14
        Me.btnWritePWM.Text = "Write"
        Me.btnWritePWM.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(182, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "PWM Val"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(56, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "PWM Pin"
        '
        'cbPWMPin
        '
        Me.cbPWMPin.FormattingEnabled = True
        Me.cbPWMPin.Location = New System.Drawing.Point(59, 45)
        Me.cbPWMPin.Name = "cbPWMPin"
        Me.cbPWMPin.Size = New System.Drawing.Size(104, 21)
        Me.cbPWMPin.TabIndex = 3
        '
        'tabEPROM
        '
        Me.tabEPROM.Controls.Add(Me.Label25)
        Me.tabEPROM.Controls.Add(Me.Label24)
        Me.tabEPROM.Controls.Add(Me.Label23)
        Me.tabEPROM.Controls.Add(Me.Label22)
        Me.tabEPROM.Controls.Add(Me.Label21)
        Me.tabEPROM.Controls.Add(Me.Label20)
        Me.tabEPROM.Controls.Add(Me.btnEPROMRead)
        Me.tabEPROM.Controls.Add(Me.btnEPROMWrite)
        Me.tabEPROM.Controls.Add(Me.txtEPROMValRead)
        Me.tabEPROM.Controls.Add(Me.txtEPROMReadLength)
        Me.tabEPROM.Controls.Add(Me.txtEPROMReadStartAddress)
        Me.tabEPROM.Controls.Add(Me.txtEPROMValWrite)
        Me.tabEPROM.Controls.Add(Me.txtEPROMWriteLength)
        Me.tabEPROM.Controls.Add(Me.txtEPROMWriteStartAddress)
        Me.tabEPROM.Location = New System.Drawing.Point(4, 22)
        Me.tabEPROM.Name = "tabEPROM"
        Me.tabEPROM.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEPROM.Size = New System.Drawing.Size(899, 235)
        Me.tabEPROM.TabIndex = 4
        Me.tabEPROM.Text = "EPROM"
        Me.tabEPROM.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(393, 112)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "EPROM Read"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(154, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "EPROM Read Length"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(24, 112)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 13)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "EPROM Read Address"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(393, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "EPROM String to Write"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(154, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "EPROM Write Length"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "EPROM Write Address"
        '
        'btnEPROMRead
        '
        Me.btnEPROMRead.Location = New System.Drawing.Point(288, 128)
        Me.btnEPROMRead.Name = "btnEPROMRead"
        Me.btnEPROMRead.Size = New System.Drawing.Size(75, 23)
        Me.btnEPROMRead.TabIndex = 20
        Me.btnEPROMRead.Text = "Read"
        Me.btnEPROMRead.UseVisualStyleBackColor = True
        '
        'btnEPROMWrite
        '
        Me.btnEPROMWrite.Location = New System.Drawing.Point(288, 33)
        Me.btnEPROMWrite.Name = "btnEPROMWrite"
        Me.btnEPROMWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnEPROMWrite.TabIndex = 19
        Me.btnEPROMWrite.Text = "Write"
        Me.btnEPROMWrite.UseVisualStyleBackColor = True
        '
        'txtEPROMValRead
        '
        Me.txtEPROMValRead.Location = New System.Drawing.Point(396, 128)
        Me.txtEPROMValRead.Name = "txtEPROMValRead"
        Me.txtEPROMValRead.Size = New System.Drawing.Size(473, 20)
        Me.txtEPROMValRead.TabIndex = 18
        '
        'txtEPROMReadLength
        '
        Me.txtEPROMReadLength.Location = New System.Drawing.Point(157, 128)
        Me.txtEPROMReadLength.Name = "txtEPROMReadLength"
        Me.txtEPROMReadLength.Size = New System.Drawing.Size(100, 20)
        Me.txtEPROMReadLength.TabIndex = 17
        '
        'txtEPROMReadStartAddress
        '
        Me.txtEPROMReadStartAddress.Location = New System.Drawing.Point(27, 128)
        Me.txtEPROMReadStartAddress.Name = "txtEPROMReadStartAddress"
        Me.txtEPROMReadStartAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtEPROMReadStartAddress.TabIndex = 16
        '
        'txtEPROMValWrite
        '
        Me.txtEPROMValWrite.Location = New System.Drawing.Point(396, 33)
        Me.txtEPROMValWrite.Name = "txtEPROMValWrite"
        Me.txtEPROMValWrite.Size = New System.Drawing.Size(473, 20)
        Me.txtEPROMValWrite.TabIndex = 15
        '
        'txtEPROMWriteLength
        '
        Me.txtEPROMWriteLength.Location = New System.Drawing.Point(157, 33)
        Me.txtEPROMWriteLength.Name = "txtEPROMWriteLength"
        Me.txtEPROMWriteLength.Size = New System.Drawing.Size(100, 20)
        Me.txtEPROMWriteLength.TabIndex = 14
        '
        'txtEPROMWriteStartAddress
        '
        Me.txtEPROMWriteStartAddress.Location = New System.Drawing.Point(27, 33)
        Me.txtEPROMWriteStartAddress.Name = "txtEPROMWriteStartAddress"
        Me.txtEPROMWriteStartAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtEPROMWriteStartAddress.TabIndex = 13
        '
        'tabSPI
        '
        Me.tabSPI.Controls.Add(Me.Label30)
        Me.tabSPI.Controls.Add(Me.Label29)
        Me.tabSPI.Controls.Add(Me.txtSPIHexReceived)
        Me.tabSPI.Controls.Add(Me.txtSPIHexToSend)
        Me.tabSPI.Controls.Add(Me.btnSPIWriteRead)
        Me.tabSPI.Controls.Add(Me.btnSPIConfigure)
        Me.tabSPI.Controls.Add(Me.Label28)
        Me.tabSPI.Controls.Add(Me.cbSPInCS_Pins)
        Me.tabSPI.Controls.Add(Me.Mode)
        Me.tabSPI.Controls.Add(Me.cbSPIMode)
        Me.tabSPI.Controls.Add(Me.Label27)
        Me.tabSPI.Controls.Add(Me.cbSPIClockDivider)
        Me.tabSPI.Controls.Add(Me.Label26)
        Me.tabSPI.Controls.Add(Me.cbSPIBitOrder)
        Me.tabSPI.Location = New System.Drawing.Point(4, 22)
        Me.tabSPI.Name = "tabSPI"
        Me.tabSPI.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSPI.Size = New System.Drawing.Size(899, 235)
        Me.tabSPI.TabIndex = 5
        Me.tabSPI.Text = "SPI"
        Me.tabSPI.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(31, 145)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(91, 13)
        Me.Label30.TabIndex = 21
        Me.Label30.Text = "Hex To Received"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(31, 97)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 13)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "Hex To Send "
        '
        'txtSPIHexReceived
        '
        Me.txtSPIHexReceived.Location = New System.Drawing.Point(140, 138)
        Me.txtSPIHexReceived.Name = "txtSPIHexReceived"
        Me.txtSPIHexReceived.Size = New System.Drawing.Size(553, 20)
        Me.txtSPIHexReceived.TabIndex = 19
        '
        'txtSPIHexToSend
        '
        Me.txtSPIHexToSend.Location = New System.Drawing.Point(140, 94)
        Me.txtSPIHexToSend.Name = "txtSPIHexToSend"
        Me.txtSPIHexToSend.Size = New System.Drawing.Size(553, 20)
        Me.txtSPIHexToSend.TabIndex = 17
        '
        'btnSPIWriteRead
        '
        Me.btnSPIWriteRead.Location = New System.Drawing.Point(727, 118)
        Me.btnSPIWriteRead.Name = "btnSPIWriteRead"
        Me.btnSPIWriteRead.Size = New System.Drawing.Size(166, 23)
        Me.btnSPIWriteRead.TabIndex = 18
        Me.btnSPIWriteRead.Text = "SPI Write/Read"
        Me.btnSPIWriteRead.UseVisualStyleBackColor = True
        '
        'btnSPIConfigure
        '
        Me.btnSPIConfigure.Location = New System.Drawing.Point(727, 34)
        Me.btnSPIConfigure.Name = "btnSPIConfigure"
        Me.btnSPIConfigure.Size = New System.Drawing.Size(166, 23)
        Me.btnSPIConfigure.TabIndex = 16
        Me.btnSPIConfigure.Text = "SPI Configure"
        Me.btnSPIConfigure.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(575, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 13)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "nCS Pin"
        '
        'cbSPInCS_Pins
        '
        Me.cbSPInCS_Pins.FormattingEnabled = True
        Me.cbSPInCS_Pins.Location = New System.Drawing.Point(578, 34)
        Me.cbSPInCS_Pins.Name = "cbSPInCS_Pins"
        Me.cbSPInCS_Pins.Size = New System.Drawing.Size(104, 21)
        Me.cbSPInCS_Pins.TabIndex = 14
        '
        'Mode
        '
        Me.Mode.AutoSize = True
        Me.Mode.Location = New System.Drawing.Point(439, 18)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(60, 13)
        Me.Mode.TabIndex = 13
        Me.Mode.Text = "Data Mode"
        '
        'cbSPIMode
        '
        Me.cbSPIMode.FormattingEnabled = True
        Me.cbSPIMode.Location = New System.Drawing.Point(442, 34)
        Me.cbSPIMode.Name = "cbSPIMode"
        Me.cbSPIMode.Size = New System.Drawing.Size(104, 21)
        Me.cbSPIMode.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(284, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Clock Divider "
        '
        'cbSPIClockDivider
        '
        Me.cbSPIClockDivider.FormattingEnabled = True
        Me.cbSPIClockDivider.Location = New System.Drawing.Point(287, 34)
        Me.cbSPIClockDivider.Name = "cbSPIClockDivider"
        Me.cbSPIClockDivider.Size = New System.Drawing.Size(104, 21)
        Me.cbSPIClockDivider.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(31, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Bit Order"
        '
        'cbSPIBitOrder
        '
        Me.cbSPIBitOrder.FormattingEnabled = True
        Me.cbSPIBitOrder.Location = New System.Drawing.Point(34, 34)
        Me.cbSPIBitOrder.Name = "cbSPIBitOrder"
        Me.cbSPIBitOrder.Size = New System.Drawing.Size(223, 21)
        Me.cbSPIBitOrder.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtFirmwareVersion)
        Me.TabPage1.Controls.Add(Me.txtProtocolVersion)
        Me.TabPage1.Controls.Add(Me.Label71)
        Me.TabPage1.Controls.Add(Me.Label70)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(899, 235)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Version Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Version Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFirmwareVersion
        '
        Me.txtFirmwareVersion.Location = New System.Drawing.Point(121, 65)
        Me.txtFirmwareVersion.Name = "txtFirmwareVersion"
        Me.txtFirmwareVersion.Size = New System.Drawing.Size(100, 20)
        Me.txtFirmwareVersion.TabIndex = 3
        '
        'txtProtocolVersion
        '
        Me.txtProtocolVersion.Location = New System.Drawing.Point(121, 27)
        Me.txtProtocolVersion.Name = "txtProtocolVersion"
        Me.txtProtocolVersion.Size = New System.Drawing.Size(100, 20)
        Me.txtProtocolVersion.TabIndex = 2
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(33, 67)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(87, 13)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Firmware Version"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(33, 29)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(84, 13)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Protocol Version"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 235)
        Me.TabPage2.TabIndex = 7
        Me.TabPage2.Text = "I2C"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_I2C_Read)
        Me.GroupBox4.Controls.Add(Me.btn_I2C_Write)
        Me.GroupBox4.Controls.Add(Me.Label76)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label75)
        Me.GroupBox4.Controls.Add(Me.txt_I2C_Error)
        Me.GroupBox4.Controls.Add(Me.Label74)
        Me.GroupBox4.Controls.Add(Me.Label73)
        Me.GroupBox4.Controls.Add(Me.Label72)
        Me.GroupBox4.Controls.Add(Me.txt_I2C_Address)
        Me.GroupBox4.Controls.Add(Me.txt_I2C_Data_Read)
        Me.GroupBox4.Controls.Add(Me.txt_I2C_Data_To_Write)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 210)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "I2C Generic "
        '
        'txt_I2C_Data_To_Write
        '
        Me.txt_I2C_Data_To_Write.Location = New System.Drawing.Point(16, 58)
        Me.txt_I2C_Data_To_Write.Name = "txt_I2C_Data_To_Write"
        Me.txt_I2C_Data_To_Write.Size = New System.Drawing.Size(200, 20)
        Me.txt_I2C_Data_To_Write.TabIndex = 0
        '
        'txt_I2C_Data_Read
        '
        Me.txt_I2C_Data_Read.Location = New System.Drawing.Point(16, 97)
        Me.txt_I2C_Data_Read.Name = "txt_I2C_Data_Read"
        Me.txt_I2C_Data_Read.Size = New System.Drawing.Size(132, 20)
        Me.txt_I2C_Data_Read.TabIndex = 1
        '
        'txt_I2C_Address
        '
        Me.txt_I2C_Address.Location = New System.Drawing.Point(16, 19)
        Me.txt_I2C_Address.Name = "txt_I2C_Address"
        Me.txt_I2C_Address.Size = New System.Drawing.Size(200, 20)
        Me.txt_I2C_Address.TabIndex = 2
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(22, 42)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(64, 13)
        Me.Label72.TabIndex = 3
        Me.Label72.Text = "I2C Address"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(22, 81)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(89, 13)
        Me.Label73.TabIndex = 4
        Me.Label73.Text = "I2C Data to Write"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(22, 120)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(78, 13)
        Me.Label74.TabIndex = 5
        Me.Label74.Text = "I2C Data Read"
        '
        'txt_I2C_Error
        '
        Me.txt_I2C_Error.Location = New System.Drawing.Point(16, 136)
        Me.txt_I2C_Error.Name = "txt_I2C_Error"
        Me.txt_I2C_Error.Size = New System.Drawing.Size(200, 20)
        Me.txt_I2C_Error.TabIndex = 6
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(22, 159)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(34, 13)
        Me.Label75.TabIndex = 7
        Me.Label75.Text = "Errors"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(151, 120)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(90, 13)
        Me.Label76.TabIndex = 9
        Me.Label76.Text = "# of bytes to read"
        '
        'btn_I2C_Write
        '
        Me.btn_I2C_Write.Location = New System.Drawing.Point(239, 60)
        Me.btn_I2C_Write.Name = "btn_I2C_Write"
        Me.btn_I2C_Write.Size = New System.Drawing.Size(115, 21)
        Me.btn_I2C_Write.TabIndex = 10
        Me.btn_I2C_Write.Text = "I2C Write"
        Me.btn_I2C_Write.UseVisualStyleBackColor = True
        '
        'btn_I2C_Read
        '
        Me.btn_I2C_Read.Location = New System.Drawing.Point(239, 97)
        Me.btn_I2C_Read.Name = "btn_I2C_Read"
        Me.btn_I2C_Read.Size = New System.Drawing.Size(115, 21)
        Me.btn_I2C_Read.TabIndex = 11
        Me.btn_I2C_Read.Text = "I2C Read"
        Me.btn_I2C_Read.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.btnreadBusVoltage)
        Me.GroupBox5.Controls.Add(Me.btnCalibrate)
        Me.GroupBox5.Controls.Add(Me.btnReset)
        Me.GroupBox5.Controls.Add(Me.btn_INA_219_Read_All)
        Me.GroupBox5.Controls.Add(Me.txt_INA219_Current)
        Me.GroupBox5.Controls.Add(Me.txt_INA219_Shunt_Voltage)
        Me.GroupBox5.Controls.Add(Me.txt_INA219_Bus_Voltage)
        Me.GroupBox5.Controls.Add(Me.Label80)
        Me.GroupBox5.Controls.Add(Me.Label79)
        Me.GroupBox5.Controls.Add(Me.voltage)
        Me.GroupBox5.Controls.Add(Me.Label77)
        Me.GroupBox5.Controls.Add(Me.txt_INA219_I2C_Address)
        Me.GroupBox5.Location = New System.Drawing.Point(401, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(471, 210)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "INA219 Specific"
        '
        'txt_INA219_I2C_Address
        '
        Me.txt_INA219_I2C_Address.Location = New System.Drawing.Point(20, 19)
        Me.txt_INA219_I2C_Address.Name = "txt_INA219_I2C_Address"
        Me.txt_INA219_I2C_Address.Size = New System.Drawing.Size(120, 20)
        Me.txt_INA219_I2C_Address.TabIndex = 1
        Me.txt_INA219_I2C_Address.Text = "&H40"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(155, 22)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(64, 13)
        Me.Label77.TabIndex = 4
        Me.Label77.Text = "I2C Address"
        '
        'voltage
        '
        Me.voltage.AutoSize = True
        Me.voltage.Location = New System.Drawing.Point(155, 68)
        Me.voltage.Name = "voltage"
        Me.voltage.Size = New System.Drawing.Size(102, 13)
        Me.voltage.TabIndex = 5
        Me.voltage.Text = "INA219 bus Voltage"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(155, 101)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(113, 13)
        Me.Label79.TabIndex = 6
        Me.Label79.Text = "INA219 Shunt Voltage"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(155, 139)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(80, 13)
        Me.Label80.TabIndex = 7
        Me.Label80.Text = "INA219 Current"
        '
        'txt_INA219_Bus_Voltage
        '
        Me.txt_INA219_Bus_Voltage.Location = New System.Drawing.Point(20, 65)
        Me.txt_INA219_Bus_Voltage.Name = "txt_INA219_Bus_Voltage"
        Me.txt_INA219_Bus_Voltage.Size = New System.Drawing.Size(120, 20)
        Me.txt_INA219_Bus_Voltage.TabIndex = 8
        '
        'txt_INA219_Shunt_Voltage
        '
        Me.txt_INA219_Shunt_Voltage.Location = New System.Drawing.Point(20, 98)
        Me.txt_INA219_Shunt_Voltage.Name = "txt_INA219_Shunt_Voltage"
        Me.txt_INA219_Shunt_Voltage.Size = New System.Drawing.Size(120, 20)
        Me.txt_INA219_Shunt_Voltage.TabIndex = 9
        '
        'txt_INA219_Current
        '
        Me.txt_INA219_Current.Location = New System.Drawing.Point(20, 136)
        Me.txt_INA219_Current.Name = "txt_INA219_Current"
        Me.txt_INA219_Current.Size = New System.Drawing.Size(120, 20)
        Me.txt_INA219_Current.TabIndex = 10
        '
        'btn_INA_219_Read_All
        '
        Me.btn_INA_219_Read_All.Location = New System.Drawing.Point(243, 181)
        Me.btn_INA_219_Read_All.Name = "btn_INA_219_Read_All"
        Me.btn_INA_219_Read_All.Size = New System.Drawing.Size(125, 23)
        Me.btn_INA_219_Read_All.TabIndex = 11
        Me.btn_INA_219_Read_All.Text = "Read All"
        Me.btn_INA_219_Read_All.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(308, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalibrate
        '
        Me.btnCalibrate.Location = New System.Drawing.Point(308, 56)
        Me.btnCalibrate.Name = "btnCalibrate"
        Me.btnCalibrate.Size = New System.Drawing.Size(125, 23)
        Me.btnCalibrate.TabIndex = 13
        Me.btnCalibrate.Text = "Calibrate"
        Me.btnCalibrate.UseVisualStyleBackColor = True
        '
        'btnreadBusVoltage
        '
        Me.btnreadBusVoltage.Location = New System.Drawing.Point(308, 91)
        Me.btnreadBusVoltage.Name = "btnreadBusVoltage"
        Me.btnreadBusVoltage.Size = New System.Drawing.Size(125, 23)
        Me.btnreadBusVoltage.TabIndex = 14
        Me.btnreadBusVoltage.Text = "Read Voltage"
        Me.btnreadBusVoltage.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(82, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Read All Repeat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnVersionInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 529)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "btnVersionInfo"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.I2C.ResumeLayout(False)
        Me.tabRawWriteRead.ResumeLayout(False)
        Me.tabRawWriteRead.PerformLayout()
        Me.tabDigital.ResumeLayout(False)
        Me.tabDigital.PerformLayout()
        Me.TabAnalog_.ResumeLayout(False)
        Me.TabAnalog_.PerformLayout()
        Me.tabPWM.ResumeLayout(False)
        Me.tabPWM.PerformLayout()
        Me.tabEPROM.ResumeLayout(False)
        Me.tabEPROM.PerformLayout()
        Me.tabSPI.ResumeLayout(False)
        Me.tabSPI.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents cbSerialProts As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents I2C As System.Windows.Forms.TabControl
    Friend WithEvents tabRawWriteRead As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReceivedDataIntegrity As System.Windows.Forms.TextBox
    Friend WithEvents txtRawReceivedErrorDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtRawDataReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtRawDataSend As System.Windows.Forms.TextBox
    Friend WithEvents txtRawErrorReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtRawErrorSend As System.Windows.Forms.TextBox
    Friend WithEvents txtRawLengthReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtRawLengthSend As System.Windows.Forms.TextBox
    Friend WithEvents txtrawChecksumReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtRawChecksumSend As System.Windows.Forms.TextBox
    Friend WithEvents txtRawKeyReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtRawKeySend As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRawSend As System.Windows.Forms.Button
    Friend WithEvents tabDigital As System.Windows.Forms.TabPage
    Friend WithEvents btnDigitalReadMultiple As System.Windows.Forms.Button
    Friend WithEvents btnDigitalConfigureMultiple As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cbDigitalVal4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalConfigVal4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalPin4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalVal3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalConfigVal3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalPin3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalVal2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalConfigVal2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalPin2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cbDigitalVal1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalConfigVal1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalPin1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnDigitalWriteMultiple As System.Windows.Forms.Button
    Friend WithEvents btnDigitalWriteRead As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbDigitalVal As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalConfigVal As System.Windows.Forms.ComboBox
    Friend WithEvents cbDigitalPins As System.Windows.Forms.ComboBox
    Friend WithEvents TabAnalog_ As System.Windows.Forms.TabPage
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents btnAnalogReadMultiple As System.Windows.Forms.Button
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtAnalogReadVolt4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogRefVolt4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogValRead4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogReadVolt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogRefVolt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogValRead3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogReadVolt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogRefVolt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogValRead2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogReadVolt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogRefVolt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogValRead1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogReadVolt As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogRefVolt As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalogValRead As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cbAnalogPin4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents cbAnalogPin3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents cbAnalogPin2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbAnalogPin1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnAnalogRead As System.Windows.Forms.Button
    Friend WithEvents cbAnalogPin As System.Windows.Forms.ComboBox
    Friend WithEvents cbAnalogRef As System.Windows.Forms.ComboBox
    Friend WithEvents tabPWM As System.Windows.Forms.TabPage
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents btnWritePWMMultiple As System.Windows.Forms.Button
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtPWMVal4 As System.Windows.Forms.TextBox
    Friend WithEvents txtPWMVal3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPWMVal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPWMVal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPWMVal As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents cbPWMPin4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents cbPWMPin3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents cbPWMPin2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cbPWMPin1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnWritePWM As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbPWMPin As System.Windows.Forms.ComboBox
    Friend WithEvents tabEPROM As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnEPROMRead As System.Windows.Forms.Button
    Friend WithEvents btnEPROMWrite As System.Windows.Forms.Button
    Friend WithEvents txtEPROMValRead As System.Windows.Forms.TextBox
    Friend WithEvents txtEPROMReadLength As System.Windows.Forms.TextBox
    Friend WithEvents txtEPROMReadStartAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEPROMValWrite As System.Windows.Forms.TextBox
    Friend WithEvents txtEPROMWriteLength As System.Windows.Forms.TextBox
    Friend WithEvents txtEPROMWriteStartAddress As System.Windows.Forms.TextBox
    Friend WithEvents tabSPI As System.Windows.Forms.TabPage
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSPIHexReceived As System.Windows.Forms.TextBox
    Friend WithEvents txtSPIHexToSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSPIWriteRead As System.Windows.Forms.Button
    Friend WithEvents btnSPIConfigure As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbSPInCS_Pins As System.Windows.Forms.ComboBox
    Friend WithEvents Mode As System.Windows.Forms.Label
    Friend WithEvents cbSPIMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbSPIClockDivider As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbSPIBitOrder As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtFirmwareVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtProtocolVersion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txt_I2C_Address As System.Windows.Forms.TextBox
    Friend WithEvents txt_I2C_Data_Read As System.Windows.Forms.TextBox
    Friend WithEvents txt_I2C_Data_To_Write As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txt_I2C_Error As System.Windows.Forms.TextBox
    Friend WithEvents btn_I2C_Read As System.Windows.Forms.Button
    Friend WithEvents btn_I2C_Write As System.Windows.Forms.Button
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_INA219_Current As System.Windows.Forms.TextBox
    Friend WithEvents txt_INA219_Shunt_Voltage As System.Windows.Forms.TextBox
    Friend WithEvents txt_INA219_Bus_Voltage As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents voltage As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txt_INA219_I2C_Address As System.Windows.Forms.TextBox
    Friend WithEvents btn_INA_219_Read_All As System.Windows.Forms.Button
    Friend WithEvents btnreadBusVoltage As System.Windows.Forms.Button
    Friend WithEvents btnCalibrate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
