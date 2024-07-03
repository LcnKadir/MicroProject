namespace MiniMicroProject.API.Models
{
    public class BaseEntity
    {
        //By using the BaseEntity class, code duplication is reduced by defining all classes in a central place.//
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
