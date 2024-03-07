using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class VehiculoCarga: Vehiculo
    {
        private int carga;

        public VehiculoCarga(int carga,string matricula, string marca, string modelo) : base(matricula, marca, modelo)
        {
            this.carga = carga;
        }

        public VehiculoCarga()
        {
        }

        public int getCarga()
        {
            return this.carga;
        }

        public void setCarga(int carga)
        {
            this.carga = carga;
        }

        public override string mostrarDatos()
        {
           return $"Matricula : {getMatricula()}\nMarca : {getMarca()}\nModelo : {getModelo()}\nCarga : {getCarga()}";
        }
    }
}
