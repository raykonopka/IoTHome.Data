using IoTHome.Data.DataAccess.DTO_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTHome.Data.DataAccess
{
    public class DAOMapping
    {
        public static SensorRecordingDAO SensorHistoryToDAO(SensorHistory history)
        {
            SensorRecordingDAO recordingDAO = new SensorRecordingDAO();

            recordingDAO.Sensor = history.SensorName;
            recordingDAO.Value = history.SavedValue;
            recordingDAO.Time = history.TimeSaved;

            return recordingDAO;
        }

        public static SensorHistory DAOToSensorHistory(SensorRecordingDAO recordingDAO)
        {
            SensorHistory history = new SensorHistory();

            history.SensorName = recordingDAO.Sensor;
            history.SavedValue = recordingDAO.Value;
            history.TimeSaved = recordingDAO.Time;

            return history;
        }

    }
}
