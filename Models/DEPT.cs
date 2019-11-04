namespace RetakeTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPT")]
    public partial class DEPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPT()
        {
            EMPs = new HashSet<EMP>();
        }

        [Key]
        public int DEPTNO { get; set; }

        [StringLength(14)]
        public string DNAME { get; set; }

        [StringLength(13)]
        public string LOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMP> EMPs { get; set; }

        public override string ToString()
        {
            return DNAME;
        }
    }
}
