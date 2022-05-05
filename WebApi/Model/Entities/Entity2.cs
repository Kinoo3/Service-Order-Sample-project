using System.ComponentModel.DataAnnotations;

namespace WebApi.Model.Entities
{
    public class Entity2
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
