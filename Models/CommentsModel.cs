using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesAPI.Models
{
    public class CommentsModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string? CommentText { get; set; }
        public string? CreatedAt { get; set; }
        public List<LikesModel>? Likes { get; set; }
    }
}