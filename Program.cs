// See https://aka.ms/new-console-template for more information
using TermiteCalculatorV0._1._0;

Console.WriteLine("Hello, World!");

Console.WriteLine("Existing Customer? Yes or no.?");
string input =  Console.ReadLine().ToLower();


switch(input)
{
    case "yes":
        Console.WriteLine("CustomerName: ");
        string cusName = Console.ReadLine();
        Console.WriteLine("PhoneNum: ");
        string phone = Console.ReadLine();
        Console.WriteLine("JobCode: ");
        string job = Console.ReadLine();

        NewInquiry newCustomer = new NewInquiry(cusName, phone, job);
        break;

    case "no":
        Console.WriteLine();
        break;
}