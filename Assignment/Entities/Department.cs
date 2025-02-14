﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    //Data Annotation
    [Table("Department", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required] [MaxLength(50)]
        [Column("DepartmentName", TypeName = "varchar")]
        public string Name { get; set; }

        [Required]
        public int Ins_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime HiringDate { get; set; }
    }
}
