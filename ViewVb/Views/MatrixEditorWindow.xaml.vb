
Namespace Global.ViewVb.Views

Public Class MatrixEditorWindow

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
End Sub


Private Sub mnuColExpand_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles mnuColExpand.Click
''--------------------------------------------------------------------
''    メニュー「列」－「拡大」
''--------------------------------------------------------------------
    Me.DataContext.DefaultCellWidth += 8.0
End Sub


Private Sub mnuColShrink_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles mnuColShrink.Click
''--------------------------------------------------------------------
''    メニュー「列」－「縮小」
''--------------------------------------------------------------------
    With Me.DataContext
        .DefaultCellWidth -= 8.0
        If ( .DefaultCellWidth <= 8.0 )  Then
            .DefaultCellWidth = 8.0
        End If
    End With
End Sub


Private Sub mnuRowExpand_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles mnuRowExpand.Click
''--------------------------------------------------------------------
''    メニュー「行」－「拡大」
''--------------------------------------------------------------------
    Me.DataContext.DefaultCellHeight += 4.0
End Sub


Private Sub mnuRowShrink_Click(ByVal sender As Object, ByVal e As EventArgs) _
    Handles mnuRowShrink.Click
''--------------------------------------------------------------------
''    メニュー「行」－「縮小」
''--------------------------------------------------------------------
    With Me.DataContext
        .DefaultCellHeight -= 4.0
        If ( .DefaultCellHeight <= 4.0 )  Then
            .DefaultCellHeight = 4.0
        End If
    End With
End Sub


End Class

End Namespace
