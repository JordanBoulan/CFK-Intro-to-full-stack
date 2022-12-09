using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using HelloCWK.Models;

namespace HelloCWK.Controllers
{
    public class ContactController : Controller
    {
      

        public ContactController()
        {

           
   

        }

        // GET: ContactController
        public ActionResult Index()
        {
            Usernames model = new Usernames();
            model.usernameList = new List<string>();
            return View("index", model);
        }



        // POST: ContactController/Create
        [HttpPost]
 
        public ActionResult Add(IFormCollection collection)
        {
            Usernames model = new Usernames();
            model.usernameList = new List<string>();
            int max = collection.Count - 3 - 1; //subtract username password, verification token, then one more to get to index 0
            // restore old usernames
            if (max >= 0)
            {
                int i = 0;
                while (i <= max)
                {
                    String key = "user" + i;
                    model.usernameList.Add(collection[key]);
                    i++;
                }
            }
            String username = collection["username"];
            model.usernameList.Add(username);
            return View("index", model);


        }
    }
}
