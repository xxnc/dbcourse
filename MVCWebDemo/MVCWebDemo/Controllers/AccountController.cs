using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using MVCWebDemo.Models;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using MVCWebDemo.Service;
using System.Collections;

namespace MVCWebDemo.Controllers
{
    public class AccountController : Controller
    {
        public UsersService usersService { set; get; }

        //GET /Account/CreateCodeImg
        public void CreateCodeImg()
        {
            string chkCode = string.Empty;
            //颜色列表，用于验证码、噪线、噪点
            Color[] color = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Brown, Color.Brown, Color.DarkBlue };
            //字体列表，用于验证码
            string[] font = { "Times New Roman", "MS Mincho", "Book Antiqua", "Gungsuh", "PMingLiU", "Impact" };
            //验证码的字符集，去掉了一些容易混淆的字符
            char[] character = { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };
            Random rnd = new Random();
            //生成验证码字符串
            for (int i = 0; i < 4; i++)
            {
                chkCode += character[rnd.Next(character.Length)];
            }
            Session["chkcode"] = chkCode;
            Bitmap image = new Bitmap(100, 40);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.White);
            //画噪线
            for (int i = 0; i < 10; i++)
            {
                int x1 = rnd.Next(100);
                int y1 = rnd.Next(40);
                int x2 = rnd.Next(100);
                int y2 = rnd.Next(40);
                Color clr = color[rnd.Next(color.Length)];
                g.DrawLine(new Pen(clr), x1, y1, x2, y2);
            }
            //画验证码字符串
            for (int i = 0; i < chkCode.Length; i++)
            {
                string fnt = font[rnd.Next(font.Length)];
                Font ft = new Font(fnt, 18);
                Color clr = color[rnd.Next(color.Length)];
                g.DrawString(chkCode[i].ToString(), ft, new SolidBrush(clr), (float)i * 20 + 8, (float)8);
            }
            //画噪点
            for (int i = 0; i < 100; i++)
            {
                int x = rnd.Next(image.Width);
                int y = rnd.Next(image.Height);
                Color clr = color[rnd.Next(color.Length)];
                image.SetPixel(x, y, clr);
            }
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Response.ClearContent();
            Response.ContentType = "image/Jpeg";
            Response.BinaryWrite(ms.ToArray());
            g.Dispose();
            image.Dispose();
            return;
        }


        public void Validate()
        {
            if(Session["chkcode"].Equals(Request["code"]))
            {
                Response.Write("success");

            }
            else
            {
                Response.Write("failed");

            }
        }

        public void Conflict()
        {
            Dictionary<string,string> info = new Dictionary<string,string>();
            info.Add("name",Request["name"]);
            usersService.conflict(info);

        }

        //POST /Account/Register
        [HttpPost]
        public void Register()
        {
            Dictionary<string,string> info = new Dictionary<string,string>();
            string token = Request["token"];
            string pwd=Request["pwd"];
            string md5Pwd=System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd,"MD5");
            info.Add("name",Request["name"]);
            info.Add("pwd",md5Pwd);
            info.Add("phone",Request["phone"]);
            info.Add("role",Request["role"]);
            usersService.register(info);
        }

        public void Login()
        {
            Dictionary<string,string> info = new Dictionary<string,string>();
            info.Add("name",Request["name"]);
            string pwd = Request["pwd"];
            string md5Pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            info.Add("pwd",md5Pwd);
            string result=usersService.login(info);
            if (result==null)
            {
                Response.Write("false");
            }
            else
            {
                Response.Write("true");
                Session["station_id"] = result;
            }
        }

        //GET /Account/RegisterForm
        public ActionResult RegisterForm()
        {
            return View();
        }
    }
}