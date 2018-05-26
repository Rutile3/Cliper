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
        Me.Close()
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

        If Text <> LastSetText AndAlso Text <> Nothing Then
            If ClipBoardList.Items.IndexOf(Text) <> -1 Then '重複の除外
                ClipBoardList.Items.Remove(Text)
            End If
            '履歴がListBoxの描画範囲外に出るなら最初のデータを消す
            If ClipBoardList.Items.Count >= (ClipBoardList.Size.Height - 4) / 16 Then
                ClipBoardList.Items.RemoveAt(0)
            End If

            ClipBoardList.Items.Add(Text)
            LastSetText = Text
        End If
    End Sub

    Private Sub Copy(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, ClipBoardList.SelectedIndexChanged
        Dim Text As String = ClipBoardList.SelectedItem

        Try
            Clipboard.SetText(Text)
            LastSetText = Text
        Catch ex As System.ArgumentNullException
            Clipboard.SetText(" ")
            LastSetText = " "
        End Try
    End Sub

    Private Sub ClipBoardList_SizeChanged(sender As Object, e As EventArgs) Handles ClipBoardList.SizeChanged
        If ClipBoardList.Items.Count > (ClipBoardList.Size.Height - 4) / 16 Then
            If ClipBoardList.Items.Count > 1 Then
                If ClipBoardList.SelectedIndex = ClipBoardList.Items.Count - 1 Then
                    ClipBoardList.SelectedIndex = ClipBoardList.Items.Count - 2
                End If
                ClipBoardList.Items.RemoveAt(ClipBoardList.Items.Count - 1)
            End If
        End If
    End Sub
End Class
