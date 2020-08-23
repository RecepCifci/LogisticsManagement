using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IVehicleTypeService
    {
        IDataResult<VehicleType> GetById(int Id);
        IDataResult<List<VehicleType>> GetList();
        IResult Add(VehicleType vehicleType);
        IResult Update(VehicleType vehicleType);
        IResult Delete(VehicleType vehicleType);
    }
}
