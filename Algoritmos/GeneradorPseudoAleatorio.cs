using GeneradorPseudoAleatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeneradorPseudoAleatorio.Algoritmos
{
    public class GeneradorCongruencialMultiplicativo
    {
        private int a;  // Multiplicador
        private int m;  // Modulo
        private int Xn; // Semilla o valor inicial

        // Constructor para inicializar los parámetros del generador
        public GeneradorCongruencialMultiplicativo(int a, int m, int semilla)
        {
            this.a = a;
            this.m = m;
            this.Xn = semilla;
        }

        // Método para generar la siguiente fila de la tabla
        public FilaTabla GenerarSiguiente(int n)
        {
            int axn = a * Xn;  // Calculamos a*X(n)
            int modulo = axn % m;  // Calculamos (a*X(n)) % m
            FilaTabla fila = new FilaTabla(n, Xn, axn, modulo);
            Xn = modulo;  // El siguiente valor de X(n) es el resultado del modulo
            return fila;
        }

        // Método para obtener la secuencia completa de números pseudoaleatorios
        public List<FilaTabla> ObtenerSecuencia(int cantidad)
        {
            List<FilaTabla> secuencia = new List<FilaTabla>();

            // Generar la secuencia de números
            for (int n = 0; n < cantidad; n++)
            {
                FilaTabla fila = GenerarSiguiente(n);
                secuencia.Add(fila);
            }

            return secuencia;
        }
    }
}
