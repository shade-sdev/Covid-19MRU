Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Dim pos1 As Long, pos2 As Long, pos3 As String

    Dim pos4 As Long, pos5 As Long, pos6 As String

    Dim pos7 As String

    Dim pos10 As Long, pos11 As Long, pos12 As String


    Dim cases As String
    Dim recov As String
    Dim death As String
    Dim casesglobal As String

    Dim c As Integer = 0
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim request As WebRequest = WebRequest.Create("https://en.wikipedia.org/wiki/Template:2019%E2%80%9320_coronavirus_pandemic_data#covid19-container")
        Dim response As HttpWebResponse = CType(request.GetResponse, HttpWebResponse)
        Dim dataStream As Stream = response.GetResponseStream
        Dim reader As New StreamReader(dataStream)
        Dim StrData As String = reader.ReadToEnd


        pos1 = InStr(StrData, "Mauri")
        pos1 = InStr(pos1 + 1, StrData, "tius", vbTextCompare)
        pos2 = InStr(pos1 + 1, StrData, "Nigeria", vbTextCompare)
        pos3 = StrData.Substring(pos1 + 500, pos2 - pos1 - 685)

        pos4 = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))

        cases = pos4.ToString().Substring(0, 3)


        GunaLabel2.Text = cases

        pos5 = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))

        recov = pos4.ToString().Substring(4, 2)

        GunaLabel4.Text = recov

        pos6 = Integer.Parse(Regex.Replace(pos3, "[^\d]", ""))

        pos7 = pos6.Replace(cases, "")

        death = pos7.Replace(recov, "")

        GunaLabel5.Text = death

        GunaCircleProgressBar1.Value = cases
        GunaCircleProgressBar2.Value = recov
        GunaCircleProgressBar3.Value = death


        pos10 = InStr(StrData, "Ref")
        pos10 = InStr(pos10 + 1, StrData, "232", vbTextCompare)
        pos11 = InStr(pos10 + 1, StrData, "United States", vbTextCompare)
        pos12 = StrData.Substring(pos10 + 670, pos11 - pos10 - 2800)
        casesglobal = Integer.Parse(Regex.Replace(pos12, "[^\d]", ""))


        GunaLabel7.Text = casesglobal

        GunaCircleProgressBar4.Value = casesglobal


    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click
        Me.Close()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click



        Form1_Load_1(sender, e)



    End Sub



    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click

        Me.Show()


    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick



        NotifyIcon1.Text = "Cases " + cases

        NotifyIcon1.BalloonTipTitle = "Covid"
        NotifyIcon1.ShowBalloonTip(cases, "Cases", cases, ToolTipIcon.Info)
    End Sub




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Form1_Load_1(sender, e)

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
