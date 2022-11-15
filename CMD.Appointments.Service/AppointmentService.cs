
using CMD.Appointments.BusinessLogic;
using CMD.Appointments.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Service
{
    [ServiceBehavior]
    public class AppointmentService : IAppointmentService
    {
        
        BusinessLogic.AppointmentManager appointmentManager = new BusinessLogic.AppointmentManager();
        AppointmentDTO appointment = new AppointmentDTO();
        PrescriptionManager prescriptionManager = new PrescriptionManager();
       
        [OperationBehavior]
        public bool AddAppointment(AppointmentDTO appointment)
        {
           return appointmentManager.AddAppointment(appointment);
        }

        public List<AppointmentDTO> getAppointmentById( long App_id)
        {
            appointment.App_Id = App_id;

            return appointmentManager.getAllAppointments(appointment);
        }

        public List<AppointmentDTO> getAllAppointmentsOfDoctor(string Doc_id)
        {
            appointment.doctorId = Doc_id;

            return appointmentManager.getAllAppointments(appointment);
        }
     
        public List<AppointmentDTO> getAllAppointmentsOfPatient(string Pat_id)
        {
            appointment.patientId = Pat_id;

         

            return appointmentManager.getAllAppointments(appointment);
        }

        public List<AppointmentDTO> getAllAppointmentsAccToStatus(string status)
        {
            appointment.Appointment_status = status;

            return appointmentManager.getAllAppointments(appointment);
        }

        public bool SetAppointmentStatus(string app_id, string status)
        {
            return appointmentManager.UpdateAppointmentStatus(app_id, status);
        }




        public bool AddPrescription(PrescriptionDTO prescription) 
        {
            return prescriptionManager.Add(prescription);
        }
      


        public List<PrescriptionDTO> ShowAllPrescripton(long App_id) 
        { 
            return prescriptionManager.ShowAll(App_id); 
        }


        public bool EditPrescription(PrescriptionDTO prescription) 
        {
            return prescriptionManager.Edit(prescription);
        }
    }
}
