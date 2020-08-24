using LogisticsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Entities.Dtos
{
    public class FaultReportDetailDto : IDto
    {
        public string PlateNo { get; set; }
        public string VehicleType { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime? ExpectedTimeToFix { get; set; }
        public string ActionTypeName { get; set; }
        public string MaintenancePicture { get; set; }
        public string MaintenanceHistoryName { get; set; }
        public string LocationLongitude { get; set; }
        public string LocationLatitude { get; set; }
    }
}
