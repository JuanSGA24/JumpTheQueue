using System;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Database
{
    public partial class JumpTheQueueContext : DbContext
    {
        public JumpTheQueueContext()
        {
        }

        public JumpTheQueueContext(DbContextOptions<JumpTheQueueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessCode> AccessCode { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=changeme;Server=localhost;Port=5432;Database=postgres;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessCode>(entity =>
            {
                entity.HasIndex(e => e.QueueId)
                    .HasName("accesscode_un2")
                    .IsUnique();

                entity.HasIndex(e => e.VisitorId)
                    .HasName("accesscode_un")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("createdTime")
                    .HasColumnType("date");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("date");

                entity.Property(e => e.QueueId).HasColumnName("queue_id");

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");

                entity.Property(e => e.VisitorId).HasColumnName("visitor_id");
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("queue_un")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessLink)
                    .HasColumnName("accessLink")
                    .HasColumnType("character varying");

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("date");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("character varying");

                entity.Property(e => e.MinAttentionTime).HasColumnName("minAttentionTime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OpenTime)
                    .HasColumnName("openTime")
                    .HasColumnType("date");

                entity.Property(e => e.Started).HasColumnName("started");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Queue)
                    .HasPrincipalKey<AccessCode>(p => p.QueueId)
                    .HasForeignKey<Queue>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("queue_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasColumnType("character varying");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.User)
                    .HasPrincipalKey<Queue>(p => p.UserId)
                    .HasForeignKey<User>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_fk");
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Visitor)
                    .HasPrincipalKey<AccessCode>(p => p.VisitorId)
                    .HasForeignKey<Visitor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("visitor_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
