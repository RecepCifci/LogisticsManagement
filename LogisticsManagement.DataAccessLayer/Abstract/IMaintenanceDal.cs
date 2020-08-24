using LogisticsManagement.Core.DataAccess;
using LogisticsManagement.Entities.Concrete;
using LogisticsManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.DataAccessLayer.Abstract
{
    public interface IMaintenanceDal : IEntityRepository<Maintenance>
    {
        List<FaultReportDto> GetReportData();
        FaultReportDetailDto GetFaultReportDetail(int maintenanceID);
    }
}
