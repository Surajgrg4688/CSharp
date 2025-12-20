using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        System.Console.WriteLine("Enter your marks: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your grade is: " + Grade(x));
    }


    static string Grade(int marks)
    { 

        
        if (marks >= 90)
            return "A";
        else if (marks >= 80)
            return "B";
        else if (marks >= 70)
            return "C";
        else if (marks >= 60)
            return "D";
        else
            return "F";
    }


    

}
