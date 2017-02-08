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
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        List<SensorRecordingDAO> GetAllSensorHistories();
    }
}
