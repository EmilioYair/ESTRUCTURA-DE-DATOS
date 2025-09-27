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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
