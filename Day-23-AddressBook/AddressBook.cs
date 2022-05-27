using Day_23_AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23_AddressBook
{
    public class AddressBook
    {
        //creating Generic Dictionary object
        Dictionary<string, List<Contact>> Book = new Dictionary<string, List<Contact>>();

        // method to take contact info
        public Object AddContact()
        {
            List<Contact> addContact = new List<Contact>(); //creating generic List for storing contacts info
            Console.Write("\nHow many contacts do you want to add :- ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            while (num > 0)
            {
                Console.Write("\nEnter the contact Details For Contact {0} \n", count);
                Contact obj = new Contact();     //creating obj of Contact class to pass info taken fromuser and intinalize them
                Console.Write("> Firstname :- ");
                obj.FirstName = Console.ReadLine();
                Console.Write("> Enter Lastname :- ");
                obj.LastName = Console.ReadLine();

                Console.Write("> Enter Address :- ");
                obj.Address = Console.ReadLine();

                Console.Write("> Enter City :- ");
                obj.City = Console.ReadLine();

                Console.Write("> Enter State :- ");
                obj.State = Console.ReadLine();

                Console.Write("> Enter pincode :- ");
                obj.Zip = Convert.ToInt32(Console.ReadLine());

                Console.Write("> Enter PhoneNumber :- ");
                obj.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                Console.Write("> Enter Email :- ");
                obj.Email = Console.ReadLine();

                addContact.Add(obj); //Adding obj holding all info of current user we are adding it to List
                num--;
                count++;
            }
            return addContact;  //Returning the whole List
        }
        //Method to Add AddressBook 
        public void AddBook(string Bookname)
        {
            List<Contact> addcontact = (List<Contact>)AddContact(); // implicitly caaling addcontact method which is returning List object

            if (addcontact != null)//checking weather List is null or not Null
            {
                Book.Add(Bookname, addcontact); // Adding Book to Dictionary with Key and Value as BookName and Obj returned by addcontact method 
                Console.WriteLine("\nBook Added Successfully...");
            }
            else
            {
                Console.WriteLine("\nAddressBook Creation Failed!!");
            }

        }
        //Method to display Contacts in BOOk 
        public void DisplayBookData()
        {
            if (Book.Count > 0)
            {
                Console.Write("\nEnter the Name of AddressBook of which you want to See the Details :- ");
                string Bookname = Console.ReadLine();
                foreach (var element in Book) //Iterating elements in Book
                {
                    if (element.Key.Contains(Bookname)) // selecting only that elemet which contain BookName  That we have searching for
                    {
                        foreach (var data in element.Value)
                            Console.WriteLine("\nFirstName:" + " = " + data.FirstName + "\n" + " " + "LastName:" + " = " + data.LastName + "\n" + "Address:" + " = " + data.Address + "\n" + "City:" + " = " + data.City + "\n " + "State:" + " = " + data.State + "\n" + "Zip:" + " = " + data.Zip + " \n" + "PhoneNumber:" + " = " + data.PhoneNumber + "\n" + "Email:" + " = " + data.Email + "\n");
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("\nSorry!! You don't have Any Book Yet...");
            }

        }


    }
}
