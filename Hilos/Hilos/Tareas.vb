Imports System.Threading
Public Class Tareas
    Private name As String
    Private second As Integer
    Sub New(name As String, second As Integer)
        Me.name = name
        Me.second = second
    End Sub
    Public Sub Tarea1()
        Console.WriteLine(name & " Esta tarea solo tendra " & second & " second . ")
        'Sleep suspende el subproceso actual durante un tiempo
        Thread.Sleep(second * 1000)
        Console.WriteLine("Tarea terminada: " & name)
    End Sub
    Public Sub Tarea2()
        Console.WriteLine(name & " Esta tarea solo tendra " & second & " second . ")
        'Sleep suspende el subproceso actual durante un tiempo
        Thread.Sleep(second * 1000)
        Console.WriteLine("Tarea terminada: " & name)
    End Sub

End Class
