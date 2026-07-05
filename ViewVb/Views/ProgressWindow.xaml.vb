
Namespace Global.ViewVb.Views

Public Class ProgressWindow

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    Progress1.ViewModel = New WpfControl.Utils.ProgressViewModel()
End Sub

End Class

End Namespace
