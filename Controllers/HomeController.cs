using StudentsScoresFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsScoresFinal.Controllers
{
    public class HomeController : Controller
    {
        private BaseDbContext allDb = new BaseDbContext();
        public ActionResult Index()
        {
            var allScores = allDb.Scores.ToList<Score>();
            var allStudents = allDb.Students.ToList<Student>();
            var allSubjects = allDb.Subjects.ToList<Subject>();
            ViewBag.Scores = allScores;
            ViewBag.Students = allStudents;
            ViewBag.Subjects = allSubjects;


           /* var StudentsScores = from sc in allDb.Scores
                                 join st in allDb.Students on sc.StudentId equals st.Id
                                 group sc by new { sc.StudentId, st.Name, st.FamilyName, sc.ScoreNum } into g
                                 select new
                                 {
                                     StudentName = g.Key.Name,
                                     AmountScore = g.Sum(sc => sc.ScoreNum)
                                 };
            ViewBag.StudentsScores = StudentsScores.ToList();
           */

            return View();

        }

       [HttpGet]
        public ActionResult Delete(int id)
        {
            Score score = allDb.Scores.Find(id);
            allDb.Scores.Remove(score);
            allDb.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}