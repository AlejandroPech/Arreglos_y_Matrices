using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    public class CuadroMagico
    {
        
        int[,] dimenciones;
        public CuadroMagico(int n)
        {
            dimenciones = new int[n, n];
        }
        public int[,] Dimenciones { get=>dimenciones; set=>dimenciones=value; }

        public string CrearCuadro()
        {

            var sb = new StringBuilder();
            int[] tmpFila = new int[dimenciones.GetLength(0)];
            for (int i = 0; i < dimenciones.GetLength(0); i++)
            {
                for (int j = 0; j < dimenciones.GetLength(0); j++)
                {
                    tmpFila[j] = dimenciones[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            return sb.ToString() ;
        }


        public int VerificarCuadro()
        {
            int resultado = 0;
            for (int i = 0; i < dimenciones.GetLength(0); i++)
            {
                int fila = 0;
                int columna = 0;
                int diagonal1 = 0;
                int diagonal2 = 0;
                for (int j = 0; j < dimenciones.GetLength(0); j++)
                {
                    fila += Dimenciones[i, j];
                    columna += Dimenciones[j, i];
                    diagonal1 += Dimenciones[j, j];
                    diagonal2 += Dimenciones[(dimenciones.GetLength(0) - j - 1), (dimenciones.GetLength(0) - j - 1)];
                    resultado = fila;
                }
                if (fila != columna || fila != diagonal1 || fila != diagonal2 || columna != diagonal1 || columna != diagonal2 || diagonal1 != diagonal2)
                {
                    resultado = 0;
                    break;
                }
            }

            return resultado;
        }
    }
}
