using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.DataAccessLayer.Concrete.PostgreSql.Context;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.DataAccessLayer.Concrete.PostgreSql
{
    public class PostgreSqlVehicleTypeDal : PostgreSqlEntityRepositoryBase<VehicleType>, IVehicleTypeDal
    {
        public PostgreSqlVehicleTypeDal(PostgreSqlContext context) : base(context)
        {
        }
    }
}
