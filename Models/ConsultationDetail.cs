﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Models
{
    public class ConsultationDetail
    {
        [Key]
        public int Consultation_Id { get; set; }

        //foreign keys
        public int Patient_Id { get; set; }
        [ForeignKey("Patient_Id")]
        public Patient Patient {get;set;}

        public int Doctor_Id { get; set; }
        [ForeignKey("Doctor_Id")]
        public Doctor Doctor { get; set; }

        //properties
        public DateTime Date { get; set; }
        public string? Consultation_Remarks { get; set; } //consultation history....can be added by doctor
        public string Consultation_Status { get; set; } //once consultation remarks done, consultation is done, either "opened", "pending payment", "closed"
        public int? Bill { get; set; } //can be accessed and added by doctor/ admin ...can be "null"

    }
}