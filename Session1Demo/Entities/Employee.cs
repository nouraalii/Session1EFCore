using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo.Entities
{
    //EF Core support 4 ways to mapping class in databases[table , view ,function]
    //1.By convention way -->[Default Behaviour]
    //2.Data Annotation-->[set of attributes used for data validation]
    //3.Fluent Api
    //4.Class Configration



    //POCO Class
    //Plain OLD CLR Object
    //Entity

    //1.By convention
    ////Table
    //internal class Employee
    //{
    //    public int Id { get; set; } //public numeric property 'Id' | 'EmployeeId' -->PK Identity(1,1)
    //    public string Name { get; set; } //Reference Type : nvarchar(max) - Required 
    //    public int? Age { get; set; } //Int : Nullable Type : int(Age)- optional 
    //    public double Salary { get; set; }//Int : value type - Required 
    //    public string? Address { get; set; } // Nullable Type : optional 

    //    public DateTime DataOfCreation { get; set; } //datetime2 - Required
    //}

    ////2.data Annotation
    //[Table("Employee", Schema = "dbo")]
    //class Employee
    //{

    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [Column(TypeName = "money")]
    //    public double Salary { get; set; }

    //    [EmailAddress]
    //    [DataType(DataType.EmailAddress)]
    //    public string? Address { get; set; } //example@example.com

    //    public string PhoneNumber { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //}

    //3.Fluent API
    class Employee
    {
        public int EmpId { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        public double Salary { get; set; }

        public string? Address { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DataOfCreation { get; set; }

        [NotMapped]
        public double TotalSalary { get; set; }

        public string Password { get; set; }
    }
}
