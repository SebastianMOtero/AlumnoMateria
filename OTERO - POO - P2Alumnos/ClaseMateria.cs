using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTERO___POO___P2Alumnos
{
    class ClaseMateria
    {
        public ClaseMateria()
        {

        }

        private int codigo;
        private string denominacion;
        private decimal nota;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Denominacion
        {
            get { return denominacion; }
            set { denominacion = value; }
        }

        public decimal Nota
        {
            get { return nota; }
            set { nota = value; }
        }

    }
}
