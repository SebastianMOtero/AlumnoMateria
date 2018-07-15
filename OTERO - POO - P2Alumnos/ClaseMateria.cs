using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTERO___POO___P2Alumnos
{
    public abstract class ClaseMateria
    {
        #region "Variables"
        private int codigo;
        private string denominacion;
        private decimal nota;
        #endregion

        #region "Constructor"
        public ClaseMateria(int pCodigo, string pDenominacion) 
        {
            Codigo = pCodigo;
            Denominacion = pDenominacion;
        }
        #endregion

        #region "Propiedades"
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

        public virtual decimal Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        #endregion
    }

    public class ClaseMateriaBasica : ClaseMateria
    {
        #region "Constructor"
        public ClaseMateriaBasica(int pCodigo, string pDenominacion) : base(pCodigo, pDenominacion) { }
        #endregion
    }

    public class ClaseMateriaEspecializada : ClaseMateria
    {
        #region "Constructor"
        public ClaseMateriaEspecializada(int pCodigo, string pDenominacion) : base(pCodigo, pDenominacion) { }
        #endregion

        #region "Propiedades"
        public override decimal Nota
        {
            get { return base.Nota; }
            set
            {
                if (value >= 6 && value <= 9)
                {
                    base.Nota = value + 1;
                }
                else
                {
                    base.Nota = value;
                }
            }
        }
        #endregion
    }
}
