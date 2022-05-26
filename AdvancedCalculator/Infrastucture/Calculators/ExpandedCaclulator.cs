using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Infrastucture.Calculators
{
    public class ExpandedCaclulator : BaseCalculator
    {
        public bool FirstNumber(int number)
        {
            bool FirstN = true;
            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    FirstN =  false;
                    break;
                }
                         
            }
            if(FirstN == true)
            {
                return true;    
            }
            else
            {
                return false;   
            }
            
        }
    }
}
