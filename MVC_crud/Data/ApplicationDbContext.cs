using Microsoft.EntityFrameworkCore;
using MVC_crud.Models.Entities;

namespace MVC_crud.Data;

public class ApplicationDbContext : DbContext
{
    //DbContext in Entity Framework acts as a bridge between your C# objects and the database.
    //It manages database connections, enables querying using LINQ, and tracks changes to data for managing updates.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
    
}