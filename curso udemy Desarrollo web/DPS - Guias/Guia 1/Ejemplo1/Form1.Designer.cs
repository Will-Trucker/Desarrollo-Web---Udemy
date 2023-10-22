namespace Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnContar = new Button();
            btnReinicio = new Button();
            BtnFin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.BackColor = SystemColors.MenuHighlight;
            btnContar.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContar.ForeColor = Color.Red;
            btnContar.Location = new Point(102, 65);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(122, 45);
            btnContar.TabIndex = 0;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // btnReinicio
            // 
            btnReinicio.BackColor = Color.FromArgb(192, 64, 0);
            btnReinicio.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReinicio.ForeColor = Color.White;
            btnReinicio.Location = new Point(529, 65);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(129, 45);
            btnReinicio.TabIndex = 1;
            btnReinicio.Text = "Reinicio";
            btnReinicio.UseVisualStyleBackColor = false;
            btnReinicio.Click += btnReinicio_Click;
            // 
            // BtnFin
            // 
            BtnFin.BackColor = Color.Yellow;
            BtnFin.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFin.ForeColor = Color.Black;
            BtnFin.Location = new Point(529, 165);
            BtnFin.Name = "BtnFin";
            BtnFin.Size = new Size(129, 45);
            BtnFin.TabIndex = 2;
            BtnFin.Text = "Cerrar";
            BtnFin.UseVisualStyleBackColor = false;
            BtnFin.Click += BtnFin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(102, 176);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 3;
            label1.Text = "contador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnFin);
            Controls.Add(btnReinicio);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Button btnReinicio;
        private Button BtnFin;
        private Label label1;
    }
}