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
    public partial class Ejercicio6 : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        

        VentasDelAnio VentasDelAnio = new VentasDelAnio();
        public Ejercicio6()
        {
            InitializeComponent();
        }
        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        private void Ejercicio6_Load_1(object sender, EventArgs e)
        {

            DiayMes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label13.Text = VentasDelAnio.VentaMayor();
                label14.Text = VentasDelAnio.VentaMenor();
                label15.Text = VentasDelAnio.VentaTotal();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void DiayMes()
        {
            List<object> lista=new List<object>();
            int[,] matriz = VentasDelAnio.DevolverVentas();
            
            for (int j = 0; j < 12; j++)
            {
                var lista1 = new
                {
                    lunes = matriz[j, 0],
                    martes = matriz[j, 1],
                    miercoles = matriz[j, 2],
                    jueves = matriz[j, 3],
                    viernes = matriz[j, 4]
                };
                lista.Add(lista1);
            }
            dataGridView1.DataSource = lista;
        }

    }
}
