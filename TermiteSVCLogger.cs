public class TermiteSVCLogger
{
    private string _customerName;
    private string _phoneNumber;
    private string _homeAddress;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _jobCode;
    private int _accountNumber;


    public NewInquiry(string customerName, string phoneNumber, string jobCode)
    {
        _customerName = customerName;
        _phoneNumber = phoneNumber;
        _jobCode = jobCode;
    }


    public void GenerateNewInquiry()
    {
        Console.WriteLine("CustomerName: ");
        _customerName = Console.ReadLine();
        Console.WriteLine("CustomerPhone: ");
        _phoneNumber = Console.ReadLine();
        Console.WriteLine("Address: ");
        _homeAddress = Console.ReadLine();
        Console.WriteLine("City: ");
        _city = Console.ReadLine();
        Console.WriteLine("State: ");
        _state = Console.ReadLine();
        Console.WriteLine("Zip: ");
        _zipCode = Console.ReadLine();
        Console.WriteLine("SalesPerson: ");
        string salesPerson = Console.ReadLine();
    }


    //Checks if job is a termite sevice or not.
    private bool JobCode()
    {
        bool isJobTermite = false;

        if (_jobCode == null)
        {
            Console.WriteLine("No job type present..");
        }
        else if (_jobCode == "tsvc")
        {
            isJobTermite = true;
            _accountNumber = SVCAccountGenerator();
        }
        else
        {
            isJobTermite = false;
            _accountNumber = SVCAccountGenerator();
        }
        return isJobTermite;
    }


    private int SVCAccountGenerator()
    {
        Random randomNumber = new Random();
        int newNum = randomNumber.Next(99999999);

        return newNum;
    }

}
}