﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;


namespace WebDeveloper.Areas.Autor.Controllers
{
    [Authorize]
    public class AutorController : Controller
    {
        private readonly AutorRepository _personRepository;
        public AutorController(AutorRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [OutputCache(Duration = 0)]
        public ActionResult Index()
        {
            ViewBag.Count = TotalPages(10);
            return View();
        }

        [OutputCache(Duration = 0)]
        public ActionResult List(int? page, int? size)
        {
            if (!page.HasValue || !size.HasValue)
            {
                page = 1;
                size = 10;
            }            
            return PartialView("_List",_personRepository.GetListDto().Page(page.Value, size.Value));
        }



        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(ModelLibroAutor person)
        //{
        //    if (!ModelState.IsValid) return PartialView("_Create", person);
        //    person.rowguid = Guid.NewGuid();
        //    person.BusinessEntity = new BusinessEntity
        //    {
        //        rowguid = person.rowguid,
        //        ModifiedDate = person.ModifiedDate
        //    };
        //    _personRepository.Add(person);
        //    return new HttpStatusCodeResult(HttpStatusCode.OK); //RedirectToAction("Index");
        //}

        //[OutputCache(Duration = 0)]
        //public ActionResult Edit(int id)
        //{
        //    var person = _personRepository.GetById(id);
        //    if (person == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    return PartialView("_Edit", person);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[OutputCache(Duration = 0)]
        //public ActionResult Edit(ModelLibroAutor person)
        //{
        //    if (!ModelState.IsValid) return PartialView("_Edit", person);
        //    _personRepository.Update(person);
        //    return RedirectToRoute("Personal_default");
        //}


        //[OutputCache(Duration = 0)]
        //public ActionResult Delete(int id)
        //{
        //    var person = _personRepository.GetById(id);
        //    if (person == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    return PartialView("_Delete", person);
        //}

        //public ActionResult Upload()
        //{
        //    return PartialView("_FileUpload");
        //}

        //[HttpPost]
        //[OutputCache(Duration = 0)]
        //public ActionResult UploadFile()
        //{
        //    if (Request.Files.Count == 0) return PartialView("_FileUpload");
        //    var file = Request.Files[0];
        //    try
        //    {
        //        var folder = Server.MapPath("~/Files");
        //        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
        //        string path = Path.Combine(folder, Path.GetFileName(file.FileName));
        //        file.SaveAs(path);
        //    }
        //    catch
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    return new HttpStatusCodeResult(HttpStatusCode.OK);
        //}

        #region Common Methods
        private int TotalPages(int? size)
        {
            var rows = _personRepository.TotalCount();
            var totalPages = rows / size.Value;
            return totalPages;
        }
        #endregion 
    }
}