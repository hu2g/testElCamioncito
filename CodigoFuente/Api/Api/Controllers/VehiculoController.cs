using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculoController : ControllerBase
    {
        // CREATE
        [HttpPost("prueba")]
        public Boolean prueba(int id)
        {
            return false;
        }

        [HttpPost("addVehiculo")]
        public Boolean addVehiculo(Vehiculo v)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE ADDVEHICULO " + v.capacidad + "," + v.consumo + "," + v.depreciacion;
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                conn.Close();
                if (data.RecordsAffected > 0)
                {
                    return true;
                }

            }
            return false;
        }

        [HttpGet("agregar")]
        public Boolean agregar(double capa, double cons, double depr)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE ADDVEHICULO " + capa + "," + cons + "," + depr;
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                conn.Close();
                if (data.RecordsAffected > 0)
                {
                    return true;
                }

            }
            return false;
        }

        //READ
        [HttpGet("getVehiculos")]
        public IActionResult getVehiculos()
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE GETVEHICULOS";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                List<Vehiculo> vehiculos = new List<Vehiculo>();
                while (data.Read())
                {
                    Vehiculo v = new Vehiculo();
                    v.id_vehiculo = int.Parse(data.GetValue(0).ToString());
                    v.capacidad = double.Parse(data.GetValue(1).ToString());
                    v.consumo = double.Parse(data.GetValue(2).ToString());
                    v.depreciacion = double.Parse(data.GetValue(3).ToString());
                    vehiculos.Add(v);
                }
                conn.Close(); 
                return Ok(vehiculos);
            }
            return NotFound("Error");
        }
        
        // UPDATE
        [HttpGet("updateVehiculo")]
        public Boolean updateVehiculo(Vehiculo v)//(int id, double capa, double cons, double depr)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE UPDATEVEHICULO " + v.id_vehiculo+ "," + v.capacidad+ "," + v.consumo+ "," + v.depreciacion;
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                conn.Close();
                if (data.RecordsAffected > 0)
                {
                    return true;
                }
            }
            return false;
        }
        [HttpGet("modificar")]
        public Boolean modificar(int id, double capa, double cons, double depr)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE UPDATEVEHICULO " + id + "," + capa + "," + cons + "," + depr;
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                conn.Close();
                if (data.RecordsAffected > 0)
                {
                    return true;
                }
            }
            return false;
        }

        // DELETE
        [HttpDelete("deleteVehiculo")]
        public Boolean deleteVehiculo(int id)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                conn.Open();
                string query = "EXECUTE DELETEVEHICULO " + id;
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader data = comando.ExecuteReader();
                conn.Close();
                if (data.RecordsAffected > 0)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
