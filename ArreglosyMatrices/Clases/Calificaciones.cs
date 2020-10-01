using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    class Calificaciones
    {
		double[,] matriz = new double[,]
		{
			 { 5.5,8.6,10 }, { 8.0, 5.5,10 }, { 9,4.1, 7.8 },
			 { 10,2.2, 8.1 }, { 7.0, 9.2 ,7.1 }, { 9.0,4.0 ,6.0 },
			 { 6.5, 5,5 }, { 4.0 ,7.0, 4.0 }, { 8,8,9},
			 { 10, 9,9.2 }, { 5,10, 8.4 }, { 9,4.6, 7.5 }
		};

		public string MayorMenor()
        {
			double num = 0;
			double numo = 99;
			for(int i=0; i < matriz.Length; i++)
            {
				for(int j=0; j < 2; j++)
                {
					if (num < matriz[i, j])
					{
						num = matriz[i, j];
					}
                    else if(numo > matriz[i, j])
                    {
						numo = matriz[i, j];
					}
				}
                
            }
			return num,numo;
        }

		public void Promedio()
        {
			double sum = 0;
			double prom = 0;
			double mi = 0;
			double ma = 0;
			for(int i = 0; i < matriz.Length; i++)
            {
				for(int j = 0; j < 2; j++)
                {
					sum = matriz[i, j] + sum;

				}
				prom = sum / 3;
                if (prom < mi)
                {
					mi = prom;
                }
				else if (prom > ma)
                {
					ma = prom;
                }
            }
        }
	};


}
