using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _10._3WinformsCArs.Cars
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string  VIN { get; set; }
        public string Make { get; set; }
         public string Model { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }

    }
}
