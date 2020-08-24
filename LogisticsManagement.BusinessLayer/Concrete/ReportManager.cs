using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.Core.Results;
using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Concrete
{
    public class ReportManager : IReportService
    {
        IMaintenanceDal _maintenanceDal;
        public ReportManager(IMaintenanceDal maintenanceDal)
        {
            _maintenanceDal = maintenanceDal;
        }
        public IDataResult<List<FaultReportDto>> GetFaultReport()
        {
            var reportList = _maintenanceDal.GetReportData();
            return new SuccessDataResult<List<FaultReportDto>>(reportList);
        }

        public IDataResult<FaultReportDetailDto> GetFaultReportDetail(int maintenanceID)
        {
            var reportDetail = _maintenanceDal.GetFaultReportDetail(maintenanceID);
            return new SuccessDataResult<FaultReportDetailDto>(reportDetail);
        }
    }
}
