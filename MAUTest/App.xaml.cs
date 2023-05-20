using MAUTest.MVVM.Views;

namespace MAUTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CalculatorView());
        }
    }
}