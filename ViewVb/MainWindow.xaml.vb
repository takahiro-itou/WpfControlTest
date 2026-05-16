
Public Class MainWindow

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    InitializeComponent()
    SampleControl1.ViewModel = New MySampleViewModel()
End Sub

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
        ByVal sender As Object, ByVal e As EventArgs)
''--------------------------------------------------------------------
''    イベントハンドラ
''
''    ユーザーコントロールの「実行ボタンクリック」
''--------------------------------------------------------------------
    RunSample(SampleControl1.InputText)
End Sub

End Class
