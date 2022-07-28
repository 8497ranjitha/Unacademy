using OpenQA.Selenium;

namespace Unacademy

{
    public class ConfigClass
    {

        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\User\source\repos\Unaccademy\Unaccademy\Drivers\";
		public static string geckoDriverPath = @"C:\Users\User\source\repos\Unaccademy\Unaccademy\Drivers\";
		
       public static string url = "https://unacademy.com/";
       // public static string Url = "https://unacademy.com/goal/jee-main-and-advanced-preparation/TMUVD";
      //  public static string url = "https://unacademy.com/search/educators";
        public static string filePath = @"C:\Users\User\source\repos\Unaccademy\Unaccademy\screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;


    }
}
