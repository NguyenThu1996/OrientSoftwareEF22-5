using Microsoft.EntityFrameworkCore;
using OrientSoftWare.Base.My.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrientSoftWareBaseMy.core.DataAccess
{
    public class OrientNetCoreContext : DbContext

    {
        public OrientNetCoreContext(DbContextOptions<OrientNetCoreContext> options) : base(options) { }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(t => new { t.UserId, t.RoleId });
            modelBuilder.Entity<UserInRole>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UserInRoles)
                .HasForeignKey(pt => pt.UserId);
            modelBuilder.Entity<UserInRole>()
                .HasOne(pt => pt.Role)
                .WithMany(p => p.UserInRoles)
                .HasForeignKey(pt => pt.RoleId);
        }
    }
}
