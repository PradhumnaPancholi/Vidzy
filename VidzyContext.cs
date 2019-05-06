using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.Models;

namespace Vidzy
{
    class VidzyContext : DbContext
    {
        public DbSet<Video> Videos {get; set;}
        public DbSet<Genre> Genres { get; set; }
    }
}
