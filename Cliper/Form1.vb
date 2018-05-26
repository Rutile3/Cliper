Public Class Form1
    Dim LastSetText As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Text As String = Clipboard.GetText()

        If Text = Nothing Then
            Text = "InitListBox"
            Clipboard.SetText("InitListBox")
        End If

        ClipBoardList.Items.Add(Text)
        LastSetText = Text
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim Text As String = ClipBoardList.SelectedItem

        Clipboard.SetText(Text)
        LastSetText = Text
    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click

    End Sub

    Private Sub ClipBoardList_MouseMove(sender As Object, e As MouseEventArgs) Handles ClipBoardList.MouseMove
        Dim Index As Integer = (e.Y - 7) / 16 '本当にクライアントか？

        If ClipBoardList.Items.Count <= Index Then
            Index = ClipBoardList.Items.Count - 1
        End If
        ClipBoardList.SelectedIndex = Index
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Text As String = Clipboard.GetText()

        If LastSetText <> Text Then
            If ClipBoardList.Items.IndexOf(Text) <> -1 Then '重複の除外
                ClipBoardList.Items.Remove(Text)
            End If

            ClipBoardList.Items.Add(Text)
            LastSetText = Text
        End If
    End Sub
End Class
