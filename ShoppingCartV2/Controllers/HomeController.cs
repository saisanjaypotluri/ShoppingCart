/*
* Course: CS 6070
* Section: 01
* Name: Sai Sanjay Potluri
* Professor: Alan Shaw
* Assignment #: Module Assignment #8
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Accessories Store";

        // Text for Order View Heading
        string orderHeading = "Categories";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Interior Accessories ", "Exterior Accessories", "Performance Parts",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Interior Accessories ", "Exterior Accessories", "Performance Parts",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "InteriorAccessories ", "ExteriorAccessories", "PerformanceParts",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Materials", "Discounts",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/logo.jpeg\">";
            ViewBag.Message2 += "<br />One stop for all your car needs!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Created by Sai Sanjay Potluri as the Webmaster.";
            ViewBag.Message3 = "<img src=\"/Images/aboutus.jpg\">";
            return View();
        }

        // Action Method for Interior Accessories View
        public ActionResult InteriorAccessories()
        {
            return GetTabView(1);
        }

        // Action Method to Process Interior Accessories View
        [HttpPost]
        public ActionResult InteriorAccessories(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }
        // Action Method for Exterior Accessories View
        public ActionResult ExteriorAccessories()
        {
            return GetTabView(2);
        }

        // Action Method to Process Exterior Accessories View
        [HttpPost]
        public ActionResult ExteriorAccessories(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }
        // Action Method for Performance parts View
        public ActionResult PerformanceParts()
        {
            return GetTabView(3);
        }

        // Action Method to Process Performance Parts View
        [HttpPost]
        public ActionResult PerformanceParts(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}