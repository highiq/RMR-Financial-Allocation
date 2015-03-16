namespace RMR.FA.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PropertyFinance")]
    public partial class PropertyFinance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int PropertyId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Revenue { get; set; }

        [Column(TypeName = "money")]
        public decimal? Expense { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateEnd { get; set; }

        public virtual Property Property { get; set; }
    }
}
