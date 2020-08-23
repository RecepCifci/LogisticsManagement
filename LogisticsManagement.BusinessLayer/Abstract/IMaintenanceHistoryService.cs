using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IMaintenanceHistoryService
    {
        IDataResult<MaintenanceHistory> GetById(int Id);
        IDataResult<List<MaintenanceHistory>> GetList();
        IResult Add(MaintenanceHistory maintenanceHistory);
        IResult Update(MaintenanceHistory maintenanceHistory);
        IResult Delete(MaintenanceHistory maintenanceHistory);
    }
}
