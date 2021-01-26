using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MacroUI.Models
{
    public class NetworkDisplayModel
    {
        public int ID { get; set; }
        public string CCSD { get; set; }
        public string Domain { get; set; }
        [Display(Name = "Type")]
        public string CKT_Type { get; set; }
        public string Source { get; set; }
        [Display(Name = "Source Interface")]
        public string SInt { get; set; }
        [Display(Name = "Source IP")]
        public string SIP { get; set; }
        public string Destination { get; set; }
        [Display(Name = "Destination Interface")]
        public string DInt { get; set; }
        [Display(Name = "Destination IP")]
        public string DIP { get; set; }
        public string CCO { get; set; }
        [Phone]
        public string Phone { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
}
