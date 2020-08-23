using LogisticsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Entities.Concrete
{
    public class MaintenanceHistory : IEntity
    {
        public int MaintenanceID { get; set; }

        public int ActionTypeID { get; set; }
        public string text { get; set; }
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
