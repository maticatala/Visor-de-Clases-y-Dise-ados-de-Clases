using System;

namespace Geometria
{
    public class Circulo
    {
        private int m_radio;

        public int Radio {
            get {
                return m_radio;
            }
            set {
                m_radio = value;
            }
        }

        public void CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public void CalcularSuperfie()
        {
            throw new System.NotImplementedException();
        }
    }
}
