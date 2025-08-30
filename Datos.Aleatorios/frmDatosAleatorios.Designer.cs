namespace Datos.Aleatorios
{
    partial class frmDatosAleatorios
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
            label1 = new Label();
            Numero = new TextBox();
            Nombre = new TextBox();
            label2 = new Label();
            FechaNacimiento = new DateTimePicker();
            label3 = new Label();
            Masculino = new RadioButton();
            Femenino = new RadioButton();
            label4 = new Label();
            Grupo = new ComboBox();
            label5 = new Label();
            Sueldo = new TextBox();
            Seguro = new CheckBox();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // Numero
            // 
            Numero.Location = new Point(134, 48);
            Numero.Name = "Numero";
            Numero.Size = new Size(125, 27);
            Numero.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(134, 113);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(276, 27);
            Nombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 120);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Location = new Point(238, 176);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(287, 27);
            FechaNacimiento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 181);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha de nacimiento";
            // 
            // Masculino
            // 
            Masculino.AutoSize = true;
            Masculino.Location = new Point(255, 222);
            Masculino.Name = "Masculino";
            Masculino.Size = new Size(97, 24);
            Masculino.TabIndex = 6;
            Masculino.TabStop = true;
            Masculino.Text = "Masculino";
            Masculino.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            Femenino.AutoSize = true;
            Femenino.Location = new Point(255, 243);
            Femenino.Name = "Femenino";
            Femenino.Size = new Size(95, 24);
            Femenino.TabIndex = 7;
            Femenino.TabStop = true;
            Femenino.Text = "Femenino";
            Femenino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 279);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Grupo";
            // 
            // Grupo
            // 
            Grupo.FormattingEnabled = true;
            Grupo.Location = new Point(175, 276);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(151, 28);
            Grupo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 327);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 10;
            label5.Text = "Sueldo";
            // 
            // Sueldo
            // 
            Sueldo.Location = new Point(175, 324);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(151, 27);
            Sueldo.TabIndex = 11;
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(318, 367);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(132, 24);
            Seguro.TabIndex = 12;
            Seguro.Text = "Seguro Medico";
            Seguro.UseVisualStyleBackColor = true;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(255, 409);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(248, 29);
            btnPrueba.TabIndex = 13;
            btnPrueba.Text = "Generar datos aleatorios";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click_1;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrueba);
            Controls.Add(Seguro);
            Controls.Add(Sueldo);
            Controls.Add(label5);
            Controls.Add(Grupo);
            Controls.Add(label4);
            Controls.Add(Femenino);
            Controls.Add(Masculino);
            Controls.Add(label3);
            Controls.Add(FechaNacimiento);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(Numero);
            Controls.Add(label1);
            Name = "frmDatosAleatorios";
            Text = "frmDatosAleatorios";
            Load += frmDatosAleatorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Numero;
        private TextBox Nombre;
        private Label label2;
        private DateTimePicker FechaNacimiento;
        private Label label3;
        private RadioButton Masculino;
        private RadioButton Femenino;
        private Label label4;
        private ComboBox Grupo;
        private Label label5;
        private TextBox Sueldo;
        private CheckBox Seguro;
        private Button btnPrueba;
    }
}