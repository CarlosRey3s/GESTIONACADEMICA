using DataLayer;
using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EmpleadosEdicion : Form
    {
        BindingSource _Datos = new BindingSource();

        private void LlenarComboBoxCargos()
        {
                try
                {
                _Datos.DataSource = DataLayer.Consulta.Cargos();
                cbxCargo.DataSource = _Datos;
                cbxCargo.DisplayMember = "Cargo";
                cbxCargo.ValueMember = "ID_Cargo";
                }
                catch (Exception ex)
                {

                }
               
        }

        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtNombreEmpleado.Text.Trim().Length == 0)
                {
                    notificador.SetError(txtNombreEmpleado, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
            }
            return Valido;
        }
        public EmpleadosEdicion()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadosEdicion_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCargos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    //Crear una instancia a partir de la clase

                    CLS.Empleados oEmpleados = new CLS.Empleados();

                    //sincronizar el objeto con la interfaz

                    try {
                        oEmpleados.ID_empleados = Convert.ToInt32(txtIDEmpleado.Text);

                    }
                    catch (Exception)
                    {
                        oEmpleados.ID_empleados = 0;
                    }
                    oEmpleados.NombresEmpleados = txtNombreEmpleado.Text;
                    oEmpleados.ApellidosEmpleados = txtApellidoEmpleado.Text;
                    oEmpleados.FechaNacEmpleados = dTFechaNac.Value;
                    oEmpleados.TelefonoEmpleados = txtTelefono.Text;
                    oEmpleados.Correos = txtCorreo.Text;
                    oEmpleados.DUI_Empleados = txtDUI.Text;
                    oEmpleados.ISSS_Empleados = Convert.ToInt32(txtISSS.Text);

                    oEmpleados.Cargos = cbxCargo.Text;
                    int selectedCargoId = (int)cbxCargo.SelectedValue;
                    oEmpleados.ID_Cargos = selectedCargoId;

                    oEmpleados.ID_Direcciones = Convert.ToInt32(txtDireccion.Text);

                    if (txtIDEmpleado.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO REGISTROS
                        if (oEmpleados.Insertar())
                        {
                            MessageBox.Show("Registro Guardado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser almacenado");
                        }
                    }
                    else
                    {
                        //ACTUALIZAR REGISTRO
                        if (oEmpleados.Actualizar())
                        {
                            MessageBox.Show("Registro Actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser actualizado");
                        }
                    }
                }
            }catch(Exception ex)
            { }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
