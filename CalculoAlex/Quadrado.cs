
namespace CalculoAlex
{
    class Quadrado : FormaGeometrica
    {
        private double lado;
        public double Lado
        {
            get { return Lado; }
            set { Lado = value; }
        }

        public override double CalcularArea()
        {
            return System.Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 4; ;
        }
    }
}
