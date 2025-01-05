using System.ComponentModel.DataAnnotations.Schema;
using AndroidX.Room;
using Java.Sql;

namespace WorkClocker
{
    [Entity(TableName ="work_days")]
    public class WorkDay(DateTime enterTime, DateTime exitTime, int hourlyPay)
    {
        [PrimaryKey]
        public int id;
        DateTime _enterTime = enterTime;
        DateTime _exitTime = exitTime;
        int _hourlyPay = hourlyPay;
        

        public DateTime EnterTime {get => _enterTime;}
        public DateTime ExitTime {get => _exitTime;}
        public int HourlyPay {get => _hourlyPay;}
        public TimeSpan WorkTime {get => _exitTime - _enterTime;}
    }
}