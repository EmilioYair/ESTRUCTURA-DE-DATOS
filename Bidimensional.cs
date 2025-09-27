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
    public partial class Bidimensional : Form
    {
        public Bidimensional()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Mostrar un cuadro de dialogo de confirmación
            DialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el Usuario selecciona "Si", cerrar la aplicación
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
