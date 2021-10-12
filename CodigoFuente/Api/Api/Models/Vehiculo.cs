using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Vehiculo
    {
        
        public int id_vehiculo { get; set; }
        public double capacidad { get; set; }
        public double consumo { get; set; }
        public double depreciacion { get; set; }
        /*
        public Vehiculo(int id, double cap, double cons, double dep)
        {
            this.id_vehiculo = id;
            this.capacidad = cap;
            this.consumo = cons;
            this.depreciacion = dep;
        }
        public Vehiculo(double cap, double cons, double dep)
        {
            this.capacidad = cap;
            this.consumo = cons;
            this.depreciacion = dep;
        }*/
    }
}
