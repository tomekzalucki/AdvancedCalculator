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
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;  
            }

            return result; 
        }

        public int PowerOfNumber(int baseNum, int exponent)
        {
            int result = 1;    
            for (int i = 1; i <= exponent; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        public bool PerfectNumber(int number)
        {
            int result = 0;
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    result = result + i;
                }              
            }

            if (number == result)
                return true;
            else
                return false;
            
        }
        public int GetAvgNumberFromArray(int[] value)
        {
           
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
            }
           
            return sum/value.Length; 


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
