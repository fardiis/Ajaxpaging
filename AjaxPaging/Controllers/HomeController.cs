using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AjaxPaging.Models;
using AjaxPaging.Helper;

namespace AjaxPaging.Controllers
{
    public class HomeController : Controller
    {
        List<BookModel> list = new List<BookModel>();
        public const int PageSize = 5;
        public IActionResult Index()
        {
            var query = new PagedData<BookModel>();
            query.Data = list.Skip(PageSize * 0).Take(PageSize).ToList();
            query.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)list.Count() / PageSize));


            return View(query);
        }
        public IActionResult RMAList(string searchingString, int pageNumber)
        {
            var query = new PagedData<BookModel>();
            query.Data = list.Skip(PageSize * (pageNumber - 1)).Take(PageSize).ToList();
            query.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)list.Count() / PageSize));
            query.CurrentPage = pageNumber;

            return PartialView("_RMAListPartial", query);


        }

    }
}

