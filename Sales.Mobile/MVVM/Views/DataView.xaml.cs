using Sales.Mobile.MVVM.ViewModels;

namespace Sales.Mobile.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
    }
}