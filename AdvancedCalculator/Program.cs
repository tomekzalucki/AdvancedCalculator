using AdvancedCalculator.Infrastucture.Calculators;

int value = Convert.ToInt32(Console.ReadLine());
int [] array1 = new int [value];    
for (int i = 0; i < array1.Length; i++)
{
    array1 [i] = Convert.ToInt32(Console.ReadLine()); 
}

var expandedCalculator = new ExpandedCaclulator();
Console.WriteLine(expandedCalculator.GetAvgNumberFromArray(array1));
  