namespace EscuelaApp.VistasCarrera
{
    partial class IndexCarrera
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnEditarCarrera = new System.Windows.Forms.Button();
            this.BtnEliminarCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva Carrera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEditarCarrera
            // 
            this.BtnEditarCarrera.Location = new System.Drawing.Point(147, 61);
            this.BtnEditarCarrera.Name = "BtnEditarCarrera";
            this.BtnEditarCarrera.Size = new System.Drawing.Size(78, 23);
            this.BtnEditarCarrera.TabIndex = 2;
            this.BtnEditarCarrera.Text = "Editar carrera";
            this.BtnEditarCarrera.UseVisualStyleBackColor = true;
            this.BtnEditarCarrera.Click += new System.EventHandler(this.BtnEditarCarrera_Click);
            // 
            // BtnEliminarCarrera
            // 
            this.BtnEliminarCarrera.Location = new System.Drawing.Point(261, 61);
            this.BtnEliminarCarrera.Name = "BtnEliminarCarrera";
            this.BtnEliminarCarrera.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarCarrera.TabIndex = 3;
            this.BtnEliminarCarrera.Text = "Eliminar carrera";
            this.BtnEliminarCarrera.UseVisualStyleBackColor = true;
            this.BtnEliminarCarrera.Click += new System.EventHandler(this.BtnEliminarCarrera_Click);
            // 
            // IndexCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminarCarrera);
            this.Controls.Add(this.BtnEditarCarrera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IndexCarrera";
            this.Text = "IndexCarrera";
            this.Activated += new System.EventHandler(this.IndexCarrera_Activated);
            this.Load += new System.EventHandler(this.IndexCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnEditarCarrera;
        private System.Windows.Forms.Button BtnEliminarCarrera;
    }
}