using Autofac;
using LogisticsManagement.BusinessLayer.Abstract;
using LogisticsManagement.BusinessLayer.Concrete;
using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.DataAccessLayer.Concrete.PostgreSql;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VehicleManager>().As<IVehicleService>();
            builder.RegisterType<PostgreSqlVehicleDal>().As<IVehicleDal>();

            builder.RegisterType<ActionTypeManager>().As<IActionTypeService>();
            builder.RegisterType<PostgreSqlActionTypeDal>().As<IActionTypeDal>();

            builder.RegisterType<MaintenanceHistoryManager>().As<IMaintenanceHistoryService>();
            builder.RegisterType<PostgreSqlMaintenanceHistoryDal>().As<IMaintenanceHistoryDal>();

            builder.RegisterType<MaintenanceManager>().As<IMaintenanceService>();
            builder.RegisterType<PostgreSqlMaintenanceDal>().As<IMaintenanceDal>();

            builder.RegisterType<PictureGroupManager>().As<IPictureGroupService>();
            builder.RegisterType<PostgreSqlPictureGroupDal>().As<IPictureGroupDal>();

            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<PostgreSqlStatusDal>().As<IStatusDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<PostgreSqlUserDal>().As<IUserDal>();

            builder.RegisterType<VehicleTypeManager>().As<IVehicleTypeService>();
            builder.RegisterType<PostgreSqlVehicleTypeDal>().As<IVehicleTypeDal>();

            builder.RegisterType<ReportManager>().As<IReportService>();
        }
    }
}
