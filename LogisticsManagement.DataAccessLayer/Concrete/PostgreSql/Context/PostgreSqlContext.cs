using LogisticsManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.DataAccessLayer.Concrete.PostgreSql.Context
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=212.237.5.27;Port=5432;Username=testcase29;Password=NZ44bLpz;Database=testcasedb29;");
        }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<ActionType> ActionType { get; set; }
        public DbSet<MaintenanceHistory> MaintenanceHistory { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<PictureGroup> PictureGroup { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

    }
}
