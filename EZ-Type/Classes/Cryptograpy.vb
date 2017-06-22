Option Explicit On

Module Cryptograpy
    Public Function Encrypt(Text As String)
        'Check if encrytion is possible.
        If Text = "" Then
            BalloonTip.ShowBalloonTipInfo("No text to encrypt.", "Encryption not successful")
            Return ""
        End If

        'Definition of variables
        Dim encrypted As String
        Dim i As Integer
        Dim s As Integer

        'Keep application alive
        Application.DoEvents()

        Try
            'Clear variables
            encrypted = ""
            i = 0
            s = 0

            'Start of encryption
            For i = 1 To Len(Text)
                s = Asc(Mid(Text, i, 1))
                s = s + 13

                If s > 255 Then s = s - 255

                encrypted = encrypted + Chr(s)
            Next
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Encrytion not sucessful")
            Return ""
        End Try

        'Return encrypted text
        Return encrypted
    End Function

    Public Function Decrypt(Text As String)
        'Chech if decryption is possible
        If Text = "" Then
            BalloonTip.ShowBalloonTipInfo("No text to decrypt.", "Encryption not successful")
            Return ""
        End If

        'Definition as variables
        Dim decrypted As String
        Dim i As Integer
        Dim s As Integer

        'Keep application alive
        Application.DoEvents()

        Try
            'Clear variables
            decrypted = ""
            i = 0
            s = 0

            'Start of decryption
            For i = 1 To Len(Text)
                s = Asc(Mid(Text, i, 1))
                s = s - 13

                If s < 0 Then s = s + 255

                decrypted = decrypted + Chr(s)
            Next
        Catch ex As Exception
            'Show error message
            BalloonTip.ShowBalloonTipError(ex.ToString, "Encrytion not sucessful")
            Return ""
        End Try

        'Return decrypted text
        Return decrypted
    End Function
End Module