namespace SimplyCRUDonDocuments
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class DocsModelContext : DbContext
    {
        public DocsModelContext()
            : base("name=ScodDbModel")
        {
        }

        public static IEnumerable<object> DocumentHeader { get; internal set; }
        public DbSet<DocumentHeader> Headers { get; set; }
        public DbSet<DocumentPositions> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
