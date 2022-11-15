using CMD.Appointments.Models;
using CMD.Appointments.Repository.ShowAppImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using CMD.Appointments.Models.Entity;
using CMD.Appointments.Repository.DoctorService;

namespace CMD.Appointments.Repository
{
    public class DbManager
    {
        AppointmentsDbContext DatabaseDB = new AppointmentsDbContext();
        public bool AddAppointment(AppointmentEF appointmentEntity)
        {
           
            DatabaseDB.Appointments.Add(appointmentEntity);
            DatabaseDB.SaveChanges();
            return true;
        }

        public bool SetAppointmentStatus(long app_id,string status)
        {
            foreach(var appointment in DatabaseDB.Appointments.ToList())
            {
                
                if(appointment.App_Id.Equals(app_id))
                {
                    appointment.Appointment_status = status;
                    DatabaseDB.SaveChanges();
                    return true;
                }
            }
            return false;

        }

        public List<AppointmentEF> GetAppointmnents(AppointmentEF appointment)
        {

            IShowAppointments appointments;


            if (appointment.App_Id != 0)
            {
                appointments = new ByAppointmentID();
                return appointments.ShowAppointments(appointment.App_Id.ToString());
            }

            if (appointment.Appointment_status != null)
            {
                appointments = new ByAppointmentStatus();
                return appointments.ShowAppointments(appointment.Appointment_status);
            }

            else if (appointment.doctorId != null)
            {
                appointments = new ByDoctorID();
                return appointments.ShowAppointments(appointment.doctorId);
            }

            else if (appointment.patientId!=null)
            {
                appointments = new ByPatientID();
                return appointments.ShowAppointments(appointment.patientId);
            }

            else return null;

        }


        //public List<DOctor> GetDoctors(List<string> ids)
        //{
        //    DoctorServiceClient doc = new DoctorServiceClient();
        //    List<Doctor> doctors = new List<Doctor>(); 
        //    foreach(var d in ids)
        //    {
        //       doctors.Add(doc.GetDoctorByNpiNo(d));
        //    }
        //    return doctors;
        //}


        //prescription methods

        public bool AddPrescription(PrescriptionEF prescription)
        {
            DatabaseDB.prescriptions.Add(prescription);
            DatabaseDB.SaveChanges();
            return true;
        }
       
        
       
        
        public List<PrescriptionEF> ShowAllPrescripton(long id)
        {
            List<PrescriptionEF> prescriptions = new List<PrescriptionEF>();
            foreach(var prescription in DatabaseDB.prescriptions.ToList())
            {
                if (prescription.App_Id == id)
                    prescriptions.Add(prescription);

            }

            return prescriptions;
        }


       
        
        public bool UpdatePrescription(PrescriptionEF prescription)
        {

            foreach (var Uprescription in DatabaseDB.prescriptions.ToList())
            {

                if (Uprescription.App_Id==prescription.App_Id && Uprescription.Medicine_Name.Equals(prescription.Medicine_Name))
                {
                   
                    Uprescription.IsBeforeFood = prescription.IsBeforeFood;
                    Uprescription.Duration = prescription.Duration;
                    Uprescription.Medicine_cycle = prescription.Medicine_cycle;
                    Uprescription.Medicine_Description = prescription.Medicine_Description;
                    Uprescription.Status = prescription.Status;

                    DatabaseDB.SaveChanges();
                    return true;
                }
            }
            return false;
        }





    }
}
