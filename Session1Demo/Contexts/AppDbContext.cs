using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session1Demo.Configration;
using Session1Demo.Entities;

namespace Session1Demo.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigration());

            #region MyRegion
            /*//modelBuilder.Entity<Employee>().HasKey("EmpId");
                //modelBuilder.Entity<Employee>().HasKey(nameof(Employee));
                modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Name)
                            .IsRequired()
                            .HasColumnName("EmployeeName")
                            .HasColumnType("varchar")
                            .HasMaxLength(50);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Age)
                            .IsRequired(false);

                modelBuilder.Entity<Employee>()
                            .Property(E => E.Salary)
                            .HasColumnType("money");*//*

                //modelBuilder.Entity<Employee>().Property(E => E.DataOfCreation).HasDefaultValue(DateTime.Now);
                //modelBuilder.Entity<Employee>().Property(E => E.DataOfCreation).HasDefaultValueSql("GETDATE()");

                modelBuilder.Entity<Employee>(E =>
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
                });*/
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public AppDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Demo; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
