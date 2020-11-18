using System;
using System.Collections.Generic;
using System.Linq;
using algorithon_server.Models;
using algorithon_server.Utils.Languages;
using Microsoft.AspNetCore.Mvc;

namespace algorithon_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguagesController : ControllerBase
    {
        private static readonly Language[] Languages = new LanguagesTable().getLanguagesTable();
        
        [HttpGet]
        public AlgorithonResponse Get()
        {
            return new AlgorithonResponse()
            {
                Message = "OK",
                Data = Languages.ToArray(),
                Error = null,
            };
        }
    }
}