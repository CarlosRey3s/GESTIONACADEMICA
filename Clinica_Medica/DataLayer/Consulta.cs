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
            String Consulta = @"select * from VistaEmpleados;";
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
    }
}
