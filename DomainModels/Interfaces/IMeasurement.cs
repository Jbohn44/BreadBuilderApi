using DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Interfaces
{
    public interface IMeasurement
    {
        public int MeasurementId { get; set; }
        public int IngredientId { get; set; }
        public double MeasurementValue { get; set; }
        public MeasurementType MeasurementType { get; set; }
    }
}
