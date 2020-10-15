using System;

namespace string2intConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input: ");
            string val = Console.ReadLine();
            string digitNumber = "";
            //Solution: 1
            //extract value to get only number
            foreach (char text in val)
            {
                //
                if (char.IsDigit(text))
                {
                    digitNumber += text;
                }
                
            }
            string digitNumber2 = digitNumber;

            //convert string to int
            //Solution: 1 ASCII value
            int result = 0;
            foreach (char number in digitNumber2)
            {
                result *= 10;
                result += number - '0';
            }
            Console.WriteLine("Output: " + result);

            //Solution: 2 Mapping char with string
            string table = "0123456789";
            int total = 0;
            int tablemap = 0;
            char x;
            for(int i = 0; i < digitNumber2.Length; i++)
            {
                x = digitNumber2[i];
                tablemap = table.IndexOf(x);
                total = total * 10 + tablemap;
            }
            Console.WriteLine("Output: "+total);

        }
        
    }
}
