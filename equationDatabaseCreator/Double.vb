Imports System.IO
Public Class FormDouble
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random()
        Dim a, b, c As Double
        Dim f As Integer
        Dim fileName As String = Label5.Text
        Dim sw As New StreamWriter(fileName)
        sw.WriteLine("a,b,c,f")
        Dim n As Integer = Integer.Parse(TextBox7.Text)
        For i As Integer = 1 To n
            a = rnd.NextDouble() * (Integer.Parse(TextBox2.Text) - Integer.Parse(TextBox1.Text)) + Integer.Parse(TextBox1.Text)
            While a = 0
                a = rnd.NextDouble() * (Integer.Parse(TextBox2.Text) - Integer.Parse(TextBox1.Text)) + Integer.Parse(TextBox1.Text)
            End While
            b = rnd.NextDouble() * (Integer.Parse(TextBox4.Text) - Integer.Parse(TextBox3.Text)) + Integer.Parse(TextBox3.Text)
            c = rnd.NextDouble() * (Integer.Parse(TextBox6.Text) - Integer.Parse(TextBox5.Text)) + Integer.Parse(TextBox5.Text)
            Dim delta As Double = Math.Pow(a, 2) - 4 * b * c
            If delta < 0 Then
                f = 0
            Else
                f = 1
            End If
            sw.WriteLine(a & "," & b & "," & c & "," & f)

        Next
        sw.Close()
        MessageBox.Show("Work done!")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
        Label5.Text = SaveFileDialog1.FileName
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormInteger.Show()
        FormInteger.Refresh()


    End Sub

    Private Sub FormDouble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = IO.Path.GetDirectoryName(Application.ExecutablePath()) & "\file.csv"
    End Sub
End Class
