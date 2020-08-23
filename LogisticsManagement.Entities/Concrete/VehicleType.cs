using LogisticsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Entities.Concrete
{
  public  class VehicleType : IEntity
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
