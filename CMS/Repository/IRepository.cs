using System.Collections.Generic;

namespace CMS.Repository
{
	public interface IRepository
	{
		Customer Add(Customer customer);
		Customer Update(Customer customer);
		List<Customer> GetCustomers();
		List<Customer> GetCustomersGenderWise(GenderType genderType);
		int RemoveCustomer(int id);
	}
}