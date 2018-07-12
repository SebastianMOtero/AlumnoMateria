using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTERO___POO___P2Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            universidad = new ClaseUniversidad();
        }

    

        public ClaseUniversidad universidad;

        private void btnAñadirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseAlumno Alumno;

                Alumno = new ClaseAlumno(Convert.ToInt32(txtAlumnoLegajo.Text), txtAlumnoNombre.Text, txtAlumnoApellido.Text);

                universidad.AgregarAlumno(Alumno);

                ActualizarDGV(dgvAlumnos, universidad.AlumnosQueCursan);

                txtAlumnoLegajo.Clear();
                txtAlumnoNombre.Clear();
                txtAlumnoApellido.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void btnAñadirMateria_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseMateria Materia;

                if (cmbMateriaTipo.SelectedIndex == 0)
                {
                    Materia = new ClaseMateriaBasica(Convert.ToInt32(txtMateriaCodigo.Text), txtMateriaDenominacion.Text);
                }
                else
                {
                    Materia = new ClaseMateriaEspecializada(Convert.ToInt32(txtMateriaCodigo.Text), txtMateriaDenominacion.Text);
                }

                universidad.AgregarMateria(Materia);

                ActualizarDGV(dgvMaterias, universidad.MateriasImpartidas);

                txtMateriaCodigo.Clear();
                txtMateriaDenominacion.Clear();
                cmbMateriaTipo.SelectedIndex = 0;
                
            }
            catch(Exception)
            {

            }
        }

        private void ActualizarDGV(DataGridView pDGV, object pObject)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pObject;
        }

        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
                ClaseMateria Materia = (ClaseMateria)(dgvMaterias.SelectedRows[0].DataBoundItem);
                int codigo = Materia.Codigo;
                string denominacion = Materia.Denominacion;
                if (Materia.Equals(typeof(ClaseMateriaBasica)))
                {
                    ClaseMateria MateriaAsignada = new ClaseMateriaBasica(codigo,denominacion);
                    Alumno.AsignarMateria(MateriaAsignada);
                }
                else
                {
                    ClaseMateria MateriaAsignada = new ClaseMateriaEspecializada(codigo,denominacion);
                    Alumno.AsignarMateria(MateriaAsignada);
                }
                //Materia.AsignarAlumno(Alumno);
                ActualizarDGV(dgvMateriasEnCurso, Alumno.MateriasEnCurso);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
            ActualizarDGV(dgvMateriasEnCurso, Alumno.MateriasEnCurso);
            ActualizarDGV(dgvMateriasAprobadas, Alumno.MateriasAprobadas);
            ActualizarDGV(dgvMateriasDesaprobadas, Alumno.MateriasDesaprobadas);

        }

        private void btnColocarNota_Click(object sender, EventArgs e)
        {
            ClaseAlumno Alumno = (ClaseAlumno)(dgvAlumnos.SelectedRows[0].DataBoundItem);
            ClaseMateria Materia = (ClaseMateria)(dgvMateriasEnCurso.SelectedRows[0].DataBoundItem);
            decimal nota = Convert.ToDecimal(txtNota.Text.ToString());

            Materia.Nota = nota;

            Alumno.FinalizarMateria(Materia);
            dgvAlumnos_CellClick(null, null);
            txtNota.Clear();
            
        }

        private void btnPruebaAlumno_Click(object sender, EventArgs e)
        {
            ClaseAlumno Alumno = new ClaseAlumno(1, "Sebastian", "Otero");
            ClaseAlumno Alumno1 = new ClaseAlumno(2, "Roberto", "Velez");
            ClaseAlumno Alumno2 = new ClaseAlumno(3, "Emilia", "Galea");
            ClaseAlumno Alumno3 = new ClaseAlumno(4, "Juan Cruz", "Yrigoyen");
            ClaseAlumno Alumno4 = new ClaseAlumno(5, "Hernan", "Lacroze");
            universidad.AgregarAlumno(Alumno);
            universidad.AgregarAlumno(Alumno1);
            universidad.AgregarAlumno(Alumno2);
            universidad.AgregarAlumno(Alumno3);
            universidad.AgregarAlumno(Alumno4);
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

        }
    }
}           
