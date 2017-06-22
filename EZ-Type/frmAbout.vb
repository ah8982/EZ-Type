Option Explicit On

Public Class frmAbout

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            'Set default icon
            .Icon = frmMain.Icon

            'Show Title
            .lblTitleOutput.Text = My.Application.Info.Title

            'Show Copyright Infomation
            .lblCopyrightOutput.Text = My.Application.Info.Copyright

            'Show Version
            .lblVersionOutput.Text = My.Application.Info.Version.ToString
        End With
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class