Public Class Arduino_Packet

    Private strPacket As String
    Private arrByte() As Byte
    Private byteLength As Byte
    Private int0 As Integer = Asc("0")
    Private int9 As Integer = Asc("9")
    Private intA As Integer = Asc("A")
    Private intF As Integer = Asc("F")
    Private Const KEY = &H13
    Private Nible_To_HEX() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"}




    Public Sub New(ByVal strPacket As String)
        Me.strPacket = strPacket.ToUpper
        Try
            arrByte = hexToByte(strPacket) 'System.Text.ASCIIEncoding.ASCII.GetBytes(strPacket)
            byteLength = arrByte.Length
        Catch ex As Exception
            Throw
        End Try



    End Sub

    Public Shared Function convertStringToArrByte(ByVal str As String) As Byte()

        Try
            If Not New Arduino_Packet().stringIsValidHex(str) Then
                Throw New Exception("Not a valid hex string ")
            End If

            Return New Arduino_Packet().hexToByte(str) 'System.Text.ASCIIEncoding.ASCII.GetBytes(str)

        Catch ex As Exception
            Throw
        End Try



    End Function

    Public Sub New()

    End Sub


    Public Sub New(ByVal CommandByte() As Byte)
        byteLength = 7 + CommandByte.Length
        ReDim arrByte(byteLength - 1)
        strPacket = ""
        arrByte(0) = KEY

        putUInt16(OFFSETS.OFFSET_ERROR, ERRORS.ERROR_OK)
        putUInt16(OFFSETS.OFFSET_LENGTH, byteLength)
        For i As Integer = 0 To CommandByte.Length - 1 Step 1
            arrByte(i + OFFSETS.OFFSET_COMMAND) = CommandByte(i)
        Next
        putUInt16(OFFSETS.OFFSET_CHECKSUM, calculateCheckSum())

        For i As Integer = 0 To arrByte.Length - 1
            strPacket += byteToHex(arrByte(i))
        Next
    End Sub

    Public Function getString() As String
        strPacket = strPacket.Replace(Chr(10), String.Empty)
        Return strPacket
    End Function

    Private Function returnBytes() As Byte()
        Return arrByte
    End Function


    Public Function hexToByte(ByVal strHex As String) As Byte()

        Dim bytes((strHex.Length - 2) / 2) As Byte
        If strHex.Length = 0 Then
            Return bytes
        End If
        Dim val As Byte
        Try
            For i As Integer = 0 To strHex.Length - 2 Step 2
                val = Asc(strHex.Substring(i, 1))

                If (val >= int0 And val <= int9) Then
                    bytes(i / 2) = (val - int0) << 4
                ElseIf (val >= intA And val <= intF) Then
                    bytes(i / 2) = (val - intA + 10) << 4
                Else
                    Throw New Exception("char " & (strHex.Substring(i, 1) & " in " & strHex & " not a valid hex "))
                End If

                val = Asc(strHex.Substring(i + 1, 1))

                If (val >= int0 And val <= int9) Then
                    bytes(i / 2) += (val - int0)
                ElseIf (val >= intA And val <= intF) Then
                    bytes(i / 2) += (val - intA + 10)
                Else
                    Throw New Exception("char " & (strHex.Substring(i, 1) & " in " & strHex & " not a valid hex "))
                End If



            Next

            Return bytes

        Catch ex As Exception
            Throw New Exception("Not a valid hex string.")
        End Try
    End Function

    Public Function byteToHex(ByVal val As Byte) As String

        Return (Nible_To_HEX(val >> 4) & Nible_To_HEX(val And &HF))
    End Function
    Public Function byteToHex(ByVal ByteArr() As Byte) As String
        Dim str As String = ""
        For i As Integer = 0 To ByteArr.Length - 1
            str += byteToHex(ByteArr(i))
        Next
        Return str
    End Function

    Public Function checkPacketIntegrity() As Integer

        If Not stringIsValidHex(strPacket) Then
            Return ERRORS.ERROR_WRONG_CHARACTER_FOUND

        End If

        If arrByte(OFFSETS.OFFSET_KEY) <> KEY Then
            Return ERRORS.ERROR_WRONG_KEY
        End If

        If getUInt16(OFFSETS.OFFSET_CHECKSUM) <> calculateCheckSum() Then
            Return ERRORS.ERROR_CHECKSUM_WRONG
        End If

        If getUInt16(OFFSETS.OFFSET_LENGTH) <> byteLength Then
            Return ERRORS.ERROR_WRONG_PACKET_LENGTH
        End If
        Return ERRORS.ERROR_OK
    End Function


    Public Function getErrorField() As Integer
        Return getUInt16(OFFSETS.OFFSET_ERROR)
    End Function



    Private Function stringIsValidHex(ByVal str As String) As Boolean

        Dim val As Integer
        For Each Ch As Char In str.ToCharArray
            val = Asc(Ch)
            If (Not (val >= int0 And val <= int9) And Not (val >= intA And val <= intF)) Then
                Return False
            End If

        Next
        Return True

    End Function



    Public Function calculateCheckSum() As UInt16
        Dim sum As UInt16 = 0
        For i As Integer = 0 To arrByte.Length - 1
            sum += arrByte(i)
        Next
        sum -= getUInt8(OFFSETS.OFFSET_CHECKSUM)
        sum -= getUInt8(OFFSETS.OFFSET_CHECKSUM + 1)

        Return sum
    End Function

    Public Function isCheckSumCorrect() As Boolean
        If calculateCheckSum() = getUInt16(OFFSETS.OFFSET_CHECKSUM) Then
            Return True
        End If
        Return False
    End Function
    Private Sub putUInt8(ByVal Offset As Integer, ByVal val As Byte)
        arrByte(Offset) = val
    End Sub

    Private Sub putUInt16(ByVal Offset As Integer, ByVal val As UInt16)
        arrByte(Offset) = CType((val And &HFF), Byte)
        arrByte(Offset + 1) = CType(((val >> 8) And &HFF), Byte)
    End Sub


    Private Function getUInt8(ByVal Offset As Integer) As Byte
        Return arrByte(Offset)
    End Function


    Private Function getUInt16(ByVal offset As Integer) As UInt16
        Dim temp As UInt16
        temp = (CUInt(getUInt8(offset + 1)) << 8)
        temp += getUInt8(offset)
        Return temp
    End Function

    Public Function getPayLoad() As Byte()
        Dim payLoad(arrByte.Length - OFFSETS.OFFSET_COMMAND - 1) As Byte
        For i As Integer = 0 To payLoad.Length - 1
            payLoad(i) = arrByte(OFFSETS.OFFSET_COMMAND + i)
        Next
        Return payLoad
    End Function


End Class
