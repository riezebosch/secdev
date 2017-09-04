using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Concurrent;
using WebApplication1.Models.ReflectedModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ReflectedController : Controller
    {
        static ConcurrentBag<Message> data = new ConcurrentBag<Message>(new Message[] { new Message { Script = "hoi", User = "Manuel" } });
        private IHttpContextAccessor context;

        public static string Script { get; private set; }

        public ReflectedController(IHttpContextAccessor context)
        {
            this.context = context;
        }

        // GET: Reflected
        public ActionResult Index()
        {
            return View(data);
        }

        //// GET: Reflected/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Reflected/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(string input)
        {
            try
            {
                data.Add(new Message { Script = input, User = context.HttpContext.User.Identity.Name });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}