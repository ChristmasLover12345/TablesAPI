using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        

    }
}