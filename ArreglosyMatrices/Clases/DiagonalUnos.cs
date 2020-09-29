using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    class DiagonalUnos
    {
        int[,] diagonal;
        public DiagonalUnos(int n)
        {
            diagonal = new int[n, n];
        }
        public int[,] Diagonal { get=>diagonal; set=>diagonal=value; }

        public string GetDiagonal()
        {
            var sb = new StringBuilder();
            int[] sumaFila = new int[diagonal.GetLength(0)];
            for(int i = 0; i < diagonal.GetLength(0); i++)
            {
                for (int j = 0;j< diagonal.GetLength(0); j++)
                {
                    if (i == j)
                        diagonal[i, j] = 1;
                    else
                        diagonal[i, j] = 0;
                    sumaFila[j] = diagonal[i, j];
                }
                sb.AppendLine("");
                sb.AppendLine(string.Join("\t", sumaFila));
            }
            return sb.ToString();
        }
    }
}
