using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace qizhong.Controllers
{
    
    public class TestController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            
            return View();
        }
        public string CheckUsername(string username)
        {
           
            if (username.Equals("wustzz")) return "用户名不能为wustzz";
            else if (username.Equals("")) return "用户名不能为空";
            else if (!Regex.IsMatch(username, "[a-z]{6,10}") || (username.Length > 10)) return "用户名为6到10个小写字母";
            else if (Regex.IsMatch(username, "[a-z]{6,10}")) { return " "; }
            else return "用户名为6到10个小写字母";

        }

    }
}