using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
     public class Vehiculo
    {
        protected String matricula;
        protected String marca;
        protected String modelo;

        //Creamos el constructor
        public Vehiculo(string matricula, string marca, string modelo)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
        }

        public Vehiculo()
        {
        }

        //Creamos los setters
        public void setMatricula(String matricula)
        {
            this.matricula = matricula;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        //Creamos los get
        public String getMatricula()
        {
            return this.matricula;
        }

        public String getMarca()
        {
            return this.marca;
        }

        public String getModelo()
        {
            return this.modelo;
        }

        public virtual String mostrarDatos()
        {
            return "Matricula " + matricula + "\nMarca : " + marca + "\nModelo : " + modelo;
        }



    }
}