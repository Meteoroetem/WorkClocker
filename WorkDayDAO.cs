using AndroidX.Room;


namespace WorkClocker
{
    [Dao]
    public interface WorkDayDAO
    {
        [Insert(OnConflict =OnConflictStrategy.Ignore)]
        void Insert(WorkDay workDay);
        [Delete]
        void Delete(WorkDay workDay);
        [Query(Value = "SELECT * FROM work_days SORT BY ")]
        List<WorkDay> GetWorkDaysByDate();
    }
}