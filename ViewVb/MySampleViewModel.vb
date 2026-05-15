
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample


Public Class MySampleViewModel
        Implements INotifyPropertyChanged
        Implements ISampleViewModel

Private m_inputText As String
Private m_outputText As String

Private ReadOnly m_clearButtonCommand As SimpleCommand
Private ReadOnly m_runButtonCommand As SimpleCommand

Public Event PropertyChanged As PropertyChangedEventHandler  _
        Implements INotifyPropertyChanged.PropertyChanged


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------

End Sub

''--------------------------------------------------------------------
''    ClearButtonCommand  プロパティ
''
Public ReadOnly Property ClearButtonCommand As ICommand  _
        Implements ISampleViewModel.ClearButtonCommand
    Get
        Return  Me.m_clearButtonCommand
    End Get
End Property


''--------------------------------------------------------------------
''    InputText プロパティ
''
Public Property InputText As String  _
        Implements ISampleViewModel.InputText
    Get
        Return  Me.m_inputText
    End Get
    Set(ByVal value As String)
        Me.m_inputText = value
    End Set
End Property


''--------------------------------------------------------------------
''    OutputText  プロパティ
''
Public ReadOnly Property OutputText As String  _
        Implements ISampleViewModel.OutputText
    Get
        Return  Me.m_outputText
    End Get
End Property


''--------------------------------------------------------------------
''    RunButtonCommand  プロパティ
''
Public ReadOnly Property RunButtonCommand As ICommand  _
        Implements ISampleViewModel.RunButtonCommand
    Get
        Return  Me.m_runButtonCommand
    End Get
End Property


Protected Sub OnPropertyChanged(
        <CallerMemberName> Optional propertyName As String = Nothing)
''--------------------------------------------------------------------
''    PropertyChanged イベントを発生させる
''--------------------------------------------------------------------
    RaiseEvent PropertyChanged(
            Me, New PropertyChangedEventArgs(propertyName)
    )
End Sub

End Class
