using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public bool HasInsurance { get; set; }
        public bool HadPreviousOperation { get; set; }
        public string MaritialStatus { get; set; }
        public DateTime RegistrationTime = DateTime.Now;
    }
}
