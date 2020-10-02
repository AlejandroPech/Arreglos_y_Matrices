using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosyMatrices.Clases
{
    public class VentasDelAnio
    {
        int[,] ventas = new int[12, 5]
        {
            {5,16,10,12,24},
            { 40,55,10,11,18},
            {15,41,78,14,51 },
            {35,22,71,10,20 },
            {50,12,71,10,20 },
            {70,40,60,28,22 },
            {50,50,50,36,25 },
            { 40,70,40,11,20},
            {20,20,30,12,18},
            { 10,40,32,13,16},
            {50,3,24,15,82 },
            {40,46,15,46,22 }
        };

        public VentasDelAnio()
        {

        }
        //public int[,] Ventas { get => ventas; set => ventas = value; }

        public string VentaTotal()
        {
            int num = 0;
            string ventatotal = "";
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    num = num + ventas[i, j];
                }
            }
            ventatotal = $"La venta total es: {num}";
            return ventatotal;
        }
        public int[,] DevolverVentas()
        {
            return ventas;
        }

        public string VentaMayor()
        {
            int num = 0;
            int[,] array = new int[1, 2];
            string ventaMayor = "";
            string mes = "";
            string dia = "";
            for(int i=0;i<12; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(num<ventas[i, j])
                    {
                        num = ventas[i, j];
                        array[0, 0] = j;
                        array[0, 1] = i;
                    }
                }
            }
            switch (array[0, 1])
            {
                case 0:
                    mes = "Enero";
                    break;
                case 1:
                    mes = "Febrero";
                    break;
                case 2:
                    mes = "Marzo";
                    break;
                case 3:
                    mes = "Abril";
                    break;
                case 4:
                    mes = "Mayo";
                    break;
                case 5:
                    mes = "Junio";
                    break;
                case 6:
                    mes = "Julio";
                    break;
                case 7:
                    mes = "Agosto";
                    break;
                case 8:
                    mes = "Septiembre";
                    break;
                case 9:
                    mes = "Octubre";
                    break;
                case 10:
                    mes = "Noviembre";
                    break;
                case 11:
                    mes = "Diciembre";
                    break;
            }
            switch (array[0, 0])
            {
                case 0:
                    dia = "Lunes";
                    break;
                case 1:
                    dia = "Martes";
                    break;
                case 2:
                    dia = "Miercoles";
                    break;
                case 3:
                    dia = "Jueves";
                    break;
                case 4:
                    dia = "Viernes";
                    break;                
            }

            ventaMayor = $"La venta Mayor fue {num} en el dia {dia} en el mes de {mes}";
            return ventaMayor;
        }

        public string VentaMenor()
        {
            int num = 1000;
            int[,] array = new int[1, 2];
            string ventaMenor = "";
            string mes = "";
            string dia = "";
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (num > ventas[i, j])
                    {
                        num = ventas[i, j];
                        array[0, 0] = j;
                        array[0, 1] = i;
                    }
                }
            }
            switch (array[0, 1])
            {
                case 0:
                    mes = "Enero";
                    break;
                case 1:
                    mes = "Febrero";
                    break;
                case 2:
                    mes = "Marzo";
                    break;
                case 3:
                    mes = "Abril";
                    break;
                case 4:
                    mes = "Mayo";
                    break;
                case 5:
                    mes = "Junio";
                    break;
                case 6:
                    mes = "Julio";
                    break;
                case 7:
                    mes = "Agosto";
                    break;
                case 8:
                    mes = "Septiembre";
                    break;
                case 9:
                    mes = "Octubre";
                    break;
                case 10:
                    mes = "Noviembre";
                    break;
                case 11:
                    mes = "Diciembre";
                    break;
            }
            switch (array[0, 0])
            {
                case 0:
                    dia = "Lunes";
                    break;
                case 1:
                    dia = "Martes";
                    break;
                case 2:
                    dia = "Miercoles";
                    break;
                case 3:
                    dia = "Jueves";
                    break;
                case 4:
                    dia = "Viernes";
                    break;
            }

            ventaMenor = $"La venta Menor fue {num} en el dia {dia} em el mes de {mes}";




            return ventaMenor;
        }
    }
}
