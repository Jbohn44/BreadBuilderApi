using DomainModels.Enums;
using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels.Models
{
    public class Measurement : IMeasurement
    {
        public int MeasurementId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MeasurementValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MeasurementType MeasurementType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IngredientId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
