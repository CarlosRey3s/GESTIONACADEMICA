using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIEdicion
{
    public partial class CitasEdicion : Form
    {
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtID_Cita.Text.Trim().Length == 0)
                {
                    Notificador.SetError(txtID_Paciente, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception)
            {
                Valido = false;
            }
            return Valido;
        }
        public CitasEdicion()
        {
            InitializeComponent();
        }

        private void CitasEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
