Option Explicit On

Module BalloonTip
    Public Sub ShowBalloonTipError(Tip As String, Title As String)
        With My.Forms.frmMain.nfiControlCenter
            Try
                .BalloonTipIcon = ToolTipIcon.Error
                .BalloonTipText = Tip
                .BalloonTipTitle = Title
                .ShowBalloonTip((Len(Tip) * 2))
            Catch ex As Exception
                'Show error message
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error showing BalloonTip")

                'Exit sub
                Exit Sub
            End Try
        End With
    End Sub

    Public Sub ShowBalloonTipInfo(Tip As String, Title As String)
        With My.Forms.frmMain.nfiControlCenter
            Try
                .BalloonTipIcon = ToolTipIcon.Info
                .BalloonTipText = Tip
                .BalloonTipTitle = Title
                .ShowBalloonTip((Len(Tip) * 2))
            Catch ex As Exception
                'Show error message
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error showing BalloonTip")

                'Exit sub
                Exit Sub
            End Try
        End With
    End Sub

    Public Sub ShowBalloonTipNone(Tip As String, Title As String)
        With My.Forms.frmMain.nfiControlCenter
            Try
                .BalloonTipIcon = ToolTipIcon.None
                .BalloonTipText = Tip
                .BalloonTipTitle = Title
                .ShowBalloonTip((Len(Tip) * 2))
            Catch ex As Exception
                'Show error message
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error showing BalloonTip")

                'Exit sub
                Exit Sub
            End Try
        End With
    End Sub

    Public Sub ShowBalloTipWarning(Tip As String, Title As String)
        With My.Forms.frmMain.nfiControlCenter
            Try
                .BalloonTipIcon = ToolTipIcon.Warning
                .BalloonTipText = Tip
                .BalloonTipTitle = Title
                .ShowBalloonTip((Len(Tip) * 2))
            Catch ex As Exception
                'Show error message
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error showing BalloonTip")

                Exit Sub
            End Try
        End With
    End Sub
End Module
