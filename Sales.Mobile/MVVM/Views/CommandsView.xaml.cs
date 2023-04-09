using Sales.Mobile.MVVM.ViewModels;

namespace Sales.Mobile.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
        BindingContext = new CommandsViewModel();
    }
}