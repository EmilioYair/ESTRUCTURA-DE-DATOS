namespace WindowsFormsApp1
{
    partial class Unidimensional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtNvDato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtArreglo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 54);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaspace Radon", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arreglos - Unidimensionales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DtgDatos);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.BtnCrear);
            this.panel2.Controls.Add(this.BtnConsultar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnModificar);
            this.panel2.Controls.Add(this.BtnInsertar);
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 496);
            this.panel2.TabIndex = 2;
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(329, 30);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.Size = new System.Drawing.Size(378, 439);
            this.DtgDatos.TabIndex = 14;
            this.DtgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.TxtNvDato);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDato);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 255);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnBuscar.Location = new System.Drawing.Point(142, 103);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 44);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // TxtNvDato
            // 
            this.TxtNvDato.Location = new System.Drawing.Point(142, 62);
            this.TxtNvDato.Name = "TxtNvDato";
            this.TxtNvDato.Size = new System.Drawing.Size(100, 20);
            this.TxtNvDato.TabIndex = 14;
            this.TxtNvDato.TextChanged += new System.EventHandler(this.TxtNvDato_TextChanged);
            this.TxtNvDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNvDato_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nuevo Dato";
            // 
            // TxtDato
            // 
            this.TxtDato.Location = new System.Drawing.Point(142, 34);
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(100, 20);
            this.TxtDato.TabIndex = 12;
            this.TxtDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDato_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtArreglo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TxtArreglo
            // 
            this.TxtArreglo.Location = new System.Drawing.Point(142, 36);
            this.TxtArreglo.Name = "TxtArreglo";
            this.TxtArreglo.Size = new System.Drawing.Size(100, 20);
            this.TxtArreglo.TabIndex = 12;
            this.TxtArreglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArreglo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arreglo de : ";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(756, 30);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(132, 44);
            this.BtnCrear.TabIndex = 8;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnConsultar.Location = new System.Drawing.Point(756, 217);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(132, 44);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnEliminar.Location = new System.Drawing.Point(756, 153);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(132, 44);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnModificar.Location = new System.Drawing.Point(756, 89);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(132, 44);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Location = new System.Drawing.Point(756, 279);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(132, 44);
            this.BtnInsertar.TabIndex = 4;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAceptar);
            this.panel3.Controls.Add(this.BtnLimpiar);
            this.panel3.Controls.Add(this.BtnRegresar);
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Location = new System.Drawing.Point(0, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 54);
            this.panel3.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnAceptar.Location = new System.Drawing.Point(461, 16);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 26);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnLimpiar.Location = new System.Drawing.Point(575, 16);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(108, 26);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Monaspace Radon", 12F);
            this.BtnRegresar.Location = new System.Drawing.Point(689, 16);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(108, 26);
            this.BtnRegresar.TabIndex = 9;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Monaspace Radon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::WindowsFormsApp1.Properties.Resources.hogar;
            this.BtnSalir.Location = new System.Drawing.Point(803, 16);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(108, 26);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Unidimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Unidimensional";
            this.Text = "Unidimensional";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtArreglo;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.TextBox TxtNvDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar;
    }
}