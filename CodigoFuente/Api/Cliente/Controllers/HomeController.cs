using Cliente.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Web.Http;
using System.Web;
using System.Net.Http.Formatting;

namespace Cliente.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Modificar(int id, double capa, double cons, double depr)
        {
            VehiculoModel v = new VehiculoModel();
            v.id_vehiculo = id;
            v.capacidad = capa;
            v.consumo = cons;
            v.depreciacion = depr;

            return View(v);
        }

        //CREATE
        public async Task<IActionResult> addVehiculo(double capacidad, double consumo, double depreciacion)
        {
            /*string parametros = "{ \"capacidad\":" + capacidad + ", \"consumo\":" + consumo + ", \"depreciacion\":" + depreciacion + "}";
            VehiculoModel v = new VehiculoModel();
            v.capacidad = capacidad;
            v.consumo = consumo;
            v.depreciacion = depreciacion;
            */
            var httpClient = _clientFactory.CreateClient("APIClient");
            var response = await httpClient.GetAsync("vehiculo/agregar?capa=" + capacidad + "&cons=" + consumo + "&depr=" + depreciacion).ConfigureAwait(false);
            
            if (response.IsSuccessStatusCode)
            {   
                return View("Index", "Home");
            }
            return View("Index", "Home");
        }


        public async Task<IActionResult> addVehiculoNo(double capacidad, double consumo, double depreciacion)
        {
            VehiculoModel v = new VehiculoModel();
            v.capacidad = capacidad;
            v.consumo = consumo;
            v.depreciacion = depreciacion;

            //string action = "capa=" + capacidad.ToString() + "&cons=" + consumo.ToString() + "&depr=" + depreciacion.ToString();

            string action = "{ \"capacidad\":" + capacidad + ", \"consumo\":" + consumo + ", \"depreciacion\":" + depreciacion + "}";
            var httpClient = _clientFactory.CreateClient("APIClient");
            var response = await httpClient.PostAsync("vehiculo/addVehiculo", new StringContent(action));
            //response.EnsureSuccessStatusCode()
            if (response.IsSuccessStatusCode)
            {
            }
            return View("Index", "Home");
        }

        // READ
        public async Task<IActionResult> Vehiculo()
        {
            var httpClient = _clientFactory.CreateClient("APIClient");
            var response = await httpClient.GetAsync("vehiculo/getVehiculos").ConfigureAwait(false);

            //response.EnsureSuccessStatusCode()
            if (response.IsSuccessStatusCode)
            {
                var companiesString = await response.Content.ReadAsStringAsync();
                var vehiculos = System.Text.Json.JsonSerializer.Deserialize<List<VehiculoModel>>(companiesString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                if (vehiculos == null) { return View(""); }
                return View(vehiculos);
            }
            return View(new List<VehiculoModel>());
        }



        // UPDATE
        public async Task<IActionResult> updateVehiculo(int id, double capacidad, double consumo, double depreciacion)
        {
            
            var httpClient = _clientFactory.CreateClient("APIClient");
            var response = await httpClient.GetAsync("vehiculo/modificar?id="+id+"&capa=" + capacidad + "&cons=" + consumo + "&depr=" + depreciacion).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return View("Index", "Home");
            }
            return View("Index", "Home");


            return View();
        }

        // DELETE
        public async Task<IActionResult> deleteVehiculo(int id_vehiculo)
        {
            var httpClient = _clientFactory.CreateClient("APIClient");
            var response = await httpClient.DeleteAsync("vehiculo/deleteVehiculo?id=" + id_vehiculo).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                //var companiesString = await response.Content.ReadAsStringAsync();
                return View("Index","Home");
            }
            return View("Index", "Home");
        }



    }
}
