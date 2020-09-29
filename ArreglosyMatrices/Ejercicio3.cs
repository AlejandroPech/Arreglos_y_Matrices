using ArreglosyMatrices.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosyMatrices
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        RichTextBox richTextBox = new RichTextBox();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            // Show
            ShowWindow(handle, SW_SHOW);                
            Console.Clear();
            ObtenerResultados();
        }

        private void ObtenerResultados()
        {
            MatrizOperariones matrizOperariones = new MatrizOperariones();
            double summ1;
            double summ2;
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Escribe el numero del indice [{i} , {j}] de la matriz 1");
                    try
                    {
                        summ1 = Convert.ToDouble(Console.ReadLine());
                        matrizOperariones.Matriz1[i, j] = summ1;
                    }
                    catch
                    {
                        Console.WriteLine("Solo se aceptan numeros o el numero es invalido");
                        j--;
                    }                   
                }             

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {                   
                    Console.WriteLine($"Escribe el numero del indice [{i} , {j}] de la matriz 2");
                    try
                    {
                        summ2 = Convert.ToDouble(Console.ReadLine());

                        matrizOperariones.Matriz2[i, j] = summ2;
                    }
                    catch
                    {
                        Console.WriteLine("Solo se aceptan numeros o el numero es invalido");
                        j--;
                    }

                }

            }
            Console.WriteLine("La suma de las matrices es");
            Console.WriteLine(matrizOperariones.GetSuma());
            Console.WriteLine("La resta de las matrices es");
            Console.WriteLine(matrizOperariones.GetResta());
            Console.WriteLine("La multiplicación de la matriz es");
            Console.WriteLine(matrizOperariones.GetMultiplicacion());
            Console.WriteLine("La divición de la matriz es");
            Console.WriteLine(matrizOperariones.GetDivicion());
        }
        

    }
}
