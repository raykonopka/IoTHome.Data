using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IoTHome.Data.DataAccess.DTO_Models
{
    [DataContract]
    public class SensorRecordingDAO
    {
        [DataMember]
        public string Sensor { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public DateTime Time { get; set; }
    }
}