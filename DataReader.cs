using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTdataReader
{
    class DataReader
    {
        private string _textpath;
        public DataReader(string txtfile)
        {
            _textpath = txtfile;
        }
        public string[] MSH_data()              //MSH Segament
        {
            string[] mshLine;
            string MSHLine = string.Empty;

            using(var sr = new StreamReader(_textpath))
            {
                MSHLine = sr.ReadLine();
            }
            mshLine = MSHLine.Split('|');
            return mshLine;
        }

        public string[] EVN_data()              //EVN Segament
        {
            string[] evnLine;
            string EVNLine;
            using(var sr2 = new StreamReader(_textpath))
            {
                for(int i=0; i<1; i++)
                {
                    sr2.ReadLine();
                }
                EVNLine = sr2.ReadLine();
            }
            evnLine = EVNLine.Split('|');
            return evnLine;
        }

        public string[] Pid_Data()              //PID Segamant
        {
            string[] pidLine;
            string PIDLine = string.Empty;

            using (var sr3 = new StreamReader(_textpath))
            {
                for (int i = 0; i < 2; i++)
                {
                    sr3.ReadLine();
                }
                PIDLine = sr3.ReadLine();

            }
            pidLine = PIDLine.Split('|');

            return pidLine;
        }
    }
}
