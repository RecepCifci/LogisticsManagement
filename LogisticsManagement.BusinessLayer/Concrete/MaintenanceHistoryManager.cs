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
    class MaintenanceHistoryManager : IMaintenanceHistoryService
    {
        private IMaintenanceHistoryDal _maintenanceHistoryDal;
        public MaintenanceHistoryManager(IMaintenanceHistoryDal maintenanceHistoryDal)
        {
            _maintenanceHistoryDal = maintenanceHistoryDal;
        }

        public IResult Add(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryDal.Add(maintenanceHistory);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryDal.Delete(maintenanceHistory);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<MaintenanceHistory> GetById(int maintenanceHistoryId)
        {
            return new SuccessDataResult<MaintenanceHistory>(_maintenanceHistoryDal.Get(c => c.ID == maintenanceHistoryId));
        }

        public IDataResult<List<MaintenanceHistory>> GetList()
        {
            return new SuccessDataResult<List<MaintenanceHistory>>(_maintenanceHistoryDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryDal.Update(maintenanceHistory);
            return new SuccessResult(Messages.Updated);
        }
    }
}
