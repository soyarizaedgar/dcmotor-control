Public Class Form1


    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub com_btn_Click(sender As Object, e As EventArgs) Handles com_btn.Click
        SerialPort1.PortName = TextBox1.Text
    End Sub

    Private Sub rbtn_Click(sender As Object, e As EventArgs) Handles rbtn.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("R")
        SerialPort1.Close()
    End Sub

    Private Sub lbtn_Click(sender As Object, e As EventArgs) Handles lbtn.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("L")
        SerialPort1.Close()
    End Sub

    Private Sub sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("S")
        SerialPort1.Close()
    End Sub

    Private Sub fbtn_Click(sender As Object, e As EventArgs) Handles fbtn.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("F")
        SerialPort1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("B")
        SerialPort1.Close()
    End Sub
End Class
