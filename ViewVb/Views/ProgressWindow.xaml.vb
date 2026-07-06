
Namespace Global.ViewVb.Views

Public Class ProgressWindow

Private m_model As TimeConsumingModel

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    Me.m_model = New TimeConsumingModel()
    Progress1.ViewModel = New WpfControl.Utils.ProgressViewModel(m_model)
End Sub

End Class

End Namespace
