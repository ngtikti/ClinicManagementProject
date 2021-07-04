using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using ClinicManagementProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementProject.Controllers
{
    public class PatientController : Controller
    {
        private readonly IRepo<Patient, string> _patientrepo;
        private readonly ILoginService<PatientViewModel, string> _patientlogin;
        private readonly IRepo<Doctor, string> _doctorrepo;
        private readonly IRepo<DoctorSchedule, List<int>> _doctorschedulerepo;
        private readonly IRepo<ConsultationDetail, int> _consultationdetailrepo;

        public PatientController(IRepo<Patient, string> patientrepo, IRepo<Doctor,string> doctorrepo, IRepo<DoctorSchedule, List<int>> doctorschedulerepo, IRepo<ConsultationDetail,int> consultationdetailrepo,ILoginService<PatientViewModel, string> patientlogin)
        {
            //_context = context; //for passing context into actions in controller
            _patientrepo = patientrepo;
            _patientlogin = patientlogin;

            _doctorrepo = doctorrepo;

            _doctorschedulerepo = doctorschedulerepo;

            _consultationdetailrepo = consultationdetailrepo;



        }


        // GET: PatientController

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //flow for patient. start from login page first
        public ActionResult Login()
        {
            PatientViewModel patient = new PatientViewModel();
            patient.Username = Convert.ToString(TempData["PatientUsername"]);
            return View(patient); //get method to show login page
        }

        [HttpPost]
        public ActionResult Login(PatientViewModel patient)
        {
            //Patient pat = _context.Patients.SingleOrDefault(p => p.Username == patient.Username); //should work as username is validated as only one in register

            //if (pat != null)
            //{
            //    using var hmac = new HMACSHA512(pat.PasswordSalt); //using pat passwordsalt as salt for keyed in patient
            //    var checkPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(patient.EnteredPassword));//encrypting into byte[] for keyed in password in login field...
            //    //checking if the byte[] of pat is the same as the byte[] of patient
            //    for(int i =0;i<checkPass.Length; i++)
            //    {
            //        if (checkPass[i] != pat.Password[i])
            //        {
            //            ViewData["Message"] = "Wrong username or password";
            //            return View();
            //        }
            //    }
            //    ViewData["Message"] = "Welcome" + pat.Name;
            //    TempData["PatientId"] = pat.Patient_Id;
            //    TempData["PatientName"] = pat.Name;
            //    return RedirectToAction("PatientConsole", "Patient"); //view and controller syntax

            //}
            //else
            //    ViewData["Message"] = "Invalid Username or Password";
            //return View();//remain to same login page, and display invalid username or password
            //calling patientloginservice object
            
            bool flag = _patientlogin.Login(patient);
            if (flag)
            {
                //log in success, means username and password correct
                ViewData["Message"] = "Welcome!"; 
                TempData["PatientUsername"] = patient.Username;
                Patient pat = _patientrepo.Get(patient.Username);
                TempData["PatientId"] = pat.Patient_Id; //locking in patient_id in tempdata for peeking\
                TempData["PatientUsername"] = pat.Username; //locking in Username in tempdata for peeking\
                return RedirectToAction("PatientConsole"); //view and controller syntax...and passing actual patient to the next...seems like patient to pass to next is too long due to password...have to only pass a part of it
            }
            else
            {
                //login fail
                ViewData["Message"] = "Invalid Username or Password";
                return View();//remain to same login page, and display invalid username or password
            }

        }

       

        public ActionResult Register()
        {
            PatientViewModel patientViewModel = new PatientViewModel();
            return View(patientViewModel); //get method to show login page
        }

        [HttpPost]
        public ActionResult Register(PatientViewModel patient)
        {
            ////validation will only be done when post..when button is pressed...and modelstate.isvalid allows us to make it such that the create to be passed to database only if true. important when savechanges. else database will reject cause required is required
            //if(ModelState.IsValid)//checking if patientviewmodel is entered correctly (includes inherited class of patient too)...with all the validations.eg. making sure required fields are keyed in, also checking through if password matches or not, else it will give exceptions
            //{
            //    Patient myPatient = patient;
            //    List<Patient> patients = _context.Patients.ToList();
            //    //encrypting password
            //    using var hmac = new HMACSHA512();
            //    myPatient.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(patient.EnteredPassword)); //encrypting keyed in password as password to myPatient.Password, with key
            //    myPatient.PasswordSalt = hmac.Key;

            //    //checking if username taken or not in patients
            //    bool usertaken = false;
            //    foreach (var item in patients)
            //    {
            //        if (patient.Username.ToLower() == item.Username.ToLower())//have to compare using lower as sql is case sensitive, will give fk error
            //        {
            //            usertaken = true;
            //        }
            //    }
            //    if (usertaken == true)
            //    {
            //        ViewBag.Message = "Username taken, please use another";
            //        return View();
            //    }
            //    else
            //    {
            //        _context.Patients.Add(myPatient);//adding myPatient to Patients, passed
            //        _context.SaveChanges();
            //        TempData["PatientUsername"] = myPatient.Username; //passing tempdata to login page for them to login
            //        return RedirectToAction("Login"); //get method to show login page
            //    }
            //}
            //ViewBag.Message = "Please fill in all the fields accordingly";

            
            bool flag = _patientlogin.Register(patient);
            if (flag)
            {
                TempData["PatientUsername"] = patient.Username;
                return RedirectToAction("Login");
            }
            ViewBag.Message = "Invalid entry. Please fill in again"; //if got time, think of a way to separate the diff errors (can use modelstate) (actually, invalidation is directly shown to cshtml if said. cool! now the only non mentioned, is invalid username)
            return View();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //patient console to link to all other modules
        public ActionResult PatientConsole() //...since model is patient, passed has to be patient or child of patient, else null. to show patient console page...have action links to bookappointment (view doctor, view doctorschedule,update doctorschedule), access reportandbill, cancel existing appointment
        {
            //clearing any prior messages

            //getting the patient from TempData["PatientId"]
            int patid = Convert.ToInt32(TempData.Peek("PatientId"));
            Patient pat = _patientrepo.GetAll().SingleOrDefault(p => p.Patient_Id == patid);
            ViewData["Message"] = "Welcome " + pat.Name;

            //for displaying any message from other modules
            ViewData["BookingMessage"] = TempData["BookingMessage"]; //this works as tempdata will only be there once from previous page...after that will be gone
            ViewData["DeleteBookingMessage"] = TempData["DeleteBookingMessage"];
            return View(pat);//...pat is to make sure model is refering to pat....else null error....should pass model.Username to the action links
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //to bookappointment (view doctor list, then view doctorschedule,update doctorschedule)
        public ActionResult BookAppointment() //model is doctor list, action link to doctorschedule by Doctor_Id
        {
 
            ICollection<Doctor> doctors = _doctorrepo.GetAll();
            return View(doctors);
        }

        public ActionResult BookAppointment_Schedule(int id)//this would be an action link to a post method (with doctorschedule model) to update doctorschedulerepo...getting the doctor_id as id, and patient_username as TempData["PatientUsername"]
        {

            ICollection<DoctorSchedule> doctorSchedule = _doctorschedulerepo.GetAll(id); //getting all the doctorschedule according to doctorId
            return View(doctorSchedule.Where(ds => ds.Patient_Id == null)); //displaying only the slots where patient_id has not been input
        }

        public ActionResult BookSlotForPatient(int timeid, int docid)//model will be the doctorschedule
        {
            
            TempData["TimeId"] = timeid;
            TempData["DocId"] = docid;


            ICollection<Doctor> doctors = _doctorrepo.GetAll();
            Doctor doc = doctors.SingleOrDefault(d => d.Doctor_Id == docid);
            ViewData["DoctorName"] = doc.Name;


            List<int> timeslotchosen = new List<int> { timeid, docid }; //putting composite id in format for Get method in doctorschedulerepo
            DoctorSchedule slotToBook = _doctorschedulerepo.Get(timeslotchosen);
            return View(slotToBook);
        }

        [HttpPost]
        public ActionResult BookSlotForPatient()//model will be the doctorschedule
        {
            //getting ids from previous section
            int patid = Convert.ToInt32(TempData.Peek("PatientId")); //getting patientId from previous action
            int timeid = Convert.ToInt32(TempData.Peek("TimeId"));
            int docid = Convert.ToInt32(TempData.Peek("DocId"));

            List<int> timeslotchosen = new List<int> { timeid, docid }; //for composite key
            DoctorSchedule doctorSchedule = _doctorschedulerepo.Get(timeslotchosen); //getting doctorschedule to update
            
            doctorSchedule.Patient_Id = patid; //adding patid to doctorschedule
            bool flag = _doctorschedulerepo.Edit(timeslotchosen, doctorSchedule); //updating repository to push update to database
            if (flag)
            {
                ViewData["Message"] = "Booking Success";
                //should update consultation detail as well. create new consultation detail, and add consultation status as opened...add patientid, docid, and date
                ConsultationDetail consultationDetail = new ConsultationDetail();
                consultationDetail.Doctor_Id = docid;
                consultationDetail.Patient_Id = patid;
                consultationDetail.Timeslot = doctorSchedule.Time;
                consultationDetail.Consultation_Status = "opened"; //new booking so open consultation status
                _consultationdetailrepo.Add(consultationDetail);

                TempData["BookingMessage"]= "Booking Success";
                
            }
            else
            {
                
                ViewData["Message"] = "Booking failed";
                TempData["BookingMessage"] = "Booking failed, please try again";
                
            }
            return RedirectToAction("PatientConsole");//returning to console, 

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //module to book and delete appointments
        public ActionResult ViewBookedAppointments() //list of booked appointments (consultationdetail list as model)
        {
            int patid = Convert.ToInt32(TempData.Peek("PatientId"));
            ICollection<ConsultationDetail> consultationDetails = _consultationdetailrepo.GetAll();
            ICollection<ConsultationDetail> bookedAppointments;
            if (consultationDetails != null)
            {
                bookedAppointments = consultationDetails.Where(cd => cd.Patient_Id == patid && cd.Consultation_Status == "opened").ToList(); //only those appointments that are opened can be canceled before the appointment itself
            }
            else
            {
                bookedAppointments = new List<ConsultationDetail> { };//passing a null list of models
            }
            
            return View(bookedAppointments);
        }

        public ActionResult CancelAppointment(int consultationid)
        {
            TempData["ConsultationId"] = consultationid;
            ConsultationDetail slottocancel = _consultationdetailrepo.Get(consultationid);
            return View(slottocancel);
        }

        [HttpPost]
        public ActionResult CancelAppointment()
        {
            //deleting patient_id from doctorslot to free up doctorschedule
            ConsultationDetail con = _consultationdetailrepo.Get(Convert.ToInt32(TempData.Peek("ConsultationId")));
            string timebooked = con.Timeslot; 
            int docid = con.Doctor_Id;
            DoctorSchedule docsch = _doctorschedulerepo.GetAll().SingleOrDefault(ds => ds.Time == timebooked && ds.Doctor_Id == docid);
            int timeid = docsch.Timeslot_Id;
            List<int> dskey = new List<int> { timeid, docid };

            docsch.Patient_Id = null; //changing patientid to null
            bool flag= _doctorschedulerepo.Edit(dskey, docsch);//updating slot to remove patientid

            //deleting consultationdetail record
            bool flag2 = _consultationdetailrepo.Delete(Convert.ToInt32(TempData.Peek("ConsultationId")));
           
            if (flag && flag2)
            {
                TempData["DeleteBookingMessage"] = "Booking deleted!";
            }
            else
            {
                TempData["DeleteBookingMessage"] = "Delete booking failed, please try again";
            }
            return RedirectToAction("PatientConsole");
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //module to view past consultation remarks (for consultation status closed, if any) [need testing with whole code]
        public ActionResult ViewPastReport()
        {
            int patid = Convert.ToInt32(TempData.Peek("PatientId"));
            ICollection<ConsultationDetail> consultationDetails = _consultationdetailrepo.GetAll();
            ICollection<ConsultationDetail> pastAppointments;
            if (consultationDetails != null)
            {
                pastAppointments = consultationDetails.Where(cd => cd.Patient_Id == patid && cd.Consultation_Status == "closed").ToList(); //view those appointments that were closed
            }
            else
            {
                pastAppointments = new List<ConsultationDetail> { };//passing a null list of models
            }

            return View(pastAppointments);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //module to make payment (for consultation status payment pending, if any) [need testing with whole code]
        public ActionResult MakePayment()
        {
            return View();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //modules to update details for patient
        public ActionResult UpdateParticulars() //for phone, address, etc personal particulars...will have an edit field, and a post method for this
        {
            return View();
        }

        public ActionResult ChangePassword() //module to change password
        {
            return View();
        }

    }
}


