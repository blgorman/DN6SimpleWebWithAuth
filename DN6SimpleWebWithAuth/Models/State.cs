using System.ComponentModel.DataAnnotations;

namespace DN6SimpleWebWithAuth.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Name of State is required")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(6)]
        public string Abbreviation { get; set; } = string.Empty;
    }
}
