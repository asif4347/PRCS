using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRCS1.Models
{
    public class BloodCampusInfo
    {
        public int ID { get; set; }
        [Required]
        [Display(Name ="Blood Campus")]
        public string BloodCampus { get; set; }
        [Display(Name ="Start Time")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        [DataType(DataType.Time)]
        public DateTime? StartTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name ="Organized Date")]
        public DateTime OrganizedDate { get; set; }
        [Required]
        [Display(Name ="Institute Name")]
        public string InstituteName { get; set; }
        [Required]
        [Display(Name ="Address")]
        public string  InstituteAddress { get; set; }
        [Display(Name ="District")]
        public string InstituteDistrict { get; set; }
        [Display(Name ="Dean's Contact")]
        public string DeansContact { get; set; }
        [Display(Name ="Society Number")]
        public string SocietyContact { get; set; }
        [Required]
        [Display(Name ="No of Blood Bags Collected")]
        public int NoOfBags { get; set; }

    }
    
}