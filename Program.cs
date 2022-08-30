class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Enter a string of numbers: ");
        string Numbers = Console.ReadLine().Trim();
        string result =LeftRightNumbers(Numbers);  
        Console.WriteLine(result);

       Console.ReadKey();       
    }
     static string LeftRightNumbers(string Letters)
    {
        int firstsum = 0;
        int secondsum = 0;

        string RightNumbers = Letters.Substring(0, Letters.Length / 2);
        string LeftNumbers = Letters.Substring(Letters.Length / 2);

        for (int i = 0; i < RightNumbers.Length; i++)
        {
            firstsum += RightNumbers[i] - '0';
            secondsum += LeftNumbers[i] - '0';
        }
       return firstsum == secondsum? "yes":"no";
    }



}