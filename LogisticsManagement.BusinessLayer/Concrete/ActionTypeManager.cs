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
    class ActionTypeManager : IActionTypeService
    {
        private IActionTypeDal _actionTypeDal;
        public ActionTypeManager(IActionTypeDal actionTypeDal)
        {
            _actionTypeDal = actionTypeDal;
        }

        public IResult Add(ActionType actionType)
        {
            _actionTypeDal.Add(actionType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ActionType actionType)
        {
            _actionTypeDal.Delete(actionType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<ActionType> GetById(int actionTypeId)
        {
            return new SuccessDataResult<ActionType>(_actionTypeDal.Get(c => c.ID == actionTypeId));
        }

        public IDataResult<List<ActionType>> GetList()
        {
            return new SuccessDataResult<List<ActionType>>(_actionTypeDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(ActionType actionType)
        {
            _actionTypeDal.Update(actionType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
