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
using ArreglosyMatrices.Clases;

namespace ArreglosyMatrices
{
    public partial class Ejercicio5 : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        public Ejercicio5()
        {
            InitializeComponent();
        }
        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        MatrizAleatoria matrizAleatoria = new MatrizAleatoria();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = matrizAleatoria.CrearMatriz();
            richTextBox2.Text = matrizAleatoria.SumarMatrizCol();
            richTextBox3.Text = matrizAleatoria.SumarMatrizFila();
        }
    }
}
