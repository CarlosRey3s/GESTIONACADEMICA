using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Consulta
    {
        public static DataTable Doctor()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select * from Vista_Doctor;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }catch (Exception ex)
            {

            }
            return Resultado;
        }
        public static DataTable Empleados()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            e.ID_Empleado, e.DUI_Empleado, e.ISSS_Empleado,e.NombresEmpleado,e.ApellidosEmpleado,
            e.TelefonoEmpleado,e.FechaNacEmpleado,e.Correo,c.Cargo,di.Linea1,di.Linea2,di.ID_Direccion,e.ID_Cargo
            FROM empleados e
            JOIN cargos c ON c.ID_Cargo = e.ID_Cargo
            JOIN direcciones di ON  di.ID_Direccion = e.ID_Direccion;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }catch(Exception ex) { }
            return Resultado;
        }
        public static DataTable Cargos()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM cargos;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable Especialidad()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT * FROM especialidad;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable Direcciones()
        { 
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Direccion,Linea1,Linea2 FROM direcciones";
            DBOperaciones operaciones = new DBOperaciones();
            try
            {
                Resultado = operaciones.Consultar(Consulta);
            }
            catch (Exception ex) { }
            return Resultado;
        }
        public static DataTable Paciente()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @" SELECT ID_Paciente, NombresPaciente, ApellidosPaciente, FechaNac, Genero, ID_Direccion, Telefono, CorreoElectronico  FROM pacientes ORDER BY ID_Paciente ASC;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            {}
            return Resultado;
        }
        public static DataTable Usuario()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Usuario, ID_Empleado, ID_Rol, Usuario, Clave FROM Usuarios;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Roles()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Rol, NombreRol FROM Roles;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }

        public static DataTable Opciones()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT ID_Opcion, NombreOpcion FROM Opciones;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable VerPermisos()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT NombreRol, NombreOpcion FROM verPermisos;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Medicamentos()
        {
            DataTable Resultado = new DataTable();
            string Consulta = @"SELECT ID_Insumo, NombreInsumo, Descripcion, CantidadDiponible, PrecioUnitario, Proveedor, FechaVencimiento, ImagenMedicamento FROM Medicamentos;";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }

    }
}
