
Imports System.ComponentModel
Imports System.Windows.Input


''========================================================================
''
''    コマンドクラス
''

Public Class SimpleCommand
        Implements ICommand

Private ReadOnly m_execute As Action(Of Object)
Private ReadOnly m_canExecute As Predicate(Of Object)

Public Event CanExecuteChanged As EventHandler _
        Implements ICommand.CanExecuteChanged


Public Sub New(
        execute As Action(Of OBject),
        Optional canExecute As Predicate(Of Object) = Nothing)
''--------------------------------------------------------------------
''    コンストラクタ
''--------------------------------------------------------------------
    Me.m_execute = execute
    Me.m_canExecute = canExecute
End Sub

Public Function CanExecute(parameter As Object) As Boolean  _
        Implements ICommand.CanExecute
''--------------------------------------------------------------------
''    コマンドが実行可能か否かを返す。
''--------------------------------------------------------------------
    Return If(m_canexecute Is Nothing, True, Me.m_canExecute(parameter))
End Function

Public Sub Execute(parameter As Object) Implements ICommand.Execute
''--------------------------------------------------------------------
''    コマンドを実行する。
''--------------------------------------------------------------------
    Me.m_execute(parameter)
End Sub


Public Sub RaiseCanExecuteChanged()
''--------------------------------------------------------------------
''    CanExecuteChanged イベントを発生させる。
''--------------------------------------------------------------------
    RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
End Sub

End Class
