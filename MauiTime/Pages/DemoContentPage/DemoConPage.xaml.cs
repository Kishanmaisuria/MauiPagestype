namespace MauiTime.Pages;

public partial class DemoConPage : ContentPage
{
	public DemoConPage()
	{
        InitializeComponent();
	}
	private async void DCP2_Clicked(object sender, EventArgs e) 
	{
		await	Navigation.PushModalAsync(new DemoConPage2());
	}
}