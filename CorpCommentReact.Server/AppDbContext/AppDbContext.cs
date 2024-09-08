using CorpCommentReact.Server.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new DataSeeder());
	}

	public DbSet<Feedback> Feedbacks { get; set; }
}
