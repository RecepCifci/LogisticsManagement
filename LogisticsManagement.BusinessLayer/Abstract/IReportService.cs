using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IReportService
    {
        public IDataResult<List<FaultReportDto>> GetFaultReport();
        public IDataResult<FaultReportDetailDto> GetFaultReportDetail(int maintenanceID);
    }
}
