using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent]
    public class TriviaViewComponent : ViewComponent
    {
        private readonly BlogDataContext _db;

        public TriviaViewComponent(BlogDataContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = _db.Trivias.ToArray();
            return View(specials);
        }

    }
}
