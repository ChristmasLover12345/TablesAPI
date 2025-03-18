using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesAPI.Models
{
    public class RoutesModel
    {

        public class Coordinates 
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public class LikesData 
        {
            public int UserId { get; set; }
            public string? RouteId { get; set; }
            public string? CreatedAt { get; set; }
        }

        public class CommentData
        {
            public int CommentId { get; set; }
            public int UserId { get; set; }
            public int RouteId { get; set; }
            public string? CommentText { get; set; }
            public string? CreatedAt { get; set; }
            public List<LikesData>? Likes { get; set; }
        }

        public int RouteId { get; set; }
        public int CreatorId { get; set; }
        public string? RouteName { get; set; }
        public string? RouteDescription { get; set; }
        public string? StartLocation { get; set; }
        public string? EndLocation { get; set; }
        public string? DateCreated { get; set; }
        public string? UpdatedAt { get; set; }
        public bool isPrivate { get; set; }
        public List<Coordinates>? RouteData { get; set;}
        public List<LikesData>? Likes { get; set; }
        public List<CommentData>? Comments { get; set; }


    }
}