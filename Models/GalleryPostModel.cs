using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesAPI.Models
{
    public class GalleryPostModel
    {
        
        public class LikesData 
        {
            public int UserId { get; set; }
            public string? PostId { get; set; }
            public string? CreatedAt { get; set; }
        }

        public class CommentData
        {
            public int CommentId { get; set; }
            public int UserId { get; set; }
            public int PostId { get; set; }
            public string? CommentText { get; set; }
            public string? CreatedAt { get; set; }
            public List<LikesData>? Likes { get; set; }
        }

        public int PostId { get; set; }
        public int CreatorId { get; set; }
        public string? ImageUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? DateCreated { get; set; }
        public bool isDeleted { get; set; }
        public List<LikesData>? Likes { get; set; }
        public List<CommentData>? Comments { get; set; }
    }
}