
Imports WpfControl.Editor

Imports System.Windows.Media


Namespace Global.ViewVb

Public Class MatrixDataModel
        Inherits WpfHelper.Data.BindableBase

Private m_data(120000) As MatrixCellData
Private m_numCols As Integer = 400
Private m_numRows As Integer = 10

Private m_colWidths  As New List(Of Double) From { 70, 120, 80, 200 }
Private m_rowHeights As New List(Of Double) From { 30, 50, 40, 60 }
Private m_defaultCellHeight As Double = 32.0
Private m_defaultCellWidth  As Double = 72.0


Public Sub New()
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
Dim i As Integer

    For i = 0 To 120000
        With m_data(i)
            If (i Mod 5) = 0 Then
                .BgColor = Colors.Black
                .FgColor = Colors.Red
            End If
            .Value = $"{i}, {i * 2}"
        End With
    Next i

    For i = 0 To 12 - 1
        With m_data(i)
            If (i Mod 2) = 0 Then
                .BgColor = Colors.Red
                .FgColor = Colors.White
            End If
            .Value = $"{i}, {i * i}"
        End With
    Next i

End Sub


Public Property CustomHeights As List(Of Double)
    Get
        Return  Me.m_rowHeights
    End Get
    Set(ByVal value As List(Of Double) )
        SetValue(Me.m_rowHeights, value)
    End Set
End Property

Public Property CustomWidths As List(Of Double)
    Get
        Return  Me.m_colWidths
    End Get
    Set(ByVal value As List(Of Double) )
        SetValue(Me.m_colWidths, value)
    End Set
End Property


Public Property DefaultCellHeight As Double
    Get
        Return  Me.m_defaultCellHeight
    End Get
    Set(ByVal value As Double)
        SetValue(Me.m_defaultCellHeight, value)
    End Set
End Property


Public Property DefaultCellWidth  As Double
    Get
        Return  Me.m_defaultCellWidth
    End Get
    Set(ByVal value As Double)
        SetValue(Me.m_defaultCellWidth, value)
    End Set
End Property


Public ReadOnly Property MatrixData As MatrixCellData()
    Get
        Return  Me.m_data
    End Get
End Property


Public Property TotalColumns As Integer
    Get
        Return  Me.m_numCols
    End Get
    Set(ByVal value As Integer)
        SetValue(Me.m_numCols, value)
    End Set
End Property

Public Property TotalRows As Integer
    Get
        Return  Me.m_numRows
    End Get
    Set(ByVal value As Integer)
        SetValue(Me.m_numRows, value)
    End Set
End Property


End Class

End Namespace
