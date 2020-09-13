using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EKebun.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public string JobOwnerCompanyName { get; set; }
        public string JobAddress { get; set; }
        public string JobDesc { get; set; }
        public decimal JobSalary { get; set; }
        public int JobWorkingHours { get; set; }
        public string JobQualification { get; set; }
        public string JobType { get; set; }
        public string JobAdditionalInformation { get; set; }
    }
}
