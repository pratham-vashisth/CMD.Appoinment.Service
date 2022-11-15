using CMD.Appointments.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Repository.ShowAppImplement
{
    public class ByDoctorID : IShowAppointments
    {
        List<AppointmentEF> appointments = new List<AppointmentEF>();
        AppointmentsDbContext DatabaseDB = new AppointmentsDbContext();
        public List<AppointmentEF> ShowAppointments(string key)
        {
            //long id = long.Parse(key);

            foreach (var appointment in DatabaseDB.Appointments.ToList())
            {
                if (appointment.doctorId.Equals(key))
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }
    }
}
