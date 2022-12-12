

using System.ComponentModel.DataAnnotations;

namespace Projet_.Net.Data
{
    public class Blog
    {
        [Key]
        public Guid Id { get; set; }

        public string titre { get; set; }

        public string description { get; set; }
    }
}
