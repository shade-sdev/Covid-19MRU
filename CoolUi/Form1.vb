Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form1

    Public cases As String
    Public c As Integer = 0
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim uristring As String = ("https://api.covid19api.com/summary")
        Dim uri As New Uri(uristring)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "get"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream)
        Dim steamjson As String = read.ReadToEnd()
        Dim read2 = Newtonsoft.Json.Linq.JObject.Parse(steamjson)

        cases = read2.Item("Countries")(107)("TotalConfirmed").ToString()
        GunaLabel2.Text = read2.Item("Countries")(107)("TotalConfirmed").ToString()

        GunaLabel4.Text = read2.Item("Countries")(107)("NewConfirmed").ToString()

        GunaLabel5.Text = read2.Item("Countries")(107)("TotalDeaths").ToString()

        GunaLabel7.Text = read2.Item("Global")("TotalConfirmed").ToString()

        GunaCircleProgressBar1.Value = read2.Item("Countries")(107)("TotalConfirmed").ToString()
        GunaCircleProgressBar2.Value = read2.Item("Countries")(107)("NewConfirmed").ToString()
        GunaCircleProgressBar3.Value = read2.Item("Countries")(107)("TotalDeaths").ToString()


        GunaCircleProgressBar4.Value = GunaLabel7.Text = read2.Item("Global")("TotalConfirmed").ToString()


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
