using Sales.Mobile.MVVM.Abstractions;

namespace Sales.Mobile.MVVM.Models
{
    public class Order : TableData
    {
        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
