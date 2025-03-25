using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TablesAPI.Context;
using TablesAPI.Models;

namespace TablesAPI.Services
{
    public class RideTablesService
    {
        
        private readonly DataContext _dataContext;
        public RideTablesService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<GalleryPostModel>> GetGalleryPosts() => await _dataContext.GalleryPosts.ToListAsync();

        public async Task<List<RoutesModel>> GetRoutes() => await _dataContext.Routes.ToListAsync();

        public async Task<bool> AddGalleryPost(GalleryPostModel post)
        {

            await _dataContext.GalleryPosts.AddAsync(post);
            return await _dataContext.SaveChangesAsync() != 0;

        }
        

    }
}