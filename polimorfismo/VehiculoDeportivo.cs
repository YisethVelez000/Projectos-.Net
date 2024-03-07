using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class VehiculoDeportivo: Vehiculo
    {
        private double cilindraje;

        public VehiculoDeportivo(double cilindraje,string matricula, string marca, string modelo) : base(matricula, marca, modelo)
        {
            this.cilindraje = cilindraje;
        }

        public VehiculoDeportivo()
        {
        }

        public double getCilindraje()
        {
            return this.cilindraje;
        }

        public void setCilindraje(double cilindraje)
        {
            this.cilindraje = cilindraje;
        }

        public override string mostrarDatos()
        {
            return $"Matricula : {getMatricula()}\nMarca : {getMarca()}\nModelo : {getModelo()}\nCilindraje : {getCilindraje()}";
        }
    }
}
