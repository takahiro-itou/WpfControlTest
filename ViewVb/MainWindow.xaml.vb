
Public Class MainWindow

Private Sub RunSample(ByVal message As String)
''--------------------------------------------------------------------
''    サンプルコード
''--------------------------------------------------------------------
Dim outText As String

    outText = $"入力した文字列は {message} です"
    SampleControl1.OutputText = outText
    MsgBox(outText, MsgBoxStyle.OkOnly)
End Sub

Private Sub SampleControl1_RunButtonClick(
        ByVal sender As Object, ByVal e As EventArgs) _
    Handles SampleControl1.RunButtonClick
''--------------------------------------------------------------------
''    イベントハンドラ
''
''    ユーザーコントロールの「実行ボタンクリック」
''--------------------------------------------------------------------
    RunSample(SampleControl1.InputText)
End Sub

End Class
