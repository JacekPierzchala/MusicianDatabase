using Microsoft.EntityFrameworkCore;
using MusicianDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace MusicianDatabase.DAL
{
    public class MusicianDbContext:DbContext
    {
        public string ConnStr { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicianDb;Integrated Security=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<ConfigEntitlement> ConfigEntitlements { get; set; }
        public DbSet<ConfigRole> ConfigRoles { get; set; }
        public DbSet<RoleEntitlement> RoleEntitlements { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Musician> Musicians { get; set; }

        public DbSet<MusicianInstrument> MusicianInstruments { get; set; }
        public DbSet<MusicianInstrumentBand> MusicianInstrumentBands { get; set; }
        public DbSet<Band> Bands { get; set; }
        public MusicianDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlServer(ConnStr);
        }
        
    }
}
