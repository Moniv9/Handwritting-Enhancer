using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Drawing;
using System.Net;

namespace PhotoUpload.Controllers
{
   public class HomeController : Controller
   {

      [HttpGet]
      public ActionResult Index()
      {
         return View();
      }

      [HttpPost]
      public ViewResult FileUpload( HttpPostedFileBase file , Boolean blackwhite )
      {
         Bitmap bmp = Scale(file);

         for(int i = 0; i < bmp.Width; i++) {
            for(int j = 0; j < bmp.Height; j++) {
               if(bmp.GetPixel(i , j).B < 80) {
                  bmp.SetPixel(i , j , Color.Black);
               }
               else {
                  if(blackwhite == true) {
                     bmp.SetPixel(i , j , Color.White);
                  }
               }
            }
         }

         SaveImage(bmp);
         ViewBag.URL = "/Images/modified.jpeg";

         return View();

      }

      private string SaveImage( Bitmap bmp )
      {
         string path = Path.Combine(Server.MapPath("~/Images") , "modified.jpeg");
         bmp.Save(path , System.Drawing.Imaging.ImageFormat.Jpeg);
         return path;
      }

      private Bitmap Scale( HttpPostedFileBase file )
      {
         Bitmap bmp = new Bitmap(file.InputStream);

         int height = (bmp.Height / 3) * 2;
         int width = (bmp.Width / 4) * 3;

         Bitmap newbmp = new Bitmap(width , height);
         newbmp.SetResolution((float)width , (float)height);
         using(Graphics g = Graphics.FromImage(newbmp)) {
            g.DrawImage(bmp , 0 , 0 , (float)width , (float)height);
         }

         return newbmp;
      }

   }
}
