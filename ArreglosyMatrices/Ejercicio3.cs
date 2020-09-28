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
            string[,] matriz = new string[3, 3]
            {
                {"Valor1","Valor2","Valor3" },
                {"Valor4","Valor5","Valor6" },
                {"Valor7","Valor8","Valor9" }
            };
            EscribirArreglo(matriz);
            richTextBox.Size = new Size(200, 200);
            richTextBox.Location = new Point(435, 181);
            richTextBox.Visible = true;
            Console.WriteLine("Hola");
            if (string.IsNullOrEmpty(textBox1.Text))
                button1.Enabled = false;

        }

        public void EscribirArreglo(string[,] matriz)
        {
            
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpFila = new string[matriz.GetLength(0)];
            for(int i = 0; i < filas; i++)
            {
                for(int j=0;j < columnas; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }
            
            richTextBox.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RichTextBox richTextBox;            
            richTextBox = new RichTextBox();
            richTextBox.Parent = this;
            richTextBox.Location = new Point(50, 50);
            richTextBox.Size = new Size(100, 100);
            richTextBox.BackColor = Color.White;

            textBox1.Size = new Size(300, 20);
        }
    }
}
