namespace RMR.FA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Property")]
    public partial class Property
    {
        public Property()
        {
            Allocations = new HashSet<Allocation>();
            PropertyFinances = new HashSet<PropertyFinance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public virtual ICollection<Allocation> Allocations { get; set; }

        public virtual ICollection<PropertyFinance> PropertyFinances { get; set; }
    }
}
