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
    class MaintenanceManager : IMaintenanceService
    {
        private IMaintenanceDal _maintenanceDal;
        public MaintenanceManager(IMaintenanceDal maintenanceDal)
        {
            _maintenanceDal = maintenanceDal;
        }

        public IResult Add(Maintenance maintenance)
        {
            _maintenanceDal.Add(maintenance);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Maintenance maintenance)
        {
            _maintenanceDal.Delete(maintenance);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Maintenance> GetById(int maintenanceId)
        {
            return new SuccessDataResult<Maintenance>(_maintenanceDal.Get(c => c.ID == maintenanceId));
        }

        public IDataResult<List<Maintenance>> GetList()
        {
            return new SuccessDataResult<List<Maintenance>>(_maintenanceDal.GetList().OrderBy(c => c.ID).ToList());
        }

        public IResult Update(Maintenance maintenance)
        {
            _maintenanceDal.Update(maintenance);
            return new SuccessResult(Messages.Updated);
        }

        public void GetMaintenanceReport()
        {
            _maintenanceDal.GetReportData();
        }
    }
}
