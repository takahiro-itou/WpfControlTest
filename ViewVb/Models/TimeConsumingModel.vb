
Imports WpfControl.Utils

Public Class TimeConsumingModel
        Inherits WpfControl.Utils.AbstractProgressModel

Public Sub New(ByVal progress As IProgress(Of Integer))
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    MyBase.New(progress)
End Sub

End Class
