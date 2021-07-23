using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerComposerNsp.Models.Entities
{
    public class Processor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Cores { get; set; }

        [Required]
        public int Threads { get; set; }

        [Required]
        public float Speed { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual ICollection<Computer> Computers { get; set; }
    }
}
