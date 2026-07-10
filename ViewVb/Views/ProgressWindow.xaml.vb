
Namespace Global.ViewVb.Views

Public Class ProgressWindow

Private m_model As TimeConsumingModel
Private m_viewModel As WpfControl.Utils.ProgressViewModel


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    Me.m_model = New TimeConsumingModel()
    Me.m_viewModel = New WpfControl.Utils.ProgressViewModel(m_model)

    Me.DataContext = Me.m_viewModel
    Progress1.ViewModel = Me.m_viewModel
End Sub

End Class

End Namespace
