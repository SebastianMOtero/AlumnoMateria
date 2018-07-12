namespace OTERO___POO___P2Alumnos
{
    partial class Form1
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lblAlumnoLegajo = new System.Windows.Forms.Label();
            this.txtAlumnoLegajo = new System.Windows.Forms.TextBox();
            this.txtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.lblAlumnoNombre = new System.Windows.Forms.Label();
            this.txtAlumnoApellido = new System.Windows.Forms.TextBox();
            this.lblAlumnoApellido = new System.Windows.Forms.Label();
            this.btnAñadirAlumno = new System.Windows.Forms.Button();
            this.lblMateriaCodigo = new System.Windows.Forms.Label();
            this.txtMateriaCodigo = new System.Windows.Forms.TextBox();
            this.txtMateriaDenominacion = new System.Windows.Forms.TextBox();
            this.lblMateriaDenominacion = new System.Windows.Forms.Label();
            this.cmbMateriaTipo = new System.Windows.Forms.ComboBox();
            this.lblMateriaTipo = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnAñadirMateria = new System.Windows.Forms.Button();
            this.btnAsignarMateria = new System.Windows.Forms.Button();
            this.dgvMateriasEnCurso = new System.Windows.Forms.DataGridView();
            this.lblMateriasEnCurso = new System.Windows.Forms.Label();
            this.btnColocarNota = new System.Windows.Forms.Button();
            this.dgvMateriasAprobadas = new System.Windows.Forms.DataGridView();
            this.dgvMateriasDesaprobadas = new System.Windows.Forms.DataGridView();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnPruebaAlumno = new System.Windows.Forms.Button();
            this.lblMateriasAprobadas = new System.Windows.Forms.Label();
            this.lblMateriasDesaprobadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasEnCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDesaprobadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(312, 47);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(360, 231);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // lblAlumnoLegajo
            // 
            this.lblAlumnoLegajo.AutoSize = true;
            this.lblAlumnoLegajo.Location = new System.Drawing.Point(31, 47);
            this.lblAlumnoLegajo.Name = "lblAlumnoLegajo";
            this.lblAlumnoLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblAlumnoLegajo.TabIndex = 1;
            this.lblAlumnoLegajo.Text = "Legajo";
            // 
            // txtAlumnoLegajo
            // 
            this.txtAlumnoLegajo.Location = new System.Drawing.Point(148, 47);
            this.txtAlumnoLegajo.Name = "txtAlumnoLegajo";
            this.txtAlumnoLegajo.Size = new System.Drawing.Size(100, 26);
            this.txtAlumnoLegajo.TabIndex = 2;
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(148, 90);
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(100, 26);
            this.txtAlumnoNombre.TabIndex = 4;
            // 
            // lblAlumnoNombre
            // 
            this.lblAlumnoNombre.AutoSize = true;
            this.lblAlumnoNombre.Location = new System.Drawing.Point(31, 90);
            this.lblAlumnoNombre.Name = "lblAlumnoNombre";
            this.lblAlumnoNombre.Size = new System.Drawing.Size(65, 20);
            this.lblAlumnoNombre.TabIndex = 3;
            this.lblAlumnoNombre.Text = "Nombre";
            // 
            // txtAlumnoApellido
            // 
            this.txtAlumnoApellido.Location = new System.Drawing.Point(148, 138);
            this.txtAlumnoApellido.Name = "txtAlumnoApellido";
            this.txtAlumnoApellido.Size = new System.Drawing.Size(100, 26);
            this.txtAlumnoApellido.TabIndex = 6;
            // 
            // lblAlumnoApellido
            // 
            this.lblAlumnoApellido.AutoSize = true;
            this.lblAlumnoApellido.Location = new System.Drawing.Point(31, 138);
            this.lblAlumnoApellido.Name = "lblAlumnoApellido";
            this.lblAlumnoApellido.Size = new System.Drawing.Size(65, 20);
            this.lblAlumnoApellido.TabIndex = 5;
            this.lblAlumnoApellido.Text = "Apellido";
            // 
            // btnAñadirAlumno
            // 
            this.btnAñadirAlumno.Location = new System.Drawing.Point(148, 192);
            this.btnAñadirAlumno.Name = "btnAñadirAlumno";
            this.btnAñadirAlumno.Size = new System.Drawing.Size(100, 57);
            this.btnAñadirAlumno.TabIndex = 7;
            this.btnAñadirAlumno.Text = "Añadir Alumno";
            this.btnAñadirAlumno.UseVisualStyleBackColor = true;
            this.btnAñadirAlumno.Click += new System.EventHandler(this.btnAñadirAlumno_Click);
            // 
            // lblMateriaCodigo
            // 
            this.lblMateriaCodigo.AutoSize = true;
            this.lblMateriaCodigo.Location = new System.Drawing.Point(743, 63);
            this.lblMateriaCodigo.Name = "lblMateriaCodigo";
            this.lblMateriaCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblMateriaCodigo.TabIndex = 8;
            this.lblMateriaCodigo.Text = "Codigo";
            // 
            // txtMateriaCodigo
            // 
            this.txtMateriaCodigo.Location = new System.Drawing.Point(854, 56);
            this.txtMateriaCodigo.Name = "txtMateriaCodigo";
            this.txtMateriaCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtMateriaCodigo.TabIndex = 9;
            // 
            // txtMateriaDenominacion
            // 
            this.txtMateriaDenominacion.Location = new System.Drawing.Point(854, 106);
            this.txtMateriaDenominacion.Name = "txtMateriaDenominacion";
            this.txtMateriaDenominacion.Size = new System.Drawing.Size(100, 26);
            this.txtMateriaDenominacion.TabIndex = 11;
            // 
            // lblMateriaDenominacion
            // 
            this.lblMateriaDenominacion.AutoSize = true;
            this.lblMateriaDenominacion.Location = new System.Drawing.Point(743, 96);
            this.lblMateriaDenominacion.Name = "lblMateriaDenominacion";
            this.lblMateriaDenominacion.Size = new System.Drawing.Size(111, 20);
            this.lblMateriaDenominacion.TabIndex = 10;
            this.lblMateriaDenominacion.Text = "Denominacion";
            // 
            // cmbMateriaTipo
            // 
            this.cmbMateriaTipo.FormattingEnabled = true;
            this.cmbMateriaTipo.Items.AddRange(new object[] {
            "Materia Basica",
            "Materia Especializada"});
            this.cmbMateriaTipo.Location = new System.Drawing.Point(854, 152);
            this.cmbMateriaTipo.Name = "cmbMateriaTipo";
            this.cmbMateriaTipo.Size = new System.Drawing.Size(121, 28);
            this.cmbMateriaTipo.TabIndex = 12;
            // 
            // lblMateriaTipo
            // 
            this.lblMateriaTipo.AutoSize = true;
            this.lblMateriaTipo.Location = new System.Drawing.Point(737, 158);
            this.lblMateriaTipo.Name = "lblMateriaTipo";
            this.lblMateriaTipo.Size = new System.Drawing.Size(39, 20);
            this.lblMateriaTipo.TabIndex = 13;
            this.lblMateriaTipo.Text = "Tipo";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(1010, 47);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(360, 231);
            this.dgvMaterias.TabIndex = 14;
            // 
            // btnAñadirMateria
            // 
            this.btnAñadirMateria.Location = new System.Drawing.Point(842, 207);
            this.btnAñadirMateria.Name = "btnAñadirMateria";
            this.btnAñadirMateria.Size = new System.Drawing.Size(100, 57);
            this.btnAñadirMateria.TabIndex = 15;
            this.btnAñadirMateria.Text = "Añadir Materia";
            this.btnAñadirMateria.UseVisualStyleBackColor = true;
            this.btnAñadirMateria.Click += new System.EventHandler(this.btnAñadirMateria_Click);
            // 
            // btnAsignarMateria
            // 
            this.btnAsignarMateria.Location = new System.Drawing.Point(664, 328);
            this.btnAsignarMateria.Name = "btnAsignarMateria";
            this.btnAsignarMateria.Size = new System.Drawing.Size(100, 57);
            this.btnAsignarMateria.TabIndex = 16;
            this.btnAsignarMateria.Text = "Asignar Materia";
            this.btnAsignarMateria.UseVisualStyleBackColor = true;
            this.btnAsignarMateria.Click += new System.EventHandler(this.btnAsignarMateria_Click);
            // 
            // dgvMateriasEnCurso
            // 
            this.dgvMateriasEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasEnCurso.Location = new System.Drawing.Point(58, 514);
            this.dgvMateriasEnCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMateriasEnCurso.MultiSelect = false;
            this.dgvMateriasEnCurso.Name = "dgvMateriasEnCurso";
            this.dgvMateriasEnCurso.ReadOnly = true;
            this.dgvMateriasEnCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasEnCurso.Size = new System.Drawing.Size(360, 231);
            this.dgvMateriasEnCurso.TabIndex = 17;
            // 
            // lblMateriasEnCurso
            // 
            this.lblMateriasEnCurso.AutoSize = true;
            this.lblMateriasEnCurso.Location = new System.Drawing.Point(54, 473);
            this.lblMateriasEnCurso.Name = "lblMateriasEnCurso";
            this.lblMateriasEnCurso.Size = new System.Drawing.Size(138, 20);
            this.lblMateriasEnCurso.TabIndex = 18;
            this.lblMateriasEnCurso.Text = "Materias en Curso";
            // 
            // btnColocarNota
            // 
            this.btnColocarNota.Location = new System.Drawing.Point(440, 514);
            this.btnColocarNota.Name = "btnColocarNota";
            this.btnColocarNota.Size = new System.Drawing.Size(100, 57);
            this.btnColocarNota.TabIndex = 19;
            this.btnColocarNota.Text = "Colocar Nota";
            this.btnColocarNota.UseVisualStyleBackColor = true;
            this.btnColocarNota.Click += new System.EventHandler(this.btnColocarNota_Click);
            // 
            // dgvMateriasAprobadas
            // 
            this.dgvMateriasAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAprobadas.Location = new System.Drawing.Point(582, 514);
            this.dgvMateriasAprobadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMateriasAprobadas.MultiSelect = false;
            this.dgvMateriasAprobadas.Name = "dgvMateriasAprobadas";
            this.dgvMateriasAprobadas.ReadOnly = true;
            this.dgvMateriasAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasAprobadas.Size = new System.Drawing.Size(360, 231);
            this.dgvMateriasAprobadas.TabIndex = 20;
            // 
            // dgvMateriasDesaprobadas
            // 
            this.dgvMateriasDesaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasDesaprobadas.Location = new System.Drawing.Point(1010, 514);
            this.dgvMateriasDesaprobadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMateriasDesaprobadas.MultiSelect = false;
            this.dgvMateriasDesaprobadas.Name = "dgvMateriasDesaprobadas";
            this.dgvMateriasDesaprobadas.ReadOnly = true;
            this.dgvMateriasDesaprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasDesaprobadas.Size = new System.Drawing.Size(360, 231);
            this.dgvMateriasDesaprobadas.TabIndex = 21;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(440, 591);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 26);
            this.txtNota.TabIndex = 22;
            // 
            // btnPruebaAlumno
            // 
            this.btnPruebaAlumno.Location = new System.Drawing.Point(384, 317);
            this.btnPruebaAlumno.Name = "btnPruebaAlumno";
            this.btnPruebaAlumno.Size = new System.Drawing.Size(182, 121);
            this.btnPruebaAlumno.TabIndex = 23;
            this.btnPruebaAlumno.Text = "Prueba";
            this.btnPruebaAlumno.UseVisualStyleBackColor = true;
            this.btnPruebaAlumno.Click += new System.EventHandler(this.btnPruebaAlumno_Click);
            // 
            // lblMateriasAprobadas
            // 
            this.lblMateriasAprobadas.AutoSize = true;
            this.lblMateriasAprobadas.Location = new System.Drawing.Point(578, 473);
            this.lblMateriasAprobadas.Name = "lblMateriasAprobadas";
            this.lblMateriasAprobadas.Size = new System.Drawing.Size(152, 20);
            this.lblMateriasAprobadas.TabIndex = 24;
            this.lblMateriasAprobadas.Text = "Materias Aprobadas";
            // 
            // lblMateriasDesaprobadas
            // 
            this.lblMateriasDesaprobadas.AutoSize = true;
            this.lblMateriasDesaprobadas.Location = new System.Drawing.Point(1006, 473);
            this.lblMateriasDesaprobadas.Name = "lblMateriasDesaprobadas";
            this.lblMateriasDesaprobadas.Size = new System.Drawing.Size(179, 20);
            this.lblMateriasDesaprobadas.TabIndex = 25;
            this.lblMateriasDesaprobadas.Text = "Materias Desaprobadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 812);
            this.Controls.Add(this.lblMateriasDesaprobadas);
            this.Controls.Add(this.lblMateriasAprobadas);
            this.Controls.Add(this.btnPruebaAlumno);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.dgvMateriasDesaprobadas);
            this.Controls.Add(this.dgvMateriasAprobadas);
            this.Controls.Add(this.btnColocarNota);
            this.Controls.Add(this.lblMateriasEnCurso);
            this.Controls.Add(this.dgvMateriasEnCurso);
            this.Controls.Add(this.btnAsignarMateria);
            this.Controls.Add(this.btnAñadirMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.lblMateriaTipo);
            this.Controls.Add(this.cmbMateriaTipo);
            this.Controls.Add(this.txtMateriaDenominacion);
            this.Controls.Add(this.lblMateriaDenominacion);
            this.Controls.Add(this.txtMateriaCodigo);
            this.Controls.Add(this.lblMateriaCodigo);
            this.Controls.Add(this.btnAñadirAlumno);
            this.Controls.Add(this.txtAlumnoApellido);
            this.Controls.Add(this.lblAlumnoApellido);
            this.Controls.Add(this.txtAlumnoNombre);
            this.Controls.Add(this.lblAlumnoNombre);
            this.Controls.Add(this.txtAlumnoLegajo);
            this.Controls.Add(this.lblAlumnoLegajo);
            this.Controls.Add(this.dgvAlumnos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasEnCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDesaprobadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblAlumnoLegajo;
        private System.Windows.Forms.TextBox txtAlumnoLegajo;
        private System.Windows.Forms.TextBox txtAlumnoNombre;
        private System.Windows.Forms.Label lblAlumnoNombre;
        private System.Windows.Forms.TextBox txtAlumnoApellido;
        private System.Windows.Forms.Label lblAlumnoApellido;
        private System.Windows.Forms.Button btnAñadirAlumno;
        private System.Windows.Forms.Label lblMateriaCodigo;
        private System.Windows.Forms.TextBox txtMateriaCodigo;
        private System.Windows.Forms.TextBox txtMateriaDenominacion;
        private System.Windows.Forms.Label lblMateriaDenominacion;
        private System.Windows.Forms.ComboBox cmbMateriaTipo;
        private System.Windows.Forms.Label lblMateriaTipo;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAñadirMateria;
        private System.Windows.Forms.Button btnAsignarMateria;
        private System.Windows.Forms.DataGridView dgvMateriasEnCurso;
        private System.Windows.Forms.Label lblMateriasEnCurso;
        private System.Windows.Forms.Button btnColocarNota;
        private System.Windows.Forms.DataGridView dgvMateriasAprobadas;
        private System.Windows.Forms.DataGridView dgvMateriasDesaprobadas;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnPruebaAlumno;
        private System.Windows.Forms.Label lblMateriasAprobadas;
        private System.Windows.Forms.Label lblMateriasDesaprobadas;
    }
}

