using CMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Services
{
	public  class CustomerService
	{
		private IRepository csRepository;
		public CustomerService(IRepository repository)
		{
			csRepository = repository;
		}

		public Customer Add(Customer customer)
		{
			return csRepository.Add(customer);
		}

		public int Remove(int id)
		{
			return csRepository.RemoveCustomer(id);
		}

		public Customer Update(Customer customer)
		{
			return csRepository.Update(customer);
		}

		public List<Customer> GetCustomers()
		{
			return csRepository.GetCustomers();
		}
		public double GetAverageAge()
		{
			List<Customer> lstCusts =   csRepository.GetCustomers();
			return CalculateAverageAge(lstCusts);

		}
		public double GetAverageAge(GenderType genderType )
		{
			List<Customer> lstCusts =   csRepository.GetCustomersGenderWise(genderType);
			return CalculateAverageAge(lstCusts);
		}

		private double CalculateAverageAge(List<Customer> cusList)
		{
			return cusList.Average(dt => (DateTime.Now - dt.DateOfBirth).TotalDays) / 365;
		}
	}
}
