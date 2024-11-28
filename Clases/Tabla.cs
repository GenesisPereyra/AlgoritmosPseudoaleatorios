using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorPseudoAleatorio.Clases
{
    public class FilaTabla
    {
        public int N { get; set; }  // El índice n
        public int Xn { get; set; } // Valor de X(n)
        public int Axn { get; set; } // Valor de a*X(n)
        public int Modulo { get; set; } // Valor de (a*X(n)) % m

        // Constructor
        public FilaTabla(int n, int xn, int axn, int modulo)
        {
            N = n;
            Xn = xn;
            Axn = axn;
            Modulo = modulo;
        }

        // Método para mostrar los valores de la fila en formato tabulado
        public override string ToString()
        {
            return $"{N}\t{Xn}\t\t{Axn}\t\t{Modulo}";
        }
    }
}
