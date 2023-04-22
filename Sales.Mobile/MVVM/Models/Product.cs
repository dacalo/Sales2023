namespace Sales.Mobile.MVVM.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }

        public bool HasOffer { get; set; }

        public decimal OfferPrice { get; set; }
    }
}
