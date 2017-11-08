using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/queryhistory")]
    public class QueryHistoryController : GenericCRUDController<QueryHistory>
    {
        public QueryHistoryController(IDataService dataService) : base(dataService, dataService.GetQueryHistoryRepository())
        {
        }
    }
}
