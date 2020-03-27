Imports System.IO
Imports System.Net

Public Class Form1

    Dim pos1 As Long, pos2 As Long, pos3 As String

    Dim pos4 As Long, pos5 As Long, pos6 As String

    Dim pos7 As Long, pos8 As Long, pos9 As String

    Dim pos10 As Long, pos11 As Long, pos12 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load





        Dim besafe As String = "https://besafemoris.mu/"

        Dim worldometer As String = "https://www.worldometers.info/coronavirus/"

        Dim request As WebRequest = WebRequest.Create(besafe)
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim StrData As String = reader.ReadToEnd

        pos1 = InStr(StrData, "Cases")
        pos1 = InStr(pos1 + 1, StrData, ":", vbTextCompare)
        pos2 = InStr(pos1 + 1, StrData, "Today", vbTextCompare)
        pos3 = StrData.Substring(pos1, pos2 - pos1 - 21)
        GunaLabel2.Text = pos3

        pos4 = InStr(StrData, "Cases: 81 |")
        pos4 = InStr(pos1 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos1 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4 + 23, pos5 - pos4 - 23)
        GunaLabel4.Text = pos6

        pos7 = InStr(StrData, "Today: 33")
        pos7 = InStr(pos1 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos1 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7 + 26, pos8 - pos7 - 450)
        GunaLabel5.Text = pos9

        GunaCircleProgressBar1.Value = pos3
        GunaCircleProgressBar2.Value = pos6
        GunaCircleProgressBar3.Value = pos9





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 81, pos11 - pos10 - 171)
        GunaLabel7.Text = pos12

        GunaCircleProgressBar4.Value = pos12


    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click


        Dim besafe As String = "https://besafemoris.mu/"

        Dim worldometer As String = "https://www.worldometers.info/coronavirus/"

        Dim request As WebRequest = WebRequest.Create(besafe)
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim StrData As String = reader.ReadToEnd

        pos1 = InStr(StrData, "Cases")
        pos1 = InStr(pos1 + 1, StrData, ":", vbTextCompare)
        pos2 = InStr(pos1 + 1, StrData, "Today", vbTextCompare)
        pos3 = StrData.Substring(pos1, pos2 - pos1 - 21)
        GunaLabel2.Text = pos3

        pos4 = InStr(StrData, "Cases: 81 |")
        pos4 = InStr(pos1 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos1 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4 + 23, pos5 - pos4 - 23)
        GunaLabel4.Text = pos6

        pos7 = InStr(StrData, "Today: 33")
        pos7 = InStr(pos1 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos1 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7 + 26, pos8 - pos7 - 450)
        GunaLabel5.Text = pos9

        GunaCircleProgressBar1.Value = pos3
        GunaCircleProgressBar2.Value = pos6
        GunaCircleProgressBar3.Value = pos9





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 81, pos11 - pos10 - 171)
        GunaLabel7.Text = pos12

        GunaCircleProgressBar4.Value = pos12






    End Sub



    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click


        Dim besafe As String = "https://besafemoris.mu/"

        Dim worldometer As String = "https://www.worldometers.info/coronavirus/"

        Dim request As WebRequest = WebRequest.Create(besafe)
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim StrData As String = reader.ReadToEnd

        pos1 = InStr(StrData, "Cases")
        pos1 = InStr(pos1 + 1, StrData, ":", vbTextCompare)
        pos2 = InStr(pos1 + 1, StrData, "Today", vbTextCompare)
        pos3 = StrData.Substring(pos1, pos2 - pos1 - 21)
        GunaLabel2.Text = pos3
        NotifyIcon1.Text = "Hello"

        NotifyIcon1.BalloonTipTitle = "Covid"
        NotifyIcon1.ShowBalloonTip(pos3, "Cases", pos3, ToolTipIcon.Info)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        Dim besafe As String = "https://besafemoris.mu/"

        Dim worldometer As String = "https://www.worldometers.info/coronavirus/"

        Dim request As WebRequest = WebRequest.Create(besafe)
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim StrData As String = reader.ReadToEnd

        pos1 = InStr(StrData, "Cases")
        pos1 = InStr(pos1 + 1, StrData, ":", vbTextCompare)
        pos2 = InStr(pos1 + 1, StrData, "Today", vbTextCompare)
        pos3 = StrData.Substring(pos1, pos2 - pos1 - 21)
        GunaLabel2.Text = pos3

        pos4 = InStr(StrData, "Cases: 81 |")
        pos4 = InStr(pos1 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos1 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4 + 23, pos5 - pos4 - 23)
        GunaLabel4.Text = pos6

        pos7 = InStr(StrData, "Today: 33")
        pos7 = InStr(pos1 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos1 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7 + 26, pos8 - pos7 - 450)
        GunaLabel5.Text = pos9

        GunaCircleProgressBar1.Value = pos3
        GunaCircleProgressBar2.Value = pos6
        GunaCircleProgressBar3.Value = pos9





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 81, pos11 - pos10 - 171)
        GunaLabel7.Text = pos12

        GunaCircleProgressBar4.Value = pos12




    End Sub
End Class
