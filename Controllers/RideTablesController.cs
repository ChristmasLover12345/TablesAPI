using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablesAPI.Models;
using TablesAPI.Services;

namespace TablesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RideTablesController : ControllerBase
    {
        
        private readonly RideTablesService _rideTablesService;
        public RideTablesController(RideTablesService rideTablesService)
        {
            _rideTablesService = rideTablesService;
        }

        [HttpGet("GetGallery")]
        public async Task<IActionResult> GetAllGalleryPosts()
        {
            
            var posts = await _rideTablesService.GetGalleryPosts();

            if(posts != null) return Ok(posts);

            return BadRequest(new {Message = "The gallery is empty.."});

        }

        [HttpGet("GetRoutes")]
        public async Task<IActionResult> GetAllRoutes()
        {

            var routes = await _rideTablesService.GetRoutes();

            if(routes != null) return Ok(routes);

            return BadRequest(new {Message = "No routes"});

        }

        [HttpPost("AddGalleryPost")]
        public async Task<IActionResult> AddGalleryPost([FromBody] GalleryPostModel post)
        {

            var success = await _rideTablesService.AddGalleryPost(post); 

            if(success) return Ok(new {Success = true});

            return BadRequest(new {Message = "Post creation was no successful"});

        }
        
        [HttpPost("AddLike")]
        public async Task<IActionResult> AddLikes([FromBody] LikesModel like)
        {

            var success = await _rideTablesService.AddLike(like);

            if(success) return Ok(new {Success = true});

            return BadRequest(new {Message = "The like was not given"});

        }

        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment([FromBody] CommentsModel comment)
        {

            var success = await _rideTablesService.AddComment(comment);

            if(success) return Ok(new {Success = true});

            return BadRequest(new {Message = "The like was not given"});

        }

    }
}