<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitleOutput = New System.Windows.Forms.Label()
        Me.lblCopyrightOutput = New System.Windows.Forms.Label()
        Me.lblVersionOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(14, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(33, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(14, 37)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(61, 15)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "Copyright:"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(14, 65)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 15)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(386, 150)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 27)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitleOutput
        '
        Me.lblTitleOutput.AutoSize = True
        Me.lblTitleOutput.Location = New System.Drawing.Point(85, 10)
        Me.lblTitleOutput.Name = "lblTitleOutput"
        Me.lblTitleOutput.Size = New System.Drawing.Size(45, 15)
        Me.lblTitleOutput.TabIndex = 4
        Me.lblTitleOutput.Text = "Label1"
        '
        'lblCopyrightOutput
        '
        Me.lblCopyrightOutput.AutoSize = True
        Me.lblCopyrightOutput.Location = New System.Drawing.Point(85, 37)
        Me.lblCopyrightOutput.Name = "lblCopyrightOutput"
        Me.lblCopyrightOutput.Size = New System.Drawing.Size(45, 15)
        Me.lblCopyrightOutput.TabIndex = 5
        Me.lblCopyrightOutput.Text = "Label1"
        '
        'lblVersionOutput
        '
        Me.lblVersionOutput.AutoSize = True
        Me.lblVersionOutput.Location = New System.Drawing.Point(85, 65)
        Me.lblVersionOutput.Name = "lblVersionOutput"
        Me.lblVersionOutput.Size = New System.Drawing.Size(45, 15)
        Me.lblVersionOutput.TabIndex = 6
        Me.lblVersionOutput.Text = "Label1"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 190)
        Me.Controls.Add(Me.lblVersionOutput)
        Me.Controls.Add(Me.lblCopyrightOutput)
        Me.Controls.Add(Me.lblTitleOutput)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitleOutput As System.Windows.Forms.Label
    Friend WithEvents lblCopyrightOutput As System.Windows.Forms.Label
    Friend WithEvents lblVersionOutput As System.Windows.Forms.Label
End Class
