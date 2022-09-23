using System.Collections.ObjectModel;

namespace mauiBlazor.Data
{
	public class CustomerService
	{
        public List<Customer> Customers = new List<Customer>();
        public CustomerService()
		{
            Customers.Add(new Customer { Id = 1, Prefix = "CV", Nama = "Duta Karya Pertiwi" });
            Customers.Add(new Customer { Id = 2, Prefix = "Bapak", Nama = "Arkan Hautami" });
            Customers.Add(new Customer { Id = 3, Prefix = "Ibu", Nama = "Raina" });
            Customers.Add(new Customer { Id = 4, Prefix = "Bapak", Nama = "Ahmad" });
            Customers.Add(new Customer { Id = 5, Prefix = "Ibu", Nama = "Ningsih" });
        }
	}
}
