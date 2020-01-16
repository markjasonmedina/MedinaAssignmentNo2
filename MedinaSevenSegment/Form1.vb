Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static state As Integer
        Select Case state
            Case 0
                AA.BackColor = RGB(79, 158, 196)
                BB.BackColor = RGB(79, 158, 196)
                CC.BackColor = RGB(79, 158, 196)
                DD.BackColor = RGB(79, 158, 196)
                EE.BackColor = RGB(79, 158, 196)
                FF.BackColor = RGB(79, 158, 196)
                GG.BackColor = RGB(0, 0, 0)
        End Select
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BB.Click

    End Sub
End Class
