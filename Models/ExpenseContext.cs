using Microsoft.EntityFrameworkCore;

namespace Muresan_Razvan_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }

        public DbSet<ExpenseDTO> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
