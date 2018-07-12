namespace OTERO___POO___P2Alumnos
{
    partial class FormAsignarMateria
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
            this.btnSeleccionarMateria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbMateriasImpartidas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSeleccionarMateria
            // 
            this.btnSeleccionarMateria.Location = new System.Drawing.Point(494, 98);
            this.btnSeleccionarMateria.Name = "btnSeleccionarMateria";
            this.btnSeleccionarMateria.Size = new System.Drawing.Size(150, 85);
            this.btnSeleccionarMateria.TabIndex = 0;
            this.btnSeleccionarMateria.Text = "Seleccionar Materia";
            this.btnSeleccionarMateria.UseVisualStyleBackColor = true;
            this.btnSeleccionarMateria.Click += new System.EventHandler(this.btnSeleccionarMateria_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(494, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 62);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbMateriasImpartidas
            // 
            this.cmbMateriasImpartidas.FormattingEnabled = true;
            this.cmbMateriasImpartidas.Location = new System.Drawing.Point(118, 124);
            this.cmbMateriasImpartidas.Name = "cmbMateriasImpartidas";
            this.cmbMateriasImpartidas.Size = new System.Drawing.Size(244, 28);
            this.cmbMateriasImpartidas.TabIndex = 2;
            // 
            // FormAsignarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMateriasImpartidas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarMateria);
            this.Name = "FormAsignarMateria";
            this.Text = "FormAsignarMateria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarMateria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbMateriasImpartidas;
    }
}