using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using polimorfismo;

namespace polimorfismo
{
    public class VehiculoTurismo: Vehiculo
    {
        private int numeroPuertas;

        public VehiculoTurismo()
        {
        }

        public VehiculoTurismo(int numeroPuertas, String marca,String matricula, String modelo): base (matricula, marca,modelo)
        {
            this.numeroPuertas = numeroPuertas;
        } 

        public int getNumeroPuertas()
        {
            return numeroPuertas;
        }

        //Setter
        public void setNumeroPuertas(int numeroPuertas)
        {
            this.numeroPuertas= numeroPuertas;
        }

        //Sobreescribimos el metodo

        public override string mostrarDatos()
        {
            return $"Matricula : {getMatricula()}\nMarca : {getMarca()}\nModelo : {getModelo()}\nNumero Puertas : {getNumeroPuertas()}";
        }

    }
}
