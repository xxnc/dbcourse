using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Service;
using MVCWebDemo.Models;
using System.Web.Mvc;
using Spring.Context;
using Spring.Context.Support;
namespace MVCWebDemo.Controllers
{
    public class InstructorController:Controller
    {
        public InstructorService instructorService{set;get;}
        //private InstructorService instructorService = ContextRegistry.GetContext().GetObject("InstructorService") as InstructorService;
        public void getAllId()
        {
            string hsql = "from Instructor";
            IList<Instructor> list = instructorService.getAllId(hsql);
        }
    }
}