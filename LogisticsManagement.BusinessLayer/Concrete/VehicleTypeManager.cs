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
    class VehicleTypeManager : IVehicleTypeService
    {
        private IVehicleTypeDal _vehicleTypeDal;
        public VehicleTypeManager(IVehicleTypeDal vehicleTypeDal)
        {
            _vehicleTypeDal = vehicleTypeDal;
        }

        public IResult Add(VehicleType vehicleType)
        {
            _vehicleTypeDal.Add(vehicleType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(VehicleType vehicleType)
        {
            _vehicleTypeDal.Delete(vehicleType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<VehicleType> GetById(int vehicleTypeId)
        {
            return new SuccessDataResult<VehicleType>(_vehicleTypeDal.Get(c => c.ID == vehicleTypeId));
        }

        public IDataResult<List<VehicleType>> GetList()
        {
            return new SuccessDataResult<List<VehicleType>>(_vehicleTypeDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(VehicleType vehicleType)
        {
            _vehicleTypeDal.Update(vehicleType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
