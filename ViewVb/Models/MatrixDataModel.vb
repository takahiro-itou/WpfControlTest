
Namespace Global.ViewVb

Public Class MatrixDataModel

Private m_data(12) As Integer


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
Dim i As Integer

    For i = 0 To 12 - 1
        m_data(i) = i * i
    Next i
End Sub


Public ReadOnly Property MatrixData As Integer()
    Get
        Return  Me.m_data
    End Get
End Property

Public ReadOnly Property TotolColumns As Integer
    Get
        Return  4
    End Get
End Property

Public ReadOnly Property TotalRows As Integer
    Get
        Return  3
    End Get
End Property


End Class

End Namespace
