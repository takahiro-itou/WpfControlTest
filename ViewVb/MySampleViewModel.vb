
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


End Class
