using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerComposerNsp.Models.Entities
{
    public class OSystem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }
    }
}
