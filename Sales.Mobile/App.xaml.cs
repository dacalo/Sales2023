using Sales.Mobile.BindingDemo;
using Sales.Mobile.ControlsDemo;
using Sales.Mobile.PagesDemo;
using PresentationControlsDemo = Sales.Mobile.PagesDemo.PresentationControlsDemo;

namespace Sales.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //var navPage = new NavigationPage(new FlyoutPageDemo());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            //MainPage = navPage;
            MainPage = new BindigPage();
        }
    }
}