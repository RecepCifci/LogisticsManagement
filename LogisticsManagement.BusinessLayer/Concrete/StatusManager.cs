using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.BusinessLayer.Constants;
using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LogisticsManagement.DataAccessLayer.Abstract;

namespace LogisticsManagement.BusinessLayer.Concrete
{
    class StatusManager : IStatusService
    {
        private IStatusDal _statusDal;
        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IResult Add(Status status)
        {
            _statusDal.Add(status);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Status status)
        {
            _statusDal.Delete(status);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Status> GetById(int statusId)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(c => c.ID == statusId));
        }

        public IDataResult<List<Status>> GetList()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(Status status)
        {
            _statusDal.Update(status);
            return new SuccessResult(Messages.Updated);
        }
    }
}
