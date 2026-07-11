
Imports WpfControl.Utils

Public Class TimeConsumingModel
        Inherits WpfControl.Utils.AbstractProgressModel(Of Integer, Integer)

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    MyBase.New()
End Sub

Public Overrides Function runTask(
        ByVal progress As IProgress(Of Integer)) As Integer
Dim i As Integer
Dim total As Integer

    total = 0
    For i = 1 To 20
        total = total + i
        System.Threading.Thread.Sleep(100)
        progress.Report(i * 5)
    Next i

    runTask = total
End Function


End Class
