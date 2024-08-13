
namespace ExamenLeonardoVelasquez
{
    public interface IAsignatura 
    {
        public double CalcularNotaFinal();

        public double CalcularNotaFinal( double nota1, double nota2, double nota3);

        public string MensajeNotalFinal();

        public void Imprimir();


    }
}
