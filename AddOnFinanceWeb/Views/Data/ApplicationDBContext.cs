

using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace AddOnFinanceWeb.Views.Data
{
    public class ApplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { 
        
        }                      
    }
}
