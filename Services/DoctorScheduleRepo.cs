using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using Microsoft.Extensions.Logging;

namespace ClinicManagementProject.Services
{
    public class DoctorScheduleRepo : IRepo<DoctorSchedule, List<int>> //List<int> is to pass composite key {Timeslot_Id, Doctor_Id}
    {
        private readonly ClinicManagementContext _context;
        private readonly ILogger<DoctorScheduleRepo> _logger;

        public DoctorScheduleRepo(ClinicManagementContext context, ILogger<DoctorScheduleRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool Add(DoctorSchedule t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<int> k)
        {
            throw new NotImplementedException();
        }

        public bool Edit(List<int> k, DoctorSchedule t)
        {
            throw new NotImplementedException();
        }

        public DoctorSchedule Get(List<int> k)
        {
            throw new NotImplementedException();
        }

        public ICollection<DoctorSchedule> GetAll()
        {
            if (_context.DoctorSchedules.Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.DoctorSchedules.ToList();
        }

        public ICollection<DoctorSchedule> GetAll(int id) //additional method to get schedule by doctor id
        {
            if (_context.DoctorSchedules.Where(ds=>ds.Doctor_Id==id).Count() == 0)
            {
                _logger.LogInformation("No schedule found");
                return null;
            }
            return _context.DoctorSchedules.Where(ds => ds.Doctor_Id == id).ToList();
        }
    }
}
