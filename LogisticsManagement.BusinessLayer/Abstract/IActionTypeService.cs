using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IActionTypeService
    {
        IDataResult<ActionType> GetById(int Id);
        IDataResult<List<ActionType>> GetList();
        IResult Add(ActionType actionType);
        IResult Update(ActionType actionType);
        IResult Delete(ActionType actionType);
    }
}
