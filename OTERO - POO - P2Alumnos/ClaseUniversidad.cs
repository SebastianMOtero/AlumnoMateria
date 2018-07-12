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
        #endregion
    }
}
