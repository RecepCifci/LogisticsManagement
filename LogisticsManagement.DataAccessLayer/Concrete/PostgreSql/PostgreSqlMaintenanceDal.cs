using LogisticsManagement.DataAccessLayer.Abstract;
using LogisticsManagement.DataAccessLayer.Concrete.PostgreSql.Context;
using LogisticsManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LogisticsManagement.Entities.Dtos;

namespace LogisticsManagement.DataAccessLayer.Concrete.PostgreSql
{
    public class PostgreSqlMaintenanceDal : PostgreSqlEntityRepositoryBase<Maintenance>, IMaintenanceDal
    {
        PostgreSqlContext _context;

        public PostgreSqlMaintenanceDal(PostgreSqlContext context) : base(context)
        {
            _context = context;
        }

        public FaultReportDetailDto GetFaultReportDetail(int maintenanceID)
        {
            var data = from maintenance in _context.Maintenance
                       join vehicle in _context.Vehicle on maintenance.VehicleID equals vehicle.ID
                       join vehicleType in _context.VehicleType on vehicle.VehicleTypeID equals vehicleType.ID
                       join responsibleUser in _context.User on maintenance.ResponsibleUserID equals responsibleUser.ID
                       join maintenanceHistory in _context.MaintenanceHistory on maintenance.ID equals maintenanceHistory.MaintenanceID
                       join actionType in _context.ActionType on maintenanceHistory.ActionTypeID equals actionType.ID
                       join pictureGroup in _context.PictureGroup on maintenance.PictureGroupID equals pictureGroup.ID
                       where maintenance.ID == maintenanceID
                       select new FaultReportDetailDto
                       {
                           PlateNo = vehicle.PlateNo,
                           VehicleType = vehicleType.Name,
                           Description = maintenance.Description,
                           UserName = String.Format("{0} {1}", responsibleUser.FirstName, responsibleUser.LastName),
                           UserPhoneNumber = responsibleUser.PhoneNumber,
                           ProfilePicture = responsibleUser.profilepicture,
                           ExpectedTimeToFix = maintenance.ExpectedTimeToFix,
                           ActionTypeName = actionType.Name,
                           MaintenancePicture = pictureGroup.PictureImage,
                           MaintenanceHistoryName = maintenanceHistory.text,
                           LocationLongitude = maintenance.LocationLongitude,
                           LocationLatitude = maintenance.LocationLatitude

                       };
            return data.FirstOrDefault();
        }

        public List<FaultReportDto> GetReportData()
        {
            var data = from maintenance in _context.Maintenance
                       join vehicle in _context.Vehicle on maintenance.VehicleID equals vehicle.ID
                       join vehicleType in _context.VehicleType on vehicle.VehicleTypeID equals vehicleType.ID
                       join responsibleUser in _context.User on maintenance.ResponsibleUserID equals responsibleUser.ID
                       join status in _context.Status on maintenance.StatusID equals status.ID
                       select new FaultReportDto
                       {
                           PlateNo = vehicle.PlateNo,
                           UserName = String.Format("{0} {1}", responsibleUser.FirstName, responsibleUser.LastName),
                           UserPhoneNumber = responsibleUser.PhoneNumber,
                           VehicleType = vehicleType.Name,
                           Description = maintenance.Description,
                           Status = status.Name,
                           ProfilePicture = responsibleUser.profilepicture
                       };
            return data.ToList();
        }

    }
}
