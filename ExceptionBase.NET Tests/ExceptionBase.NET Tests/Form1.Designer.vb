<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDoubleToStringError = New System.Windows.Forms.Button()
        Me.btnNonexistentFileError = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDatabaseAdress = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(272, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(433, 59)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dieses Programm testet die Fehlerbehandlung und das damit verbundene Fehlerfenste" & _
    "r von ExceptionBase.NET. Weitere Informationen: http://git.exceptionbase.net"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 10)
        Me.Panel1.TabIndex = 4
        '
        'btnDoubleToStringError
        '
        Me.btnDoubleToStringError.Location = New System.Drawing.Point(12, 126)
        Me.btnDoubleToStringError.Name = "btnDoubleToStringError"
        Me.btnDoubleToStringError.Size = New System.Drawing.Size(409, 35)
        Me.btnDoubleToStringError.TabIndex = 5
        Me.btnDoubleToStringError.Text = "Fehler auslösen (String zu Double konvertieren)"
        Me.btnDoubleToStringError.UseVisualStyleBackColor = True
        '
        'btnNonexistentFileError
        '
        Me.btnNonexistentFileError.Location = New System.Drawing.Point(12, 167)
        Me.btnNonexistentFileError.Name = "btnNonexistentFileError"
        Me.btnNonexistentFileError.Size = New System.Drawing.Size(409, 33)
        Me.btnNonexistentFileError.TabIndex = 6
        Me.btnNonexistentFileError.Text = "Fehler auslösen (Nicht existierende Datei öffnen)"
        Me.btnNonexistentFileError.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDatabaseAdress)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adresse der Datenbank-API"
        '
        'tbDatabaseAdress
        '
        Me.tbDatabaseAdress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDatabaseAdress.Location = New System.Drawing.Point(3, 16)
        Me.tbDatabaseAdress.Name = "tbDatabaseAdress"
        Me.tbDatabaseAdress.Size = New System.Drawing.Size(403, 20)
        Me.tbDatabaseAdress.TabIndex = 0
        Me.tbDatabaseAdress.Text = "http://meine.domain/api/addException.php"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 211)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNonexistentFileError)
        Me.Controls.Add(Me.btnDoubleToStringError)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExceptionBase.NET Tests"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDoubleToStringError As System.Windows.Forms.Button
    Friend WithEvents btnNonexistentFileError As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbDatabaseAdress As System.Windows.Forms.TextBox

End Class
