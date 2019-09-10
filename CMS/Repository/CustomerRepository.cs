using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Repository
{
	public class CustomerRepository : IRepository
	{
		private List<Customer> _inMemCustList;
		private int lastCustId;
		public CustomerRepository()
		{
			_inMemCustList = new List<Customer>();
		}
		public Customer Add(Customer customer)
		{
			customer.Id = lastCustId + 1;
			_inMemCustList.Add(customer);
			return customer;
		}

		public int RemoveCustomer(int id)
		{
			Customer customer = _inMemCustList.Find(m => m.Id == id);
			if (customer == null)
				return 0;
			else
			{
				_inMemCustList.Remove(customer);
				return customer.Id;
			}

		}
		public List<Customer> GetCustomers()
		{
			return _inMemCustList;
		}

		public List<Customer> GetCustomersGenderWise(GenderType genderType)
		{
			return _inMemCustList.FindAll(m => m.Gender == genderType);
		}
		public Customer Update(Customer customer)
		{
			Customer tempCust = _inMemCustList.Find(m => m.Id == customer.Id);
			if (customer != null)
			{
				customer.Id = tempCust.Id;
				_inMemCustList.Remove(customer);
				_inMemCustList.Add(customer);
			}
			else
			{
				Add(customer);
			}

			return customer;
		}
	}
}
