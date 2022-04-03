using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentsScoresFinal.Models;

namespace StudentsScoresFinal.Controllers
{
    public class ScoreController : Controller
    {
        private BaseDbContext db = new BaseDbContext();
                

        // GET: Score/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name");
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Title");
            return View();
        }

        // POST: Score/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ScoreNum,Date,SubjectId,StudentId")] Score score)
        {
            if (ModelState.IsValid)
            {
                db.Scores.Add(score);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "Name", score.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "Title", score.SubjectId);
            return View(score);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
