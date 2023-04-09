using Sales.Mobile.MVVM.ViewModels;

namespace Sales.Mobile.MVVM.Views;

public partial class DemoAutoPropertyChangedView : ContentPage
{
	public DemoAutoPropertyChangedView()
	{
		InitializeComponent();
        BindingContext = new DemoAutoPropertyChangedViewModel();
    }
}