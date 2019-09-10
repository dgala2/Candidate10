using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    public class Customer
    {
	    public int Id{ get; set; }

	    public string Name { get; set; }

	    public GenderType Gender{ get; set; }

	    public DateTime DateOfBirth { get; set; }
    }

	public enum GenderType
	{
		Male,
		Female,
		Undiscolsed
	}
}
