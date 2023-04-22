using Sales.Mobile.BindingDemo;
using Sales.Mobile.ControlsDemo;
using Sales.Mobile.MVVM.Models;
using Sales.Mobile.MVVM.Repository;
using Sales.Mobile.MVVM.Views;
using Sales.Mobile.PagesDemo;
using PresentationControlsDemo = Sales.Mobile.PagesDemo.PresentationControlsDemo;

namespace Sales.Mobile
{
    public partial class App : Application
    {
        public static BaseRepository<Customer> CustomerRepo { get; private set; }

        public static BaseRepository<Order> OrderRepo { get; private set; }

        public App(BaseRepository<Customer> customerRepo, BaseRepository<Order> orderRepo)
        {
            InitializeComponent();
            CustomerRepo = customerRepo;
            OrderRepo = orderRepo;
            MainPage = new NavigationPage(new MainPage());
        }
    }
}