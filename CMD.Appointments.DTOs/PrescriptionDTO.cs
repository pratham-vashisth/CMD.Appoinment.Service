using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.DTOs
{
    [DataContract]
    public class PrescriptionDTO
    {
        
        public long Prescription_ID { get; set; }
        
        [DataMember]
        public string Medicine_Name { get; set; }
        
        [DataMember]
        public string Duration { get; set; }
        
        [DataMember]
        public string Medicine_cycle { get; set; }
        
        [DataMember]
        public string Medicine_Description { get; set; }

        [DataMember]
        public bool IsBeforeFood { get; set; }
        
        [DataMember]
        public long App_Id { get; set; }
        
        [DataMember]
        public string Status { get; set; }
    }
}
