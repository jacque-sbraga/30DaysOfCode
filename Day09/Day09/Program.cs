

using System.Linq;

namespace Day09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contact> data = new Dictionary<string, Contact>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                Contact contact = new Contact(line[0], line[1]);
                data.Add(contact.Name, contact);
            }

            for(int i = 0;i < n; i++)
            {
                string nameSearch = Console.ReadLine();

                try
                {
                    string result = data[nameSearch].Phone;
                    Console.WriteLine($"{nameSearch}={result}");
                } catch(Exception e) {
                
                    Console.WriteLine("Not found");
                }

            }
        }

        public class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            

            public Contact() { }

            public Contact(string name, string phone)
            {
                Name = name;
                Phone = phone;
            }

        }
    }
}
