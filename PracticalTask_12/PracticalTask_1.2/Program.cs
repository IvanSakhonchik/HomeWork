using System;
using System.Text;

namespace PracticalTask_12
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {

                    //Input decimal value for translating
                    Console.WriteLine("Enter value in the decimal system:");
                    string inputDecimalSystemValue = Console.ReadLine();
                    HasNumbersValueAndIsNullOrEmpty(inputDecimalSystemValue);

                    //Input system for translating
                    Console.WriteLine("Enter system that want to translate:");
                    string inputOtherSystem = Console.ReadLine();
                    HasNumbersValueAndIsNullOrEmpty(inputOtherSystem);

                    //Output result current system
                    Console.WriteLine("Result:{0}", TranslateDecimalSystemValueInOtherSystem(inputDecimalSystemValue, inputOtherSystem));
                    break;
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }

        //This method translate decimal value to value of other system
        static string TranslateDecimalSystemValueInOtherSystem(string inputDecimalSystemValue, string inputOtherSystem)
        {
            int decimalValue = int.Parse(inputDecimalSystemValue);
            int otherSystem = int.Parse(inputOtherSystem);
            int currentValue;
            StringBuilder resultHelper = new StringBuilder();
            while(decimalValue > otherSystem)
            {
                currentValue = decimalValue % otherSystem;
                decimalValue = decimalValue / otherSystem;
                resultHelper.Append(currentValue);
            }
            currentValue = decimalValue % otherSystem;
            resultHelper.Append(currentValue);
            string ValueInInputSystem = string.Empty;
            for(int i = resultHelper.Length-1; i >= 0; i--)
            {
                ValueInInputSystem += resultHelper[i];
            }
            return ValueInInputSystem;
        }
        
        // Checking string on number, null or empty
        static void HasNumbersValueAndIsNullOrEmpty(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                throw new Exception("Invalid numbers. Try again");
            }
            foreach (var number in inputString)
            {
                if (number < '0' || number > '9')
                {
                    throw new Exception("Invalid numbers. Try again");
                }
            }
        }
    }
}
