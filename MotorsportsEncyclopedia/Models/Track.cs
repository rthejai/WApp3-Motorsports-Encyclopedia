using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotorsportsEncyclopedia.Models
{
	public class Track
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int TrackID { get; set; }
		public string TrackName { get; set; }
		public string TrackLocation { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}