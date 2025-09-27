using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sensorSubmarinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void operacionesConArreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Mostrar un cuadro de dialogo de confirmación
            DialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el Usuario selecciona "Si", cerrar la aplicación
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Aplicaciones
        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uniDimensionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unidimensional unidimensional = new Unidimensional();
            unidimensional.Show();
            this.Hide();

        }
    }
}
