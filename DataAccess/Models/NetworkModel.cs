using System;

namespace DataAccess.Models
{
    public class NetworkModel
    {
        public int ID { get; set; }
        public string CCSD { get; set; }
        public string Domain { get; set; }
        public string CKT_Type { get; set; }
        public string Source { get; set; }
        public string SInt { get; set; }
        public string SIP { get; set; }
        public string Destination { get; set; }
        public string DInt { get; set; }
        public string DIP { get; set; }
        public string CCO { get; set; }
        public string Phone { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
}
