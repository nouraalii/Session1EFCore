using Microsoft.EntityFrameworkCore;
using Session1Demo.Contexts;

namespace Session1Demo
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext context = new AppDbContext();

            context.Employee.Where(E=>E.EmpId == 1);

            //context.Database.Migrate();
        }
    }
}
