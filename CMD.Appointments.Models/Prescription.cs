using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Models
{
    [Table("prescriptions")]
    public class PrescriptionEF
    {
        [Key]
        public long Prescription_ID { get; set; }

        [Required]
        public string Medicine_Name { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string Medicine_cycle { get; set; }

        [Required]
        public string Medicine_Description { get; set; }

        [Required]
        public bool IsBeforeFood { get; set; }

        [Required]
        public long App_Id { get; set; }
        
        [Required]
        public string Status { get; set; }
    }
}
