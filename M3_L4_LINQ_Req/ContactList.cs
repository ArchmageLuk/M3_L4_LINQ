using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_L4_LINQ_Req_
{    
    internal class ContactList
    {
        private string PathNames = @"D:\Projects\C# learning\Code\M3_L4_LINQ\M3_L4_LINQ_Req\Names.txt";
        private string PathNumbers = @"D:\Projects\C# learning\Code\M3_L4_LINQ\M3_L4_LINQ_Req\Number.txt";

        public List<Contact> Contacts = new List<Contact>();
        Tools Tools = new Tools();

        public ContactList()
        {
            var list = new List<Contact>();
            string[] names = File.ReadAllLines(PathNames);
            string[] numbers = File.ReadAllLines(PathNumbers);

            for (int i = 0; i < names.Length; i++)
            {
                var contact = new Contact(names[i], numbers[i]);
                list.Add(contact);
            }

            list = Tools.Sorting(list);
            Contacts = list;
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to your contact list.");
            Console.WriteLine("These are your contacts now.");
            Console.WriteLine(" ");
            Tools.ShowAll(Contacts);

            Console.WriteLine(" ");
            Console.WriteLine("This are <FirstOrDefault>");
            var firstCont = Contacts.FirstOrDefault();
            Console.WriteLine($"This is first contact - {firstCont.Name}. Their number {firstCont.Number}");

            Console.WriteLine(" ");
            Console.WriteLine("This are <Where>, <StartsWith> and <ElementAt>");
            Console.WriteLine("Choose contacts, which start with 'W', and show the second one");
            var condition = Contacts.Where(x => x.Name.StartsWith("W")).ElementAt(2);
            Console.WriteLine(condition.Name);

            Console.WriteLine(" ");
            Console.WriteLine("This are <Select> and <Count>");
            Console.WriteLine("This are names that longer than 5");
            var selection = Contacts.Select(x => x.Name.Length > 5).ToArray();
        }


    }
}
