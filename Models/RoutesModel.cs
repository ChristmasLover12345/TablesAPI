using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablesAPI.Models
{
        public class Coordinates 
        {
            public int Id { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
    public class RoutesModel
    {

   
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public string? RouteName { get; set; }
        public string? RouteDescription { get; set; }
        public string? StartLocation { get; set; }
        public string? EndLocation { get; set; }
        public string? DateCreated { get; set; }
        public string? UpdatedAt { get; set; }
        public bool IsPrivate { get; set; }
        public List<Coordinates>? RouteData { get; set;}
        public List<LikesModel>? Likes { get; set; }
        public List<CommentsModel>? Comments { get; set; }


    }
}