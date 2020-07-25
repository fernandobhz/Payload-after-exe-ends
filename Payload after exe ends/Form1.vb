Imports System.Text.RegularExpressions

Public Class Form1

    Function EXEPayload() As String
        Dim Contents = My.Computer.FileSystem.ReadAllText(Application.ExecutablePath)

        If Contents.EndsWith("}") Then
            Dim Reverse As String = String.Join("", Contents.Reverse)
            Dim Point = Reverse.IndexOf("{")

            If Point < 0 Then
                Return Nothing
            Else
                Point = Contents.Length - Point - 1

                Dim Value = Contents.Substring(Point)
                Return Value
            End If
        Else
            Return Nothing
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(EXEPayload)
        Application.Exit()
    End Sub
End Class
