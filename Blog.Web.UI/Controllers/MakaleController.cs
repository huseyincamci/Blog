﻿using Blog.BLL.DataServices;
using Blog.DAL.Data.Entities;
using Blog.Web.UI.ViewModels;
using PagedList;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Blog.Web.UI.Controllers
{
    public class MakaleController : Controller
    {
        private MakaleRepository _makaleRepository;

        public MakaleController()
        {
            _makaleRepository = new MakaleRepository();
        }
        // GET: Makale
        public ActionResult Index(int sayfa = 1)
        {
            var makaleler = _makaleRepository.GetList().OrderByDescending(x => x.Id).ToPagedList(sayfa, 20);
            return View(makaleler);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MakaleViewModel model)
        {
            if (!ModelState.IsValid) return View();
            var makale = new Makale()
            {
                Baslik = model.Baslik,
                Ozet = model.Ozet,
                Icerik = model.Icerik,
                KategoriId = 1,
                CreatedDate = DateTime.Now,
                Like = 0,
                Dislike = 0,
                Views = 0,
                IsActive = model.IsActive,
                IsDeleted = model.IsDeleted
            };
            _makaleRepository.Add(makale);
            _makaleRepository.Save();
            return RedirectToAction("Index");
        }
    }
}