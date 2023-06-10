using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmShellCalc.Models
{
    public class Calculation
    {
        public string firstnumber { set; get; }
        public string secondnumber { set; get; }
        public string result { set; get; }
        public string operation { set; get; }
        public Calculation(string fn, string sn, string r, string o)
        {
            firstnumber = fn;
            secondnumber = sn;
            result = r;
            operation = o;
        }

        public override string ToString()
        {
            return $"{firstnumber}{operation}{secondnumber}={result} ";
        }
    }
}
