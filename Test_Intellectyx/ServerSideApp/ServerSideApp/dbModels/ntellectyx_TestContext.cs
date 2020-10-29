using Microsoft.EntityFrameworkCore;

namespace ServerSideApp.models
{
    public partial class ntellectyx_TestContext : DbContext
    {
        public ntellectyx_TestContext()
        {
        }

        public ntellectyx_TestContext(DbContextOptions<ntellectyx_TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StatusDetails> StatusDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=ntellectyx_Test;Integrated Security=True;Persist Security Info=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<StatusDetails>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__StatusDe__C8EE2043616C60B9");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");
            });
        }
    }
}
