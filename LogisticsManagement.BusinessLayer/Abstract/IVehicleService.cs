using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IVehicleService
    {
        IDataResult<Vehicle> GetById(int Id);
        IDataResult<List<Vehicle>> GetList();
        IResult Add(Vehicle vehicle);
        IResult Update(Vehicle vehicle);
        IResult Delete(Vehicle vehicle);
    }
}
