using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Unidimensional : Form
    {

        int[] A;
        int i = -1, n, dato, nvodato, j = 0;
        string opcion = "";

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            BtnConsultar.Enabled = true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnInsertar.Enabled = true;
            TxtNvDato.Enabled = true;
            TxtArreglo.Enabled = true;
            BtnAceptar.Enabled = true;
            opcion = "crear";
            TxtArreglo.Focus();


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "crear":
                    {
                        if (TxtArreglo.Text.Trim() != "")
                        {
                            n = Convert.ToInt32(TxtArreglo.Text);
                            A = new int[n];
                            MessageBox.Show("Arreglo creado " + n);
                            BtnInsertar.Enabled = true;
                            BtnCrear.Enabled = false;
                            TxtArreglo.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Ingresa el tam del arreglo");
                            TxtArreglo.Focus();
                            
                            
                        }
                        BtnAceptar.Focus();
                        break;
                    }
                case "insertar":
                    {
                        if (i < n - 1)
                        {
                            if (TxtDato.Text.Trim() != "")
                            {
                                dato = Convert.ToInt32(TxtDato.Text);
                                i++;
                                A[i] = dato;
                                MessageBox.Show("Dato insertado " + dato);
                                TxtDato.Clear();
                                TxtDato.Focus();

                                DtgDatos.Rows.Clear();
                                DtgDatos.Columns.Clear();
                                DtgDatos.Columns.Add("Indice", "Índice");
                                DtgDatos.Columns.Add("Valor", "Valor");
                                for (int idx = 0; idx <= i; idx++)
                                {
                                    DtgDatos.Rows.Add(idx, A[idx]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingresa un dato");
                                TxtDato.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arreglo lleno");
                            BtnInsertar.Enabled = false;
                            TxtDato.Clear();
                            TxtDato.Enabled = false;
                        }
                        Actualizar();
                        BtnAceptar.Focus();
                        break;
                    }
                case "modificar":
                    {
                        Buscar();
                        
                        if (TxtNvDato.Text.Trim() != "")
                        {
                            A[j] = Convert.ToInt32(TxtNvDato.Text);
                            MessageBox.Show("Dato modificado");
                            TxtDato.Enabled = false;
                            TxtDato.Clear();
                            TxtNvDato.Clear();
                            TxtNvDato.Enabled = false;
                            BtnBuscar.Enabled = false;

                        }
                        Actualizar();
                        BtnAceptar.Focus();
                        break;
                    }
                case "eliminar":
                    {
                        Buscar();
                        A[j] = 0;
                        MessageBox.Show("Dato eliminado");
                        TxtDato.Enabled = false;
                        TxtDato.Clear();
                        BtnBuscar.Enabled = false;

                        Actualizar();
                        BtnAceptar.Focus();
                        break;
                    }


            }
        }


        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            TxtDato.Enabled = true;
            BtnAceptar.Enabled = true;
            opcion = "insertar";
            TxtDato.Focus();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            TxtArreglo.Enabled = true;
            TxtDato.Enabled = true;
            TxtNvDato.Enabled = true;
            BtnConsultar.Enabled = true;
            opcion = "eliminar";
        }

        public Boolean Buscar()
        {
            Boolean existe = false;
            if (TxtDato.Text.Trim() != "")
            {
                dato = Convert.ToInt32(TxtDato.Text);
                for ( j = 0; j <= i; j++)
                {
                    if (A[j] == dato)
                    {
                        existe = true;
                        break;
                    }
                    else
                    {
                        existe = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingresa dato a buscar");
                TxtDato.Focus();
            }
            return existe;
        }

        //consultar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TxtArreglo.Enabled = true;
            BtnAceptar.Enabled = true;
            opcion = "consultar";
        }

        private void DtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtArreglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void TxtNvDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void TxtNvDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            DtgDatos.Refresh();
            DtgDatos.Update();
            opcion = "actualizar";
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            Boolean exis = Buscar();
            if (exis == true)
            {
                MessageBox.Show("Dato encontrado");
                TxtNvDato.Enabled = true;
                BtnAceptar.Enabled = true;
                TxtNvDato.Focus();

            }
            else
            {
                MessageBox.Show("Dato no encontrado");
                TxtDato.Clear();
                TxtDato.Focus();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            A = null;
            DtgDatos.Rows.Clear();
            DtgDatos.Columns.Clear();
            TxtArreglo.Clear();
            TxtDato.Clear();
            TxtNvDato.Clear();
            BtnCrear.Enabled = true;
            BtnInsertar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            


        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
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

        public Unidimensional()
        {
            InitializeComponent();
            BtnConsultar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnInsertar.Enabled = false;
            TxtArreglo.Enabled = false;
            TxtArreglo.Enabled = false;
            TxtNvDato.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //BtnModificar
        private void button2_Click(object sender, EventArgs e)
        {
            TxtArreglo.Enabled = true;
            BtnConsultar.Enabled = true;
            opcion = "modificar";
            


        }

        
        public void Actualizar ()
        {
            
            DtgDatos.Rows.Clear();
                        DtgDatos.Columns.Clear();
                        DtgDatos.Columns.Add("Indice", "Índice");
                        DtgDatos.Columns.Add("Valor", "Valor");
                        for (int idx = 0; idx <= i; idx++)
                        {
                            DtgDatos.Rows.Add(idx, A[idx]);
                        }
                        DtgDatos.Refresh();
                        DtgDatos.Update();
        }
    }
}

