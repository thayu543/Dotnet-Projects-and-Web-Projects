namespace MVC_Project_Using_Entity_framework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int emp_id { get; set; }

        [StringLength(100)]
        public string ename { get; set; }

        [StringLength(100)]
        public string job_desc { get; set; }

        public int? salary { get; set; }
    }
}
