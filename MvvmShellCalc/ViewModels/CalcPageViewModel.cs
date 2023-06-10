using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MvvmShellCalc.Models;
using System.Threading.Tasks;


namespace MvvmShellCalc.ViewModels
{
    //its actualy the calcukations history page
    public class CalcPageViewModel:ViewModel
    {
        public static ObservableCollection<Calculation> CalcsList=new ObservableCollection<Calculation>();

        
        public ObservableCollection<Calculation> Calulations { get { return CalcsList; } }
        public CalcPageViewModel() 
        {
            
        }
    }
}
