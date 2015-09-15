using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HollyRoommateWebApp.Models;
using System.Net;
using Microsoft.Azure;

namespace HollyRoommateWebApp.Controllers
{
    public class HomeController : Controller
    {
        public void InitializeRoommates (Roommates roommates)
        {
            for (int i = 0; i < 5; i++)
            {
                /*
                roommates.roomMates[i].Email = CloudConfigurationManager.GetSetting("EmailAddr_" + i);
                roommates.roomMates[i].Name = CloudConfigurationManager.GetSetting("Name_" + i);
                */

                Roommate roommate = new Roommate();
                roommate.Email = "perigryn@gmail.com";
                roommate.Name = "Jack";

                roommates.roomMates[i] = roommate;
            }
        }

        public ActionResult Index()
        {
            Roommates roommatesModel = new Roommates();
            InitializeRoommates(roommatesModel);

            ChoreRequestModel chorerequest = new ChoreRequestModel();
            chorerequest.roommates = roommatesModel;

            return View(chorerequest);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}