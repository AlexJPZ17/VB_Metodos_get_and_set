Module Module1

    Sub Main()
        'Crear un objeto y utilizar las propiedades
        Dim p As New Empleado("Joel", 500, New DateTime(2013, 7, 11))
        'método que cambia la propiedad FullNombre
        p.FullNombre = "Alex"
        Console.WriteLine("Nombre del empleado: " & p.FullNombre)
        Console.WriteLine("Remuneracion: " & p.Remuneracion)
        Console.WriteLine("Dias trabajados: " & p.DiasTrabajados)
        Console.ReadLine()
    End Sub

End Module
