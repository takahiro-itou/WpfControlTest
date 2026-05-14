
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample

Public Class SimpleCommand
        Implements ICommand

Private ReadOnly m_execute As Action(Of Object)
Private ReadOnly m_canExecute As Predicate(Of Object)

Public Sub New(
        execute As Action(Of OBject),
        Optional canExecute As Predicate(Of Object) = Nothing)
    Me.m_execute = execute
    Me.m_canExecute = canExecute
End Sub

Public Function CanExecute(parameter As Object) As Boolean  _
        Implements ICommand.CanExecute
    Return If(m_canexecute Is Nothing, True, Me.m_canExecute(parameter))
End Function

Public Sub Execute(parameter As Object) Implements ICommand.Execute
    Me.m_execute(parameter)
End Sub

Public Event CanExecuteChanged As EventHandler _
        Implements ICommand.CanExecuteChanged

Public Sub RaiseCanExecuteChanged()
    RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
End Sub

End Class


Public Class MySampleViewModel
        Implements INotifyPropertyChanged
        Implements ISampleViewModel

Private m_inputText As String
Private m_outputText As String

Private ReadOnly m_clearButtonCommand As SimpleCommand
Private ReadOnly m_runButtonCommand As SimpleCommand

Public Sub New()

End Sub

Public ReadOnly Property ClearButtonCommand As ICommand  _
        Implements ISampleViewModel.ClearButtonCommand
    Get
        Return  Me.m_clearButtonCommand
    End Get
End Property

Public Property InputText As String  _
        Implements ISampleViewModel.InputText
End Property

Public ReadOnly Property OutputText As String  _
        Implements ISampleViewModel.OutputText
End Property

Public ReadOnly Property RunButtonCommand As ICommand  _
        Implements ISampleViewModel.RunButtonCommand
End Property

End Class
