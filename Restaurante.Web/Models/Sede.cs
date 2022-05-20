using System.ComponentModel.DataAnnotations;

namespace Restaurante.Web.Models
{
    public class Sede
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
