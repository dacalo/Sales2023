using Sales.Mobile.PagesDemo;

namespace Sales.Mobile
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageDemo());
        }
    }
}