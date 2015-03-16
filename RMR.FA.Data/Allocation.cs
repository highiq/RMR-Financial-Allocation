namespace RMR.FA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Allocation")]
    public partial class Allocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int PropertyId { get; set; }

        [Column("Allocation", TypeName = "money")]
        public decimal? Allocation1 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Property Property { get; set; }
    }
}
