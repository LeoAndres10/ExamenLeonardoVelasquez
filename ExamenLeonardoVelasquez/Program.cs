using ExamenLeonardoVelasquez;

Asignatura asignatura= new Asignatura();

try
{
    Console.WriteLine("Ingrese nombre del alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();
    Console.WriteLine("Ingrese numero de cuenta: ");
    asignatura.NumeroCuenta = Console.ReadLine();
    Console.WriteLine("Ingrese correo electronico: ");
    asignatura.Email = Console.ReadLine();
    Console.WriteLine("Ingrese nombre de la clase:   ");
    asignatura.NombreAsignatura = Console.ReadLine();
    Console.WriteLine("Ingrese horario de la clase: ");
    asignatura.Horario = Console.ReadLine();
    Console.WriteLine("Ingrese nombre del docente: ");
    asignatura.NombreDocente = Console.ReadLine();


    Console.WriteLine("Ingrese nota primer parcial: ");
    bool nota1 = int.TryParse(Console.ReadLine(), out asignatura.N1);
    Console.WriteLine("Ingrese nota segundo parcial: ");
    bool nota2 = int.TryParse(Console.ReadLine(), out asignatura.N2);
    Console.WriteLine("Ingrese nota tercer parcial: ");
    bool nota3 = int.TryParse(Console.ReadLine(), out asignatura.N3);

    if (nota1 && nota2 && nota3)
    {
        if (asignatura.N1 <= 30 && asignatura.N2 <= 30)
        {
            if (asignatura.N3 <= 40)
            {
                asignatura.Imprimir();
            }
            else
            {
                Console.WriteLine("La nota del terce parcial no puede pasar del 40%");
                
            }
        }
        else
        {
            Console.WriteLine("La nota del primer o segundo parcial no pueden pasar de 30%");
            Console.WriteLine();
            
        }

    }
    else
    {
        Console.WriteLine("Uno de los valores tiene el formato incorrecto");
    }


} catch (FormatException e)
{
    Console.WriteLine(e.ToString());
}catch(OverflowException e)
{
    Console.WriteLine(e.ToString() );
}catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
