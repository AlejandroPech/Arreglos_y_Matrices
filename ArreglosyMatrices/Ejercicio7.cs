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

    public partial class Ejercicio7 : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        Calificaciones calificaciones = new Calificaciones();

        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = calificaciones.Crear();
            label5.Text = calificaciones.Promedio();
        }
    }
}
