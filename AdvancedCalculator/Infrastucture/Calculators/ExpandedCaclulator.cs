using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Infrastucture.Calculators
{
    public class ExpandedCaclulator : BaseCalculator
    {
        public bool PrimeNumber(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)                  
                return true;           
            else            
                return false;                         
        }

        public int Factorial(int number)
        {
            int ResultFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                ResultFactorial = ResultFactorial * i;  
            }

            return ResultFactorial; 
        }

        public int PowerOfNumber(int Base, int Exponent)
        {
            int ResultPowerOfNumber = 1;    
            for (int i = 1; i <= Exponent; i++)
            {
                ResultPowerOfNumber = ResultPowerOfNumber * Base;
            }

            return ResultPowerOfNumber;
        }
    }
}
