Imports ExceptionBase

Public Class Form1
    Dim ExBase As New ExceptionBase("", 1, ProductVersion.ToString, My.Resources.bug)

    Private Sub testDoubleToString(sender As Object, e As EventArgs) Handles btnDoubleToStringError.Click
        Try
            Dim test As Integer = "Hallo Welt"
        Catch ex As Exception
            ExBase.Track(ex, True)
        End Try
    End Sub

    Private Sub textNonexistentFile(sender As Object, e As EventArgs) Handles btnNonexistentFileError.Click
        Try
            Dim test As String = My.Computer.FileSystem.ReadAllText("C:\SomeNonExistentPath\That\WillNever\Exist.txt")
        Catch ex As Exception
            ExBase.Track(ex, True)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbDatabaseAdress.TextChanged
        If tbDatabaseAdress.Text Like "http*://*.*/api/addException.php" Then
            ExBase.Server = tbDatabaseAdress.Text
            btnDoubleToStringError.Enabled = True
            btnNonexistentFileError.Enabled = True
        Else
            btnDoubleToStringError.Enabled = False
            btnNonexistentFileError.Enabled = False
        End If
    End Sub
End Class
