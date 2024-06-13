using Microsoft.EntityFrameworkCore;

namespace EFCore_DBLibrary;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
        
    }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }

}

