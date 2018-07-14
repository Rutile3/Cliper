<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClipBoardList = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ClipBoardList
        '
        Me.ClipBoardList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClipBoardList.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ClipBoardList.FormattingEnabled = True
        Me.ClipBoardList.ItemHeight = 16
        Me.ClipBoardList.Location = New System.Drawing.Point(0, 0)
        Me.ClipBoardList.Name = "ClipBoardList"
        Me.ClipBoardList.Size = New System.Drawing.Size(199, 286)
        Me.ClipBoardList.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 286)
        Me.Controls.Add(Me.ClipBoardList)
        Me.MinimumSize = New System.Drawing.Size(215, 39)
        Me.Name = "Form1"
        Me.Text = "Cliper"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClipBoardList As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
