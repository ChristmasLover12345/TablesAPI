using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesAPI.Models
{
    public class LikesModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? PostId { get; set; }
        public string? CreatedAt { get; set; }
    }
}