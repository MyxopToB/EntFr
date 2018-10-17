using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntFr
{
    public partial class inventoryContext : DbContext
    {
        public inventoryContext()
        {
        }

        public inventoryContext(DbContextOptions<inventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hdd> Hdd { get; set; }
        public virtual DbSet<Stamps> Stamps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Database=inventory;User=root;Password=FlvbyGAH;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hdd>(entity =>
            {
                entity.ToTable("hdd");

                entity.Property(e => e.HddId)
                    .HasColumnName("hddId")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RegistrationNumber)
                    .HasColumnName("registration_number")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Stamps>(entity =>
            {
                entity.HasKey(e => e.StampId);

                entity.ToTable("stamps");

                entity.Property(e => e.StampId)
                    .HasColumnName("stampId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FillingDate)
                    .HasColumnName("filling_date")
                    .HasColumnType("date");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.OpeningDate)
                    .HasColumnName("opening_date")
                    .HasColumnType("date");
            });
        }
    }
}
