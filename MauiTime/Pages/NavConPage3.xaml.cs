namespace MauiTime.Pages;


public partial class NavConPage3 : ContentPage
{
    public NavConPage3()
    {
        InitializeComponent();
    }

    private async void Nav3C_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavConPage1());
    }
}