using MAUTest.MVVM.ViewModels;

namespace MAUTest.MVVM.Views;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
        InitializeComponent();
        BindingContext = new CalculatorViewModel();
    }
}