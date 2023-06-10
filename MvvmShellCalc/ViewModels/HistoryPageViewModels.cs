using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Windows.Input;
using MvvmShellCalc.Models;


namespace MvvmShellCalc.ViewModels
{
    // acctually the calculator page
    public class HistoryPageViewModels:ViewModel
    {
        private static bool firsTime = true;
        private string tempresult;
        private string result;
        private string currentNumber;
        private string selectedOperator;

        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public ICommand NumberCommand { get; private set; }
        public ICommand OperatorCommand { get; private set; }
        public ICommand ClearCommand { get; private set; }
        public ICommand CalculateCommand { get; private set; }

        public HistoryPageViewModels()
        {
            NumberCommand = new Command<string>(AddNumber);
            OperatorCommand = new Command<string>(SelectOperator);
            ClearCommand = new Command(Clear);
            CalculateCommand = new Command(Calculate);

            currentNumber = string.Empty;
            selectedOperator = string.Empty;
            tempresult = string.Empty;
            result = string.Empty;
            
        }

        
        
        private void AddNumber(string number)
        {
            if (tempresult == currentNumber)
            {
                currentNumber += number;

                tempresult += currentNumber;
            }
            else { currentNumber += number; }


            Result = currentNumber;
        }

        private void SelectOperator(string operatorSymbol)
        {
            selectedOperator = operatorSymbol;
            currentNumber = string.Empty;
        }

        private void Clear()
        {
            currentNumber = string.Empty;
            selectedOperator = string.Empty;
            Result = string.Empty;
            tempresult=string.Empty;
        }

        private async void Calculate()
        {
            if (firsTime)
            {
                await Browser.Default.OpenAsync("https://youtu.be/dQw4w9WgXcQ", BrowserLaunchMode.SystemPreferred);
            }
            if (!string.IsNullOrEmpty(selectedOperator) && double.TryParse(currentNumber, out double number))
            {
                switch (selectedOperator)
                {
                    case "+":
                        Result = (double.Parse(tempresult) + double.Parse(currentNumber)).ToString();
                        break;
                    case "-":
                        Result = (double.Parse(tempresult) - double.Parse(currentNumber)).ToString();
                        break;
                    case "*":
                        Result = (double.Parse(tempresult) * double.Parse(currentNumber)).ToString();
                        break;
                    case "/":
                        if (number != 0)
                            Result = (double.Parse(tempresult) / double.Parse(currentNumber)).ToString();
                        else
                            Result = "Cannot divide by zero";
                        break;
                }
            }
            CalcPageViewModel.CalcsList.Add(new Calculation(tempresult, currentNumber, result, selectedOperator));
            currentNumber = result;
            tempresult = result;
            selectedOperator = string.Empty;
        }



    }
}
