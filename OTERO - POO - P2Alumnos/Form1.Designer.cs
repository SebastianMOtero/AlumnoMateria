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
            this.btnPromMateriasAprob = new System.Windows.Forms.Button();
            this.btnPromedioGeneral = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblListaAlumnos = new System.Windows.Forms.Label();
            this.lblListaDeMaterias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasEnCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDesaprobadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(230, 49);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(286, 201);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // lblAlumnoLegajo
            // 
            this.lblAlumnoLegajo.AutoSize = true;
            this.lblAlumnoLegajo.Location = new System.Drawing.Point(21, 54);
            this.lblAlumnoLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumnoLegajo.Name = "lblAlumnoLegajo";
            this.lblAlumnoLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblAlumnoLegajo.TabIndex = 1;
            this.lblAlumnoLegajo.Text = "Legajo";
            // 
            // txtAlumnoLegajo
            // 
            this.txtAlumnoLegajo.Location = new System.Drawing.Point(102, 51);
            this.txtAlumnoLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlumnoLegajo.MaxLength = 4;
            this.txtAlumnoLegajo.Name = "txtAlumnoLegajo";
            this.txtAlumnoLegajo.Size = new System.Drawing.Size(107, 20);
            this.txtAlumnoLegajo.TabIndex = 2;
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(102, 90);
            this.txtAlumnoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlumnoNombre.MaxLength = 15;
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(107, 20);
            this.txtAlumnoNombre.TabIndex = 4;
            // 
            // lblAlumnoNombre
            // 
            this.lblAlumnoNombre.AutoSize = true;
            this.lblAlumnoNombre.Location = new System.Drawing.Point(21, 93);
            this.lblAlumnoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumnoNombre.Name = "lblAlumnoNombre";
            this.lblAlumnoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoNombre.TabIndex = 3;
            this.lblAlumnoNombre.Text = "Nombre";
            // 
            // txtAlumnoApellido
            // 
            this.txtAlumnoApellido.Location = new System.Drawing.Point(102, 125);
            this.txtAlumnoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlumnoApellido.MaxLength = 15;
            this.txtAlumnoApellido.Name = "txtAlumnoApellido";
            this.txtAlumnoApellido.Size = new System.Drawing.Size(107, 20);
            this.txtAlumnoApellido.TabIndex = 6;
            // 
            // lblAlumnoApellido
            // 
            this.lblAlumnoApellido.AutoSize = true;
            this.lblAlumnoApellido.Location = new System.Drawing.Point(21, 128);
            this.lblAlumnoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumnoApellido.Name = "lblAlumnoApellido";
            this.lblAlumnoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoApellido.TabIndex = 5;
            this.lblAlumnoApellido.Text = "Apellido";
            // 
            // btnAñadirAlumno
            // 
            this.btnAñadirAlumno.Location = new System.Drawing.Point(121, 174);
            this.btnAñadirAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirAlumno.Name = "btnAñadirAlumno";
            this.btnAñadirAlumno.Size = new System.Drawing.Size(88, 46);
            this.btnAñadirAlumno.TabIndex = 7;
            this.btnAñadirAlumno.Text = "Añadir Alumno";
            this.btnAñadirAlumno.UseVisualStyleBackColor = true;
            this.btnAñadirAlumno.Click += new System.EventHandler(this.btnAñadirAlumno_Click);
            // 
            // lblMateriaCodigo
            // 
            this.lblMateriaCodigo.AutoSize = true;
            this.lblMateriaCodigo.Location = new System.Drawing.Point(543, 54);
            this.lblMateriaCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaCodigo.Name = "lblMateriaCodigo";
            this.lblMateriaCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblMateriaCodigo.TabIndex = 8;
            this.lblMateriaCodigo.Text = "Codigo";
            // 
            // txtMateriaCodigo
            // 
            this.txtMateriaCodigo.Location = new System.Drawing.Point(628, 51);
            this.txtMateriaCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMateriaCodigo.MaxLength = 4;
            this.txtMateriaCodigo.Name = "txtMateriaCodigo";
            this.txtMateriaCodigo.Size = new System.Drawing.Size(107, 20);
            this.txtMateriaCodigo.TabIndex = 9;
            // 
            // txtMateriaDenominacion
            // 
            this.txtMateriaDenominacion.Location = new System.Drawing.Point(628, 90);
            this.txtMateriaDenominacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtMateriaDenominacion.MaxLength = 20;
            this.txtMateriaDenominacion.Name = "txtMateriaDenominacion";
            this.txtMateriaDenominacion.Size = new System.Drawing.Size(107, 20);
            this.txtMateriaDenominacion.TabIndex = 11;
            // 
            // lblMateriaDenominacion
            // 
            this.lblMateriaDenominacion.AutoSize = true;
            this.lblMateriaDenominacion.Location = new System.Drawing.Point(543, 93);
            this.lblMateriaDenominacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaDenominacion.Name = "lblMateriaDenominacion";
            this.lblMateriaDenominacion.Size = new System.Drawing.Size(75, 13);
            this.lblMateriaDenominacion.TabIndex = 10;
            this.lblMateriaDenominacion.Text = "Denominacion";
            // 
            // cmbMateriaTipo
            // 
            this.cmbMateriaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaTipo.FormattingEnabled = true;
            this.cmbMateriaTipo.Items.AddRange(new object[] {
            "Materia Basica",
            "Materia Especializada"});
            this.cmbMateriaTipo.Location = new System.Drawing.Point(628, 125);
            this.cmbMateriaTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMateriaTipo.Name = "cmbMateriaTipo";
            this.cmbMateriaTipo.Size = new System.Drawing.Size(107, 21);
            this.cmbMateriaTipo.TabIndex = 12;
            // 
            // lblMateriaTipo
            // 
            this.lblMateriaTipo.AutoSize = true;
            this.lblMateriaTipo.Location = new System.Drawing.Point(543, 128);
            this.lblMateriaTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriaTipo.Name = "lblMateriaTipo";
            this.lblMateriaTipo.Size = new System.Drawing.Size(28, 13);
            this.lblMateriaTipo.TabIndex = 13;
            this.lblMateriaTipo.Text = "Tipo";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(763, 49);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(286, 201);
            this.dgvMaterias.TabIndex = 14;
            // 
            // btnAñadirMateria
            // 
            this.btnAñadirMateria.Location = new System.Drawing.Point(648, 174);
            this.btnAñadirMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirMateria.Name = "btnAñadirMateria";
            this.btnAñadirMateria.Size = new System.Drawing.Size(87, 46);
            this.btnAñadirMateria.TabIndex = 15;
            this.btnAñadirMateria.Text = "Añadir Materia";
            this.btnAñadirMateria.UseVisualStyleBackColor = true;
            this.btnAñadirMateria.Click += new System.EventHandler(this.btnAñadirMateria_Click);
            // 
            // btnAsignarMateria
            // 
            this.btnAsignarMateria.Location = new System.Drawing.Point(570, 290);
            this.btnAsignarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarMateria.Name = "btnAsignarMateria";
            this.btnAsignarMateria.Size = new System.Drawing.Size(120, 46);
            this.btnAsignarMateria.TabIndex = 16;
            this.btnAsignarMateria.Text = "Asignar Materia";
            this.btnAsignarMateria.UseVisualStyleBackColor = true;
            this.btnAsignarMateria.Click += new System.EventHandler(this.btnAsignarMateria_Click);
            // 
            // dgvMateriasEnCurso
            // 
            this.dgvMateriasEnCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasEnCurso.Location = new System.Drawing.Point(12, 396);
            this.dgvMateriasEnCurso.MultiSelect = false;
            this.dgvMateriasEnCurso.Name = "dgvMateriasEnCurso";
            this.dgvMateriasEnCurso.ReadOnly = true;
            this.dgvMateriasEnCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasEnCurso.Size = new System.Drawing.Size(286, 201);
            this.dgvMateriasEnCurso.TabIndex = 17;
            // 
            // lblMateriasEnCurso
            // 
            this.lblMateriasEnCurso.AutoSize = true;
            this.lblMateriasEnCurso.Location = new System.Drawing.Point(11, 369);
            this.lblMateriasEnCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriasEnCurso.Name = "lblMateriasEnCurso";
            this.lblMateriasEnCurso.Size = new System.Drawing.Size(92, 13);
            this.lblMateriasEnCurso.TabIndex = 18;
            this.lblMateriasEnCurso.Text = "Materias en Curso";
            // 
            // btnColocarNota
            // 
            this.btnColocarNota.Location = new System.Drawing.Point(318, 478);
            this.btnColocarNota.Margin = new System.Windows.Forms.Padding(2);
            this.btnColocarNota.Name = "btnColocarNota";
            this.btnColocarNota.Size = new System.Drawing.Size(118, 61);
            this.btnColocarNota.TabIndex = 19;
            this.btnColocarNota.Text = "Colocar Nota";
            this.btnColocarNota.UseVisualStyleBackColor = true;
            this.btnColocarNota.Click += new System.EventHandler(this.btnColocarNota_Click);
            // 
            // dgvMateriasAprobadas
            // 
            this.dgvMateriasAprobadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAprobadas.Location = new System.Drawing.Point(461, 396);
            this.dgvMateriasAprobadas.MultiSelect = false;
            this.dgvMateriasAprobadas.Name = "dgvMateriasAprobadas";
            this.dgvMateriasAprobadas.ReadOnly = true;
            this.dgvMateriasAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasAprobadas.Size = new System.Drawing.Size(286, 201);
            this.dgvMateriasAprobadas.TabIndex = 20;
            // 
            // dgvMateriasDesaprobadas
            // 
            this.dgvMateriasDesaprobadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriasDesaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasDesaprobadas.Location = new System.Drawing.Point(798, 396);
            this.dgvMateriasDesaprobadas.MultiSelect = false;
            this.dgvMateriasDesaprobadas.Name = "dgvMateriasDesaprobadas";
            this.dgvMateriasDesaprobadas.ReadOnly = true;
            this.dgvMateriasDesaprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasDesaprobadas.Size = new System.Drawing.Size(286, 201);
            this.dgvMateriasDesaprobadas.TabIndex = 21;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(318, 436);
            this.txtNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(118, 20);
            this.txtNota.TabIndex = 22;
            // 
            // btnPruebaAlumno
            // 
            this.btnPruebaAlumno.Location = new System.Drawing.Point(446, 290);
            this.btnPruebaAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.btnPruebaAlumno.Name = "btnPruebaAlumno";
            this.btnPruebaAlumno.Size = new System.Drawing.Size(120, 46);
            this.btnPruebaAlumno.TabIndex = 23;
            this.btnPruebaAlumno.Text = "Prueba";
            this.btnPruebaAlumno.UseVisualStyleBackColor = true;
            this.btnPruebaAlumno.Click += new System.EventHandler(this.btnPruebaAlumno_Click);
            // 
            // lblMateriasAprobadas
            // 
            this.lblMateriasAprobadas.AutoSize = true;
            this.lblMateriasAprobadas.Location = new System.Drawing.Point(458, 369);
            this.lblMateriasAprobadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriasAprobadas.Name = "lblMateriasAprobadas";
            this.lblMateriasAprobadas.Size = new System.Drawing.Size(101, 13);
            this.lblMateriasAprobadas.TabIndex = 24;
            this.lblMateriasAprobadas.Text = "Materias Aprobadas";
            // 
            // lblMateriasDesaprobadas
            // 
            this.lblMateriasDesaprobadas.AutoSize = true;
            this.lblMateriasDesaprobadas.Location = new System.Drawing.Point(795, 369);
            this.lblMateriasDesaprobadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateriasDesaprobadas.Name = "lblMateriasDesaprobadas";
            this.lblMateriasDesaprobadas.Size = new System.Drawing.Size(119, 13);
            this.lblMateriasDesaprobadas.TabIndex = 25;
            this.lblMateriasDesaprobadas.Text = "Materias Desaprobadas";
            // 
            // btnPromMateriasAprob
            // 
            this.btnPromMateriasAprob.Location = new System.Drawing.Point(198, 290);
            this.btnPromMateriasAprob.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromMateriasAprob.Name = "btnPromMateriasAprob";
            this.btnPromMateriasAprob.Size = new System.Drawing.Size(120, 46);
            this.btnPromMateriasAprob.TabIndex = 26;
            this.btnPromMateriasAprob.Text = "Promedio de Materias Aprobadas";
            this.btnPromMateriasAprob.UseVisualStyleBackColor = true;
            this.btnPromMateriasAprob.Click += new System.EventHandler(this.btnPromMateriasAprob_Click);
            // 
            // btnPromedioGeneral
            // 
            this.btnPromedioGeneral.Location = new System.Drawing.Point(74, 290);
            this.btnPromedioGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromedioGeneral.Name = "btnPromedioGeneral";
            this.btnPromedioGeneral.Size = new System.Drawing.Size(120, 46);
            this.btnPromedioGeneral.TabIndex = 27;
            this.btnPromedioGeneral.Text = "Promedio General";
            this.btnPromedioGeneral.UseVisualStyleBackColor = true;
            this.btnPromedioGeneral.Click += new System.EventHandler(this.btnPromedioGeneral_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(15, 174);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(88, 46);
            this.btnEliminarAlumno.TabIndex = 28;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(546, 174);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(87, 46);
            this.btnEliminarMateria.TabIndex = 29;
            this.btnEliminarMateria.Text = "Eliminar Materia";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(322, 290);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(120, 46);
            this.btnOrdenar.TabIndex = 30;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Location = new System.Drawing.Point(227, 21);
            this.lblListaAlumnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(87, 13);
            this.lblListaAlumnos.TabIndex = 31;
            this.lblListaAlumnos.Text = "Lista de Alumnos";
            // 
            // lblListaDeMaterias
            // 
            this.lblListaDeMaterias.AutoSize = true;
            this.lblListaDeMaterias.Location = new System.Drawing.Point(760, 21);
            this.lblListaDeMaterias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaDeMaterias.Name = "lblListaDeMaterias";
            this.lblListaDeMaterias.Size = new System.Drawing.Size(87, 13);
            this.lblListaDeMaterias.TabIndex = 32;
            this.lblListaDeMaterias.Text = "Lista de Materias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 609);
            this.Controls.Add(this.lblListaDeMaterias);
            this.Controls.Add(this.lblListaAlumnos);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnPromedioGeneral);
            this.Controls.Add(this.btnPromMateriasAprob);
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
            this.Name = "Form1";
            this.Text = "Universidad";
            this.Click += new System.EventHandler(this.Form1_Click);
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
        private System.Windows.Forms.Button btnPromMateriasAprob;
        private System.Windows.Forms.Button btnPromedioGeneral;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Label lblListaDeMaterias;
    }
}

