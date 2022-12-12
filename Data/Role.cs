using System.ComponentModel.DataAnnotations;
namespace Projet_.Net.Data
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
