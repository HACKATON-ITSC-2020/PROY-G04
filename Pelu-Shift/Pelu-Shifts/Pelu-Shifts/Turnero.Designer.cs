namespace Pelu_Shifts
{
    partial class Turnero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnero));
            this.txthorarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtservicios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txthorarios
            // 
            this.txthorarios.FormattingEnabled = true;
            this.txthorarios.Items.AddRange(new object[] {
            "",
            "Martes: 9:00hs ",
            "Martes: 12:00hs ",
            "Martes: 17:00 hs ",
            "Martes: 20:00hs ",
            "",
            "Miercoles: 9:00hs",
            "Miercoles: 12:00hs",
            "Miercoles: 17:00hs ",
            "Miercoles: 20:00hs",
            "",
            "Jueves: 9:00hs ",
            "Jueves: 12:00hs ",
            "Jueves: 17:00hs",
            "Jueves: 20:00hs ",
            "",
            "Viernes: 9:00hs ",
            "Viernes: 12:00hs ",
            "Viernes: 17:00hs ",
            "Viernes: 20:00hs"});
            this.txthorarios.Location = new System.Drawing.Point(50, 310);
            this.txthorarios.Name = "txthorarios";
            this.txthorarios.Size = new System.Drawing.Size(121, 21);
            this.txthorarios.TabIndex = 0;
            this.txthorarios.Text = "Horarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Horarios";
            // 
            // txtservicios
            // 
            this.txtservicios.FormattingEnabled = true;
            this.txtservicios.Items.AddRange(new object[] {
            "Corte de pelo",
            "Peinados",
            "Alisado",
            "Lavado + Tintura",
            "Lavado + Brushing"});
            this.txtservicios.Location = new System.Drawing.Point(50, 244);
            this.txtservicios.Name = "txtservicios";
            this.txtservicios.Size = new System.Drawing.Size(121, 21);
            this.txtservicios.TabIndex = 2;
            this.txtservicios.Text = "Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reservar Turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(270, 12);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.Size = new System.Drawing.Size(545, 501);
            this.dg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = global::Pelu_Shifts.Properties.Resources.descarga_ico;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 168);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peluqueros Disponible\r\n#Peluquero 1\r\n#Peluquero 2\r\nMartes = Peluquero 2\r\nMiercole" +
    "s y Jueves= Peluquero 1\r\nViernes= Peluquero 2\r\nSabado = Dueño.\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1165, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthorarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pelu-Shifts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txthorarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtservicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label3;
    }
}

