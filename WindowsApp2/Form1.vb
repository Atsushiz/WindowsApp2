Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "テストメッセージ"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = DateString + " " + TimeString
        Label1.Text = DateString + " " + TimeString

    End Sub
End Class
