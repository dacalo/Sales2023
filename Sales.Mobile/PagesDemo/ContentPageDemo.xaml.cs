namespace Sales.Mobile.PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Navigation.PopAsync();
        Navigation.PushAsync(new AnotherPage());
    }
}