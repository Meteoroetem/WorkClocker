using SQLite;

namespace WorkClocker
{
    [Table("workdays")]
    public class WorkDay(DateTime enterTime, DateTime exitTime, int hourlyPay)
    {
        DateTime _enterTime = enterTime;
        DateTime _exitTime = exitTime;
        int _hourlyPay = hourlyPay;
        

        [PrimaryKey,AutoIncrement,Column("id")]
        public int Id {get; set;}
        [Column("enter_time")]public DateTime EnterTime {get => _enterTime;}
        [Column("exit_time")]public DateTime ExitTime {get => _exitTime;}
        [Column("hourly_pay")]public int HourlyPay {get => _hourlyPay;}
        [Column("work_time")]public TimeSpan WorkTime {get => _exitTime - _enterTime;}
    }
}