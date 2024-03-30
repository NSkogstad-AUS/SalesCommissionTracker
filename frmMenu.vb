Public Class frmMenu
    'Nicolai Skogstad - Peninsula Grammar - Y11 Student
    'Sales and Commission U3AOS1 SAC assignment
    'Version 1.3 (Part 4) of the 4 part exam.
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmView.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class