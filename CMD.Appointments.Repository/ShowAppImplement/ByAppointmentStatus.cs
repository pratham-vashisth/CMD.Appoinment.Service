using CMD.Appointments.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Repository.ShowAppImplement
{
    
    public class ByAppointmentStatus : IShowAppointments
    {
        List<AppointmentEF> appointments = new List<AppointmentEF>();
        AppointmentsDbContext DatabaseDB = new AppointmentsDbContext();
        public List<AppointmentEF> ShowAppointments(string key)
        {

            foreach (var appointment in DatabaseDB.Appointments.ToList())
            {
                if (appointment.Appointment_status.Equals(key))
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }
    }
}
