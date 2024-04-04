namespace Usuarios.Models
{
    public class RoleIndexViewModel
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<Usuarios.Models.Role> Roles { get; set; }
    }
}
