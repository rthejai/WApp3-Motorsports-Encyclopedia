using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorsportsEncyclopedia.Models
{
	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		public int TrackID { get; set; }
		public int CarID { get; set; }
		public string LapTime { get; set; }

		public virtual Track Track { get; set; }
		public virtual Car Car { get; set; }
	}
}