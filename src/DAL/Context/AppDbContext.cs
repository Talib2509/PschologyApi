using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsychologyApi.Core.Entities;
using PsychologyApi.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.DAL.Context;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
 
    public DbSet<Answer>Answers {  get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<BlogPost> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    public DbSet<Psychologist> Psychologists { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<Vacancy> Vacancy { get; set; }
    public DbSet<Test>Tests { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
