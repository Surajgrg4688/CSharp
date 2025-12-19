using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {


        //write code to find greatest number between 3 numbers. ask user to input 3 numbers
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int greatest;
        if (num1 >= num2 && num1 >= num3)
        {
            greatest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            greatest = num2;
        }
        else
        {
            greatest = num3;
        }
        Console.WriteLine("The greatest number is: " + greatest);

    }


    

}
