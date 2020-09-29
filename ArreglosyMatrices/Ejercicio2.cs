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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        Label labelnum = new Label();
        Label label = new Label();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTamañoM_Click(object sender, EventArgs e)
        {
            try
            {

                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            CrearMatriz();
        }


        private void CrearMatriz()
        {
            
            int tamaño = Int32.Parse(txtTamañoM.Text);
            int Numeromagico = 0;
            CuadroMagico cuadroMagico = new CuadroMagico(tamaño);
            int[,] matriz = new int[tamaño, tamaño];

            for (int i = 0; i < Int32.Parse(txtTamañoM.Text); i++)
            {
                for (int j = 0; j < Int32.Parse(txtTamañoM.Text); j++)
                {
                    int textChild = Int32.Parse(Interaction.InputBox("Ingresa el valor deseado  " + i+" "+j, "Cuadro Magico"));
                    if (textChild < 1 || textChild > (tamaño * tamaño))
                    {
                        
                        j=j-1;
                        MessageBox.Show("Este numero es invalido");
                        
                    }
                    else
                    {
                        cuadroMagico.Dimenciones[i,j]=textChild;

                    }
                }
            }
            richTextBox1.Text = cuadroMagico.CrearCuadro();
            
            Numeromagico= cuadroMagico.VerificarCuadro();
            
            label.Parent = this;
            label.Location = new Point(50,110);
            label.Size = new Size(200, 20);
            

            if (Numeromagico > 0)
            {
                label.Text = "Este es un cuadrado magico";
                
                labelnum.Parent = this;
                labelnum.Location = new Point(50,160);
                labelnum.Size = new Size(200, 20);
                labelnum.Text = $"El numero magico es {Numeromagico}";
                labelnum.Visible = true;
            }
            else
            {
                label.Text = "Este no es un cuadrado magico";
                labelnum.Visible = false;
            }
                
        }


        
    }
}
