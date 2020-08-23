using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.BusinessLayer.Constants;
using LogisticsManagement.Core.Results;
using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Concrete
{
    public class VehicleManager : IVehicleService
    {
        private IVehicleDal _vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public IResult Add(Vehicle vehicle)
        {
            _vehicleDal.Add(vehicle);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Vehicle vehicle)
        {
            _vehicleDal.Delete(vehicle);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Vehicle> GetById(int vehicleId)
        {
            return new SuccessDataResult<Vehicle>(_vehicleDal.Get(c => c.ID == vehicleId));
        }

        public IDataResult<List<Vehicle>> GetList()
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(Vehicle vehicle)
        {
            _vehicleDal.Update(vehicle);
            return new SuccessResult(Messages.Updated);
        }
    }
}
