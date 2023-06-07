using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FindJobOnWeb.Model.Entities
{
    public partial class JobOnWebContext : DbContext
    {
        public JobOnWebContext()
        {
        }

        public JobOnWebContext(DbContextOptions<JobOnWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Information> Information { get; set; }
        public virtual DbSet<JobPost> JobPosts { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<ProfileSkill> ProfileSkills { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-PB55PLBV\\SQLEXPRESS; Database = JobOnWeb; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(10);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BusinessStreamName)
                    .HasMaxLength(50)
                    .HasColumnName("businessStreamName");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CertificateDegreeName).HasMaxLength(50);

                entity.Property(e => e.Jpa).HasMaxLength(50);

                entity.Property(e => e.Majoring).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_Education_Profile");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CurrentJob).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NameCompany).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.YearOfExperience).HasMaxLength(10);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_Experience_Profile");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Contens).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<Information>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.Contens).HasMaxLength(50);

                entity.Property(e => e.DatePost).HasColumnType("date");

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<JobPost>(entity =>
            {
                entity.ToTable("JobPost");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Education).HasMaxLength(50);

                entity.Property(e => e.Experience).HasMaxLength(50);

                entity.Property(e => e.JobTypeName).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.Skill).HasMaxLength(50);

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_JobPost_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobPosts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_JobPost_User");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Currency).HasMaxLength(50);

                entity.Property(e => e.CurrentSalary).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Profile_User");
            });

            modelBuilder.Entity<ProfileSkill>(entity =>
            {
                entity.ToTable("ProfileSkill");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SkillLevel).HasMaxLength(50);

                entity.Property(e => e.SkillName).HasMaxLength(50);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileSkills)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_ProfileSkill_Profile");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}


