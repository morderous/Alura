using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using  ShoppingApp.Models;

namespace ShoppingApp.Controllers
{
    public class HomeController : Controller
    {
        private ShoppingDBEntities _db = new ShoppingDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.Lojas.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Loja lojaToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            _db.Lojas.Add(lojaToCreate);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var lojaToEdit = (from a in _db.Lojas
                               where a.Id == id
                               select a).First();
            return View(lojaToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Loja lojaToEdit)
        {
            var originalLoja = (from a in _db.Lojas
                                where a.Id == lojaToEdit.Id
                                select a).First();

            if (!ModelState.IsValid)
                return View(originalLoja);

            _db.Entry(originalLoja).CurrentValues.SetValues(lojaToEdit);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
