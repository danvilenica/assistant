using DAL.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<PlayerAttack> Attack { get; set; }
        public DbSet<PlayerDefense> Defence { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
