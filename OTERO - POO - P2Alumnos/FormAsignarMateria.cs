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
    public partial class FormAsignarMateria : Form
    {
        public FormAsignarMateria(Array[] pMaterias)
        {
            InitializeComponent();
            cmbMateriasImpartidas.Items.Add(pMaterias[0]);
            
        }

        //public object Materia { get; set; }

        private void btnSeleccionarMateria_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
