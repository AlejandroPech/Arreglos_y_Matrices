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
        int con = 0;
        int sumfil = 0;

        public MatrizAleatoria()
        {
        }



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
            Sumar();
            return sb.ToString();

        }

        public string SumarMatrizCol()
        {
            string a = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a += (" " + columnas[i, j]);
                }
                a = a + "\n";
            }
            return a;

        }

        public string SumarMatrizFila()
        {
            string a = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a += (" " + filas[i, j]);
                }
                a = a + "\n";
            }
            return a;

        }
        public void Reiniciar()
        {

            sumfil = 0;
            con = 0;
        }

        public void Sumar()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sumfil += matriz[i, j];
                    con++;
                }
                if (con == 10)
                {
                    filas[i, 0] = sumfil;
                    filas[i, 1] = sumfil / 10;
                    Reiniciar();
                }
            }
        }
    }
}
