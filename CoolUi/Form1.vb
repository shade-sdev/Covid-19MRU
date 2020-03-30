Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1

    Dim pos1 As Long, pos2 As Long, pos3 As String

    Dim pos4 As Long, pos5 As Long, pos6 As String

    Dim pos7 As Long, pos8 As Long, pos9 As String

    Dim pos10 As Long, pos11 As Long, pos12 As String

    Dim c As Integer = 2

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cases As String
        Dim casetoday As String
        Dim death As String
        Dim casesglobal As String


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
        pos3 = StrData.Substring(pos1, pos2 - pos1)
        cases = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))
        GunaLabel2.Text = cases


        pos4 = InStr(StrData, "Cases:")
        pos4 = InStr(pos4 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos4 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4, pos5 - pos4)
        casetoday = Integer.Parse(Regex.Replace(pos6, "[^\d]", ""))
        GunaLabel4.Text = casetoday


        pos7 = InStr(StrData, "Today")
        pos7 = InStr(pos7 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos7 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7, pos8 - pos7)
        death = Integer.Parse(Regex.Replace(pos9, "[^\d]", ""))
        GunaLabel5.Text = death

        GunaCircleProgressBar1.Value = cases
        GunaCircleProgressBar2.Value = casetoday
        GunaCircleProgressBar3.Value = death





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 10, pos11 - pos10)
        casesglobal = Integer.Parse(Regex.Replace(pos12, "[^\d]", ""))
        GunaLabel7.Text = casesglobal

        GunaCircleProgressBar4.Value = casesglobal


    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click



        Dim cases As String
        Dim casetoday As String
        Dim death As String
        Dim casesglobal As String


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
        pos3 = StrData.Substring(pos1, pos2 - pos1)
        cases = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))
        GunaLabel2.Text = cases


        pos4 = InStr(StrData, "Cases:")
        pos4 = InStr(pos4 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos4 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4, pos5 - pos4)
        casetoday = Integer.Parse(Regex.Replace(pos6, "[^\d]", ""))
        GunaLabel4.Text = casetoday


        pos7 = InStr(StrData, "Today")
        pos7 = InStr(pos7 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos7 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7, pos8 - pos7)
        death = Integer.Parse(Regex.Replace(pos9, "[^\d]", ""))
        GunaLabel5.Text = death

        GunaCircleProgressBar1.Value = cases
        GunaCircleProgressBar2.Value = casetoday
        GunaCircleProgressBar3.Value = death





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 10, pos11 - pos10)
        casesglobal = Integer.Parse(Regex.Replace(pos12, "[^\d]", ""))
        GunaLabel7.Text = casesglobal

        GunaCircleProgressBar4.Value = casesglobal



    End Sub



    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click


        Dim cases As String
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
        pos3 = StrData.Substring(pos1, pos2 - pos1)
        cases = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))

        NotifyIcon1.Text = "Cases" + cases

        NotifyIcon1.BalloonTipTitle = "Covid"
        NotifyIcon1.ShowBalloonTip(cases, "Cases", cases, ToolTipIcon.Info)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        Dim cases As String
        Dim casetoday As String
        Dim death As String
        Dim casesglobal As String


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
        pos3 = StrData.Substring(pos1, pos2 - pos1)
        cases = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))
        GunaLabel2.Text = cases


        pos4 = InStr(StrData, "Cases:")
        pos4 = InStr(pos4 + 1, StrData, "Today:", vbTextCompare)
        pos5 = InStr(pos4 + 1, StrData, " | Death", vbTextCompare)
        pos6 = StrData.Substring(pos4, pos5 - pos4)
        casetoday = Integer.Parse(Regex.Replace(pos6, "[^\d]", ""))
        GunaLabel4.Text = casetoday


        pos7 = InStr(StrData, "Today")
        pos7 = InStr(pos7 + 1, StrData, " | Death:", vbTextCompare)
        pos8 = InStr(pos7 + 1, StrData, "Opening", vbTextCompare)
        pos9 = StrData.Substring(pos7, pos8 - pos7)
        death = Integer.Parse(Regex.Replace(pos9, "[^\d]", ""))
        GunaLabel5.Text = death

        GunaCircleProgressBar1.Value = cases
        GunaCircleProgressBar2.Value = casetoday
        GunaCircleProgressBar3.Value = death





        Dim request2 As WebRequest = WebRequest.Create(worldometer)
        Dim response2 As HttpWebResponse = CType(request2.GetResponse(), HttpWebResponse)
        Dim dataStream2 As Stream = response2.GetResponseStream
        Dim reader2 As New StreamReader(dataStream2)
        Dim StrData2 As String = reader2.ReadToEnd


        pos10 = InStr(StrData2, "Coronavirus")
        pos10 = InStr(pos10 + 1, StrData2, "Cases:", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData2, "view by country", vbTextCompare)
        pos12 = StrData2.Substring(pos10 + 10, pos11 - pos10)
        casesglobal = Integer.Parse(Regex.Replace(pos12, "[^\d]", ""))
        GunaLabel7.Text = casesglobal

        GunaCircleProgressBar4.Value = casesglobal

    End Sub

    Private Sub GunaGoogleSwitch1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaGoogleSwitch1.MouseClick
        c = c + 1
        Dim w11 As String = "#FFEEEEF2"
        Dim w55 As String = "#BEBEBE"
        If c Mod 2 = 0 Then
            Me.BackColor = ColorTranslator.FromHtml(w11)

            GunaElipsePanel4.BaseColor = Color.White
            GunaElipsePanel3.BaseColor = Color.White
            GunaElipsePanel2.BaseColor = Color.White
            GunaElipsePanel1.BaseColor = Color.White


            GunaLabel1.ForeColor = ColorTranslator.FromHtml(w55)
            GunaLabel3.ForeColor = ColorTranslator.FromHtml(w55)
            GunaLabel6.ForeColor = ColorTranslator.FromHtml(w55)
            GunaLabel8.ForeColor = ColorTranslator.FromHtml(w55)


            GunaLabel2.ForeColor = Color.Black
            GunaLabel4.ForeColor = Color.Black
            GunaLabel7.ForeColor = Color.Black
            GunaLabel5.ForeColor = Color.Black

            GunaControlBox1.IconColor = Color.Black

        ElseIf c Mod 2 <> 0 Then

            Dim w22 As String = "#30303030"
            Dim w33 As String = "#fff"
            Dim w44 As String = "#E8E8E8E8"
            Me.BackColor = Color.Black
            GunaElipsePanel4.BaseColor = ColorTranslator.FromHtml(w22)
            GunaElipsePanel3.BaseColor = ColorTranslator.FromHtml(w22)
            GunaElipsePanel2.BaseColor = ColorTranslator.FromHtml(w22)
            GunaElipsePanel1.BaseColor = ColorTranslator.FromHtml(w22)


            GunaLabel1.ForeColor = ColorTranslator.FromHtml(w33)
            GunaLabel3.ForeColor = ColorTranslator.FromHtml(w33)
            GunaLabel6.ForeColor = ColorTranslator.FromHtml(w33)
            GunaLabel8.ForeColor = ColorTranslator.FromHtml(w33)


            GunaLabel2.ForeColor = ColorTranslator.FromHtml(w44)
            GunaLabel4.ForeColor = ColorTranslator.FromHtml(w44)
            GunaLabel7.ForeColor = ColorTranslator.FromHtml(w44)
            GunaLabel5.ForeColor = ColorTranslator.FromHtml(w44)

            GunaControlBox1.IconColor = Color.White

        End If




    End Sub
End Class
