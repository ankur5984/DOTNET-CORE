using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineShopingApplication.Models;

namespace OnlineShopingApplication.Controllers
{
    public class AccountsController:Controller
    {
        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
              
              if(username=="ravi" && password=="ravi"){
                  return RedirectToAction("index","products");

              }
                    
                return View();
        }
        
        public IActionResult Register(){
            return View();
        }
     [HttpPost]
    public IActionResult Register(RegisterViewModel model){
        if (ModelState.IsValid){
             return RedirectToAction("login","accounts");
        }
        else{
            return View();
        }
        
        //return view();
    }




    }
}