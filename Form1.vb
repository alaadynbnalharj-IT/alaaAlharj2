Public Class Form1
    Dim a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "alaa "
        TextBox2.Text = "Abdubari "
        TextBox3.Text = "Sahem"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text & TextBox2.Text & TextBox3.Text
        Dim s As String
        s = a.Substring(5, 8)
        TextBox4.Text = s
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text & TextBox2.Text & TextBox3.Text
        Dim r As String
        r = a.Remove(14, 5)
        TextBox4.Text = r
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = TextBox1.Text & TextBox2.Text & TextBox3.Text
        Dim m As String
        m = a.Insert(0, "ans ")
        TextBox4.Text = m
    End Sub
End Class
