using System;
using System.Collections.Generic;
using System.Linq;
using MVCWebDemo.Models;

namespace MVCWebDemo.Service
{
    public interface InstructorService
    {
        
        IList<Instructor> getAllId(string hsql);
        

    }
}