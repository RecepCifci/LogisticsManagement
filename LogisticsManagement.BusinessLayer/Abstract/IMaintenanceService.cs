using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
  public  interface IMaintenanceService
    {
        IDataResult<Maintenance> GetById(int Id);
        IDataResult<List<Maintenance>> GetList();
        IResult Add(Maintenance maintenance);
        IResult Update(Maintenance maintenance);
        IResult Delete(Maintenance maintenance);
    }
}
