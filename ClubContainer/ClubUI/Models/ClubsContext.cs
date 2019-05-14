using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClubUI.Models
{
    public partial class ClubsContext : DbContext
    {
        public ClubsContext()
        {
        }

        public ClubsContext(DbContextOptions<ClubsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<GroupInstrument> GroupInstrument { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<Style> Style { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(e => e.ClubId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("club");

                entity.Property(e => e.ClubId).HasColumnName("clubId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("styleCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.StyleCodeNavigation)
                    .WithMany(p => p.Club)
                    .HasForeignKey(d => d.StyleCode)
                    .HasConstraintName("FK_club_style1");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.ContractId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("contract");

                entity.Property(e => e.ContractId).HasColumnName("contractId");

                entity.Property(e => e.ClubId).HasColumnName("clubId");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.NumberOfPerformances).HasColumnName("numberOfPerformances");

                entity.Property(e => e.PricePerPerformace).HasColumnName("pricePerPerformace");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");

                entity.HasOne(d => d.Club)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.ClubId)
                    .HasConstraintName("contract_FK00");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("contract_FK01");
            });

            modelBuilder.Entity<GroupInstrument>(entity =>
            {
                entity.HasKey(e => e.GroupInstumentId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("groupInstrument");

                entity.Property(e => e.GroupInstumentId).HasColumnName("groupInstumentId");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.InstrumentCode)
                    .IsRequired()
                    .HasColumnName("instrumentCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupInstrument)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("groupInstrument_FK01");

                entity.HasOne(d => d.InstrumentCodeNavigation)
                    .WithMany(p => p.GroupInstrument)
                    .HasForeignKey(d => d.InstrumentCode)
                    .HasConstraintName("groupInstrument_FK00");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("groups");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.StyleCode)
                    .HasColumnName("styleCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.StyleCodeNavigation)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.StyleCode)
                    .HasConstraintName("FK_groups_style");
            });

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.HasKey(e => e.InstrumentCode)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("instrument");

                entity.Property(e => e.InstrumentCode)
                    .HasColumnName("instrumentCode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.HasKey(e => e.StyleCode)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("style");

                entity.Property(e => e.StyleCode)
                    .HasColumnName("styleCode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);
            });
        }
    }
}
