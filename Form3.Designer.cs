namespace WindowsFormsApp1
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uniDimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(61, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorDeTemperaturaToolStripMenuItem,
            this.operacionesToolStripMenuItem1});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.operacionesToolStripMenuItem.Text = "Aplicaciones";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // sensorDeTemperaturaToolStripMenuItem
            // 
            this.sensorDeTemperaturaToolStripMenuItem.Name = "sensorDeTemperaturaToolStripMenuItem";
            this.sensorDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sensorDeTemperaturaToolStripMenuItem.Text = "Sensor de Temperatura";
            // 
            // operacionesToolStripMenuItem1
            // 
            this.operacionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniDimensionalToolStripMenuItem,
            this.bidimensionalToolStripMenuItem});
            this.operacionesToolStripMenuItem1.Name = "operacionesToolStripMenuItem1";
            this.operacionesToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.operacionesToolStripMenuItem1.Text = "Operaciones";
            // 
            // uniDimensionalToolStripMenuItem
            // 
            this.uniDimensionalToolStripMenuItem.Name = "uniDimensionalToolStripMenuItem";
            this.uniDimensionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uniDimensionalToolStripMenuItem.Text = "Unidimensional";
            this.uniDimensionalToolStripMenuItem.Click += new System.EventHandler(this.uniDimensionalToolStripMenuItem_Click);
            // 
            // bidimensionalToolStripMenuItem
            // 
            this.bidimensionalToolStripMenuItem.Name = "bidimensionalToolStripMenuItem";
            this.bidimensionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bidimensionalToolStripMenuItem.Text = "Bidimensional";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uniDimensionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bidimensionalToolStripMenuItem;
    }
}