
Imports WpfControl.Editor

Imports System.Windows.Media


Namespace Global.ViewVb

Public Class MatrixDataModel

Private m_data(120000) As MatrixCellData
Private m_colWidths  As New List(Of Double) From { 70, 120, 80, 200 }
Private m_rowHeights As New List(Of Double) From { 30, 50, 40, 60 }

Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
Dim i As Integer
Dim brushBg1 As Brush
Dim brushBg2 As Brush

    brushBg1 = Brushes.Red
    brushBg2 = Brushes.LightGreen

    For i = 0 To 120000
        With m_data(i)
            If (i Mod 5) = 0 Then
                .Background = brushBg1
            End If
            .Value = $"{i}, {i * 2}"
        End With
    Next i

    For i = 0 To 12 - 1
        With m_data(i)
            If (i Mod 2) = 0 Then
                .Background = brushBg2
            End If
            .Value = $"{i}, {i * i}"
        End With
    Next i

End Sub


Public ReadOnly Property CustomHeights As List(Of Double)
    Get
        Return  Me.m_rowHeights
    End Get
End Property

Public ReadOnly Property CustomWidths As List(Of Double)
    Get
        Return  Me.m_colWidths
    End Get
End Property

Public ReadOnly Property MatrixData As MatrixCellData()
    Get
        Return  Me.m_data
    End Get
End Property

Public ReadOnly Property TotalColumns As Integer
    Get
        Return  400
    End Get
End Property

Public ReadOnly Property TotalRows As Integer
    Get
        Return  10
    End Get
End Property


End Class

End Namespace
