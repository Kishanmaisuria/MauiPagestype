namespace MauiTime.Pages;

public partial class DemoConPage3 : ContentPage
{
	public DemoConPage3()
	{
		InitializeComponent();
	}

    private async void DCP1_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}