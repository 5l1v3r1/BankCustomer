using System;

namespace BankCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Kağan";
            customer.Surname = "Çelenk";
            customer.City = "New York";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";
            customer2.City = "Diyarbakır";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Cenk";
            customer3.Surname = "Koçak";
            customer3.City = "İstanbul";

            Console.WriteLine(" ");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(" ");

            // EKLEME
            
            CustomerManager customerAdd = new CustomerManager();
            customerAdd.Add(customer);
            Console.WriteLine("-------------------");
            customerAdd.Add(customer2);
            Console.WriteLine("-------------------");
            customerAdd.Add(customer3);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(" ");

            // SİLME
            
            CustomerManager customerDelete = new CustomerManager();
            customerDelete.Delete(customer);
            Console.WriteLine("-------------------");
            customerDelete.Delete(customer2);
            Console.WriteLine("-------------------");
            customerDelete.Delete(customer3);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(" ");

            // LİSTELEME

            CustomerManager customerListing = new CustomerManager();
            customerListing.Listing(customer);
            customerListing.Listing(customer2);
            customerListing.Listing(customer3);

            Console.WriteLine(" ");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine(" ");
        }


    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

    class CustomerManager
    {
        public void Add(Customer customer) // EKLEME METHODU
        {
            Console.WriteLine("Added to the system"+" : "+customer.Id+" : "+ customer.Name+" : "+customer.Surname+" : "+customer.City);
        }

        public void Delete(Customer customer) // SİLME METHODU
        {
            Console.WriteLine("Deleted from the system"+" / "+customer.Id+" / "+customer.Name+" / "+customer.Surname+" / "+customer.City);
        }

        public void Listing(Customer customer) // LİSTELEME METHODU
        {
            Customer[] list = new Customer[] {customer};

            foreach (var search in list)
            {
                Console.WriteLine("Listed"+": "+search.Id+" - "+search.Name+" - "+search.Surname+" - "+search.City);
            }

        }

    }

}
