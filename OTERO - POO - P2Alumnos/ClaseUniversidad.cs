using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTERO___POO___P2Alumnos
{
    public class ClaseUniversidad
    {
        #region "Variables y declaraciones"
        List<ClaseMateria> ListaMaterias;
        List<ClaseAlumno> ListaAlumnos;
        int alumnosOrdenAZ = 1;
        #endregion

        #region "Constructor"
        public ClaseUniversidad()
        {
            ListaAlumnos = new List<ClaseAlumno>();
            ListaMaterias = new List<ClaseMateria>();
        }
        #endregion

        #region "Propiedades"
        public ClaseAlumno[] AlumnosQueCursan
        {
            get { return ListaAlumnos.ToArray(); }
        }

        public ClaseMateria[] MateriasImpartidas
        {
            get { return ListaMaterias.ToArray(); }
        }
        public int AlumnosOrdenAZ
        {
            get { return alumnosOrdenAZ;  }
            set { alumnosOrdenAZ = value; }
        }
        #endregion

        #region "Metodos"
        public void AgregarAlumno(ClaseAlumno pAlumno)
        {
            try
            {
                ListaAlumnos.Add(pAlumno);
            }
            catch (Exception)

            {

            }
        }

        public void EliminarAlumno(ClaseAlumno pAlumno)
        {
            try
            {
                ListaAlumnos.Remove(pAlumno);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AgregarMateria(ClaseMateria pMateria)
        {
            try
            {
                ListaMaterias.Add(pMateria);
            }
            catch (Exception)

            {

            }
        }

        public void EliminarMateria(ClaseMateria pMateria)
        {
            try
            {
                ListaMaterias.Remove(pMateria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OrdenarAlfabeticamente()
        {
            if (alumnosOrdenAZ == 1)
            {
                ListaAlumnos.Sort(new ClaseAlumno.ApellidoAscendente());
            }
            else
            {
                ListaAlumnos.Sort(new ClaseAlumno.ApellidoDescendente());
            }
        }
        #endregion
    }
}
