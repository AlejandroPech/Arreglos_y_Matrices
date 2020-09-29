using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    class MatrizOperariones
    {
        double[,] matriz1 = new double[2, 2];
        double[,] matriz2 = new double[2, 2];
        public MatrizOperariones()
        {

        }
        public double[,] Matriz1 { get=>matriz1; set=>matriz1=value; }
        public double[,] Matriz2 { get => matriz2; set => matriz2 = value; }

        public string GetSuma()
        {            
            double[] sumamatriz = new double[4];
            int n=-1;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    n++;
                    sumamatriz[n] = matriz1[i, j] + matriz2[i, j];
                }
                
            }
            sb.AppendLine(string.Join("\t", sumamatriz));
            sb.AppendLine("");
            return sb.ToString();
        }

        public string GetResta()
        {
            StringBuilder sb = new StringBuilder();
            double[] restamatriz = new double[4];
            int n = -1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    n++;
                    restamatriz[n] = matriz1[i, j] - matriz2[i, j];
                    
                }
            }
            sb.AppendLine(string.Join("\t", restamatriz));
            sb.AppendLine("");
            return sb.ToString();
        }

        public string GetMultiplicacion()
        {
            StringBuilder sb = new StringBuilder();
            double[] multimatriz = new double[4];
            int n = -1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    n++;
                    multimatriz[n] = matriz1[i, j] * matriz2[i, j];
                    
                }
            }
            sb.AppendLine(string.Join("\t", multimatriz));
            sb.AppendLine("");
            return sb.ToString();
        }


        public string GetDivicion()
        {
            StringBuilder sb = new StringBuilder();
            double[] divimatriz = new double[4];
            int n = -1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    n++;
                    divimatriz[n] = matriz1[i, j] / matriz2[i, j];
                    
                }
            }
            sb.AppendLine(string.Join("\t", divimatriz));
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}
