using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;

namespace ClinicManagementProject.Services
{
    public class DoctorScheduleRepo : IRepo<DoctorSchedule, List<int>> //List<int> is to pass composite key {Timeslot_Id, Doctor_Id}
    {
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
            throw new NotImplementedException();
        }
    }
}
