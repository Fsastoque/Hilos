Imports System.Threading
Module Module1

    Sub Main()
        '**Con Arrays

        Dim listTareas As New ArrayList
        listTareas.Add("Hilo1")
        listTareas.Add("Hilo2")
        listTareas.Add("Hilo3")
        Dim listSecond As New ArrayList
        listSecond.Add(8)
        listSecond.Add(16)
        listSecond.Add(24)
        For i = 0 To listSecond.Count - 1
            Dim tareas As String = Convert.ToString(listTareas(i))
            Dim second As Integer = Convert.ToString(listSecond(i))
            Dim obj1 As New Tareas(tareas, second)
            Dim hilo1 As New Thread(AddressOf obj1.Tarea1)
            hilo1.Start()
        Next

        '****con variables

        'Dim obj1 As New Tareas("hilo1", 8)
        'Dim obj2 As New Tareas("hilo2", 16)
        ''AddressOf asigna la funcion a ejecutar
        'Dim hilo1 As New Thread(AddressOf obj1.Tarea1)
        'Dim hilo2 As New Thread(AddressOf obj2.Tarea2)
        'hilo1.Start()
        'hilo2.Start()
        'Console.ReadKey()
    End Sub

End Module
