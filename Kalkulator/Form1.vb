Public Class Form1
    Dim op As String
    Dim num1, num2 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click_(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button12tambah_Click(sender As Object, e As EventArgs) Handles Button12tambah.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "+"
    End Sub

    Private Sub Button13kurang_Click(sender As Object, e As EventArgs) Handles Button13kurang.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "-"
    End Sub

    Private Sub Button14kali_Click_1(sender As Object, e As EventArgs) Handles Button14kali.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "*"
    End Sub

    Private Sub Button15bagi_Click_1(sender As Object, e As EventArgs) Handles Button15bagi.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "/"
    End Sub

    Private Sub Button16modul_Click(sender As Object, e As EventArgs) Handles Button16modul.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "%"
    End Sub

    Private Sub Button17hasil_Click(sender As Object, e As EventArgs) Handles Button17hasil.Click
        num2 = TextBox1.Text
        If op = "*" Then
            TextBox1.Text = num1 * num2
        ElseIf op = "+" Then
            TextBox1.Text = num1 + num2
        ElseIf op = "-" Then
            TextBox1.Text = num1 - num2
        ElseIf op = "/" Then
            TextBox1.Text = num1 / num2
        ElseIf op = "%" Then
            TextBox1.Text = num1 Mod num2
        End If
    End Sub

    Private Sub Button18hapus_Click(sender As Object, e As EventArgs) Handles Button18hapus.Click
        TextBox1.Text = ""
    End Sub
End Class
