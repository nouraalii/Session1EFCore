using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session1Demo.Entities;

namespace Session1Demo.Configration
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(E => E.EmpId);

            E
                        .Property(E => E.Name)
                        .IsRequired()
                        .HasColumnName("EmployeeName")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

            E
                        .Property(E => E.Age)
                        .IsRequired(false);

            E.Property(E => E.Salary)
                         .HasColumnType("money");

            //E.Property(E => E.DataOfCreation).HasDefaultValue(DateTime.Now);
            E.Property(E => E.DataOfCreation).HasDefaultValueSql("GETDATE()");
        }
    }
}
