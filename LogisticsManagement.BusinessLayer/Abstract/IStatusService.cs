using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IStatusService
    {
        IDataResult<Status> GetById(int Id);
        IDataResult<List<Status>> GetList();
        IResult Add(Status status);
        IResult Update(Status status);
        IResult Delete(Status status);
    }
}
