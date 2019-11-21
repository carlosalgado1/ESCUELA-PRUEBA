namespace EscuelaApp.VistasAlumno
{
    partial class NuevoAlumno
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnNombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCarrera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // BtnNombre
            // 
            this.BtnNombre.AutoSize = true;
            this.BtnNombre.Location = new System.Drawing.Point(33, 13);
            this.BtnNombre.Name = "BtnNombre";
            this.BtnNombre.Size = new System.Drawing.Size(44, 13);
            this.BtnNombre.TabIndex = 1;
            this.BtnNombre.Text = "Nombre";
            this.BtnNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // BtnCarrera
            // 
            this.BtnCarrera.AutoSize = true;
            this.BtnCarrera.Location = new System.Drawing.Point(36, 212);
            this.BtnCarrera.Name = "BtnCarrera";
            this.BtnCarrera.Size = new System.Drawing.Size(41, 13);
            this.BtnCarrera.TabIndex = 3;
            this.BtnCarrera.Text = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido Paterno";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(33, 80);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(218, 20);
            this.txtApePat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido Materno";
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(33, 124);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(218, 20);
            this.txtApeMat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Location = new System.Drawing.Point(36, 270);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crear.TabIndex = 10;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(175, 270);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 311);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApePat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCarrera);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "NuevoAlumno";
            this.Text = "NuevoAlumno";
            this.Load += new System.EventHandler(this.NuevoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label BtnNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BtnCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Button BtnCancelar;
    }
}