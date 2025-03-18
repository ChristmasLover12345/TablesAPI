using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TablesAPI.Models;

namespace TablesAPI.Context
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions options) : base(options)
        {

        }  

        public DbSet<UserProfileModel> UserProfile { get; set; }
        public DbSet<GalleryPostModel> GalleryPosts { get; set; }
        public DbSet<RoutesModel> Routes { get; set; }
        

    }
}