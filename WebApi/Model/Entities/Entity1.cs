using System.ComponentModel.DataAnnotations;

namespace WebApi.Model.Entities
{
    public class Entity1
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teste2 { get; set; }

        public Entity2 Entity2 { get; set; }
    }
}
