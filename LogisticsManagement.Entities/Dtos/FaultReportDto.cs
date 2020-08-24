using LogisticsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Entities.Dtos
{
   public class FaultReportDto : IDto
    {
        public string PlateNo { get; set; }
        public string VehicleType { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string Status { get; set; }
        public string ProfilePicture { get; set; }
    }
}
