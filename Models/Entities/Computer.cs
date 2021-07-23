using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerComposerNsp.Models.Entities
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public bool RGB { get; set; }

        [Required]
        public int BoxId { get; set; }

        [ForeignKey(name: "BoxId")]
        public virtual Box Box { get; set; }

        [Required]
        public int GraphicId { get; set; }

        [ForeignKey(name: "GraphicId")]
        public virtual Graphic Graphic { get; set; }

        [Required]
        public int OSystemId { get; set; }

        [ForeignKey(name: "OSystemId")]
        public virtual OSystem OSystem { get; set; }

        [Required]
        public int PowerUnitId { get; set; }

        [ForeignKey(name: "PowerUnitId")]
        public virtual PowerUnit PowerUnit { get; set; }

        [Required]
        public int ProcessorId { get; set; }

        [ForeignKey(name: "ProcessorId")]
        public virtual Processor Processor { get; set; }

        [Required]
        public int RamId { get; set; }

        [ForeignKey(name: "RamId")]
        public virtual Ram Ram { get; set; }
    }
}
