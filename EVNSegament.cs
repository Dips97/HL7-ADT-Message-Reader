using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTdataReader
{
    class EVNSegament
    {
        public string EventTypeCode { get; set; }
        public string RecordedDateTime { get; set; }
        public string DateTimePlannedEvent { get; set; }
        public string EventReasonCode { get; set; }
        public string OperatorID { get; set; }
        public string EventOccured { get; set; }
    }
}
