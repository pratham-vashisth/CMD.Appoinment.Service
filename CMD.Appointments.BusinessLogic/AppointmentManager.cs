using AutoMapper;
using CMD.Appointments.DTOs;
using CMD.Appointments.Models;
using CMD.Appointments.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.BusinessLogic
{
    public class AppointmentManager
    {
        DbManager dbManager = new DbManager();
        AppointmentEF appointment = new AppointmentEF();
        List<AppointmentDTO> appointmentDTOs = new List<AppointmentDTO>();
        List<AppointmentEF> appointmentEFs = new List<AppointmentEF>();

        public bool AddAppointment(AppointmentDTO appointmentDTO)
        {


            //automapper and passing


         
            Mapper.CreateMap<AppointmentDTO, AppointmentEF>();
            appointment = Mapper.Map<AppointmentDTO, AppointmentEF>(appointmentDTO);


           bool added=dbManager.AddAppointment(appointment);
            if (added)
            { return true; }
            else
            { return false; }
        }

      
        public bool UpdateAppointmentStatus(string app_id , string status)
        {

            //appointment = Mapper.Map<AppointmentDTO, AppointmentEF>(appointmentDTO);
            long id = long.Parse(app_id);
            bool save =dbManager.SetAppointmentStatus(id,status);

            if (save)
            { return true; }
            else
            { return false; }
        }

      
        
        public List<AppointmentDTO> getAllAppointments(AppointmentDTO appointmentDTO)
        {
            //converting DTO to EF entity
            Mapper.CreateMap<AppointmentDTO, AppointmentEF>();          
            appointment = Mapper.Map<AppointmentDTO, AppointmentEF>(appointmentDTO);
            
            //Get ALL Appointments from database
            appointmentEFs= dbManager.GetAppointmnents(appointment);

            //converting EF to DTo entity
            Mapper.CreateMap<AppointmentEF, AppointmentDTO>();

            foreach (AppointmentEF app in appointmentEFs)
            {
                appointmentDTO = Mapper.Map<AppointmentEF, AppointmentDTO>(app);
                appointmentDTOs.Add(appointmentDTO);
            }
               
            //return appointments to service
            return appointmentDTOs;
        }

        //public List<DoctorService.Doctor> GetALLdoctors(List<AppointmentDTO> app)
        //{
        //    List<string> doc = new List<string>();
        //    foreach(var d in app)
        //    {
        //        string i = d.doctorId;
        //        doc.Add(i);
        //    }

        //}
    }
}       
