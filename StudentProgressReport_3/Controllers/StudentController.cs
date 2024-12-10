using StudentProgressReport_3.Models;
using StudentProgressReport_3.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentProgressReport_3.Controllers
{
    public class StudentController : Controller
    {
       
        public ActionResult EnterNewStudent()
        {
            Student st=new Student();
            StudentVM svm = new StudentVM(st);
            return View(svm);
        }
        public ActionResult SaveStudentDetails(Student student)
        {
            StudentVM svm = new StudentVM(student);
            if(ModelState.IsValid)
            {
                //Student st = new Student();
                //svm.student = st;
                svm.student=student;
                return View("EnterNewStudent", svm);
            }
            else
            {
                svm.student=student;
                return View("EnterNewStudent", svm);
            }


        }
    }
}