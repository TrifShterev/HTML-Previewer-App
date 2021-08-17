using System;
using System.Linq;

using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

using Previewer.Data;
using Previewer.Models;

namespace Previewer.Controllers
{
    public class HomeController : Controller
    {
        private readonly HtmlPreviewerContext _db;

        public HomeController(HtmlPreviewerContext dbContext)
        {
            this._db = dbContext;
        }


        public IActionResult AddNewText() => View(new HtmlManagerVM());

      
        public IActionResult AddNewTextGet(int id)
        {
            var dbEntity = _db.HtmlManagers.Find(id);

            return View(new HtmlManagerVM
            {
                Id = dbEntity.Id,
                TextHtml = dbEntity.TextHtml,
            });
        }

        [HttpPost]
        public IActionResult AddNewText(HtmlManagerVM htmlManager)
        {
            if (!ModelState.IsValid)
            {
                return View(htmlManager);
            }

            // TODO: generate HASH and compare hashes
            var dbEntity = _db.HtmlManagers.FirstOrDefault(x => x.TextHtml == htmlManager.TextHtml);
            if (dbEntity != null)
            {
                dbEntity.TextHtml = htmlManager.TextHtml;
                dbEntity.LastEditedOn = DateTime.Now;

                _db.SaveChanges();

                htmlManager.Id = dbEntity.Id;

                TempData["Success"] = "The data successfully updated in the database";
            }
            else
            {
                HtmlManager model = new HtmlManager()
                {
                    Id = htmlManager.Id,
                    TextHtml = htmlManager.TextHtml,
                    CreatedOn = DateTime.Now,
                    Url = htmlManager.Url = HttpContext.Request.GetDisplayUrl()
                };
                _db.HtmlManagers.Add(model);
                _db.SaveChanges();

                htmlManager.Id = model.Id;

                TempData["Success"] = "The data successfully saved in the database";
            }

          


            return View(htmlManager);
        }

        public IActionResult Run(HtmlManagerVM htmlManager) => View("AddNewText", htmlManager);

        public ActionResult CheckOriginal(HtmlManagerVM htmlManager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var entityHtmlManager = _db.HtmlManagers.FirstOrDefault(x =>  x.TextHtml == htmlManager.TextHtml);

            if (entityHtmlManager != null)
            {
                return Ok("The text already exist in the database");
            }

            return BadRequest("The text DOES NOT exist in the database");
        }
    }
}
