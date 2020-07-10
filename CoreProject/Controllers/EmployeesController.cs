using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineShopingApplication.Models;

namespace OnlineShoppingApplication.Controllers{
    public class EmployeesController:Controller
    {
        
       public IActionResult Index()
       {

            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee{ Id=15, FullName="Ankur Prasad", Location="Ranchi", Age=25});
            Employees.Add(new Employee{ Id=16, FullName="Sanket Raikar", Location="Beed", Age=25});
            Employees.Add(new Employee{ Id=17, FullName="GAnesh Shinde", Location="Pune", Age=25});
            Employees.Add(new Employee{ Id=18, FullName="KIshan Gupta", Location="Mumbai", Age=25});
            Employees.Add(new Employee{ Id=19, FullName="Rajiv Sodhi", Location="BAngalore", Age=25});

            //HttpContext.Session["list"]=Customers;

           
           
           return View(Employees);
       }

       public IActionResult Details(int id)
       {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee{ Id=15, FullName="Ankur Prasad", Location="Ranchi", Age=25});
            employees.Add(new Employee{ Id=16, FullName="Sanket Raikar", Location="Beed", Age=25});
            employees.Add(new Employee{ Id=17, FullName="GAnesh Shinde", Location="Pune", Age=25});
            employees.Add(new Employee{ Id=18, FullName="KIshan Gupta", Location="Mumbai", Age=25});
            employees.Add(new Employee{ Id=19, FullName="Rajiv Sodhi", Location="BAngalore", Age=25});
            
            Employee theFoundEmployee=employees.Find(emp=>(emp.Id ==id));
           // ViewBag.theCustomer=theFoundCustomer;
            
           return View(theFoundEmployee);
       }
    }
}