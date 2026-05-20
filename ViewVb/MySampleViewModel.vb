
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample


Public Class MySampleViewModel
        Inherits WpfControl.Sample.AbstractSampleViewModel

Private m_inputText As String
Private m_outputText As String

Private ReadOnly m_clearButtonCommand As SimpleCommand
Private ReadOnly m_runButtonCommand As SimpleCommand


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
Public ReadOnly Property ClearButtonCommand As ICommand
    Get
        Return  Me.m_clearButtonCommand
    End Get
End Property


''--------------------------------------------------------------------
''    InputText プロパティ
''
Public Property InputText As String
    Get
        Return  Me.m_inputText
    End Get
    Set(ByVal value As String)
        Me.m_inputText = value
        Me.m_runButtonCommand.RaiseCanExecuteChanged()
        OnPropertyChanged(NameOf(InputText))
    End Set
End Property


''--------------------------------------------------------------------
''    OutputText  プロパティ
''
Public Property OutputText As String
    Get
        Return  Me.m_outputText
    End Get
    Private Set(ByVal value As String)
        Me.m_outputText = value
        OnPropertyChanged(NameOf(OutputText))
    End Set
End Property


''--------------------------------------------------------------------
''    RunButtonCommand  プロパティ
''
Public ReadOnly Property RunButtonCommand As ICommand
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
    Me.InputText  = ""
    Me.OutputText = ""
End Sub

Private Sub ExecuteRunButtonCommand()
''--------------------------------------------------------------------
''    「実行」ボタンをクリックした時の処理
''--------------------------------------------------------------------
Dim outText As String

    outText = $"Input is {Me.m_inputText} !"
    Me.OutputText = outText

    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub

End Class
