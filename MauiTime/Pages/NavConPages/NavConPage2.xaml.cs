namespace MauiTime.Pages;

public partial class NavConPage2 : ContentPage
{
	public NavConPage2()
	{
		InitializeComponent();
	}
    private async void Nav2_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavConPage3());
    }

    private async void Nav2C_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavConPage1());
    }


}