using Edi.Captcha;

namespace ImageWeb.Models
{
    public class Images
    {
        public void Test()
        {
            CaptchaResult result = CaptchaImageGenerator.GetImage(200, 100, "HELLO");
        }
    }
}