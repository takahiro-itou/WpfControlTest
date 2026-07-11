
Imports MyViewModel = WpfControl.Utils.ProgressViewModel(Of Integer, Integer)

Namespace Global.ViewVb.Views

Public Class ProgressWindow

Private m_model As TimeConsumingModel
Private m_viewModel As MyViewModel


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    Me.m_model = New TimeConsumingModel()
    Me.m_viewModel = New MyViewModel(m_model)

    Me.DataContext = Me.m_viewModel
    Progress1.ViewModel = Me.m_viewModel
End Sub

End Class

End Namespace
