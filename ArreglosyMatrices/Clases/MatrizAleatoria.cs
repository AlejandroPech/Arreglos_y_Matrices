using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    public class MatrizAleatoria
    {
        Random numeros = new Random();
        int[,] matriz = new int[5, 10];
        int[,] columnas = new int[2, 10];
        int[,] filas = new int[5, 2];

        public MatrizAleatoria()
        {
        }


        //public string Suma()
        //{

        //}

        public string CrearMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = numeros.Next(0, 10);
                }
            }
            var sb = new StringBuilder();
            double[] tmpFila = new double[10];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString();

        }

        public string SumarMatrizCol()
        {
            var sb = new StringBuilder();
            double[] tmpFila = new double[10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tmpFila[j] = filas[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString();
        }

        public string SumarMatrizFila()
        {
            var sb = new StringBuilder();
            double[] tmpFila = new double[2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tmpFila[j] = filas[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString();
        }
    }
}
