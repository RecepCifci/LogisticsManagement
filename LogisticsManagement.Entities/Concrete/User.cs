using LogisticsManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.Entities.Concrete
{
    public class User : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string profilepicture { get; set; }
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
