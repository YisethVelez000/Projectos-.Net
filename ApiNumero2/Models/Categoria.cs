using System.ComponentModel.DataAnnotations;

namespace ApiNumero2.Models{
    public class Categoria{
         //[Key] //Define la clave primaria
        public  Guid  CategoriaId { get; set; }
       // [Required]
        //[MaxLength(150)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}