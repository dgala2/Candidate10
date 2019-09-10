using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Repository;
using CMS;
using CMS.Services;

namespace CMSConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomerRepository crp = new CustomerRepository();
			CustomerService service = new CustomerService(crp);
			Customer c1 = new Customer() {Name = " John", DateOfBirth = new DateTime(1980,02,23) , Gender = GenderType.Male};
			Customer c2 = new Customer() { Name = " James", DateOfBirth = new DateTime(1985, 12, 13) , Gender = GenderType.Male };
			Customer c3 = new Customer() { Name = " Jeane", DateOfBirth = new DateTime(1990, 8, 03), Gender = GenderType.Female };
			Customer c4 = new Customer() { Name = "Kim", DateOfBirth = new DateTime(1990, 08, 03),Gender = GenderType.Female};

			service.Add(c1);
			service.Add(c2);
			service.Add(c3);
			service.Add(c4);
			double avregaeAge = service.GetAverageAge();
			double avgMale= service.GetAverageAge(GenderType.Male);
			double avgFemale = service.GetAverageAge(GenderType.Female);

			Console.WriteLine("Average age of all customers: {0}", avregaeAge);
			Console.WriteLine("Average age of all Male customers: {0}", avgMale);
			Console.WriteLine("Average age of all Female customers: {0}", avgFemale);
		}
	}
}
