using AutoMapper;
using CMD.Appointments.DTOs;
using CMD.Appointments.Models;
using CMD.Appointments.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Appointments.BusinessLogic
{
    public class PrescriptionManager
    {

        DbManager dbManager = new DbManager();
        PrescriptionEF prescription = new PrescriptionEF();
        List<PrescriptionDTO> prescriptionDTOs = new List<PrescriptionDTO>();
        List<PrescriptionEF> prescriptionEFs = new List<PrescriptionEF>();


        public bool Add(PrescriptionDTO prescriptionDTO)
        {

            Mapper.CreateMap<PrescriptionDTO, PrescriptionEF>();
            prescription = Mapper.Map<PrescriptionDTO, PrescriptionEF>(prescriptionDTO);


            bool added = dbManager.AddPrescription(prescription);
            if (added)
            { return true; }
            else
            { return false; }
        }


        public List<PrescriptionDTO> ShowAll(long id)
        {
            PrescriptionDTO prescriptionDTO = new PrescriptionDTO();
          
            //Get ALL Appointments from database
            prescriptionEFs = dbManager.ShowAllPrescripton(id);

            //converting EF to DTo entity
            Mapper.CreateMap<PrescriptionEF, PrescriptionDTO>();

            foreach (var prep in prescriptionEFs)
            {
                prescriptionDTO = Mapper.Map<PrescriptionEF, PrescriptionDTO>(prep);
                prescriptionDTOs.Add(prescriptionDTO);
            }

            //return appointments to service
            return prescriptionDTOs;
        }


        public bool Edit(PrescriptionDTO prescriptionDTO)
        {

            Mapper.CreateMap<PrescriptionDTO, PrescriptionEF>();
            prescription = Mapper.Map<PrescriptionDTO, PrescriptionEF>(prescriptionDTO);


            bool added = dbManager.UpdatePrescription(prescription);
            if (added)
            { return true; }
            else
            { return false; }
        }
    }
}
