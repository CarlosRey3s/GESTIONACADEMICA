using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.GUI;

namespace General.GUI
{
    public partial class DoctoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();


        private void Cargar()// Muestra la informacion en el datagripview
        { 
            try
            {
                _DATOS.DataSource = DataLayer.Consulta.Doctor();
                dtbDoctor.AutoGenerateColumns = false;
                dtbDoctor.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
            public DoctoresGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
