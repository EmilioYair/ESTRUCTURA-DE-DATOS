namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cmbTemperaturas = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPromSem = new System.Windows.Forms.TextBox();
            this.txtMinSem = new System.Windows.Forms.TextBox();
            this.txtMaxSem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProD = new System.Windows.Forms.TextBox();
            this.txtMinD = new System.Windows.Forms.TextBox();
            this.txtMaxD = new System.Windows.Forms.TextBox();
            this.txtProV = new System.Windows.Forms.TextBox();
            this.txtMinV = new System.Windows.Forms.TextBox();
            this.txtProS = new System.Windows.Forms.TextBox();
            this.txtMinS = new System.Windows.Forms.TextBox();
            this.txtMaxS = new System.Windows.Forms.TextBox();
            this.txtMaxV = new System.Windows.Forms.TextBox();
            this.txtProMi = new System.Windows.Forms.TextBox();
            this.txtMinMi = new System.Windows.Forms.TextBox();
            this.txtProJ = new System.Windows.Forms.TextBox();
            this.txtMinJ = new System.Windows.Forms.TextBox();
            this.txtMaxJ = new System.Windows.Forms.TextBox();
            this.txtMaxMi = new System.Windows.Forms.TextBox();
            this.txtProL = new System.Windows.Forms.TextBox();
            this.txtMinL = new System.Windows.Forms.TextBox();
            this.txtProM = new System.Windows.Forms.TextBox();
            this.txtMinM = new System.Windows.Forms.TextBox();
            this.txtMaxM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgTem = new System.Windows.Forms.DataGridView();
            this.chrTem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrTem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaspace Radon Wide", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor De Temperaturas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.cmbTemperaturas);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1779, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Monaspace Radon Wide", 8.25F);
            this.btnRegresar.Location = new System.Drawing.Point(1589, 9);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(92, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cmbTemperaturas
            // 
            this.cmbTemperaturas.FormattingEnabled = true;
            this.cmbTemperaturas.Location = new System.Drawing.Point(213, 11);
            this.cmbTemperaturas.Name = "cmbTemperaturas";
            this.cmbTemperaturas.Size = new System.Drawing.Size(58, 21);
            this.cmbTemperaturas.TabIndex = 0;
            this.cmbTemperaturas.Text = "Temp";
            this.cmbTemperaturas.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Monaspace Radon Wide", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1687, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 21);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(146, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(61, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(79, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(61, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 9);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(61, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPromSem);
            this.panel3.Controls.Add(this.txtMinSem);
            this.panel3.Controls.Add(this.txtMaxSem);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtProD);
            this.panel3.Controls.Add(this.txtMinD);
            this.panel3.Controls.Add(this.txtMaxD);
            this.panel3.Controls.Add(this.txtProV);
            this.panel3.Controls.Add(this.txtMinV);
            this.panel3.Controls.Add(this.txtProS);
            this.panel3.Controls.Add(this.txtMinS);
            this.panel3.Controls.Add(this.txtMaxS);
            this.panel3.Controls.Add(this.txtMaxV);
            this.panel3.Controls.Add(this.txtProMi);
            this.panel3.Controls.Add(this.txtMinMi);
            this.panel3.Controls.Add(this.txtProJ);
            this.panel3.Controls.Add(this.txtMinJ);
            this.panel3.Controls.Add(this.txtMaxJ);
            this.panel3.Controls.Add(this.txtMaxMi);
            this.panel3.Controls.Add(this.txtProL);
            this.panel3.Controls.Add(this.txtMinL);
            this.panel3.Controls.Add(this.txtProM);
            this.panel3.Controls.Add(this.txtMinM);
            this.panel3.Controls.Add(this.txtMaxM);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtMaxL);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 196);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F);
            this.label2.Location = new System.Drawing.Point(850, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Semana";
            // 
            // txtPromSem
            // 
            this.txtPromSem.Location = new System.Drawing.Point(839, 129);
            this.txtPromSem.Name = "txtPromSem";
            this.txtPromSem.Size = new System.Drawing.Size(100, 20);
            this.txtPromSem.TabIndex = 34;
            this.txtPromSem.TextChanged += new System.EventHandler(this.txtPromSem_TextChanged);
            // 
            // txtMinSem
            // 
            this.txtMinSem.Location = new System.Drawing.Point(839, 88);
            this.txtMinSem.Name = "txtMinSem";
            this.txtMinSem.Size = new System.Drawing.Size(100, 20);
            this.txtMinSem.TabIndex = 33;
            // 
            // txtMaxSem
            // 
            this.txtMaxSem.Location = new System.Drawing.Point(839, 42);
            this.txtMaxSem.Name = "txtMaxSem";
            this.txtMaxSem.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSem.TabIndex = 32;
            this.txtMaxSem.TextChanged += new System.EventHandler(this.txtMaxSem_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(496, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "S";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "V";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(358, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "J";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(565, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "M";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "L";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtProD
            // 
            this.txtProD.Location = new System.Drawing.Point(553, 129);
            this.txtProD.Name = "txtProD";
            this.txtProD.ReadOnly = true;
            this.txtProD.Size = new System.Drawing.Size(46, 20);
            this.txtProD.TabIndex = 24;
            // 
            // txtMinD
            // 
            this.txtMinD.Location = new System.Drawing.Point(553, 89);
            this.txtMinD.Name = "txtMinD";
            this.txtMinD.ReadOnly = true;
            this.txtMinD.Size = new System.Drawing.Size(46, 20);
            this.txtMinD.TabIndex = 23;
            this.txtMinD.TextChanged += new System.EventHandler(this.txtMinimo_TextChanged);
            // 
            // txtMaxD
            // 
            this.txtMaxD.Location = new System.Drawing.Point(553, 45);
            this.txtMaxD.Name = "txtMaxD";
            this.txtMaxD.ReadOnly = true;
            this.txtMaxD.Size = new System.Drawing.Size(46, 20);
            this.txtMaxD.TabIndex = 22;
            // 
            // txtProV
            // 
            this.txtProV.Location = new System.Drawing.Point(414, 128);
            this.txtProV.Name = "txtProV";
            this.txtProV.ReadOnly = true;
            this.txtProV.Size = new System.Drawing.Size(46, 20);
            this.txtProV.TabIndex = 21;
            // 
            // txtMinV
            // 
            this.txtMinV.Location = new System.Drawing.Point(414, 88);
            this.txtMinV.Name = "txtMinV";
            this.txtMinV.ReadOnly = true;
            this.txtMinV.Size = new System.Drawing.Size(46, 20);
            this.txtMinV.TabIndex = 20;
            // 
            // txtProS
            // 
            this.txtProS.Location = new System.Drawing.Point(484, 128);
            this.txtProS.Name = "txtProS";
            this.txtProS.ReadOnly = true;
            this.txtProS.Size = new System.Drawing.Size(46, 20);
            this.txtProS.TabIndex = 19;
            // 
            // txtMinS
            // 
            this.txtMinS.Location = new System.Drawing.Point(484, 88);
            this.txtMinS.Name = "txtMinS";
            this.txtMinS.ReadOnly = true;
            this.txtMinS.Size = new System.Drawing.Size(46, 20);
            this.txtMinS.TabIndex = 18;
            // 
            // txtMaxS
            // 
            this.txtMaxS.Location = new System.Drawing.Point(484, 44);
            this.txtMaxS.Name = "txtMaxS";
            this.txtMaxS.ReadOnly = true;
            this.txtMaxS.Size = new System.Drawing.Size(46, 20);
            this.txtMaxS.TabIndex = 17;
            // 
            // txtMaxV
            // 
            this.txtMaxV.Location = new System.Drawing.Point(414, 44);
            this.txtMaxV.Name = "txtMaxV";
            this.txtMaxV.ReadOnly = true;
            this.txtMaxV.Size = new System.Drawing.Size(46, 20);
            this.txtMaxV.TabIndex = 16;
            // 
            // txtProMi
            // 
            this.txtProMi.Location = new System.Drawing.Point(275, 128);
            this.txtProMi.Name = "txtProMi";
            this.txtProMi.ReadOnly = true;
            this.txtProMi.Size = new System.Drawing.Size(46, 20);
            this.txtProMi.TabIndex = 15;
            // 
            // txtMinMi
            // 
            this.txtMinMi.Location = new System.Drawing.Point(275, 88);
            this.txtMinMi.Name = "txtMinMi";
            this.txtMinMi.ReadOnly = true;
            this.txtMinMi.Size = new System.Drawing.Size(46, 20);
            this.txtMinMi.TabIndex = 14;
            // 
            // txtProJ
            // 
            this.txtProJ.Location = new System.Drawing.Point(345, 128);
            this.txtProJ.Name = "txtProJ";
            this.txtProJ.ReadOnly = true;
            this.txtProJ.Size = new System.Drawing.Size(46, 20);
            this.txtProJ.TabIndex = 13;
            // 
            // txtMinJ
            // 
            this.txtMinJ.Location = new System.Drawing.Point(345, 88);
            this.txtMinJ.Name = "txtMinJ";
            this.txtMinJ.ReadOnly = true;
            this.txtMinJ.Size = new System.Drawing.Size(46, 20);
            this.txtMinJ.TabIndex = 12;
            // 
            // txtMaxJ
            // 
            this.txtMaxJ.Location = new System.Drawing.Point(345, 44);
            this.txtMaxJ.Name = "txtMaxJ";
            this.txtMaxJ.ReadOnly = true;
            this.txtMaxJ.Size = new System.Drawing.Size(46, 20);
            this.txtMaxJ.TabIndex = 11;
            // 
            // txtMaxMi
            // 
            this.txtMaxMi.Location = new System.Drawing.Point(275, 44);
            this.txtMaxMi.Name = "txtMaxMi";
            this.txtMaxMi.ReadOnly = true;
            this.txtMaxMi.Size = new System.Drawing.Size(46, 20);
            this.txtMaxMi.TabIndex = 10;
            // 
            // txtProL
            // 
            this.txtProL.Location = new System.Drawing.Point(128, 128);
            this.txtProL.Name = "txtProL";
            this.txtProL.ReadOnly = true;
            this.txtProL.Size = new System.Drawing.Size(46, 20);
            this.txtProL.TabIndex = 9;
            // 
            // txtMinL
            // 
            this.txtMinL.Location = new System.Drawing.Point(128, 88);
            this.txtMinL.Name = "txtMinL";
            this.txtMinL.ReadOnly = true;
            this.txtMinL.Size = new System.Drawing.Size(46, 20);
            this.txtMinL.TabIndex = 8;
            // 
            // txtProM
            // 
            this.txtProM.Location = new System.Drawing.Point(198, 128);
            this.txtProM.Name = "txtProM";
            this.txtProM.ReadOnly = true;
            this.txtProM.Size = new System.Drawing.Size(46, 20);
            this.txtProM.TabIndex = 7;
            // 
            // txtMinM
            // 
            this.txtMinM.Location = new System.Drawing.Point(198, 88);
            this.txtMinM.Name = "txtMinM";
            this.txtMinM.ReadOnly = true;
            this.txtMinM.Size = new System.Drawing.Size(46, 20);
            this.txtMinM.TabIndex = 6;
            // 
            // txtMaxM
            // 
            this.txtMaxM.Location = new System.Drawing.Point(198, 44);
            this.txtMaxM.Name = "txtMaxM";
            this.txtMaxM.ReadOnly = true;
            this.txtMaxM.Size = new System.Drawing.Size(46, 20);
            this.txtMaxM.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Promedio";
            // 
            // txtMaxL
            // 
            this.txtMaxL.Location = new System.Drawing.Point(128, 44);
            this.txtMaxL.Name = "txtMaxL";
            this.txtMaxL.Size = new System.Drawing.Size(46, 20);
            this.txtMaxL.TabIndex = 3;
            this.txtMaxL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Minimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monaspace Radon Wide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgTem);
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(956, 312);
            this.panel4.TabIndex = 3;
            // 
            // dtgTem
            // 
            this.dtgTem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTem.Location = new System.Drawing.Point(0, 0);
            this.dtgTem.Name = "dtgTem";
            this.dtgTem.ReadOnly = true;
            this.dtgTem.Size = new System.Drawing.Size(956, 312);
            this.dtgTem.TabIndex = 0;
            // 
            // chrTem
            // 
            chartArea1.Name = "ChartArea1";
            this.chrTem.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrTem.Legends.Add(legend1);
            this.chrTem.Location = new System.Drawing.Point(962, 46);
            this.chrTem.Name = "chrTem";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrTem.Series.Add(series1);
            this.chrTem.Size = new System.Drawing.Size(817, 514);
            this.chrTem.TabIndex = 4;
            this.chrTem.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1780, 606);
            this.Controls.Add(this.chrTem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrTem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtgTem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProL;
        private System.Windows.Forms.TextBox txtMinL;
        private System.Windows.Forms.TextBox txtProM;
        private System.Windows.Forms.TextBox txtMinM;
        private System.Windows.Forms.TextBox txtMaxM;
        private System.Windows.Forms.TextBox txtProD;
        private System.Windows.Forms.TextBox txtMinD;
        private System.Windows.Forms.TextBox txtMaxD;
        private System.Windows.Forms.TextBox txtProV;
        private System.Windows.Forms.TextBox txtMinV;
        private System.Windows.Forms.TextBox txtProS;
        private System.Windows.Forms.TextBox txtMinS;
        private System.Windows.Forms.TextBox txtMaxS;
        private System.Windows.Forms.TextBox txtMaxV;
        private System.Windows.Forms.TextBox txtProMi;
        private System.Windows.Forms.TextBox txtMinMi;
        private System.Windows.Forms.TextBox txtProJ;
        private System.Windows.Forms.TextBox txtMinJ;
        private System.Windows.Forms.TextBox txtMaxJ;
        private System.Windows.Forms.TextBox txtMaxMi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTemperaturas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPromSem;
        private System.Windows.Forms.TextBox txtMinSem;
        private System.Windows.Forms.TextBox txtMaxSem;
    }
}

