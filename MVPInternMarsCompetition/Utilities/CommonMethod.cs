using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPInternMarsCompetition.Utilities
{
    public class CommonMethod
    {
        public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
        {
            var folderLocation = @"Screenshots\";

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(ScreenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-MM-yyyy_mss"));
            fileName.Append(".jpeg");
            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
            return fileName.ToString();
        }
    }
}
