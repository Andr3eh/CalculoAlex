

namespace CalculoAlex
{
    class TrianguloIsósceles : FormaGeometrica
    {
        private int _area;

        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        private int _base;
        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private int _AlturaRelativa;

        public int Relativa
        {
            get { return _AlturaRelativa; }
            set { _AlturaRelativa = value; }
        }

        public override double CalcularArea()
        {
            return (_base * _AlturaRelativa) /2;
        }

        public override double CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }
    }

}

