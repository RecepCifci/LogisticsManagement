using LogisticsManagement.Core.DataAccess;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.DataAccessLayer.Abstract
{
    public interface IMaintenanceHistoryDal : IEntityRepository<MaintenanceHistory>
    {
    }
}
