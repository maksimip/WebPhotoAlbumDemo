using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhotoAlbumDemo.Models;

namespace PhotoAlbumDemo.Domain
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}