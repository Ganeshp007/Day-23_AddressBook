// See https://aka.ms/new-console-template for more information
using Day_23_AddressBook;

Console.WriteLine("------- Welcome To Address Book Application -------");

AddressBook contact = new AddressBook();  //creating obj of AddressBook class to access it methods
bool check = true;
while (check)
{
    Console.Write("\nChooce Operation : \n1.Create AddressBooks\n2.Display AddressBook Contact\n3.Add New Contact to AddressBook\n4.Update Contact\n5.Display Book\n7.Delete Contact\n8.Exit\nEnter your Choice :- ");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("\n>> Create AddressBook Operation :");
            Console.Write("\nHow many AddressBooks You want to create :- ");
            int countofBook = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            while (countofBook > 0)
            {
                num++;
                Console.Write("\nEnter the {0} AddressBook Name to create :- ", num);
                string name = Console.ReadLine();
                contact.AddBook(name);
                countofBook--;
            }
            break;
        case 2:
            Console.WriteLine("\n>> AddressBooks Details :");
            contact.DisplayBookData();
            break;

        case 8:
            check = false;
            break;

        default: Console.WriteLine("\nPlease Enter correct choice!!"); break;
    }
}