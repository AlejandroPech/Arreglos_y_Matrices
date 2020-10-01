using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    public class MatrizAleatoria
    {
        int[,] matriz = new int[5, 10];
        Random numeros = new Random();

        public MatrizAleatoria()
        {
        }

        public int[,] Matriz { get => matriz; set => matriz = value; }

        public string Suma()
        {

        }
    }
}
