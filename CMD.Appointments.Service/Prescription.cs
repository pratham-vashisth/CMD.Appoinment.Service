using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Service
{
    public class Prescription
    {
        public String medicineName { get; set; }
        public String medicineDescription { get; set; }
        public bool isBeforeFood { get; set; }

    }
}
