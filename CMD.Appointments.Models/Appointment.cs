using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Models
{
    [Table("Appointments")]
    public class AppointmentEF 
    {
        [Key]
        public long App_Id { get; set; }

        [Required]
        public string patientId { get; set; }

        [Required]
        public string doctorId { get; set; }

        [Required]
        public String Issue { get; set; }

        [Required]
        public String TimeSlot { get; set; }

        public string ReasonForVisit { get; set; }

        [Required]
        public String Appointment_status { get; set; }
    }
}



