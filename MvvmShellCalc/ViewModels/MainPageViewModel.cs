using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MvvmShellCalc.ViewModels
{
    public class MainPageViewModel:ViewModel
    {
        public ICommand calcCommand { get; private set; }
        public VerticalStackLayout VerticalStackLayout { get; private set; }
        public ICommand registerCommand {get;private set;}
        public Button registerButton { get;private set;}
        public MainPageViewModel()
        {
            registerCommand = new Command(registerClicked) { }; 
        }
        public void registerClicked()
        {
            registerButton.IsVisible=false;
            Button calcButton = new Button();
            calcButton.Command = calcCommand;
            calcButton.Text = "calculator";


            VerticalStackLayout.Add(calcButton);
        }
    }
}
