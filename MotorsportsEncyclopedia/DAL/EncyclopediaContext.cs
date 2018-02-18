using MotorsportsEncyclopedia.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MotorsportsEncyclopedia.DAL
{
	public class EncyclopediaContext : DbContext
	{

		public EncyclopediaContext() : base("EncyclopediaContext")
		{
		}

		public DbSet<Car> Cars { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Track> Tracks { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}