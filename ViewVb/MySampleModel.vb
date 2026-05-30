
Imports WpfControl.Sample

Public Class MySampleModel
        Inherits WpfControl.Sample.AbstractSampleModel

Public Override Sub executeCommand()
''--------------------------------------------------------------------
''    適当な動作を実行する
''--------------------------------------------------------------------
Dim outText As String

    outText = $"Input is {Me.InputText} !"
    Me.setOutputText(outText)

    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub

End Class
