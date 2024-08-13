

namespace ExamenLeonardoVelasquez
{
    public class Asignatura : Alumno, IAsignatura
    {

        public Asignatura()
        {

        }

        public Asignatura(int N1, int N2, int N3, string NombreAsignatura, string Horario, string NombreDocente, string NombreAlumno, string NumeroCuenta, string Email)
        {
            this.N1 = N1;
            this.N2 = N2;
            this.N3 = N3;
            this.NombreAsignatura = NombreAsignatura;
            this.Horario = Horario;
            this.NombreDocente = NombreDocente;
            this.NombreAlumno = NombreAlumno;
            this.NumeroCuenta = NumeroCuenta;
            this.Email = Email;
        }

        public int N1;
        public int N2;
        public int N3;

        public string NombreAsignatura {  get; set; }

        public string Horario {  get; set; }

        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            double nota= (N1+ N2 + N3);
            
            return nota;
        }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3)
        {
            double nota= (N1 + N2 + N3);

            return nota;
        }


        public string MensajeNotalFinal()
        {
            string mensaje="";
            if (CalcularNotaFinal() <= 59 && CalcularNotaFinal(N1,N2,N3) <=59)
            {
                mensaje = $"Reprobado {CalcularNotaFinal()}% \n {CalcularNotaFinal(N1,N2,N3)}%";
                return mensaje;
            } if ((CalcularNotaFinal() >= 60 && CalcularNotaFinal() <= 79) && (CalcularNotaFinal(N1, N2, N3) >= 60 && CalcularNotaFinal(N1, N2, N3) <=79))
            {
                 mensaje = $"Bueno {CalcularNotaFinal()}% \n {CalcularNotaFinal(N1,N2,N3)}%";
                return mensaje;
            } if ((CalcularNotaFinal() >= 80 && CalcularNotaFinal() <= 89) && (CalcularNotaFinal(N1, N2, N3) >= 80 && CalcularNotaFinal(N1, N2, N3) <= 89))
            {
                mensaje = $"Muy bueno {CalcularNotaFinal()}% \n {CalcularNotaFinal(N1, N2, N3)}%";
                return mensaje;
            } if ((CalcularNotaFinal() >= 90 && CalcularNotaFinal() <= 100) && (CalcularNotaFinal(N1, N2, N3) >= 90 && CalcularNotaFinal(N1, N2, N3) <= 100))
            {
                 mensaje = $"Sobresaliente {CalcularNotaFinal()}% \n Sobresaliente {CalcularNotaFinal(N1, N2, N3)}%";
                return mensaje; 
            }
            return mensaje; 


        }
        public void Imprimir()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Nombre del estudiante:  {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta:  {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico:  {Email}");
            Console.WriteLine($"Nombre de la clase:  {NombreAsignatura}");
            Console.WriteLine($"Horario:  {Horario}");
            Console.WriteLine($"Nombre del docente:  {NombreDocente}");
            Console.WriteLine($"Notal final :  {MensajeNotalFinal()}");
        }

    }
}
