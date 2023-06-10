using MvvmShellCalc.ViewModels;

namespace MvvmShellCalc;

public partial class MainPage : ContentPage
{

	
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		

	}
	

	
}

