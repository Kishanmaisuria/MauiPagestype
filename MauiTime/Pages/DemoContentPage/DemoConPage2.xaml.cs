namespace MauiTime.Pages;

public partial class DemoConPage2 : ContentPage
{
	public DemoConPage2()
	{
		InitializeComponent();
	}
    private async void DCP1_Clicked(object sender, EventArgs e)
    {
       await Navigation.PopModalAsync();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoConPage3());

    }
}