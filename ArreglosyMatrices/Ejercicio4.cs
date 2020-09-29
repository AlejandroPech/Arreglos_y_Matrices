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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        const int SW_HIDE = 0;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            richTextBox1.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DiagonalUnos diagonalUnos = new DiagonalUnos(Int32.Parse(txtNumD.Text.Trim()));
                if (Int32.Parse(txtNumD.Text.Trim()) <= 10 && Int32.Parse(txtNumD.Text.Trim()) > 0)
                    richTextBox1.Text = diagonalUnos.GetDiagonal();
                else
                    MessageBox.Show("Este numero es muy grande o muy pequño");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
