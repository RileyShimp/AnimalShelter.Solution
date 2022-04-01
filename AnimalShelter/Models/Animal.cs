using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public string Group { get; set; }

    }
}