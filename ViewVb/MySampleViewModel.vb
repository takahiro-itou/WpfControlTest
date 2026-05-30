
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample


Public Class MySampleViewModel
        Inherits WpfControl.Sample.SampleViewModel

Private ReadOnly m_runButtonCommand As WpfControl.Common.SimpleCommand


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------

    Me.m_runButtonCommand = New WpfControl.Common.SimpleCommand(
        Sub(ByVal parameter As Object)
            ExecuteRunButtonCommand()
        End Sub,
        Function(ByVal parameter As Object) As Boolean
            Return  Me.InputText <> ""
        End Function
    )

End Sub


''--------------------------------------------------------------------
''    RunButtonCommand  プロパティ
''
Public Overrides ReadOnly Property RunButtonCommand As ICommand
    Get
        Return  Me.m_runButtonCommand
    End Get
End Property


Protected Overrides Sub raiseCanExecuteChanged()
''--------------------------------------------------------------------
''    CanExecuteChanged を発生させる
''--------------------------------------------------------------------
    Me.m_runButtonCommand.RaiseCanExecuteChanged()
End Sub


Private Sub ExecuteRunButtonCommand()
''--------------------------------------------------------------------
''    「実行」ボタンをクリックした時の処理
''--------------------------------------------------------------------
Dim outText As String

    outText = $"Input is {Me.InputText} !"
    Me.OutputText = outText

    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub

End Class
