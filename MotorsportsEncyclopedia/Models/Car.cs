using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorsportsEncyclopedia.Models
{
	public class Car
	{
		public int CarID { get; set; }
		public int CarYear { get; set; }
		public string CarMake { get; set; }
		public string CarName { get; set; }
		public string CarDescription { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}