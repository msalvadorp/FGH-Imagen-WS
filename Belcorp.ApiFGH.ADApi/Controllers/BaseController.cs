﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.ApiFGH.ADApi.Controllers
{
    //[ServiceFilter(typeof(ApiActionFilter))]
    //[ServiceFilter(typeof(ApiExceptionFilter))]
    [Route("api/[controller]/[action]")]
    [EnableCors("AllowAllCORS")]
    public class BaseController : Controller
    {

 
    }
}
