using TechTalk.SpecFlow;

namespace Unacademy
{
    public class ApplicationHooks : UtilityClass
    {


       // public Get_subscription GB;
        public LoginPage LP;
        public SearchFieldPage SFP;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            browserMaximize();
            
                
            
            LaunchApp(url);
         // LaunchApp(Url);
            Thread.Sleep(2000);



            SFP = new SearchFieldPage(driver);
           // driver.Manage().Window.FullScreen();

            LP = new LoginPage(driver);
            //driver.Manage().Window.FullScreen();

           

            Thread.Sleep(5000);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
           // CloseBrowser();
        }
    }
}
