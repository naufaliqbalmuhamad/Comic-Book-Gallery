using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _ComicRepo = new ComicBookRepository();
        
        // GET: ComicBooks
        public ActionResult Index()
        {
            var ComicBooks = _ComicRepo.GetAllComicBook();
            return View(ComicBooks);
        }

        public ActionResult Detail(int? Id) //liat dengan cara menambahkan "../nama controller/Detail" pada web tampilan
        {
            if((Id == null) || (Id > 3))
                return HttpNotFound();
            
            var comicBook = _ComicRepo.GetComicBook((int) Id);
            return View(comicBook);
        }
    }
}