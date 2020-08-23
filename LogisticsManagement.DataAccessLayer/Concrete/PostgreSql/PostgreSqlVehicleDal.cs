using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.DataAccessLayer.Concrete.PostgreSql.Context;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LogisticsManagement.DataAccessLayer.Concrete.PostgreSql
{
    public class PostgreSqlVehicleDal : PostgreSqlEntityRepositoryBase<Vehicle>, IVehicleDal
    {
        public PostgreSqlVehicleDal(PostgreSqlContext context) : base(context)
        {
        }
    }
}
