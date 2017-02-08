using IoTHome.Data.DataAccess.DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTHome.Data.DataAccess
{
    public class IoTHomeData
    {
        IoTHomeDBEntities db = new IoTHomeDBEntities();

        public List<SensorRecordingDAO> GetSensorHistories()
        {
            var allSensorHistories = db.SensorHistories;
            List<SensorRecordingDAO> allSensorRecordingsDAO = new List<SensorRecordingDAO>();

            foreach (SensorHistory history in allSensorHistories)
            {
                allSensorRecordingsDAO.Add(DAOMapping.SensorHistoryToDAO(history));
            }

            return allSensorRecordingsDAO;
        }

    }
}
