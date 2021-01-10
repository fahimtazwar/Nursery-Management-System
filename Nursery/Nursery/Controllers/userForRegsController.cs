using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nursery.Models;

namespace Nursery.Controllers
{
    public class userForRegsController : Controller
    {
        private myDB db = new myDB();

        // GET: userForRegs
        public ActionResult Index()
        {
            return View(db.userRegi.ToList());
        }

        // GET: userForRegs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userForReg userForReg = db.userRegi.Find(id);
            if (userForReg == null)
            {
                return HttpNotFound();
            }
            return View(userForReg);
        }

        // GET: userForRegs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: userForRegs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Name,Address,Phone,Email,UserName,Password")] userForReg userForReg)
        {
            if (ModelState.IsValid)
            {
                db.userRegi.Add(userForReg);
                db.SaveChanges();
               // return RedirectToAction("Index");
            }
            ModelState.Clear();
            ViewBag.Message = userForReg.Name + " successfully registered";
            return RedirectToAction("Login"); ;
        }

        // GET: userForRegs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userForReg userForReg = db.userRegi.Find(id);
            if (userForReg == null)
            {
                return HttpNotFound();
            }
            return View(userForReg);
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(userForReg newUser)
        {
            using (myDB db = new myDB())
            {

                var loginSuccessful = false;

                try
                {
                    ModelState.Clear();
                    var usr = db.userRegi.Single(u => u.UserName == newUser.UserName && u.Password == newUser.Password);
                    if (usr != null)
                    {
                        Session["UserID"] = newUser.UserID.ToString();
                        Session["UserName"] = newUser.UserName.ToString();
                        //ViewBag.Message = Session["UserName"] + " successfully logged in";
                        loginSuccessful = true;
                        ModelState.Clear();
                 
                        return RedirectToAction("LoggedIn");

                    }

                }

                catch(InvalidOperationException)
                {

                }

                if(!loginSuccessful)
                {
                    ModelState.AddModelError("", "Incorrect Combination");
                   // 
                }

            }

            return View();
        }


        public ActionResult LoggedIn()
        {
            if(Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

       

        // POST: userForRegs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Name,Address,Phone,Email,UserName,Password")] userForReg userForReg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userForReg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userForReg);
        }

        // GET: userForRegs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userForReg userForReg = db.userRegi.Find(id);
            if (userForReg == null)
            {
                return HttpNotFound();
            }
            return View(userForReg);
        }

        // POST: userForRegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            userForReg userForReg = db.userRegi.Find(id);
            db.userRegi.Remove(userForReg);
            db.SaveChanges();
            return RedirectToAction("Index");
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
