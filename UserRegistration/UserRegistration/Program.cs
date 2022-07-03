// See https://aka.ms/new-console-template for more information
Regex_User_Registration.RegularExpression regex = new Regex_User_Registration.RegularExpression();
Console.WriteLine("1 - Enter First Name");
Console.WriteLine("2 - Enter Last Name");
Console.WriteLine("3 - Enter Enail-id");
Console.WriteLine("4 - Enter Mobile Number");
Console.WriteLine("5 - Enter Password");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        Console.WriteLine("Enter First Name");
        string fName = Console.ReadLine();
        regex.FirstName(fName);
        break;
    case 2:
        Console.WriteLine("Enter Last Name");
        string lName = Console.ReadLine();
        regex.LastName(lName);
        break;
    case 3:
        Console.WriteLine("Enter Email-id");
        string id = Console.ReadLine();
        regex.email(id);
        break;
    case 4:
        Console.WriteLine("Enter Mobile Number");
        string number = Console.ReadLine();
        regex.ContactNumber(number);
        break;
    case 5:
        Console.WriteLine("Enter Password");
        string inputPassword = Console.ReadLine();
        regex.Password(inputPassword);
        break;
}