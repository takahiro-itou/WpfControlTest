
Namespace Global.ViewVb.Views

Public Class MainWindow

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
End Sub


Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    System.Windows.Application.Current.Shutdown()
End Sub

Private Sub mnuLaunchSample_Click(ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    メニュー「起動」－「サンプル」
''--------------------------------------------------------------------
    Dim frmSample As New SampleWindow()
    frmSample.Show()
End Sub


End Class

End Namespace
