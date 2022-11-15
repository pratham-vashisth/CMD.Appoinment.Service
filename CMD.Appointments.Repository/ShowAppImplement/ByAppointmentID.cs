using CMD.Appointments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Repository.ShowAppImplement
{
    public class ByAppointmentID : IShowAppointments
    {
        List<AppointmentEF> appointments = new List<AppointmentEF>();
        AppointmentsDbContext DatabaseDB = new AppointmentsDbContext();
        public List<AppointmentEF> ShowAppointments(string key)
        {
            
            long id=long.Parse(key);


            AppointmentEF appointment = DatabaseDB.Appointments.FirstOrDefault(x => x.App_Id == id);

             appointments.Add(appointment);
   
            return appointments;
        }
    }
}
