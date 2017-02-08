using IoTHome.Data.DataAccess;
using IoTHome.Data.DataAccess.DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IoTHome.Data.DataService
{
    public class DataService : IDataService
    {
        private IoTHomeData data = new IoTHomeData();

        public List<SensorRecordingDAO> GetAllSensorHistories()
        {
            return data.GetSensorHistories();
        }
    }
}
