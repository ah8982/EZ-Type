Option Explicit On

Public Class frmItem

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update Icon
        Me.Icon = My.Forms.frmMain.Icon
    End Sub

    Private Sub addKey(ByVal key As String)
        'Check if there is text in key.
        'If not, exit sub.
        If key = "" Then Exit Sub

        'Add key to text box
        With Me.txtItem
            .Text = .Text & key
            .Select(.Text.Length, 0)
        End With
    End Sub

    Private Sub lblBackspace_Click(sender As Object, e As EventArgs) Handles lblBackspace.Click
        Try
            'Add key to text box
            addKey(Me.lblBackspace.Tag)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblBreak_Click(sender As Object, e As EventArgs) Handles lblBreak.Click
        Try
            'Add key to text box
            addKey(Me.lblBreak.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblCapsLock_Click(sender As Object, e As EventArgs) Handles lblCapsLock.Click
        Try
            'Add key to text box
            addKey(Me.lblCapsLock.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            'Add key to text box
            addKey(Me.lblDelete.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblDown_Click(sender As Object, e As EventArgs) Handles lblDown.Click
        Try
            'Add key to text box
            addKey(Me.lblDown.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblEnd_Click(sender As Object, e As EventArgs) Handles lblEnd.Click
        Try
            'Add key to text box
            addKey(Me.lblEnd.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblEnter_Click(sender As Object, e As EventArgs) Handles lblEnter.Click
        Try
            'Add key to text box
            addKey(Me.lblEnter.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblEscape_Click(sender As Object, e As EventArgs) Handles lblEscape.Click
        Try
            'Add key to text box
            addKey(Me.lblEscape.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        Try
            'Add key to text box
            addKey(Me.lblHelp.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Try
            'Add key to text box
            addKey(Me.lblHome.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblInsert_Click(sender As Object, e As EventArgs) Handles lblInsert.Click
        Try
            'Add key to text box
            addKey(Me.lblInsert.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblLeft_Click(sender As Object, e As EventArgs) Handles lblLeft.Click
        Try
            'Add key to text box
            addKey(Me.lblLeft.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblNumLock_Click(sender As Object, e As EventArgs) Handles lblNumLock.Click
        Try
            'Add key to text box
            addKey(Me.lblNumLock.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblPgDn_Click(sender As Object, e As EventArgs) Handles lblPgDn.Click
        Try
            'Add key to text box
            addKey(Me.lblPgDn.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblPgUp_Click(sender As Object, e As EventArgs) Handles lblPgUp.Click
        Try
            'Add key to text box
            addKey(Me.lblPgUp.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblPrtSc_Click(sender As Object, e As EventArgs) Handles lblPrtSc.Click
        Try
            'Add key to text box
            addKey(Me.lblPrtSc.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblRight_Click(sender As Object, e As EventArgs) Handles lblRight.Click
        Try
            'Add key to text box
            addKey(Me.lblRight.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblScollLock_Click(sender As Object, e As EventArgs) Handles lblScollLock.Click
        Try
            'Add key to text box
            addKey(Me.lblScollLock.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblTab_Click(sender As Object, e As EventArgs) Handles lblTab.Click
        Try
            'Add key to text box
            addKey(Me.lblTab.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblUp_Click(sender As Object, e As EventArgs) Handles lblUp.Click
        Try
            'Add key to text box
            addKey(Me.lblUp.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF1_Click(sender As Object, e As EventArgs) Handles lblF1.Click
        Try
            'Add key to text box
            addKey(Me.lblF1.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF2_Click(sender As Object, e As EventArgs) Handles lblF2.Click
        Try
            'Add key to text box
            addKey(Me.lblF2.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF3_Click(sender As Object, e As EventArgs) Handles lblF3.Click
        Try
            'Add key to text box
            addKey(Me.lblF3.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF4_Click(sender As Object, e As EventArgs) Handles lblF4.Click
        Try
            'Add key to text box
            addKey(Me.lblF4.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF5_Click(sender As Object, e As EventArgs) Handles lblF5.Click
        Try
            'Add key to text box
            addKey(Me.lblF5.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF6_Click(sender As Object, e As EventArgs) Handles lblF6.Click
        Try
            'Add key to text box
            addKey(Me.lblF6.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF7_Click(sender As Object, e As EventArgs) Handles lblF7.Click
        Try
            'Add key to text box
            addKey(Me.lblF7.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF8_Click(sender As Object, e As EventArgs) Handles lblF8.Click
        Try
            'Add key to text box
            addKey(Me.lblF8.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF9_Click(sender As Object, e As EventArgs) Handles lblF9.Click
        Try
            'Add key to text box
            addKey(Me.lblF9.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF10_Click(sender As Object, e As EventArgs) Handles lblF10.Click
        Try
            'Add key to text box
            addKey(Me.lblF10.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF11_Click(sender As Object, e As EventArgs) Handles lblF11.Click
        Try
            'Add key to text box
            addKey(Me.lblF11.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF12_Click(sender As Object, e As EventArgs) Handles lblF12.Click
        Try
            'Add key to text box
            addKey(Me.lblF12.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF13_Click(sender As Object, e As EventArgs) Handles lblF13.Click
        Try
            'Add key to text box
            addKey(Me.lblF13.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF14_Click(sender As Object, e As EventArgs) Handles lblF14.Click
        Try
            'Add key to text box
            addKey(Me.lblF14.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF15_Click(sender As Object, e As EventArgs) Handles lblF15.Click
        Try
            'Add key to text box
            addKey(Me.lblF15.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblF16_Click(sender As Object, e As EventArgs) Handles lblF16.Click
        Try
            'Add key to text box
            addKey(Me.lblF16.Text)
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Error adding special key")

            'Exit sub
            Exit Sub
        End Try
    End Sub

    Private Sub lblBackspace_MouseHover(sender As Object, e As EventArgs) Handles lblBackspace.MouseHover
        'Set BG-Color
        With Me.lblBackspace
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblBackspace_MouseLeave(sender As Object, e As EventArgs) Handles lblBackspace.MouseLeave
        'Reset BG-Color
        With Me.lblBackspace
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblBreak_MouseHover(sender As Object, e As EventArgs) Handles lblBreak.MouseHover
        'Set BG-Color
        With Me.lblBreak
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblBreak_MouseLeave(sender As Object, e As EventArgs) Handles lblBreak.MouseLeave
        'Reset BG-Color
        With Me.lblBreak
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblCapsLock_MouseHover(sender As Object, e As EventArgs) Handles lblCapsLock.MouseHover
        'Set BG-Color
        With Me.lblCapsLock
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblCapsLock_MouseLeave(sender As Object, e As EventArgs) Handles lblCapsLock.MouseLeave
        'Reset BG-Color
        With Me.lblCapsLock
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblDelete_MouseHover(sender As Object, e As EventArgs) Handles lblDelete.MouseHover
        'Set BG-Color
        With Me.lblDelete
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblDelete_MouseLeave(sender As Object, e As EventArgs) Handles lblDelete.MouseLeave
        'Reset BG-Color
        With Me.lblDelete
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblDown_MouseHover(sender As Object, e As EventArgs) Handles lblDown.MouseHover
        'Set BG-Color
        With Me.lblDown
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblDown_MouseLeave(sender As Object, e As EventArgs) Handles lblDown.MouseLeave
        'Reset BG-Color
        With Me.lblDown
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblEnd_MouseHover(sender As Object, e As EventArgs) Handles lblEnd.MouseHover
        'Set BG-Color
        With Me.lblEnd
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblEnd_MouseLeave(sender As Object, e As EventArgs) Handles lblEnd.MouseLeave
        'Reset BG-Color
        With Me.lblEnd
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblEnter_MouseHover(sender As Object, e As EventArgs) Handles lblEnter.MouseHover
        'Set BG-Color
        With Me.lblEnter
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblEnter_MouseLeave(sender As Object, e As EventArgs) Handles lblEnter.MouseLeave
        'Reset BG-Color
        With Me.lblEnter
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblEscape_MouseHover(sender As Object, e As EventArgs) Handles lblEscape.MouseHover
        'Set BG-Color
        With Me.lblEscape
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblEscape_MouseLeave(sender As Object, e As EventArgs) Handles lblEscape.MouseLeave
        'Reset BG-color
        With Me.lblEscape
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblHelp_MouseHover(sender As Object, e As EventArgs) Handles lblHelp.MouseHover
        'Set BG-Color
        With Me.lblHelp
            With Me.lblHelp
                .BackColor = Color.LightBlue
            End With
        End With
    End Sub

    Private Sub lblHelp_MouseLeave(sender As Object, e As EventArgs) Handles lblHelp.MouseLeave
        'Reset BG-Color
        With Me.lblHelp
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblHome_MouseHover(sender As Object, e As EventArgs) Handles lblHome.MouseHover
        'Set BG-Color
        With Me.lblHome
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblHome_MouseLeave(sender As Object, e As EventArgs) Handles lblHome.MouseLeave
        'Reset BG-Color
        With Me.lblHome
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblInsert_MouseHover(sender As Object, e As EventArgs) Handles lblInsert.MouseHover
        'Set BG-Color
        With Me.lblInsert
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblInsert_MouseLeave(sender As Object, e As EventArgs) Handles lblInsert.MouseLeave
        'Reset BG-Color
        With Me.lblInsert
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblLeft_MouseHover(sender As Object, e As EventArgs) Handles lblLeft.MouseHover
        'Set BG-Color
        With Me.lblLeft
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblLeft_MouseLeave(sender As Object, e As EventArgs) Handles lblLeft.MouseLeave
        'Reset BG-Color
        With Me.lblLeft
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblNumLock_MouseHover(sender As Object, e As EventArgs) Handles lblNumLock.MouseHover
        'Set BG-Color
        With Me.lblNumLock
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblNumLock_MouseLeave(sender As Object, e As EventArgs) Handles lblNumLock.MouseLeave
        'Reset BG-Color
        With Me.lblNumLock
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblPgDn_MouseHover(sender As Object, e As EventArgs) Handles lblPgDn.MouseHover
        'Set BG-Color
        With Me.lblPgDn
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblPgDn_MouseLeave(sender As Object, e As EventArgs) Handles lblPgDn.MouseLeave
        'Reset BG.Color
        With Me.lblPgDn
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblPgUp_MouseHover(sender As Object, e As EventArgs) Handles lblPgUp.MouseHover
        'Set BG-Color
        With Me.lblPgUp
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblPgUp_MouseLeave(sender As Object, e As EventArgs) Handles lblPgUp.MouseLeave
        'Reset BG-Color
        With Me.lblPgUp
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblPrtSc_MouseHover(sender As Object, e As EventArgs) Handles lblPrtSc.MouseHover
        'Set BG-Color
        With Me.lblPrtSc
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblPrtSc_MouseLeave(sender As Object, e As EventArgs) Handles lblPrtSc.MouseLeave
        'Reset BG-Color
        With Me.lblPrtSc
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblRight_MouseHover(sender As Object, e As EventArgs) Handles lblRight.MouseHover
        'Set BG-Color
        With Me.lblRight
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblRight_MouseLeave(sender As Object, e As EventArgs) Handles lblRight.MouseLeave
        'Reset BG-Color
        With Me.lblRight
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblScollLock_MouseHover(sender As Object, e As EventArgs) Handles lblScollLock.MouseHover
        'Set BG-Color
        With Me.lblScollLock
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblScollLock_MouseLeave(sender As Object, e As EventArgs) Handles lblScollLock.MouseLeave
        'Reset BG-Color
        With Me.lblScollLock
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblTab_MouseHover(sender As Object, e As EventArgs) Handles lblTab.MouseHover
        'Set BG-Color
        With Me.lblTab
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblTab_MouseLeave(sender As Object, e As EventArgs) Handles lblTab.MouseLeave
        'Reset BG-Color
        With Me.lblTab
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblUp_MouseHover(sender As Object, e As EventArgs) Handles lblUp.MouseHover
        'Set BG-Color
        With Me.lblUp
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblUp_MouseLeave(sender As Object, e As EventArgs) Handles lblUp.MouseLeave
        'Reset BG-Color
        With Me.lblUp
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF1_MouseHover(sender As Object, e As EventArgs) Handles lblF1.MouseHover
        'Set BG-Color
        With Me.lblF1
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF1_MouseLeave(sender As Object, e As EventArgs) Handles lblF1.MouseLeave
        'Reset BG-Color
        With Me.lblF1
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF2_MouseHover(sender As Object, e As EventArgs) Handles lblF2.MouseHover
        'Set BG-Color
        With Me.lblF2
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF2_MouseLeave(sender As Object, e As EventArgs) Handles lblF2.MouseLeave
        'Reset BG-Color
        With Me.lblF2
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF3_MouseHover(sender As Object, e As EventArgs) Handles lblF3.MouseHover
        'Set BG-Color
        With Me.lblF3
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF3_MouseLeave(sender As Object, e As EventArgs) Handles lblF3.MouseLeave
        'Reset BG-Color
        With Me.lblF3
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF4_MouseHover(sender As Object, e As EventArgs) Handles lblF4.MouseHover
        'Set BG-Color
        With Me.lblF4
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF4_MouseLeave(sender As Object, e As EventArgs) Handles lblF4.MouseLeave
        'Reset BG-Color
        With Me.lblF4
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF5_MouseHover(sender As Object, e As EventArgs) Handles lblF5.MouseHover
        'Set BG-Color
        With Me.lblF5
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF5_MouseLeave(sender As Object, e As EventArgs) Handles lblF5.MouseLeave
        'Reset BG-Color
        With Me.lblF5
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF6_MouseHover(sender As Object, e As EventArgs) Handles lblF6.MouseHover
        'Set BG-Color
        With Me.lblF6
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF6_MouseLeave(sender As Object, e As EventArgs) Handles lblF6.MouseLeave
        'Reset BG-Color
        With Me.lblF6
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF7_MouseHover(sender As Object, e As EventArgs) Handles lblF7.MouseHover
        'Set BG-Color
        With Me.lblF7
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF7_MouseLeave(sender As Object, e As EventArgs) Handles lblF7.MouseLeave
        'Reset BG-Color
        With Me.lblF7
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF8_MouseHover(sender As Object, e As EventArgs) Handles lblF8.MouseHover
        'Set BG-Color
        With Me.lblF8
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF8_MouseLeave(sender As Object, e As EventArgs) Handles lblF8.MouseLeave
        'Reset BG-Color
        With Me.lblF8
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF9_MouseHover(sender As Object, e As EventArgs) Handles lblF9.MouseHover
        'Set BG-Color
        With Me.lblF9
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF9_MouseLeave(sender As Object, e As EventArgs) Handles lblF9.MouseLeave
        'Reset BG-Color
        With Me.lblF9
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF10_MouseHover(sender As Object, e As EventArgs) Handles lblF10.MouseHover
        'Set BG-Color
        With Me.lblF10
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF10_MouseLeave(sender As Object, e As EventArgs) Handles lblF10.MouseLeave
        'Reset BG-Color
        With Me.lblF10
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF11_MouseHover(sender As Object, e As EventArgs) Handles lblF11.MouseHover
        'Set BG-Color
        With Me.lblF11
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF11_MouseLeave(sender As Object, e As EventArgs) Handles lblF11.MouseLeave
        'Reset BG-Color
        With Me.lblF11
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF12_MouseHover(sender As Object, e As EventArgs) Handles lblF12.MouseHover
        'Set BG-Color
        With Me.lblF12
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF12_MouseLeave(sender As Object, e As EventArgs) Handles lblF12.MouseLeave
        'Reset BG-Color
        With Me.lblF12
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF13_MouseHover(sender As Object, e As EventArgs) Handles lblF13.MouseHover
        'Set BG-Color
        With Me.lblF13
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF13_MouseLeave(sender As Object, e As EventArgs) Handles lblF13.MouseLeave
        'Reset BG-Color
        With Me.lblF13
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF14_MouseHover(sender As Object, e As EventArgs) Handles lblF14.MouseHover
        'Set BG-Color
        With Me.lblF14
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF14_MouseLeave(sender As Object, e As EventArgs) Handles lblF14.MouseLeave
        'Reset BG-Color
        With Me.lblF14
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF15_MouseHover(sender As Object, e As EventArgs) Handles lblF15.MouseHover
        'Set BG-Color
        With Me.lblF15
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF15_MouseLeave(sender As Object, e As EventArgs) Handles lblF15.MouseLeave
        'Reset BG-Color
        With Me.lblF15
            .BackColor = Me.BackColor
        End With
    End Sub

    Private Sub lblF16_MouseHover(sender As Object, e As EventArgs) Handles lblF16.MouseHover
        'Set BG-Color
        With Me.lblF16
            .BackColor = Color.LightBlue
        End With
    End Sub

    Private Sub lblF16_MouseLeave(sender As Object, e As EventArgs) Handles lblF16.MouseLeave
        'Reset BG-Color
        With Me.lblF16
            .BackColor = Me.BackColor
        End With
    End Sub
End Class