using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTdataReader
{
    public class PIDsegament
    {
        public string PatientID_External { get; set; }
        public string PatientID_Internal { get; set; }
        public string PatientName { get; set; }
        public string Patient_DOB { get; set; }
        public string Patient_Sex { get; set; }
        public string Patient_Address { get; set; }
        public string PhoneNo_Home { get; set; }
        public string PhoneNO_Business { get; set; }
        public string Marital_status { get; set; }
        public string SSN { get; set; }

        //public PID(string External_patID, string PatIDint, string name, string DOB, string Psex, string address, string HomePhone, string BusinessPhone, string MaritalS, string SSN)
        //{
        //    PatientID_External = External_patID;
        //    PatientID_Internal = PatIDint;
        //    PatientName = name;
        //    Patient_DOB = DOB;
        //    Patient_Sex = Psex;
        //    Patient_Address = address;
        //    PhoneNo_Home = HomePhone;
        //    PhoneNO_Business = BusinessPhone;
        //    Marital_status = MaritalS;
        //    this.SSN = SSN;
        //}

    }
}
