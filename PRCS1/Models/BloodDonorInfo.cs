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
        public string RegNo { get; set; }
        public string DonorNo { get; set; }
        public string SerialNo { get; set; }
        
        public string Name { get; set; }
        [Display(Name ="S/o.D/o")]
        public string SonOf { get; set; }
        public string Gender { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        
        public DateTime DOB { get; set; }
        public float Weight { get; set; }

        [Display(Name ="Blood Group")]
        public string BloodGroup { get; set; }

        [Display(Name = "Last Donation")]
        [DataType(DataType.Date)]
       
        public DateTime LastDonation { get; set; }

        [Display(Name = "No. of Donation")]
        public int NoOfDonation { get; set; }
        public string Institute { get; set; }
        public string Class { get; set; }

        [Display(Name = "Residance Telephone")]
        public string TelResidance { get; set; }
        [Display(Name = "Office Telephone")]
        public string TelOffice { get; set; }
        public string FAX { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }

    public class BloodDbContext : DbContext
    {

        public DbSet<BloodDonorInfo> BloodInfo { get; set; }

    }

}

