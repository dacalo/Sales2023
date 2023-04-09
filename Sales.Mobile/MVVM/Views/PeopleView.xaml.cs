using Sales.Mobile.MVVM.ViewModels;

namespace Sales.Mobile.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
        BindingContext = new PeopleViewModel();
    }
}