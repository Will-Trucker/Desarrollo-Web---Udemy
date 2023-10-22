namespace Guia6Complementario
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
            label1 = new Label();
            txtNombreComun = new TextBox();
            label2 = new Label();
            txtNombreCientifico = new TextBox();
            label3 = new Label();
            btnSeleccionarFoto = new Button();
            label4 = new Label();
            comboBoxTipoAnimal = new ComboBox();
            label5 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            label6 = new Label();
            pictureBoxFoto = new PictureBox();
            dgvAnimales = new DataGridView();
            btnRegistrarAnimal = new Button();
            txtHabitat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Común";
            // 
            // txtNombreComun
            // 
            txtNombreComun.Location = new Point(44, 52);
            txtNombreComun.Name = "txtNombreComun";
            txtNombreComun.Size = new Size(160, 23);
            txtNombreComun.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(45, 101);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Cientifico";
            // 
            // txtNombreCientifico
            // 
            txtNombreCientifico.Location = new Point(45, 128);
            txtNombreCientifico.Name = "txtNombreCientifico";
            txtNombreCientifico.Size = new Size(160, 23);
            txtNombreCientifico.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(45, 171);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Foto";
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.BackColor = Color.White;
            btnSeleccionarFoto.Location = new Point(55, 224);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(75, 23);
            btnSeleccionarFoto.TabIndex = 5;
            btnSeleccionarFoto.Text = "Agregar";
            btnSeleccionarFoto.UseVisualStyleBackColor = false;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(44, 376);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Familia";
            // 
            // comboBoxTipoAnimal
            // 
            comboBoxTipoAnimal.FormattingEnabled = true;
            comboBoxTipoAnimal.Items.AddRange(new object[] { "Mamífero", "Reptil", "Peces", "Artrópodos" });
            comboBoxTipoAnimal.Location = new Point(47, 412);
            comboBoxTipoAnimal.Name = "comboBoxTipoAnimal";
            comboBoxTipoAnimal.Size = new Size(121, 23);
            comboBoxTipoAnimal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(44, 466);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Habitat";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(588, 52);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(200, 23);
            dtpFechaRegistro.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(580, 24);
            label6.Name = "label6";
            label6.Size = new Size(208, 15);
            label6.TabIndex = 11;
            label6.Text = "Fecha de registro/ultima actualización";
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(147, 184);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(242, 153);
            pictureBoxFoto.TabIndex = 12;
            pictureBoxFoto.TabStop = false;
            // 
            // dgvAnimales
            // 
            dgvAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimales.Location = new Point(429, 128);
            dgvAnimales.Name = "dgvAnimales";
            dgvAnimales.RowTemplate.Height = 25;
            dgvAnimales.Size = new Size(738, 360);
            dgvAnimales.TabIndex = 13;
            // 
            // btnRegistrarAnimal
            // 
            btnRegistrarAnimal.Location = new Point(747, 517);
            btnRegistrarAnimal.Name = "btnRegistrarAnimal";
            btnRegistrarAnimal.Size = new Size(99, 30);
            btnRegistrarAnimal.TabIndex = 14;
            btnRegistrarAnimal.Text = "Enviar";
            btnRegistrarAnimal.UseVisualStyleBackColor = true;
            btnRegistrarAnimal.Click += btnRegistrarAnimal_Click;
            // 
            // txtHabitat
            // 
            txtHabitat.Location = new Point(44, 498);
            txtHabitat.Name = "txtHabitat";
            txtHabitat.Size = new Size(120, 23);
            txtHabitat.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1179, 649);
            Controls.Add(txtHabitat);
            Controls.Add(btnRegistrarAnimal);
            Controls.Add(dgvAnimales);
            Controls.Add(btnSeleccionarFoto);
            Controls.Add(pictureBoxFoto);
            Controls.Add(label6);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(label5);
            Controls.Add(comboBoxTipoAnimal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombreCientifico);
            Controls.Add(label2);
            Controls.Add(txtNombreComun);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreComun;
        private Label label2;
        private TextBox txtNombreCientifico;
        private Label label3;
        private Button btnSeleccionarFoto;
        private Label label4;
        private ComboBox comboBoxTipoAnimal;
        private Label label5;
        private DateTimePicker dtpFechaRegistro;
        private Label label6;
        private PictureBox pictureBoxFoto;
        private DataGridView dgvAnimales;
        private Button btnRegistrarAnimal;
        private TextBox txtHabitat;
    }
}