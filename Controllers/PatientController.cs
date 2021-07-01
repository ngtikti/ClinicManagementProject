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

        public PatientController(IRepo<Patient, string> patientrepo, IRepo<Doctor,string> doctorrepo, ILoginService<PatientViewModel, string> patientlogin)
        {
            //_context = context; //for passing context into actions in controller
            _patientrepo = patientrepo;
            _patientlogin = patientlogin;

            _doctorrepo = doctorrepo;
    
        }


        // GET: PatientController

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
                return RedirectToAction("PatientConsole", "Patient", patient); //view and controller syntax...and passing actual patient to the next...seems like patient to pass to next is too long due to password...have to only pass a part of it
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


        public ActionResult PatientConsole(Patient p) //...since model is patient, passed has to be patient or child of patient, else null. to show patient console page...have action links to bookappointment (view doctor, view doctorschedule,update doctorschedule), access reportandbill, cancel existing appointment
        {
            Patient pat = _patientrepo.Get(p.Username);//calling the actual patient using username in order to get the name to say welcome lol
            ViewData["Message"] = "Welcome " + pat.Name;
            return View(pat);//...pat is to make sure model is refering to pat....else null error....should pass model.Username to the action links
        }

        //to bookappointment (view doctor list, then view doctorschedule,update doctorschedule)
        public ActionResult BookAppointment(string str) //model is doctor list, action link to doctorschedule by Doctor_Id
        {
            string patusername = str;
            ICollection<Doctor> doctors = _doctorrepo.GetAll();
            return View(doctors);
        }

        //public ActionResult BookAppointment_Schedule()//this would be an action link to a post method (with doctorschedule model) to update doctorschedulerepo
        //{
            //need to figure out how to pass both patusername and doctor_id into here....then subsequently show list of DoctorSchedule as view() with doctor_id....then post method is to update the patient_Id of the selected schedule
        //}

    }
}
