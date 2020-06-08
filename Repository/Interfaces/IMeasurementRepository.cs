using DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IMeasurementRepository
    {
        public Task<List<IMeasurement>> GetMeasurements(int id);
        public Task<IMeasurement> Save(IMeasurement measurement);
    }
}
