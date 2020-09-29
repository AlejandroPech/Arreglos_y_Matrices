using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    class CerosporColumna
    {
        int filas;
        int columnas;
        int[,] matriz;
        public CerosporColumna(int filas,int columnas)
        {
            matriz = new int[filas, columnas];
        }
        public int Filas { get => filas; set => filas = value; }
        public int Columnas { get => columnas; set => columnas = value; }
        public int[,] Matriz { get => matriz; set => matriz = value; }

        public string GetCerosbyColumn()
        {
            StringBuilder sb = new StringBuilder();
            int[] ceros = new int[filas];
            for (int i = 0; i < filas; i++)
            {
                int n = 0;
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        n++;
                    }
                    ceros[i] = n;
                }
                sb.AppendLine("");
                sb.AppendLine($"La cantidad de 0 en la columna {i} =" + ceros[i]);
            }
            return sb.ToString();
        }
    }
}
