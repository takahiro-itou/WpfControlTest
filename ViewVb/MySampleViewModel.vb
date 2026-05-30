
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample


Public Class MySampleViewModel
        Inherits WpfControl.Sample.SampleViewModel


Public Sub New(ByVal model As MySampleModel)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    MyBase.New(model)
End Sub


Protected Overrides Sub raiseCanExecuteChanged()
''--------------------------------------------------------------------
''    CanExecuteChanged を発生させる
''--------------------------------------------------------------------

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
