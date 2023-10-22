namespace Ejemplo1
{
    partial class Form2
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
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblTiempo = new Label();
            txtTiempo = new TextBox();
            lblTasaInter = new Label();
            rdbInteres1 = new RadioButton();
            lstResul = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            txtTasaInterEX = new TextBox();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpresa.ForeColor = Color.Lime;
            lblEmpresa.Location = new Point(41, 47);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(118, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(165, 44);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(660, 23);
            txtEmpresa.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = Color.Lime;
            lblMonto.Location = new Point(41, 125);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(113, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto prestamo ($)";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(165, 122);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(184, 23);
            txtMonto.TabIndex = 3;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.ForeColor = Color.Lime;
            lblTiempo.Location = new Point(481, 125);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(83, 15);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "Tiempo (años)";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(582, 122);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(243, 23);
            txtTiempo.TabIndex = 5;
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.ForeColor = Color.Lime;
            lblTasaInter.Location = new Point(41, 213);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(70, 15);
            lblTasaInter.TabIndex = 6;
            lblTasaInter.Text = "Tasa Interes:";
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Checked = true;
            rdbInteres1.ForeColor = Color.Lime;
            rdbInteres1.Location = new Point(79, 278);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(50, 19);
            rdbInteres1.TabIndex = 7;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12 %";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.CheckedChanged += rdbInteres1_CheckedChanged;
            // 
            // lstResul
            // 
            lstResul.Enabled = false;
            lstResul.FormattingEnabled = true;
            lstResul.ItemHeight = 15;
            lstResul.Items.AddRange(new object[] { "Resultados" });
            lstResul.Location = new Point(41, 319);
            lstResul.Name = "lstResul";
            lstResul.Size = new Size(784, 184);
            lstResul.TabIndex = 8;
            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = Color.FromArgb(255, 128, 128);
            btnAnalisis.ForeColor = Color.White;
            btnAnalisis.Location = new Point(177, 523);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(164, 27);
            btnAnalisis.TabIndex = 9;
            btnAnalisis.Text = "Análisis Financiero";
            btnAnalisis.UseVisualStyleBackColor = false;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.BackColor = Color.Orange;
            btnFin.Location = new Point(444, 523);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(153, 27);
            btnFin.TabIndex = 10;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = false;
            btnFin.Click += btnFin_Click;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.ForeColor = Color.Lime;
            rdbInteres2.Location = new Point(345, 278);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(59, 19);
            rdbInteres2.TabIndex = 11;
            rdbInteres2.TabStop = true;
            rdbInteres2.Text = "23.5 %";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.ForeColor = Color.Lime;
            rdbInteres3.Location = new Point(582, 278);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(98, 19);
            rdbInteres3.TabIndex = 12;
            rdbInteres3.TabStop = true;
            rdbInteres3.Text = "Otro, indique:";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(712, 274);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(113, 23);
            txtTasaInterEX.TabIndex = 13;
            txtTasaInterEX.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(852, 571);
            Controls.Add(txtTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lstResul);
            Controls.Add(rdbInteres1);
            Controls.Add(lblTasaInter);
            Controls.Add(txtTiempo);
            Controls.Add(lblTiempo);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Name = "Form2";
            Text = "Calculo del Monto a pagar por un Prestamo";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblTiempo;
        private TextBox txtTiempo;
        private Label lblTasaInter;
        private RadioButton rdbInteres1;
        private ListBox lstResul;
        private Button btnAnalisis;
        private Button btnFin;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox txtTasaInterEX;
    }
}