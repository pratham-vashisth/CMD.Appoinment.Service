using CMD.Appointments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Repository.ShowAppImplement
{
    public interface IShowAppointments
    {
        List<AppointmentEF> ShowAppointments(String key); 
    }
}
