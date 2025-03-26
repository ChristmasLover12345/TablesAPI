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

        public async Task<bool> AddRoute(RoutesModel route)
        {
            await _dataContext.Routes.AddAsync(route);
            return await _dataContext.SaveChangesAsync() !=0;
        }

        public async Task<bool> AddLike(LikesModel like)
        {
            await _dataContext.Likes.AddAsync(like);
            return await _dataContext.SaveChangesAsync() != 0;
        }
        public async Task<bool> AddComment(CommentsModel comment)
        {
            await _dataContext.Comments.AddAsync(comment);
            return await _dataContext.SaveChangesAsync() !=0;
        }
        
        public async Task<bool> EditGalleryPost(GalleryPostModel post)
        {
            var postToEdit = await GetGalleryPostById(post.Id);
            

            if(postToEdit == null) return false;

            postToEdit.Title = post.Title;
            postToEdit.ImageUrl = post.ImageUrl;
            postToEdit.Description = post.Description;
            postToEdit.CreatorId = post.CreatorId;
            postToEdit.Comments = post.Comments;
            postToEdit.DateCreated = post.DateCreated;
            postToEdit.IsDeleted = post.IsDeleted;
            postToEdit.Likes = post.Likes;

            _dataContext.GalleryPosts.Update(postToEdit);
            return await _dataContext.SaveChangesAsync() != 0;
        }

        private async Task<GalleryPostModel> GetGalleryPostById(int Id) => await _dataContext.GalleryPosts.FindAsync(Id);
        public async Task<List<LikesModel>> GetLikes(int postId) => await _dataContext.Likes.Where(like => like.PostId == postId).ToListAsync();
        public async Task<List<CommentsModel>> GetComments(int postId) => await _dataContext.Comments.Where(comment => comment.PostId == postId).ToListAsync();

    }
}