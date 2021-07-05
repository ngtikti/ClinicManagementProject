using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ClinicManagementProject.Services
{
    public class ConsultationDetailRepo : IConsult<ConsultationDetail, int>
    {
        private readonly ClinicManagementContext _context;
        private readonly ILogger<ConsultationDetailRepo> _logger;

        public ConsultationDetailRepo(ClinicManagementContext context, ILogger<ConsultationDetailRepo> logger)
        {
            _context = context;
            _logger = logger;
        }


        public bool Add(ConsultationDetail t)
        {
            try
            {
                _context.ConsultationDetails.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("Consultationdetails opened", t);
                return true;
            }

            catch (Exception e)
            {
                _logger.LogError("Could not add consultation details " + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public bool Delete(int k)
        {
            try
            {
                var consultationDetail = Get(k);
                _context.ConsultationDetails.Remove(consultationDetail); //to remove the entire consultationdetail record
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to delete the timeslot" + k + " " + e.Message);
            }
            return false;
        }

        public bool Edit(int k, ConsultationDetail t)
        {
            try
            {
                _context.Update(t);//this requires get to be called first
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update doctor schedule " + k + e.Message);
                return false;
            }

        }

        public ConsultationDetail Get(int k)
        {
            try
            {
                var consultationDetail = _context.ConsultationDetails.SingleOrDefault(cd=>cd.Consultation_Id ==k);
                return consultationDetail;
            }
            catch (Exception e)
            {
                _logger.LogError("No detail found for this id " + k + " " + e.Message);
            }
            return null;
        }

        public ConsultationDetail Get(string k)
        {
            var detail = _context.ConsultationDetails.SingleOrDefault(p => p.Consultation_Id == Convert.ToInt32(k));
            return detail;
        }


        public ICollection<ConsultationDetail> GetAll()
        {
            if (_context.ConsultationDetails.Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.ConsultationDetails.ToList();
        }


        public ICollection<ConsultationDetail> GetAll(string pend)
        {
            if (_context.ConsultationDetails.Count() == 0)
            {
                _logger.LogInformation("No Consultation record");
                return null;
            }
            return _context.ConsultationDetails.Include(c => c.Patient).Where(p => p.Consultation_Status.ToLower() == pend.ToLower()).ToList();
        }

        public ICollection<ConsultationDetail> GetAll(int id)
        {
            throw new NotImplementedException();
        }



        public bool Update(string k)
        {
            try
            {
                var detail = Get(k);
                detail.Consultation_Status = "Consultation Closed";
                _context.Update(detail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Unable to update the pizza details" + k + " " + e.Message);
            }
            return false;
        }
    }
}
