using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTERO___POO___P2Alumnos
{
    public class ClaseAlumno
    {
        #region "Variables"
        List<ClaseMateria> ListaMateriasEnCurso;
        List<ClaseMateria> ListaMateriasAprobadas;
        List<ClaseMateria> ListaMateriasDesaprobadas;
        private int legajo;
        private string nombre;
        private string apellido;
        #endregion

        #region "Constructores"
        public ClaseAlumno()
        {
            ListaMateriasEnCurso = new List<ClaseMateria>();
            ListaMateriasAprobadas = new List<ClaseMateria>();
            ListaMateriasDesaprobadas = new List<ClaseMateria>();
        }
        public ClaseAlumno(int pLegajo, string pNombre, string pApellido) : this()
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;
        }
        #endregion

        #region "Propiedades"
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public ClaseMateria[] MateriasEnCurso
        {
            get { return ListaMateriasEnCurso.ToArray(); }
        }

        public ClaseMateria[] MateriasAprobadas
        {
            get { return ListaMateriasAprobadas.ToArray(); }
        }

        public ClaseMateria[] MateriasDesaprobadas
        {
            get { return ListaMateriasDesaprobadas.ToArray(); }
        }
        #endregion

        #region "metodos"
        public void AsignarMateria(ClaseMateria pMateria)
        {
            try
            {
                ListaMateriasEnCurso.Add(pMateria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FinalizarMateria(ClaseMateria pMateria)
        {
            try
            {
                if (pMateria.Nota > 4)
                {
                    ListaMateriasAprobadas.Add(pMateria);
                }
                else
                {
                    ListaMateriasDesaprobadas.Add(pMateria);

                }
                ListaMateriasEnCurso.Remove(pMateria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public decimal PromedioDeMateriasAprobadas()
        {
            int materiasAprobadas = ListaMateriasAprobadas.Count();
            int materiasTotales = + ListaMateriasDesaprobadas.Count() + materiasAprobadas;
            if (materiasTotales == 0)
            {
                throw new Exception("Aun no posee notas.");
            }
            return materiasAprobadas * 100 / materiasTotales;
        }
        public event EventHandler<EventoPromedioAltoEventsArgs> EventoPromedioAlto;

        public decimal PromedioGeneral()
        {
            int cantNotas = 0;
            decimal sumaNotas = 0;

            foreach (ClaseMateria C in ListaMateriasAprobadas)
            {
                cantNotas++;
                sumaNotas += C.Nota;
            }

            foreach (ClaseMateria B in ListaMateriasDesaprobadas)
            {
                cantNotas++;
                sumaNotas += B.Nota;
            }
            if (cantNotas == 0)
            {
                throw new Exception("El alumno no posee notas.");
            }
            decimal prom = sumaNotas / cantNotas;
            if (prom >= 9)
            {
                EventoPromedioAlto(this, new EventoPromedioAltoEventsArgs(Legajo, Nombre, Apellido, prom));
            }
            return (prom);
        }

        public class ApellidoAscendente : IComparer<ClaseAlumno>
        {
            public int Compare(ClaseAlumno x, ClaseAlumno y)
            {
                return String.Compare(x.Apellido, y.Apellido);
            }
        }

        public class ApellidoDescendente : IComparer<ClaseAlumno>
        {
            public int Compare(ClaseAlumno x, ClaseAlumno y)
            {
                return String.Compare(x.Apellido, y.Apellido) * -1;
            }
        }

        #endregion
    }
}
