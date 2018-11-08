Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        horas.Text = DateAndTime.Now.ToLongTimeString()
        calendario.Text = DateAndTime.Now.ToLongDateString()
    End Sub


End Class
