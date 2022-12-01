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
        public int AverageOfNumbersArray(int arry)
        {
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array1[i] = arry;
            }    
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array1[i]);
            } 
            return array1[10];  
               
        }

    }
}
