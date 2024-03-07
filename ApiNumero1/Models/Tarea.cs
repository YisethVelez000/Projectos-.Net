using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APiNumero1.Models
{
    public class Tarea
    {
        [Key]
        public Guid TareaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Guid CategoriaId { get; set; }
        [Required]
        [MaxLength(150)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        Prioridad PrioridadTarea{get; set;}
        public DateTime FechaCreacion { get; set; }
        public virtual Categoria Categoria { get; set; }
        [NotMapped] //Para que no se cree en la base de datos 


        public string Resumen { get; set; }// Se llena con la descripcion de la tarea, pero no se almacena en la base de datos


    public enum Prioridad{
        Baja,
        Media,
        Alta
    }
   }
}

