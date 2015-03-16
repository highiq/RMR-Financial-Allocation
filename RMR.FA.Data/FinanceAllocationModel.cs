namespace RMR.FA.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FinanceAllocationModel : DbContext
    {
        public FinanceAllocationModel()
            : base("name=FinanceAllocationModel")
        {
        }

        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyFinance> PropertyFinances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allocation>()
                .Property(e => e.Allocation1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Allocations)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.Allocations)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.PropertyFinances)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PropertyFinance>()
                .Property(e => e.Revenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PropertyFinance>()
                .Property(e => e.Expense)
                .HasPrecision(19, 4);
        }
    }
}
