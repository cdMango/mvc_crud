using Microsoft.EntityFrameworkCore;

namespace MVC_crud.Data;

public class ApplicationDbContext : DbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
}