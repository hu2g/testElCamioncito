using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

//namespace API_Example.Conection{
public class Conexion
{
    public static string cadena = "Data Source=DESKTOP-L0O2DCR; Initial Catalog=camioncito; Integrated Security=True";





    public SqlConnection conectarbd = new SqlConnection();

    public SqlConnection getCadenaConexion()
    {
        conectarbd.ConnectionString = cadena;
        return conectarbd;
    }

    public Conexion()
    {
        conectarbd.ConnectionString = cadena;
    }

    public bool openConection()
    {
        try
        {
            conectarbd.Open();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public void closeConection()
    {
        conectarbd.Close();
    }


    
    
}
//}
