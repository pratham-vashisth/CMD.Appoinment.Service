using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.DTOs
{
    [DataContract]
    public class AppointmentDTO
    {

        
        public long App_Id { get; set; }

        [DataMember]
        public string patientId { get; set; }

        [DataMember]
        public string doctorId { get; set; }

        [DataMember]
        public String Issue { get; set; }

        [DataMember]
        public String TimeSlot { get; set; }
       
        [DataMember]
        public string ReasonForVisit { get; set; }

        [DataMember]
        public String Appointment_status { get; set; }
    }
}
