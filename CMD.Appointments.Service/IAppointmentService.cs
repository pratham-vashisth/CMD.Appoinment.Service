using CMD.Appointments.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.Service
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IAppointmentService
    {
        [OperationContract]
        bool AddAppointment(AppointmentDTO appointment);
        [OperationContract]
        List<AppointmentDTO> getAppointmentById(long App_id);

        [OperationContract]
        List<AppointmentDTO> getAllAppointmentsOfDoctor(string Doc_id);

        [OperationContract]
        List<AppointmentDTO> getAllAppointmentsOfPatient(string Pat_Emailid);
       
        [OperationContract]
        List<AppointmentDTO> getAllAppointmentsAccToStatus(String status);

        [OperationContract]
        bool SetAppointmentStatus(String app_id, String status);

        
        
        
      
        
        [OperationContract]
        List<PrescriptionDTO> ShowAllPrescripton(long id);

        [OperationContract]
        bool EditPrescription(PrescriptionDTO prescription);

        [OperationContract]
        bool AddPrescription(PrescriptionDTO prescription);
    }
}
