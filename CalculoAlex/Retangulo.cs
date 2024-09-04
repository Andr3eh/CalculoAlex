
namespace CalculoAlex
{
    class Retangulo : FormaGeometrica
    {
        private int _base;

        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }
        private int altura;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override double CalcularArea()
        {
            return _base * altura;
        }

        public override double CalcularPerimetro()
        {
            return ((_base * 2) + (altura * 2));
        }
    }
}
