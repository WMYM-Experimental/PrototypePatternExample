﻿using System.ComponentModel.DataAnnotations;

namespace PrototypePatternExample.Models
{
    /// <summary>
    /// Class for modeling a car
    /// </summary>
    public class Car
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Model { get; set; }
        [StringLength(150)]
        public string Color { get; set; }
        [StringLength(150)]
        public string Brand { get; set; }
        [Range(1950, int.MaxValue)]
        public int Year { get; set; }
    }
}
