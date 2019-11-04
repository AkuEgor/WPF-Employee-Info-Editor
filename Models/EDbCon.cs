namespace RetakeTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EDbCon : DbContext
    {
        public EDbCon()
            : base("name=EDbCon")
        {
        }

        public virtual DbSet<DEPT> DEPTs { get; set; }
        public virtual DbSet<EMP> EMPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPT>()
                .Property(e => e.DNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPT>()
                .Property(e => e.LOC)
                .IsUnicode(false);

            modelBuilder.Entity<DEPT>()
                .HasMany(e => e.EMPs)
                .WithRequired(e => e.DEPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.ENAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMP>()
                .Property(e => e.JOB)
                .IsUnicode(false);
        }
    }
}
