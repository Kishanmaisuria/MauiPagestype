using MauiTime.Pages;
using MauiTime.Pages.FlyoutPages;
using MauiTime.Pages.TabPages;

namespace MauiTime
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navigationPage = new NavigationPage(new NavConPage1());
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.Black;
            //MainPage = navigationPage;

            //MainPage = new FlyPages();


            MainPage = new TabPage();
        }
    }
}