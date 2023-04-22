using Sales.Mobile.MVVM.ViewModels;

namespace Sales.Mobile.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
        BindingContext = new DataViewModel();
    }
}