Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BB.Click

    End Sub

    Private Sub AA_Click(sender As Object, e As EventArgs) Handles AA.Click

    End Sub

    Dim i As Integer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        i = i + 1

        If i = 1 Then
            GG.BackColor = Color.FromArgb(0, 0, 0)
        End If

        If i = 2 Then
            AA.BackColor = Color.FromArgb(0, 0, 0)
            DD.BackColor = Color.FromArgb(0, 0, 0)
            EE.BackColor = Color.FromArgb(0, 0, 0)
            FF.BackColor = Color.FromArgb(0, 0, 0)
        End If
    End Sub
End Class
