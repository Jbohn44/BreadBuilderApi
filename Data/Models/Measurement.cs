using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Data.Models
{
    public class Measurement
    {
        [Key]
        public int MeasurementId { get; set; }
        public int IngredientId { get; set; }
        public int MeasurementTypeId { get; set; }
        public double MeasurementValue { get; set; }
    }
}
