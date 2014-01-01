Public Class Empleado
    'Declaramos los atributos de la clase empleado
    Private Nombre As String
    Private Salario As Decimal
    Private Horas As DateTime
    'Definimos un constructor para la clase con el fin de inicializar los campos de la clase Empleado
    Public Sub New(ByVal Nombre As String, ByVal Salario As Decimal, ByVal Horas As DateTime)
        'Inicializamos  los atributos 
        Me.Nombre = Nombre
        Me.Salario = Salario
        Me.Horas = Horas
    End Sub
    'Definimos las propiedades de la clase utilizando método Get
    Public Property FullNombre() As String
    'Get devuelve el nombre del empleado
        Get
            Return Me.Nombre
        End Get
        'Set para establecer el nombre del empleado.
        Set(ByVal value As String)
            Me.Nombre = value
        End Set
    End Property
    'Método
    'ReadOnly que especifica que una variable o una propiedad se puede leer, pero no se puede modificar.
    Public ReadOnly Property Remuneracion() As Decimal
        ' Get devuelve el sueldo del empleado
        Get
            Return Me.Salario
        End Get
    End Property
    'Método
    'ReadOnly que especifica que una variable o una propiedad se puede leer, pero no se puede modificar.
    Public ReadOnly Property DiasTrabajados() As Decimal
        ' Get calcula cuántos días ha trabajado el empleado 
        Get
            'TimeSpan representa un intervalo de tiempo.
            'DateTime representa un instante de tiempo, normalmente expresado 
            'como una fecha y hora del día.
            Dim timespan As TimeSpan = DateTime.Now.Subtract(Me.Horas)
            Return timespan.Days
        End Get
    End Property
End Class
