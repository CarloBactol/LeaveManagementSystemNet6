﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystemNet6.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
     
    }
}
