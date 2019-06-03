using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                ServiceReference1Grupp1.LoginServiceClient grupp1 = new ServiceReference1Grupp1.LoginServiceClient();
                ServiceReference2Grupp2.Service1Client grupp2 = new ServiceReference2Grupp2.Service1Client();
                ServiceReference3Grupp3.Service1Client grupp3 = new ServiceReference3Grupp3.Service1Client();
                ServiceReference4Grupp4.UserProfileServiceClient grupp4 = new ServiceReference4Grupp4.UserProfileServiceClient();
                ServiceReference5Grupp5.Service1Client grupp5 = new ServiceReference5Grupp5.Service1Client();

            Models.IsAliveClass aliveClass = new Models.IsAliveClass();

            bool trueorfalse1 = false;
            bool trueorfalse2 = false;
            bool trueorfalse3 = false;
            bool trueorfalse4 = false;
            bool trueorfalse5 = false;

            aliveClass.grupp1 = trueorfalse1;
            aliveClass.grupp2 = trueorfalse2;
            aliveClass.grupp3 = trueorfalse3;
            aliveClass.grupp4 = trueorfalse4;
            aliveClass.grupp5 = trueorfalse5;
            
            try
            {
                trueorfalse2 = grupp2.IsAlive();
                aliveClass.grupp2 = trueorfalse2;
            }
            catch (Exception)
            {
                aliveClass.grupp2 = trueorfalse2;
            }

            try
            {
                trueorfalse1 = grupp1.IsAlive();
                aliveClass.grupp1 = trueorfalse1;
            }
            catch (Exception)
            {
                aliveClass.grupp1 = trueorfalse1;
            }

            try
            {
                trueorfalse3 = grupp3.IsAlive();
                aliveClass.grupp3 = trueorfalse3;
            }
            catch (Exception)
            {
                aliveClass.grupp3 = trueorfalse3;
            }

            try
            {
                trueorfalse4 = grupp4.IsAlive();
                aliveClass.grupp4 = trueorfalse4;
            }
            catch (Exception)
            {
                aliveClass.grupp4 = trueorfalse4;
            }

            try
            {
                trueorfalse5 = grupp5.IsAlive();
                aliveClass.grupp5 = trueorfalse5;
            }
            catch (Exception)
            {
                aliveClass.grupp5 = trueorfalse5;
            }

            return View(aliveClass);

        }

      
    }
}