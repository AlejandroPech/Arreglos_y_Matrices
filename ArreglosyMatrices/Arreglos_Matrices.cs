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
    public partial class Arreglos_Matrices : Form
    {
        public Arreglos_Matrices()
        {
            InitializeComponent();
        }

        private void Arreglos_Matrices_Load(object sender, EventArgs e)
        {

        }

        private void AbrirPanel(object formmenor)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fm = formmenor as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fm);
            this.PanelContenedor.Tag = fm;
            fm.Show();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio1());
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio2());
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio3());
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio4());
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio5());
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio6());
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Ejercicio7());
        }
    }
}
