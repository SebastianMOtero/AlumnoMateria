using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace OTERO___POO___P2Alumnos
{
    public partial class Form1 : Form
    {
        #region "Constructor"
        public Form1()
        {
            InitializeComponent();
            universidad = new ClaseUniversidad();
            cmbMateriaTipo.SelectedIndex = 0;
        }
        #endregion

        //Crea universidad
        public ClaseUniversidad universidad;

        #region "Metodos"
        //Método para determinar si ya existe el alumno a ingresar en la universidad(utilizando LINQ).
        public int ExisteAlumno(int pNuevoLegajo)
        {
            //Origen de los datos, la lista de alumnos inscriptos
            ClaseAlumno[] alumnosInscriptos = universidad.AlumnosQueCursan;

            //Creación de la consulta, compara cada legajo de alumno, con el nuevo legajo.
            IEnumerable<ClaseAlumno> legajoQuery = from alumno in alumnosInscriptos
                                                   where (alumno.Legajo == pNuevoLegajo)
                                                   select alumno;

            //Ejecuta la consulta, en caso de encontrar legajo retorna 1
            foreach (ClaseAlumno alu in legajoQuery)
            {
                return 1;
            }

            //En caso de no existir legajo, retorna 0
            return 0;
        }

        //Método para actualizar un DataGridView, recibe cual DGV quiere actualizar y con que objetos
        private void ActualizarDGV(DataGridView pDGV, object pObject)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pObject;
        }

        //Método que analiza si un alumno se esta inscribiendo en una materia que ya se encuentra en una de sus listas de materia
        public bool PuedeCursar(Array pListaMaterias, ClaseMateria pMateria)
        {
            //Comprueba el codigo de cada materia de una lista con la materia a la que se quiere anotar
            foreach (ClaseMateria C in pListaMaterias)
            {
                if (C.Codigo == pMateria.Codigo)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region "Botones"
        //Boton para añadir un alumno a la universidad
        private void btnAñadirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                //Controla si se ingreso algún valor en el legajo
                if (txtAlumnoLegajo.Text == "")
                {
                    throw new Exception("Ingrese legajo.");
                }

                //Controla si el legajo ya existe, utilizando consula LINQ
                if (ExisteAlumno(Convert.ToInt32(txtAlumnoLegajo.Text)) == 1)
                {
                    throw new Exception("Ya existe un alumno con este legajo.");
                }

                //Controla si el nombre ingresado tiene mas de 3 caracteres
                if (txtAlumnoNombre.Text.Count() < 3)
                {
                    throw new Exception("Ingrese un nombre con 3 caracteres mínimo.");
                }

                //Controla si el apellido ingresado tiene mas de 3 caracteres
                if (txtAlumnoApellido.Text.Count() < 3)
                {
                    throw new Exception("Ingrese un apellido con 3 caracteres mínimo.");
                }

                //Declara alumno
                ClaseAlumno Alumno;

                //Almacena los datos ingresados en variables
                int legajo = Convert.ToInt32(txtAlumnoLegajo.Text);
                string nombre = txtAlumnoNombre.Text.ToString();
                string apellido = txtAlumnoApellido.Text.ToString();

                //Crea alumno con los datos en variables
                Alumno = new ClaseAlumno(legajo, nombre, apellido);

                //Suscribe al alumno a el evento "promedio alto"
                Alumno.EventoPromedioAlto += FuncionEventoPromedioAlto;

                //Se agrega el alumno a la lista de alumnos de la universidad
                universidad.AgregarAlumno(Alumno);
                //Se ordenan alfabeticamente
                universidad.OrdenarAlfabeticamente();
                //Se actualiza el DataGridView
                ActualizarDGV(dgvAlumnos, universidad.AlumnosQueCursan);
                //Se borra los textbox con los datos ingresados
                txtAlumnoLegajo.Clear();
                txtAlumnoNombre.Clear();
                txtAlumnoApellido.Clear();
            }
            catch (Exception ex)
            {
                //en caso de Error, muestra el mensaje correspondiente
                MessageBox.Show(ex.Message, "¡ERROR!");
            }
        }

        //Botón para añadir una materia a la universidad
        private void btnAñadirMateria_Click(object sender, EventArgs e)
        {
            try
            {
                //Controla si se ingreso algún texto en el codigo de materia.
                if (txtMateriaCodigo.Text == "")
                {
                    throw new Exception("Ingrese codigo");
                }

                //Controla si la denominacion ingresada tiene mas de 3 caracteres
                if (txtMateriaDenominacion.Text.Count() < 4)
                {
                    throw new Exception("Ingrese denominacion");
                }

                //Declara la materia
                ClaseMateria Materia;

                //Almacena variables de los valores ingresados
                int codigo = Convert.ToInt32(txtMateriaCodigo.Text);
                string denominacion = txtMateriaDenominacion.Text;

                //Crea la materia según se haya elegido básica o especializada (por medio de un combobox).
                if (cmbMateriaTipo.SelectedIndex == 0)
                {
                    Materia = new ClaseMateriaBasica(codigo, denominacion);
                }
                else
                {
                    Materia = new ClaseMateriaEspecializada(codigo, denominacion);
                }

                //Agrega la materia a la universidad
                universidad.AgregarMateria(Materia);

                //Actualiza el DataGridView
                ActualizarDGV(dgvMaterias, universidad.MateriasImpartidas);

                //Borra los TextBox con los valores ingresados respecto a la materia nueva.
                txtMateriaCodigo.Clear();
                txtMateriaDenominacion.Clear();
                cmbMateriaTipo.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                //En caso de error muestra el mensaje correspondiente.
                MessageBox.Show(ex.Message, "¡ERROR¡");
            }
        }

        //Botón para asignar una materia a un alumno
        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                //En caso de no existir aun datos de alumnos
                if ( dgvAlumnos.Rows.Count == 0)
                {
                    throw new Exception("Ingrese alumno.");
                }
                //En caso de no estar seleccionado un alumno
                if (dgvAlumnos.SelectedRows.Count < 1 )
                {
                    throw new Exception("Seleccione alumno.");
                }
                //En caso de no existir aun datos de materias
                if (dgvMaterias.Rows.Count == 0)
                {
                    throw new Exception("Ingrese materias.");
                }
                //En caso de no estar seleccionada una materia
                if (dgvMaterias.SelectedRows.Count < 1)
                {
                    throw new Exception("Seleccione materia.");
                }

                //Crea alumno y materia, según lo seleccionado en los DataGridView
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
                ClaseMateria Materia = (ClaseMateria)(dgvMaterias.SelectedRows[0].DataBoundItem);

                //Comprobar si ya esta cursando la materia
                if (!PuedeCursar(Alumno.MateriasEnCurso, Materia))
                {
                    throw new Exception("Ya esta cursando esta materia.");
                }

                //Comprobar si ya aprobo esa materia
                if (!PuedeCursar(Alumno.MateriasAprobadas, Materia))
                {
                    throw new Exception("Ya curso y aprobo esta materia.");
                }

                //Comprobar si ya esta cursando una materia especializada
                if (Materia.GetType().Equals(typeof(ClaseMateriaEspecializada)))
                {
                    foreach (ClaseMateria C in Alumno.MateriasEnCurso)
                    {
                        if (C.GetType() == typeof(ClaseMateriaEspecializada))
                        {
                            throw new Exception("Ya esta cursando una especializada");
                        }   
                    }
                }

                //Almacena los datos de la materia en variables
                int codigo = Materia.Codigo;
                string denominacion = Materia.Denominacion;

                //Crea un nuevo objeto con los datos obtenidos de la materia seleccionada, 
                //para asociar al alumno
                if (Materia.GetType().Equals(typeof(ClaseMateriaBasica)))
                {
                    ClaseMateria MateriaAsignada = new ClaseMateriaBasica(codigo,denominacion);
                    Alumno.AsignarMateria(MateriaAsignada);
                }
                else
                {
                    ClaseMateria MateriaAsignada = new ClaseMateriaEspecializada(codigo,denominacion);
                    Alumno.AsignarMateria(MateriaAsignada);
                }

                //Actualiza el DataGridView de las materias cursadas actualmente por el alumno
                ActualizarDGV(dgvMateriasEnCurso, Alumno.MateriasEnCurso);
            }
            catch (Exception ex)
            {
                //En caso de error, muestra el mensaje correspondiente
                MessageBox.Show(ex.Message, "¡ERROR!");
            }
        }

        //Boton para eliminar un alumno de la universidad
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtiene el alumno seleccionado de la lista
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
                //Ejecuta el metood eliminar alumno
                universidad.EliminarAlumno(Alumno);
                //Ordena alfabeticamente los alumnos
                universidad.OrdenarAlfabeticamente(); 
                //Actualiza la nueva lista de alumnos
                ActualizarDGV(dgvAlumnos, universidad.AlumnosQueCursan);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un alumno para eliminar", "¡ERROR!");
            }
        }

        //Boton para eliminar una materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            try 
            {
                //Obtiene la materia seleccionada
                ClaseMateria Materia = (ClaseMateria)(dgvMaterias.SelectedRows[0].DataBoundItem);
                //Ejecuta el metodo eliminar materia
                universidad.EliminarMateria(Materia);
                //Actualiza la nueva lista de materias
                ActualizarDGV(dgvMaterias, universidad.MateriasImpartidas);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una materia para eliminar", "¡ERROR!");
            }
        }
        
        //Boton que muestra el promedio general de un alumno
        private void btnPromedioGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null)
                {
                    throw new Exception("Seleccione un alumno de la lista.");
                }
                //Obtiene el alumno de la lista
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);

                //Ejecuta el metodo que calcula el promedio general
                decimal promedio = Alumno.PromedioGeneral();

                //Muestra el promedio por medio de un MessageBox
                MessageBox.Show(promedio.ToString());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "¡ERROR!");
            }
        }

        //Boton para generar 5 alumnos y 5 materias automaticamente.
        private void btnPruebaAlumno_Click(object sender, EventArgs e)
        {
            ClaseAlumno Alumno = new ClaseAlumno(1, "Sebastian", "Otero");
            ClaseAlumno Alumno1 = new ClaseAlumno(2, "Roberto", "Velez");
            ClaseAlumno Alumno2 = new ClaseAlumno(3, "Emilia", "Galea");
            ClaseAlumno Alumno3 = new ClaseAlumno(4, "Juan Cruz", "Yrigoyen");
            ClaseAlumno Alumno4 = new ClaseAlumno(5, "Hernan", "Lacroze");
            Alumno.EventoPromedioAlto += FuncionEventoPromedioAlto;
            Alumno1.EventoPromedioAlto += FuncionEventoPromedioAlto;
            Alumno2.EventoPromedioAlto += FuncionEventoPromedioAlto;
            Alumno3.EventoPromedioAlto += FuncionEventoPromedioAlto;
            Alumno4.EventoPromedioAlto += FuncionEventoPromedioAlto;
            universidad.AgregarAlumno(Alumno);
            universidad.AgregarAlumno(Alumno1);
            universidad.AgregarAlumno(Alumno2);
            universidad.AgregarAlumno(Alumno3);
            universidad.AgregarAlumno(Alumno4);
            universidad.OrdenarAlfabeticamente();
            ActualizarDGV(dgvAlumnos, universidad.AlumnosQueCursan);

            ClaseMateria Materia = new ClaseMateriaBasica(1, "Matematicas");
            ClaseMateria Materia1 = new ClaseMateriaBasica(2, "Literatura");
            ClaseMateria Materia2 = new ClaseMateriaEspecializada(3, "Quimica Organica");
            ClaseMateria Materia3 = new ClaseMateriaBasica(4, "Fisica");
            ClaseMateria Materia4 = new ClaseMateriaEspecializada(5, "Telecomunicaciones");

            universidad.AgregarMateria(Materia);
            universidad.AgregarMateria(Materia1);
            universidad.AgregarMateria(Materia2);
            universidad.AgregarMateria(Materia3);
            universidad.AgregarMateria(Materia4);
            ActualizarDGV(dgvMaterias, universidad.MateriasImpartidas);
            btnPruebaAlumno.Enabled = false;
        }

        //Boton para calcular el promedio de materias aprobadas (Solo tiene en cuenta materias con nota)
        private void btnPromMateriasAprob_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprueba si existe un alumno seleccionado
                if (dgvAlumnos.CurrentRow == null)
                {
                    throw new Exception("Seleccione un alumno para conocer el promedio");
                }
                //Obtiene el alumno seleccionado del DGV
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
                //Ejecuta el metodo de promedio de materias aprobadas
                decimal promedio = Alumno.PromedioDeMateriasAprobadas();
                //En caso de tener 0 materias, el propio metodo lanza un mensaje de error
                //Muestra el promedio
                MessageBox.Show("El/La alumno/a "+Alumno.Nombre+" "+Alumno.Apellido+" tiene el "+promedio.ToString()+" % de materias aprobadas.","PROMEDIO.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "¡ERROR!");
            }
        }
        #endregion

        #region "Eventos"
        //Evento al seleccionar un alumno de la lista de alumnos
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el alumno seleccionado y actualiza los DGV de sus materias
            ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
            ActualizarDGV(dgvMateriasEnCurso, Alumno.MateriasEnCurso);
            ActualizarDGV(dgvMateriasAprobadas, Alumno.MateriasAprobadas);
            ActualizarDGV(dgvMateriasDesaprobadas, Alumno.MateriasDesaprobadas);

        }

        //Evento al clickear sobre la interfaz del programa
        private void Form1_Click(object sender, EventArgs e)
        {
            //Borra la seleccion de los DGV alumno y materia y borra los datos de los otros DGV
            dgvAlumnos.ClearSelection();
            dgvMaterias.ClearSelection();
            dgvMateriasAprobadas.DataSource = null;
            dgvMateriasDesaprobadas.DataSource = null;
            dgvMateriasEnCurso.DataSource = null;
        }
        #endregion


        //eVENTO PERSONALIZADO
        private void FuncionEventoPromedioAlto(object sender, EventoPromedioAltoEventsArgs e)
        {
            try
            {
                MessageBox.Show(e.Legajo + " " + e.Nombre + " " + e.Apellido + " " + e.Promedio + " ");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Boton para colocar nota a un alumno en una determinada materia cursada
        private void btnColocarNota_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprueba si hay un alumno seleccionado
                if (dgvAlumnos.CurrentRow == null)
                {
                    throw new Exception("Seleccione un alumno de la lista de alumnos.");
                }
                //Obtiene el alumno seleccionado de la lista
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
                //Comprueba si hay una materia en curso seleccionada
                if (dgvMateriasEnCurso.CurrentRow == null)
                {
                    throw new Exception("Seleccione una materia de la lista de materias.");
                }
                //Obtiene la materia
                ClaseMateria Materia = (ClaseMateria)(dgvMateriasEnCurso.SelectedRows[0].DataBoundItem);
                //Comprueba si ingreso algo en el txtbox
                if (txtNota.Text == "")
                {
                    txtNota.Focus();
                    throw new Exception("Ingrese una nota entre 0 y 10");
                }
                //Almacena la nota ingresada
                decimal nota = Convert.ToDecimal(txtNota.Text.ToString());
                //Comprueba si la nota se encuentra entre 0 y 10
                if (nota <= 0 || nota > 10)
                {
                    throw new Exception("Solo se permiten notas entre 0 y 10.");
                }
                //Almacena la nota
                Materia.Nota = nota;
                //finaliza la materia
                Alumno.FinalizarMateria(Materia);
                dgvAlumnos_CellClick(null, null);
                txtNota.Clear();

             }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "¡ERROR!");
            }   
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (universidad.AlumnosOrdenAZ == 0)
            {
                universidad.AlumnosOrdenAZ = 1;
            }
            else
            {
                universidad.AlumnosOrdenAZ = 0;
            }
            universidad.OrdenarAlfabeticamente();
            ActualizarDGV(dgvAlumnos, universidad.AlumnosQueCursan);
        }
    }

    //Clase del argumento del evento personalizado
    public class EventoPromedioAltoEventsArgs : EventArgs
    {
        public EventoPromedioAltoEventsArgs(int pLegajo, string pNombre, string pApellido, decimal pPromedio)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;
            Promedio = pPromedio;
        }

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Promedio { get; set; }

    }
}           
