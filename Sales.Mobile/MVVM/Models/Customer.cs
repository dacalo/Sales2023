using Sales.Mobile.MVVM.Abstractions;
using SQLite;

namespace Sales.Mobile.MVVM.Models
{
    [Table("Customers")]
    public class Customer : TableData
    {
        [Indexed, MaxLength(100), NotNull]
        public string Name { get; set; }

        [MaxLength(20), Unique]
        public string Phone { get; set; }

        public int Age { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
    }
}
