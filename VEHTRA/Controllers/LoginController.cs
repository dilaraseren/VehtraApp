﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
   
    
        [AllowAnonymous]
        public class LoginController : Controller
        {
            // GET: Login
            Context c = new Context();
            public ActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public PartialViewResult Partial1()
            {
                return PartialView();
            }

            [HttpPost]
            //public PartialViewResult Partial1(Cari p)
            //{
            //    c.Caris.Add(p);
            //    c.SaveChanges();
            //    return PartialView();
            //}

            [HttpGet]
            public ActionResult CariLogin1()
            {
                return View();
            }

            [HttpPost]
            //public ActionResult CariLogin1(Cari p)
            //{
            //    var bilgiler = c.Caris.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);
            //    if (bilgiler != null)
            //    {
            //        FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
            //        Session["Mail"] = bilgiler.Mail.ToString();
            //        return RedirectToAction("Index", "CariPanel");
            //    }
            //    else
            //    {
            //        return RedirectToAction("Index", "Login");
            //    }

            //}

            [HttpGet]
            public ActionResult AdminLogin()
            {
                return View();
            }
            //public ActionResult AdminLogin(Admin p)
            //{
            //    var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            //    if (bilgiler != null)
            //    {
            //        FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
            //        Session["KullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
            //        return RedirectToAction("KolayTablolar", "Istatistik");

            //    }
            //    else
            //    {
            //        return RedirectToAction("Index", "Login");

            //    }

            //}

        }
    }