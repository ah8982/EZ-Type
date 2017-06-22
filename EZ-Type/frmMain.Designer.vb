<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.nfiControlCenter = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsControlCenter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuShowHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrpMainWindow = New System.Windows.Forms.MenuStrip()
        Me.mitAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitHideWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mitExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSendText = New System.Windows.Forms.Button()
        Me.tmrSendKeystrokes = New System.Windows.Forms.Timer(Me.components)
        Me.chkEncrypt = New System.Windows.Forms.CheckBox()
        Me.cmsControlCenter.SuspendLayout()
        Me.mstrpMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'nfiControlCenter
        '
        Me.nfiControlCenter.Text = "EZ-Type"
        Me.nfiControlCenter.Visible = True
        '
        'cmsControlCenter
        '
        Me.cmsControlCenter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmsControlCenter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowHide, Me.ToolStripSeparator1, Me.mnuAbout, Me.mnuExit})
        Me.cmsControlCenter.Name = "cmsControlCenter"
        Me.cmsControlCenter.Size = New System.Drawing.Size(170, 82)
        '
        'mnuShowHide
        '
        Me.mnuShowHide.Name = "mnuShowHide"
        Me.mnuShowHide.Size = New System.Drawing.Size(169, 24)
        Me.mnuShowHide.Text = "Hide Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(169, 24)
        Me.mnuAbout.Text = "About EZ-Type"
        '
        'mnuExit
        '
        Me.mnuExit.ForeColor = System.Drawing.Color.Maroon
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(169, 24)
        Me.mnuExit.Text = "Exit"
        '
        'mstrpMainWindow
        '
        Me.mstrpMainWindow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mstrpMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mitAbout, Me.mitHideWindow, Me.mitExit})
        Me.mstrpMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.mstrpMainWindow.Name = "mstrpMainWindow"
        Me.mstrpMainWindow.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mstrpMainWindow.Size = New System.Drawing.Size(567, 27)
        Me.mstrpMainWindow.TabIndex = 1
        Me.mstrpMainWindow.Text = "MenuStrip1"
        '
        'mitAbout
        '
        Me.mitAbout.Name = "mitAbout"
        Me.mitAbout.Size = New System.Drawing.Size(59, 23)
        Me.mitAbout.Text = "About"
        '
        'mitHideWindow
        '
        Me.mitHideWindow.Name = "mitHideWindow"
        Me.mitHideWindow.Size = New System.Drawing.Size(103, 23)
        Me.mitHideWindow.Text = "Hide Window"
        '
        'mitExit
        '
        Me.mitExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mitExit.ForeColor = System.Drawing.Color.Maroon
        Me.mitExit.Name = "mitExit"
        Me.mitExit.Size = New System.Drawing.Size(42, 23)
        Me.mitExit.Text = "Exit"
        '
        'lbItems
        '
        Me.lbItems.Cursor = System.Windows.Forms.Cursors.Cross
        Me.lbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.HorizontalScrollbar = True
        Me.lbItems.ItemHeight = 15
        Me.lbItems.Location = New System.Drawing.Point(14, 35)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.ScrollAlwaysVisible = True
        Me.lbItems.Size = New System.Drawing.Size(444, 259)
        Me.lbItems.Sorted = True
        Me.lbItems.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(465, 35)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 32)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(465, 74)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 32)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSendText
        '
        Me.btnSendText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendText.Location = New System.Drawing.Point(465, 262)
        Me.btnSendText.Name = "btnSendText"
        Me.btnSendText.Size = New System.Drawing.Size(87, 32)
        Me.btnSendText.TabIndex = 5
        Me.btnSendText.Text = "Send Text"
        Me.btnSendText.UseVisualStyleBackColor = True
        '
        'tmrSendKeystrokes
        '
        Me.tmrSendKeystrokes.Interval = 2000
        '
        'chkEncrypt
        '
        Me.chkEncrypt.AutoSize = True
        Me.chkEncrypt.Enabled = False
        Me.chkEncrypt.Location = New System.Drawing.Point(12, 297)
        Me.chkEncrypt.Name = "chkEncrypt"
        Me.chkEncrypt.Size = New System.Drawing.Size(197, 19)
        Me.chkEncrypt.TabIndex = 6
        Me.chkEncrypt.Text = "Save/Load templates encrypted"
        Me.chkEncrypt.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 328)
        Me.Controls.Add(Me.chkEncrypt)
        Me.Controls.Add(Me.btnSendText)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.mstrpMainWindow)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstrpMainWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EZ-Type"
        Me.cmsControlCenter.ResumeLayout(False)
        Me.mstrpMainWindow.ResumeLayout(False)
        Me.mstrpMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nfiControlCenter As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsControlCenter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mstrpMainWindow As System.Windows.Forms.MenuStrip
    Friend WithEvents mitAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShowHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSendText As System.Windows.Forms.Button
    Friend WithEvents tmrSendKeystrokes As System.Windows.Forms.Timer
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mitHideWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkEncrypt As System.Windows.Forms.CheckBox

End Class
