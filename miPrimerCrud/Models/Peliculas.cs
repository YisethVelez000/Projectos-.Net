using System.ComponentModel.DataAnnotations;

namespace miPrimerCrud.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]

        public DateTime ReleaseData { get; set; }

        public  string Genre {  get; set; }

        public double Price { get; set; }

    }
}
