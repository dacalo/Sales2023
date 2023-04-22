using SQLite;

namespace Sales.Mobile.MVVM.Abstractions
{
    public class TableData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
