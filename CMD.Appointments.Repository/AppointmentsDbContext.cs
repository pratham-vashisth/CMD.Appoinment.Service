using CMD.Appointments.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Repository
{
    public class AppointmentsDbContext : DbContext
    {
        public AppointmentsDbContext() : base("name=CMDConnectionString") { }

        public DbSet<AppointmentEF> Appointments { get; set; }
        public DbSet<PrescriptionEF> prescriptions { get; set; }
    }
}
