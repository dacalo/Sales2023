namespace Sales.Mobile.PagesDemo;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}