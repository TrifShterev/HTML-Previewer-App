using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Previewer.Data
{
    public partial class HtmlPreviewerContext : DbContext
    {
        public HtmlPreviewerContext()
        {
        }

        public HtmlPreviewerContext(DbContextOptions<HtmlPreviewerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HtmlManager> HtmlManagers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=HtmlPreviewer;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<HtmlManager>(entity =>
            {
                entity.ToTable("HtmlManager");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastEditedOn).HasColumnType("datetime");

                entity.Property(e => e.TextHtml).IsRequired();

                entity.Property(e => e.Url).HasColumnType("Url");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
