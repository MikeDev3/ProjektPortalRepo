﻿using System;
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
            /*
            try
            {
                trueorfalse1 = grupp1.IsAlive();
     
                if (trueorfalse1 == true)
                {
                 aliveClass.grupp1 = trueorfalse1;     // Här tilldelas alla bool-variabler till objektet "aliveclass" som returneras till vyn

                }
            
            }
            catch (Exception)
            {
                throw;

            } */

            try
            {
                trueorfalse2 = grupp2.IsAlive();
               
                if (trueorfalse2 == true)
                {
                    aliveClass.grupp2 = trueorfalse2;     // Här tilldelas alla bool-variabler till objektet "aliveclass" som returneras till vyn

                }

            }
            catch (Exception)
            {
                throw;

            }
            try
            {
               
                trueorfalse3 = grupp3.IsAlive();
             
                if (trueorfalse3 == true)
                {
                    aliveClass.grupp3 = trueorfalse3;     // Här tilldelas alla bool-variabler till objektet "aliveclass" som returneras till vyn

                }

            }
            catch (Exception)
            {
                throw;

            }

            try
            {
              
                trueorfalse4 = grupp4.IsAlive();
                if (trueorfalse4 == true)
                {
                    aliveClass.grupp4 = trueorfalse4;     // Här tilldelas alla bool-variabler till objektet "aliveclass" som returneras till vyn

                }

            }
            catch (Exception)
            {
                throw;

            }

            try
            {
           
                trueorfalse5 = grupp5.IsAlive();

                if (trueorfalse5 == true)
                {
                    aliveClass.grupp5 = trueorfalse5;     // Här tilldelas alla bool-variabler till objektet "aliveclass" som returneras till vyn

                }
               
            }
            catch (Exception)
            {
                throw;

            }


            return View(aliveClass);
        }

      
    }
}