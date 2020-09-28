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
    }
}
