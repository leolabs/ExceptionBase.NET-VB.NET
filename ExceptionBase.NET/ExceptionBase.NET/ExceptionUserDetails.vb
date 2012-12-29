Public Class ExceptionUserDetails
    Dim state As Integer = -1

    Private Sub ExceptionUserDetailsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Text = l("exUserWindowDescription")
        gbUserDescription.Text = l("exUserWindowGroupName")
        Me.Text = l("exUserWindowGroupName")
        btnSend.Text = l("exUserWindowOK")
        btnSkip.Text = l("exUserWindowSkip")
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub
End Class