Imports PCSC.Iso7816
Imports System
Public Class frmAPDUSpeedometer
    Private SmartPCSC As New SmartPCSC
    Private firstRun As Boolean = False
    Private latestResponse As Byte()
    Private latestResponseStr As String

    Private Sub refreshReaderList() Handles MyBase.Load, btnRefesh.Click
        cbxReader.Items.Clear()

        Dim readerList As String()
        readerList = SmartPCSC.getReaderList
        For Each reader In readerList
            cbxReader.Items.Add(reader)
        Next
        cbxReader.SelectedIndex = 0

        If firstRun <> False Then
            MessageBox.Show("Refresh Reader List Complete!, " & readerList.Length & " Reader Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            firstRun = True
        End If
    End Sub

    Private Sub btnSendAPDU_Click(sender As Object, e As EventArgs) Handles btnSendAPDU.Click
        APDU2Card(txtAPDU.Text)
    End Sub

    Private Sub btnGetATR_Click(sender As Object, e As EventArgs) Handles btnGetATR.Click
        'txtATRValue.Clear()

        Try
            Dim cardATR As Byte() = SmartPCSC.getCardATR(cbxReader.Text)
            Dim cardATRstr As String

            If Not cardATR Is Nothing Then
                cardATRstr = BitConverter.ToString(cardATR)
                cardATRstr = cardATRstr.Replace("-", " ")

                'txtATRValue.Text = cardATRstr

                'MessageBox.Show("Get Card ATR Complete", "GetCardATR : Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtLog.AppendText("Command: ATR >> Success" & vbNewLine & "-> " & cardATRstr & vbNewLine & vbNewLine)
            Else
                txtLog.AppendText("Command: ATR >> Failed" & vbNewLine & vbNewLine)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "GetCardATR : Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLog.AppendText("Command: ATR >> Failed" & vbNewLine & "::: " & ex.Message & vbNewLine & vbNewLine)
        End Try
    End Sub
    Private Sub APDU2Card(APDU_text As String)
        'txtRecievedAPDU.Clear()
        'txtSW1SW2.Clear()
        'txtASCII.Clear()

        latestResponse = Nothing
        latestResponseStr = ""

        If APDU_text <> "" Then
            If Not (APDU_text.StartsWith("Command") Or APDU_text.StartsWith(";")) Then
                Dim APDUstring As String
                APDUstring = APDU_text.Replace(" ", "")

                'Temporary Solution
                Dim APDUcase As IsoCase
                APDUcase = IsoCase.Case4Short

                Dim APDUbyte As Byte()
                Try
                    APDUbyte = SmartPCSC.getByteArrayfromString(APDUstring)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "TranslatingAPDU : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtLog.AppendText(vbNewLine & vbNewLine & "TranslatingAPDU : ERROR" & vbNewLine & "::: " & ex.Message)
                    Exit Sub
                End Try

                Dim APDUstr As String
                APDUstr = BitConverter.ToString(APDUbyte)
                APDUstr = APDUstr.Replace("-", " ")
                Dim responseObj As Object
                Dim currentDateTime2 As DateTime
                Dim currentDateTime1 As DateTime = DateTime.Now
                txtLog.AppendText(currentDateTime1.ToString("hh:mm:ss.fff") & " -> " & APDUstr & vbNewLine)
                Try
                    responseObj = SmartPCSC.trasmitAPDU(cbxReader.Text, APDUbyte, APDUcase)
                    currentDateTime2 = DateTime.Now
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "TransmitAPDU : ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtLog.AppendText(vbNewLine & vbNewLine & "TransmitAPDU : ERROR" & vbNewLine & "<< " & APDUstr & vbNewLine & "::: " & ex.Message)
                    Exit Sub
                End Try

                Dim responseByte As Byte()
                Dim responseStr As String

                If responseObj(0) IsNot Nothing Then
                    If responseObj(0).Length > 0 Then
                        responseByte = responseObj(0)
                        latestResponse = responseByte

                        responseStr = BitConverter.ToString(responseByte)
                        responseStr = responseStr.Replace("-", " ")
                        latestResponseStr = responseStr
                        'txtRecievedAPDU.Text = responseStr
                        txtLog.AppendText(currentDateTime2.ToString("hh:mm:ss.fff") & " <- " & responseStr)
                    Else
                        'txtRecievedAPDU.Text = "NO RESPONSE DATA"
                        txtLog.AppendText(currentDateTime2.ToString("hh:mm:ss.fff") & " <- ")
                    End If
                End If

                Dim SW1 As Byte = responseObj(1)
                Dim SW2 As Byte = responseObj(2)

                Dim SWarray As Byte() = {&H0, &H0}
                SWarray(0) = SW1
                SWarray(1) = SW2

                Dim SWstr As String
                SWstr = BitConverter.ToString(SWarray)
                SWstr = SWstr.Replace("-", " ")

                'txtSW1SW2.Text = SWstr

                Dim difference As TimeSpan = currentDateTime2.Subtract(currentDateTime1)
                txtLog.AppendText(" " & SWstr & vbNewLine & "Timelapsed: " & Math.Round(difference.TotalMilliseconds) & " ms" & vbNewLine & vbNewLine)
            Else
                'ResponsiveSleep(100)
                txtLog.AppendText(APDU_text & vbNewLine) ' this is the line starting with Command: which is a comment to clarify what the command is about.
                If APDU_text.StartsWith("Command: STATUS") Then
                    ResponsiveSleep(100)
                End If
            End If
        End If
    End Sub
    Public Sub ResponsiveSleep(iMilliSeconds As Integer)
        Dim iHalfSeconds As Integer = iMilliSeconds / 50
        For i = 1 To iHalfSeconds
            Threading.Thread.Sleep(50)
            Application.DoEvents()
        Next
    End Sub
    Function ByteSwapHexString(ByVal hexString As String) As String
        Dim hexBytes As String() = hexString.Split(" "c)
        Dim byteSwappedHex As New List(Of String)

        For Each hexByte As String In hexBytes
            byteSwappedHex.Add(New String(hexByte.Reverse().ToArray()))
        Next

        Return String.Concat(byteSwappedHex)
    End Function

    Private Sub btnReadICCID_Click(sender As Object, e As EventArgs) Handles btnReadICCID.Click
        Dim APDUstr As String
        APDUstr = "Command: SELECT MF" & vbNewLine
        APDUstr = APDUstr & "00 A4 00 0C 02 3F 00" & vbNewLine
        APDUstr = APDUstr & "Command: SELECT ICCID" & vbNewLine
        APDUstr = APDUstr & "00 A4 08 0C 02 2F E2" & vbNewLine
        APDUstr = APDUstr & "Command: READ BINARY" & vbNewLine
        APDUstr = APDUstr & "00 B0 00 00 0A"

        Dim linetxt As String
        ' Tách nội dung thành từng dòng
        Dim lines As String() = APDUstr.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        ' Xử lý từng dòng bằng APDU2Card
        For Each line As String In lines
            If Not (line.StartsWith("<-")) Then
                linetxt = line.Replace("->", "")
                APDU2Card(linetxt)
            End If
        Next
        If (latestResponseStr <> "") Then
            txtLog.AppendText("ICCID = " & ByteSwapHexString(latestResponseStr) & vbNewLine & vbNewLine)
        End If
    End Sub

    Private Sub btnReadIMSI_Click(sender As Object, e As EventArgs) Handles btnReadIMSI.Click
        Dim APDUstr As String
        APDUstr = "Command: SELECT MF" & vbNewLine
        APDUstr = APDUstr & "00 A4 00 0C 02 3F 00" & vbNewLine
        APDUstr = APDUstr & "Command: SELECT DF_GSM" & vbNewLine
        APDUstr = APDUstr & "00 A4 08 0C 02 7F 20" & vbNewLine
        APDUstr = APDUstr & "Command: SELECT IMSI" & vbNewLine
        APDUstr = APDUstr & "00 A4 00 0C 02 6F 07" & vbNewLine
        APDUstr = APDUstr & "Command: READ BINARY" & vbNewLine
        APDUstr = APDUstr & "00 B0 00 00 09"

        Dim linetxt As String
        ' Tách nội dung thành từng dòng
        Dim lines As String() = APDUstr.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        ' Xử lý từng dòng bằng APDU2Card
        For Each line As String In lines
            If Not (line.StartsWith("<-")) Then
                linetxt = line.Replace("->", "")
                APDU2Card(linetxt)
            End If
        Next
        If (latestResponseStr <> "") Then
            txtLog.AppendText("IMSI 2G = " & ByteSwapHexString(latestResponseStr).Substring(3) & vbNewLine & vbNewLine)
        End If

    End Sub

    Private Sub btnSendBatchAPDU_Click(sender As Object, e As EventArgs) Handles btnSendBatchAPDU.Click
        ' Lấy nội dung từ txtBatchAPDU
        Dim batchAPDU As String = txtBatchAPDU.Text
        Dim linetxt As String
        ' Tách nội dung thành từng dòng
        Dim lines As String() = batchAPDU.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        ' Xử lý từng dòng bằng APDU2Card
        For Each line As String In lines
            If Not (line.StartsWith("<-")) Then
                linetxt = line.Replace("->", "")
                APDU2Card(linetxt)
            End If
        Next

    End Sub

End Class
