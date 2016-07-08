using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.DAO;
using MVCWebDemo.Models;
using MVCWebDemo.Service;

namespace MVCWebDemo.ServiceImpl
{
    public class InstructorServiceImpl:InstructorService
    {
        public InstructorDAO instructorDAO { set; get; }
        public IList<Instructor> getAllId(string hsql)
        {
            return instructorDAO.getEntity(hsql);
        }
    }
}