Option Explicit On

Public Class frmMain

    Dim isHidden As Boolean = False
    Dim isEncrypted As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.nfiControlCenter
            'Keep app responsive
            Try
                Application.DoEvents()
            Catch ex As Exception
                'Show error message
                BalloonTip.ShowBalloonTipError(ex.ToString, "Keep application responsive")
            End Try

            'Add NotifyIcon to taskbar
            .Icon = Me.Icon
            .Visible = True

            'Update Menu
            Me.mnuShowHide.Text = "Hide Window"
            isHidden = False

            'Clear List Box
            Try
                Me.lbItems.Items.Clear()
            Catch ex As Exception
                'Show error message
                BalloonTip.ShowBalloonTipError(ex.ToString, "Clear List Box")
            End Try

            Try
                'Load the items
                LoadItems()
            Catch ex As Exception
                'Show error message
                BalloonTip.ShowBalloonTipError(ex.ToString, "Load the items")
            End Try
        End With
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Remove NotifyIcon from taskbar
        With Me.nfiControlCenter
            .Visible = False
        End With

        'Save the items
        Try
            SaveItems()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Save the items")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub nfiControlCenter_Click(sender As Object, e As EventArgs) Handles nfiControlCenter.Click
        'Show Context Menu
        With Me.cmsControlCenter
            .Show(MousePosition)
        End With
    End Sub

    Private Sub AboutEZTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'Show About Form
        With My.Forms.frmAbout
            .ShowDialog()
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitAbout.Click
        'Show About Form
        With My.Forms.frmAbout
            .ShowDialog()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitExit.Click
        'Exit application
        Application.Exit()
    End Sub

    Private Sub mnuShowHide_Click(sender As Object, e As EventArgs) Handles mnuShowHide.Click
        'Update the state of the window
        UpdateWindowState()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Keep application responsive
        Try
            Application.DoEvents()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Keep application responsive")

            'Exit sub
            Exit Sub
        End Try

        With Me.lbItems
            'If there are no items to delete, exit sub
            If .Items.Count = 0 Then Exit Sub

            'Delete selected item
            .Items.RemoveAt(.SelectedIndex)

            'Sort items
            Me.lbItems.Sorted = True
        End With

        'Save the items
        Try
            SaveItems()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Save the items")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Keep application responsive
        Try
            Application.DoEvents()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Keep application responsive")

            'Exit sub
            Exit Sub
        End Try

        With My.Forms.frmItem
            'Show item window
            .ShowDialog()

            'Determine if the OK button was clicked on the dialog box
            If .DialogResult = DialogResult.OK Then
                'Add item
                Me.lbItems.Items.Add(frmItem.txtItem.Text)

                'Sort items
                Me.lbItems.Sorted = True
            End If

            'Dispose Item window
            .Dispose()
        End With

        'Save the items
        Try
            SaveItems()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Save the items")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Hide Window
        isHidden = False
        Me.Visible = isHidden

        'Update Menu
        Me.mnuShowHide.Text = "Show Window"
    End Sub

    Private Sub lbItems_DoubleClick(sender As Object, e As EventArgs) Handles lbItems.DoubleClick
        'Keep application responsive
        Application.DoEvents()

        'Update item
        Dim TempText As String

        On Error Resume Next

        With Me.lbItems
            'If there are no items to update, exit sub
            If .Items.Count = 0 Then Exit Sub

            'Save temporary
            TempText = .Items.Item(.SelectedIndex)

            'Update text in item window
            frmItem.txtItem.Text = TempText

            'Show item window
            My.Forms.frmItem.ShowDialog()

            'Determine if the OK button was clicked on the dialog box
            If My.Forms.frmItem.DialogResult = DialogResult.OK Then
                'Save changes
                Me.lbItems.Items.Add(My.Forms.frmItem.txtItem.Text)
            Else
                'Add new item
                Me.lbItems.Items.Add(TempText)
            End If

            'Sort items
            Me.lbItems.Sorted = True

            'Dispose Item window
            My.Forms.frmItem.Dispose()

            'Delete selected item
            .Items.RemoveAt(.SelectedIndex)
        End With

        'Save the items
        SaveItems()
    End Sub

    Private Sub btnSendText_Click(sender As Object, e As EventArgs) Handles btnSendText.Click
        With Me
            .Visible = False
            .tmrSendKeystrokes.Enabled = True
            '.Visible = True
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrSendKeystrokes.Tick
        'Keep application responsive
        Application.DoEvents()

        Try
            'Send the keystrokes
            SendKeys.Send(Me.lbItems.Items.Item(Me.lbItems.SelectedIndex).ToString)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError("No text for sending selected.", "Information")
        End Try

        'Disable timer
        Me.tmrSendKeystrokes.Enabled = False
    End Sub

    Private Sub SaveItems()
        'Keep application responsive
        Try
            Application.DoEvents()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Keep application responsive")

            'Exit sub
            Exit Sub
        End Try

        'Variables
        Dim ini As New INIDatei
        Dim Items As Integer = Me.lbItems.Items.Count
        Dim i As Integer
        Dim encItem As String

        Try
            With ini
                'Set path
                .Pfad = My.Application.Info.DirectoryPath & "\Settings.ini"

                'Save the numer of items
                .WertSchreiben("Settings", "Items", Items)

                'Save encryption state
                .WertSchreiben("Settings", "Encrypted", isEncrypted)

                'If there is no item to save, exit sub
                If Items = 0 Then Exit Sub

                'Save each item
                For i = 1 To Items
                    encItem = Cryptograpy.Decrypt(Me.lbItems.Items.Item(i - 1))
                    If isEncrypted = "Yes" Then
                        .WertSchreiben("Templates", "Item" & i.ToString, encItem)
                    Else
                        .WertSchreiben("Templates", "Item" & i.ToString, Me.lbItems.Items.Item(i - 1))
                    End If
                Next
            End With
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error saving")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub LoadItems()
        'Keep application responsive
        Try
            Application.DoEvents()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Keep application responsive")

            'Exit sub
            Exit Sub
        End Try

        'Variables
        Dim ini As New INIDatei
        Dim Items As Integer
        Dim i As Integer
        Dim e As String
        Dim encItem As String

        Try
            With ini
                'Set path
                .Pfad = My.Application.Info.DirectoryPath & "\Settings.ini"

                'Load the numer of items
                Items = .WertLesen("Settings", "Items")

                'Load enryption state
                e = .WertLesen("Settings", "Encrypted")
                If e = "Yes" Then
                    Me.chkEncrypt.Checked = True
                    isEncrypted = "Yes"
                Else
                    Me.chkEncrypt.Checked = False
                    isEncrypted = "No"
                End If

                'If there is no item to load, exit sub
                If Items = 0 Then Exit Sub

                'Load each item
                For i = 1 To Items
                    encItem = Cryptograpy.Encrypt(.WertLesen("Templates", "Item" & i.ToString))
                    If isEncrypted = "Yes" Then
                        Me.lbItems.Items.Add(encItem)
                    Else
                        Me.lbItems.Items.Add(.WertLesen("Templates", "Item" & i.ToString))
                    End If
                Next
            End With
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error loading")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Quit application
        Application.Exit()
    End Sub

    Private Sub nfiControlCenter_DoubleClick(sender As Object, e As EventArgs) Handles nfiControlCenter.DoubleClick
        'Show main window
        Try
            'Show window
            isHidden = False
            Me.mnuShowHide.Text = "Show Window"

            'Update window state
            Me.Visible = isHidden
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error call updating window state")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub HideWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mitHideWindow.Click
        'Update the window state
        Try
            UpdateWindowState()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Update window state")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub UpdateWindowState()
        Try
            If isHidden = True Then
                'Unhide window
                isHidden = False
                Me.mnuShowHide.Text = "Show Window"
            Else
                'Hide window
                isHidden = True
                Me.mnuShowHide.Text = "Hide Window"
            End If

            'Update window state
            Me.Visible = isHidden
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Update Window State - Main Sub")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub nfiControlCenter_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nfiControlCenter.MouseDoubleClick
        'Show main window
        Try
            Me.UpdateWindowState()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Update Window State - Main Sub")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub chkEncrypt_CheckedChanged(sender As Object, e As EventArgs) Handles chkEncrypt.CheckedChanged
        Try
            With Me.chkEncrypt
                If .Checked = True Then
                    isEncrypted = "Yes"
                Else
                    isEncrypted = "No"
                End If
            End With

            SaveItems()
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Update encryption")

            'Exit sub
            Exit Sub
        End Try
    End Sub
End Class