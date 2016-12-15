using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRCS1.Models
{
    public class PatientInfo
    {
        public int ID { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string PresBy { get; set; }
        [Required]
        public string Cause { get; set; }
        [Required]
        public string crossMatch { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Issue Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime issueDate { get; set; }
        [Display(Name = "Issue Time")]
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public DateTime? StartTime { get; set; }
        [Required]
        public string AdverseReaction { get; set; }
        public string Details { get; set; }
    }
}