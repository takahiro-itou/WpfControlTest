
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Windows.Input

Imports WpfControl.Sample

Public Class SimpleCommand
        Implements ICommand

Private ReadOnly m_execute As Action(Of Object)
Private ReadOnly m_canExecute As Predicate(Of Object)

Public Sub New(
        execute As Action(Of OBject)
        Optional canExecute As Predicate(Of Object) = Nothing)
    Me.m_execute = execute
    Me.m_canExecute = canExecute
End Sub

End Class


Public Class MySampleViewModel
        Implements INotifyPropertyChanged
        Implements ISampleViewModel

End Class
