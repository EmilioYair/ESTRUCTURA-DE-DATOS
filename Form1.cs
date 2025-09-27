using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[,] tem = new int[24, 7];


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Métodos de cálculo por día
        public int MaximoDia(int[,] temperaturas, int dia)
        {
            int max = temperaturas[0, dia];
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                if (temperaturas[i, dia] > max)
                {
                    max = temperaturas[i, dia];
                }
            }
            return max;
        }

        public int MinimoDia(int[,] temperaturas, int dia)
        {
            int min = temperaturas[0, dia];
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                if (temperaturas[i, dia] < min)
                {
                    min = temperaturas[i, dia];
                }
            }
            return min;
        }

        public double PromedioDia(int[,] temperaturas, int dia)
        {
            double suma = 0;
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                suma += temperaturas[i, dia];
            }
            return suma / 24;
        }

        public double MaximoSemana(int[,] temperaturas)
        {
            int maxs = temperaturas[0, 0];
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                for (int j = 0; j < 7; j++)
                {
                    if (temperaturas[i, j] > maxs)
                    {
                        maxs = temperaturas[i, j];
                    }
                }
            }
            return maxs;
        }

        public double MinimoSemana(int[,] temperaturas)
        {
            int mins = temperaturas[0, 0];
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                for (int j = 0; j < 7; j++)
                {
                    if (temperaturas[i, j] < mins)
                    {
                        mins = temperaturas[i, j];
                    }
                }
            }
            return mins;
        }

        public double PromedioSemana(int[,] temperaturas)
        {
            double sumas = 0;
            for (int i = 0; i < 24; i++) // Itera sobre las 24 horas de ese día
            {
                for (int j = 0; j < 7; j++)
                {
                    sumas += temperaturas[i, j];
                }
            }
            return sumas / (24 * 7);
        }



        // BOTON CALCULAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbTemperaturas.Items.Count == 0)

            {

                MessageBox.Show("Por favor, genere las temperaturas primero.");

            }

            else

            {

                // Calcula y muestra los valores para cada día
                // LUNES (índice 0)
                txtMaxL.Text = MaximoDia(tem, 0).ToString();
                txtMinL.Text = MinimoDia(tem, 0).ToString();
                txtProL.Text = PromedioDia(tem, 0).ToString("F2");

                // MARTES (índice 1)
                txtMaxM.Text = MaximoDia(tem, 1).ToString();
                txtMinM.Text = MinimoDia(tem, 1).ToString();
                txtProM.Text = PromedioDia(tem, 1).ToString("F2");

                // MIÉRCOLES (índice 2)
                txtMaxMi.Text = MaximoDia(tem, 2).ToString();
                txtMinMi.Text = MinimoDia(tem, 2).ToString();
                txtProMi.Text = PromedioDia(tem, 2).ToString("F2");

                // JUEVES (índice 3)
                txtMaxJ.Text = MaximoDia(tem, 3).ToString();
                txtMinJ.Text = MinimoDia(tem, 3).ToString();
                txtProJ.Text = PromedioDia(tem, 3).ToString("F2");

                // VIERNES (índice 4)
                txtMaxV.Text = MaximoDia(tem, 4).ToString();
                txtMinV.Text = MinimoDia(tem, 4).ToString();
                txtProV.Text = PromedioDia(tem, 4).ToString("F2");

                // SÁBADO (índice 5)
                txtMaxS.Text = MaximoDia(tem, 5).ToString();
                txtMinS.Text = MinimoDia(tem, 5).ToString();
                txtProS.Text = PromedioDia(tem, 5).ToString("F2");

                // DOMINGO (índice 6)
                txtMaxD.Text = MaximoDia(tem, 6).ToString();
                txtMinD.Text = MinimoDia(tem, 6).ToString();
                txtProD.Text = PromedioDia(tem, 6).ToString("F2");

                // Cálculos semanales
                txtMaxSem.Text = MaximoSemana(tem).ToString();
                txtMinSem.Text = MinimoSemana(tem).ToString();
                txtPromSem.Text = PromedioSemana(tem).ToString("F2");
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Mostrar un cuadro de dialogo de confirmación
            DialogResult = MessageBox.Show("¿Está seguro que desea reiniciar?", "Confirmar Reinicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el Usuario selecciona "Si", reiniciar la aplicación
            if (DialogResult == DialogResult.Yes)
            {
                txtMaxD.Clear();
                txtMaxJ.Clear();
                txtMaxL.Clear();
                txtMaxM.Clear();
                txtMaxMi.Clear();
                txtMaxS.Clear();
                txtMaxV.Clear();
                txtMaxSem.Clear();
                txtMinSem.Clear();
                txtMinD.Clear();
                txtMinJ.Clear();
                txtMinL.Clear();
                txtMinM.Clear();
                txtMinMi.Clear();
                txtMinS.Clear();
                txtMinV.Clear();
                txtPromSem.Clear();
                txtProD.Clear();
                txtProJ.Clear();
                txtProL.Clear();
                txtProM.Clear();
                txtProMi.Clear();
                txtProS.Clear();
                txtProV.Clear();
                cmbTemperaturas.Items.Clear();
                chrTem.Series.Clear();
                dtgTem.DataSource = null;
                dtgTem.Rows.Clear();

            }
            
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            DataTable dt = new DataTable();
            dt.Columns.Add("Lunes");
            dt.Columns.Add("Martes");
            dt.Columns.Add("Miércoles");
            dt.Columns.Add("Jueves");
            dt.Columns.Add("Viernes");
            dt.Columns.Add("Sábado");
            dt.Columns.Add("Domingo");
            cmbTemperaturas.Items.Clear();

            for (int i = 0; i < 24; i++)
            {
                DataRow fila = dt.NewRow();
                for (int j = 0; j < 7; j++)
                {
                    tem[i, j] = r.Next(-2, 40);
                    cmbTemperaturas.Items.Add(tem[i, j]);
                    fila[j] = tem[i, j];
                }
                dt.Rows.Add(fila);
            }
            dtgTem.DataSource = dt;

            chrTem.Series.Clear();

            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            for (int j = 0; j < 7; j++)
            {
                var serie = chrTem.Series.Add(dias[j]);
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 0; i < 24; i++)
                {
                    serie.Points.AddXY(i, tem[i, j]);
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnS1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaxSem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPromSem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
