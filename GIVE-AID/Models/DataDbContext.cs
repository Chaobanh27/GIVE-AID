using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Reflection.Emit;

namespace GIVE_AID.Models
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("DefaultConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UsersRolesMapping> UsersRolesMappings { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<NGO> NGOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersRolesMapping>()
                .HasKey(ur => ur.Id);
            modelBuilder.Entity<UsersRolesMapping>()
                .HasRequired(ur => ur.User)
                .WithMany(u => u.UsersRolesMappings)
                .HasForeignKey(ur => ur.UserId);
            modelBuilder.Entity<UsersRolesMapping>()
                .HasRequired(ur => ur.Role)
                .WithMany(r => r.UsersRolesMappings)
                .HasForeignKey(ur => ur.RoleId);
            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<User>()
                .HasRequired(u => u.UserDetail)
                .WithRequiredPrincipal(ud => ud.User);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Donations)
                .WithRequired(d => d.User)
                .HasForeignKey(d => d.UserId);
            modelBuilder.Entity<Donation>()
                .HasKey(d => d.Id);
            modelBuilder.Entity<Donation>()
                .HasRequired(d => d.User)
                .WithMany(u => u.Donations)
                .HasForeignKey(d => d.UserId);
            modelBuilder.Entity<Donation>()
                .HasRequired(d => d.Cause)
                .WithMany(c => c.Donations)
                .HasForeignKey(d => d.CauseId);
            modelBuilder.Entity<Cause>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Cause>()
                .HasMany(c => c.Donations)
                .WithRequired(d => d.Cause)
                .HasForeignKey(d => d.CauseId);
            modelBuilder.Entity<NGO>()
                .HasRequired(n => n.User)
                .WithMany(u => u.NGOs)
                .HasForeignKey(n => n.UserId);

            base.OnModelCreating(modelBuilder);
        }

    }
}