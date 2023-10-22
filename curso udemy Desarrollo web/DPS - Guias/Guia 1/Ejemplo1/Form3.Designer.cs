namespace Ejemplo1
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
            lblApe1 = new Label();
            txtApe1 = new TextBox();
            lblApe2 = new Label();
            txtApe2 = new TextBox();
            lblNom = new Label();
            txtNom = new TextBox();
            lblCUM = new Label();
            txtCUM = new TextBox();
            btnAnalisis = new Button();
            txtResul = new TextBox();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblApe1
            // 
            lblApe1.AutoSize = true;
            lblApe1.Location = new Point(66, 52);
            lblApe1.Name = "lblApe1";
            lblApe1.Size = new Size(73, 15);
            lblApe1.TabIndex = 0;
            lblApe1.Text = "1er Apellido:";
            // 
            // txtApe1
            // 
            txtApe1.Location = new Point(151, 44);
            txtApe1.Name = "txtApe1";
            txtApe1.Size = new Size(379, 23);
            txtApe1.TabIndex = 1;
            // 
            // lblApe2
            // 
            lblApe2.AutoSize = true;
            lblApe2.Location = new Point(66, 95);
            lblApe2.Name = "lblApe2";
            lblApe2.Size = new Size(77, 15);
            lblApe2.TabIndex = 2;
            lblApe2.Text = "2do Apellido:";
            // 
            // txtApe2
            // 
            txtApe2.Location = new Point(151, 87);
            txtApe2.Name = "txtApe2";
            txtApe2.Size = new Size(379, 23);
            txtApe2.TabIndex = 3;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(66, 136);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(56, 15);
            lblNom.TabIndex = 4;
            lblNom.Text = "Nombres";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(151, 133);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(379, 23);
            txtNom.TabIndex = 5;
            // 
            // lblCUM
            // 
            lblCUM.AutoSize = true;
            lblCUM.Location = new Point(66, 178);
            lblCUM.Name = "lblCUM";
            lblCUM.Size = new Size(79, 15);
            lblCUM.TabIndex = 6;
            lblCUM.Text = "Valor de CUM";
            // 
            // txtCUM
            // 
            txtCUM.Location = new Point(151, 175);
            txtCUM.Name = "txtCUM";
            txtCUM.Size = new Size(379, 23);
            txtCUM.TabIndex = 7;
            txtCUM.Text = "0.0";
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(151, 288);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(75, 23);
            btnAnalisis.TabIndex = 8;
            btnAnalisis.Text = "Calcular UV";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // txtResul
            // 
            txtResul.Location = new Point(66, 227);
            txtResul.Name = "txtResul";
            txtResul.Size = new Size(464, 23);
            txtResul.TabIndex = 9;
            txtResul.Text = "Resultado de Evaluación";
            // 
            // btnFin
            // 
            btnFin.Location = new Point(324, 288);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(158, 23);
            btnFin.TabIndex = 10;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 351);
            Controls.Add(btnFin);
            Controls.Add(txtResul);
            Controls.Add(btnAnalisis);
            Controls.Add(txtCUM);
            Controls.Add(lblCUM);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(txtApe2);
            Controls.Add(lblApe2);
            Controls.Add(txtApe1);
            Controls.Add(lblApe1);
            Name = "Form3";
            Text = "Calculo de UV a cursar";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApe1;
        private TextBox txtApe1;
        private Label lblApe2;
        private TextBox txtApe2;
        private Label lblNom;
        private TextBox txtNom;
        private Label lblCUM;
        private TextBox txtCUM;
        private Button btnAnalisis;
        private TextBox txtResul;
        private Button btnFin;
    }
}