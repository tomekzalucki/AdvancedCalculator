﻿using System;
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
    }
}
