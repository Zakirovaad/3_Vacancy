using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vacancy.Models;
using System.Data;
using System.Data.Entity;



namespace Vacancy.Controllers
{
    public class ValuesController : ApiController
    {
        VacancyListContext db = new VacancyListContext();
        // GET api/values
        public IEnumerable<VacancyList> GetVacancyList() //Cписок вакансий
        {
            return db.VacancyList;
        }

        // GET api/values/5
        public VacancyList GetVacancy(int id) //Детали вакансии
        {
            VacancyList vacancy = db.VacancyList.Find(id);
            return vacancy;
        }


        // POST api/values
        [HttpPost]
        public void CreateVacancy([FromBody] VacancyList vacancy)
        {
            var vac = db.VacancyList.Where(p=> p.id_hh==vacancy.id_hh).ToList();
           // foreach (VacancyList vl in vac)
            //  var pid_hh = vl.id_hh;
            
            if (vac.Count == 0)
            {
                db.VacancyList.Add(vacancy);
                db.SaveChanges();
            }

        }

        // PUT api/values/5
        [HttpPut]
        public void EditVacancy(int id, [FromBody] VacancyList vacancy)
        {
            if (id == vacancy.id)
            {
                db.Entry(vacancy).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void DeleteVacancy(int id)
        {
            VacancyList vacancy = db.VacancyList.Find(id);
            if (vacancy != null)
            {
                db.VacancyList.Remove(vacancy);
                db.SaveChanges();
            }
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
