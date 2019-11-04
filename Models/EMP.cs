namespace RetakeTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMP")]
    public partial class EMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EMPNO { get; set; }

        [Required]
        [StringLength(10)]
        public string ENAME { get; set; }

        [Required]
        [StringLength(9)]
        public string JOB { get; set; }

        public int? MGR { get; set; }

        public DateTime? HIREDATE { get; set; }

        public int? SAL { get; set; }

        public int? COMM { get; set; }

        public int DEPTNO { get; set; }

        [ForeignKey("DEPTNO")]
        public virtual DEPT DEPT { get; set; }
    }
}
