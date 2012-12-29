<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDetails))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pbAppImage = New System.Windows.Forms.PictureBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.gbUserDescription = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbAppImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUserDescription.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.pbAppImage, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDescription, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 76)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'pbAppImage
        '
        Me.pbAppImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbAppImage.Location = New System.Drawing.Point(3, 3)
        Me.pbAppImage.Name = "pbAppImage"
        Me.pbAppImage.Size = New System.Drawing.Size(58, 58)
        Me.pbAppImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAppImage.TabIndex = 0
        Me.pbAppImage.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoEllipsis = True
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Location = New System.Drawing.Point(67, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Padding = New System.Windows.Forms.Padding(10)
        Me.lblDescription.Size = New System.Drawing.Size(435, 64)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'gbUserDescription
        '
        Me.gbUserDescription.Controls.Add(Me.TextBox1)
        Me.gbUserDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbUserDescription.Location = New System.Drawing.Point(10, 86)
        Me.gbUserDescription.Name = "gbUserDescription"
        Me.gbUserDescription.Padding = New System.Windows.Forms.Padding(10)
        Me.gbUserDescription.Size = New System.Drawing.Size(503, 245)
        Me.gbUserDescription.TabIndex = 5
        Me.gbUserDescription.TabStop = False
        Me.gbUserDescription.Text = "Bechreibung des Fehlers"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.AcceptsTab = True
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(10, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(483, 212)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblModuleName)
        Me.Panel1.Controls.Add(Me.btnSkip)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(10, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel1.Size = New System.Drawing.Size(503, 35)
        Me.Panel1.TabIndex = 6
        '
        'lblModuleName
        '
        Me.lblModuleName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblModuleName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblModuleName.Location = New System.Drawing.Point(6, 6)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(104, 23)
        Me.lblModuleName.TabIndex = 3
        Me.lblModuleName.Text = "ExceptionBase.NET"
        Me.lblModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSkip
        '
        Me.btnSkip.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSkip.Location = New System.Drawing.Point(323, 6)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(84, 23)
        Me.btnSkip.TabIndex = 2
        Me.btnSkip.Text = "Ü&berspringen"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(407, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(6, 23)
        Me.Panel3.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSend.Location = New System.Drawing.Point(413, 6)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(84, 23)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "&OK"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 10)
        Me.Panel2.TabIndex = 7
        '
        'UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 386)
        Me.Controls.Add(Me.gbUserDescription)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserDetails"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pbAppImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUserDescription.ResumeLayout(False)
        Me.gbUserDescription.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbAppImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents gbUserDescription As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents lblModuleName As System.Windows.Forms.Label
End Class
