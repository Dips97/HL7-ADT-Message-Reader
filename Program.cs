using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADTdataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtfile = @"C:\Users\LENOVO\source\repos\ADTdataReader\ADT.txt";
            DataReader data = new DataReader(txtfile);

            var MSHLineData = data.MSH_data();
            MSHsegament msh = new MSHsegament();
            msh.Type = MSHLineData[8];

            var EVNLineData = data.EVN_data();
            EVNSegament evn = new EVNSegament();
            evn.EventTypeCode = EVNLineData[1];

            var pidLineData = data.Pid_Data();
            PIDsegament pid = new PIDsegament();
            pid.PatientID_Internal = pidLineData[3];




            Console.WriteLine($"You are viewing {msh.Type} Message: Patient Registration");
            Console.WriteLine($"Event Type Code: {evn.EventTypeCode}");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Here are the data: ");
            Console.WriteLine($"\nPatient name: {pid.PatientName} \nPatient ID: {pid.PatientID_Internal} \nSSN Number: {pid.SSN} " +
                $"\nGender: {pid.Patient_Sex} \nDate of Birth: {pid.Patient_DOB} \nPhone Number: {pid.PhoneNo_Home} \nAddress: {pid.Patient_Address} ");
            Console.WriteLine($"Patient ID: {pid.PatientID_Internal}");
            Console.ReadLine();
        }
    }
}
