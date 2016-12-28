using PRCS1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PRCS.Models
{
    public class BloodDonorInfo
    {

        public int ID { get; set; }
        public int Sr { get; set; }
        [Required]
        [Display(Name = "Donor#")]
        public string DonorNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "S/o.D/o")]
        public string SonOf { get; set; }
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DOB { get; set; }
        public float Weight { get; set; }
        [Required]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Display(Name = "Last Donation")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Required]
        public DateTime LastDonation { get; set; }

        [Display(Name = "No. of Donation")]
        public int NoOfDonation { get; set; }
        
        [Required]
        public string Adress { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        [DisplayFormat( ApplyFormatInEditMode = true)]
        public string PermanentDonor { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string HBsAg { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string HCV { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string HIV { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string Syphilis { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true)]
        public string Malaria { get; set; }
        public string Institute { get; set; }
        public string Class { get; set; }

       
        [Display(Name = "Office Telephone")]
        public string TelOffice { get; set; }
       
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
      //  [Display(Name ="Donor's Reaction")]
        public string DonorReaction { get; set; }
        public string Other { get; set; }
        public string Nausia { get; set; }
        [Display(Name = "Vometing")]
        public string Vom { get; set; }
        public string  Dizziness { get; set; }
        public string Fainting { get; set; }
        public string Convulsions { get; set; }
       // [Display(Name = "Select Donor")]
        public string isSelected { get; set; }
        [Display(Name="Patient Name")]
        public string PatientName { get; set; }

        public string PresBy { get; set; }

        public string Cause { get; set; }

        public string crossMatch { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime issueDate { get; set; }

      //  public DateTime? StartTime { get; set; }

        public string AdverseReaction { get; set; }
        public string Details { get; set; }



    }

    public class BloodDbContext : DbContext
    {

        public DbSet<BloodDonorInfo> BloodInfo { get; set; }
        public DbSet<BloodCampusInfo> CampusInfo { get; set; }
        public DbSet<LibTestBlood> LibTest { get; set; }
        public DbSet<BloodBankTest> BloodBank { get; set; }
                                           //  public DbSet<PatientInfo> patientInfo { get; set; }
    }

}

