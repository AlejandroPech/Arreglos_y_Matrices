using ArreglosyMatrices.Clases;
using Microsoft.VisualBasic;
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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
                GetCeros();
            //}
            //catch(Exception ex)
            //{
              //  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        public void GetCeros()
        {
            int filas = Int32.Parse(txtFilas.Text.Trim());
            int columnas = Int32.Parse(txtColumnas.Text.Trim());
            CerosporColumna cerosporColumna = new CerosporColumna(filas,columnas);
            cerosporColumna.Filas = filas;
            cerosporColumna.Columnas = columnas;
            for (int i = 0; i < (filas); i++){
                for (int j = 0; j < columnas; j++)
                {
                    int numColumna = Int32.Parse(Interaction.InputBox("Ingresa el valor deseado para el indice  {" + i + " " + j +"}","Valor"));
                    cerosporColumna.Matriz[i, j] = numColumna;
                }
            }
            richTextBox1.Text = cerosporColumna.GetCerosbyColumn();
        }
    }
}
