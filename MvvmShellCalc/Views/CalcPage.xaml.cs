using MvvmShellCalc.ViewModels;

namespace MvvmShellCalc.Views;

public partial class CalcPage : ContentPage
{
	public CalcPage(CalcPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    

}