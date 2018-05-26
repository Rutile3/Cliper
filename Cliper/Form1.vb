Public Class Form1
    Dim LastSetText As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Text As String = Clipboard.GetText()

        If Text = Nothing Then
            Text = "InitListBox"
        End If

        ClipBoardList.Items.Add(Text)
        LastSetText = Text
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click

    End Sub

    Private Sub ClipBoardList_MouseMove(sender As Object, e As MouseEventArgs) Handles ClipBoardList.MouseMove

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Text As String = Clipboard.GetText()
        If LastSetText <> Text Then
            ClipBoardList.Items.Add(Text)
            LastSetText = Text
        End If
    End Sub
End Class
