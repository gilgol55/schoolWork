using MvvmShellCalc.ViewModels;

namespace MvvmShellCalc.Views;

public partial class HistoryPage : ContentPage
{
    
    public HistoryPage(HistoryPageViewModels vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
        
    }
    
}