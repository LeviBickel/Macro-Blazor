using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MacroUI.Models
{
    public class SoftwareDisplayModel
    {
        public int ID { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Display(Name = "Software Title")]
        [Required]
        public string SoftwareTitle { get; set; }
        [Display(Name = "Installed on")]
        public string AssignedTo { get; set; }
        [Display(Name = "Purchase Order")]
        public string PurchaseOrder { get; set; }
        [Display(Name = "License Type")]
        public string LicenseType { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PurchaseDate { get; set; }
        public bool Supported { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SupportExp { get; set; }
        [Display(Name = "Total Keys")]
        [Required]
        public int TotalKeys { get; set; }
        [Display(Name = "Used Keys")]
        [Required]
        public int UsedKeys { get; set; }
        [Display(Name = "License Key")]
        public string LicenseKey { get; set; }
        [Display(Name = "Date Added")]
        [DataType(DataType.DateTime)]
        public DateTime Added { get; set; }
    }
}
