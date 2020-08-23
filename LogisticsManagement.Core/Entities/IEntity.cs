using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Core.Entities
{
    public interface IEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
