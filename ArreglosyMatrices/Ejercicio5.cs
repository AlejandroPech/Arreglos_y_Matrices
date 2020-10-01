using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosyMatrices
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        public void showmatriz(int[,] matriz)
        {
            foreach(int i in matriz)
            {
                label1.Text = i.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[5, 10];
            Random numeros = new Random();
            for (int i=0; i<matriz.Length; i++)
            {
                for (int j=0; j<matriz.Length; j++)
                {
                    matriz[i, j] = numeros.Next(0,10);
                }
            }
            showmatriz(matriz);
        }
    }
}
