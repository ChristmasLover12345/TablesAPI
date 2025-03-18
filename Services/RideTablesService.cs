using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TablesAPI.Context;

namespace TablesAPI.Services
{
    public class RideTablesService
    {
        
         private readonly DataContext _dataContext;
        public RideTablesService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    }
}