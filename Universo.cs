using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGravitacional
{
    public abstract class Universo
    {
        public abstract void CalculoForçaGravitacional(Planeta planeta1, Planeta planeta2);
        public abstract void CalculoInteracoesGravitacionais();
        public abstract double CalculoDistanciaEntreCorpos(Planeta planeta1, Planeta planeta2);
    }
}
