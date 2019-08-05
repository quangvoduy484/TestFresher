using Microsoft.EntityFrameworkCore;
using RadarWebModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadarWebModels.Contexts
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Data Source=DESKTOP-KSMGIIG;Initial Catalog=WebHook;Integrated Security=True");
    }

    public DbSet<Event> Events { get; set; }

    public DbSet<Geofences> Geofences { get; set; }

    public DbSet<MetaData> MetaDatas { get; set; }

    public DbSet<User> Users { get; set; }

    //public DbSet<Place> MetaDatas { get; set; }


  }
}
