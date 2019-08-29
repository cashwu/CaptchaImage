using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using ImageWeb.Models;
using Edi.Captcha;

namespace ImageWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("image")]
        public FileStreamResult Image()
        {
            CaptchaResult result = CaptchaImageGenerator.GetImage(200, 100, "HELLO");

            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}