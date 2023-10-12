using MauiTime.Pages;

namespace MauiTime
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NavConPage1());
        }
    }
}