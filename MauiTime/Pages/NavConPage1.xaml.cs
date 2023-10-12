namespace MauiTime.Pages;

public partial class NavConPage1 : ContentPage
{
	public NavConPage1()
	{
		InitializeComponent();
	}

    private async void Nav1_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavConPage2());
    }
}