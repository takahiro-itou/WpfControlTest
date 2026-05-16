
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

    Me.m_clearButtonCommand = New SimpleCommand(
        Sub(ByVal parameter As Object)
            ExecuteClearButtonCommand()
        End Sub
    )
    Me.m_runButtonCommand = New SimpleCommand(
        Sub(ByVal parameter As Object)
            ExecuteRunButtonCommand()
        End Sub,
        Function(ByVal parameter As Object) As Boolean
            Return  Me.m_inputText <> ""
        End Function
    )

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
        Me.m_runButtonCommand.RaiseCanExecuteChanged()
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


Private Sub ExecuteClearButtonCommand()
''--------------------------------------------------------------------
''    「クリア」ボタンをクリックした時の処理
''--------------------------------------------------------------------
    Me.m_inputText = ""
    Me.m_outputText = ""
End Sub

Private Sub ExecuteRunButtonCommand()
''--------------------------------------------------------------------
''    「実行」ボタンをクリックした時の処理
''--------------------------------------------------------------------
Dim outText As String

    outText = $"Input is {Me.m_inputText} !"
    Me.m_outputText = outText
    OnPropertyChanged(NameOf(OutputText))

    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub

End Class
