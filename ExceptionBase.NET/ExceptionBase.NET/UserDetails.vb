Option Strict On

Public Class UserDetails
    ' Beschriftungen initialisieren
    Public winTitle As String = "Benutzerdetails zu dem Fehler"
    Public winDescription As String = "Es ist ein schwerwiegender Fehler aufgetreten. Bitte beschreiben Sie die Schritte, die zu dem Fehler geführt haben könnten, damit wir ihn so schnell wie möglich beheben können."
    Public winInputCaption As String = "Beschreibung des Fehlers"
    Public bSkip As String = "Ü&berspringen"
    Public bSend As String = "&OK"

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Me.DialogResult = Windows.Forms.DialogResult.Ignore
    End Sub

    Private Sub UserDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = winTitle
        lblDescription.Text = winDescription
        gbUserDescription.Text = winInputCaption
        btnSend.Text = bSend
        btnSkip.Text = bSkip
    End Sub
End Class