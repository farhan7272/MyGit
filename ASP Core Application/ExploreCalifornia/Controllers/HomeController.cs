using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController 
    {
        // GET: Home
        public string Index()
        {
            return "Index Action";
        }        
    }
}