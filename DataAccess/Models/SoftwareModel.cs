using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class SoftwareModel
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string SoftwareTitle { get; set; }
        public string AssignedTo { get; set; }
        public string PurchaseOrder { get; set; }
        public string LicenseType { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Supported { get; set; }
        public DateTime SupportExp { get; set; }
        public int TotalKeys { get; set; }
        public int UsedKeys { get; set; }
        public string LicenseKey { get; set; }
        public DateTime Added { get; set; }
    }
}
