using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTERO___POO___P2Alumnos
{
    class ClaseAlumno
    {
        List<ClaseMateria> listaMaterias;
        private int legajo;
        private string nombre;
        private string apellido;
        
        #region "Constructores"
        public ClaseAlumno()
        {
            listaMaterias = new List<ClaseMateria>();
        }
        public ClaseAlumno(int pLegajo, string pNombre, string pApellido)
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
        #endregion
    }
}
