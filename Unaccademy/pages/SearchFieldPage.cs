using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unacademy
{
    public class SearchFieldPage : UtilityClass
    {
        private IWebDriver driver;

           


        // Search text box


        private By Search_Text_Box = By.CssSelector("#searchTab > div > div > div > svg");

        private By Enter_lessons = By.CssSelector("#searchInput");
         private By Click_On_Enter1 = By.XPath("//p[normalize-space()='lessons']");

         private By Enter_educators = By.CssSelector("#searchInput");
         private By Click_On_Enter = By.XPath("//p[normalize-space()='educators']");

         private By Enter_courses = By.CssSelector("#searchInput");
         private By Click_On_Enter2 = By.XPath("//p[normalize-space()='courses']");

        private By Enter_educatorsData = By.CssSelector("#searchInput");
        private By Click_On_EnterData1 = By.XPath("//div[@class='css-zhxa7k-Item esu8lwp0']");

        private By Enter_lessonsData = By.CssSelector("#searchInput");
        private By Click_On_EnterData2 = By.XPath("//p[@class='css-1trt5ra-P1-P esu8lwp1']");

        public void scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,3000);");
            Thread.Sleep(3000);
        }
      



        public SearchFieldPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        public void SearchText_Box()
        {
            driver.FindElement(Search_Text_Box).Click();
        }
        


        public void Enterlessons()
        {
            driver.FindElement(Enter_lessons).SendKeys("lessons");
        }


        public void ClickOnEnter1()
        {
            driver.FindElement(Click_On_Enter1).Click();
        }

         public void Entereducators()
         {
             driver.FindElement(Enter_educators).SendKeys("educators");

         }

        public void ClickOnEnter()
         {
             driver.FindElement(Click_On_Enter).Click();
         }

        public void Entercourses()

         {
             driver.FindElement(Enter_courses).SendKeys("courses");
         }
        public void ClickOnEnter2()
        {
            driver.FindElement(Click_On_Enter2).Click();
        }
       



        //Data's
        public void EnterEducatorsData()
        {
            driver.FindElement(Enter_educatorsData).SendKeys("educators from karnataka");
        }


        public void ClickOnEnterData1()
        {
            driver.FindElement(Click_On_EnterData1).Click();
        }



        public void EnterlessonsData()
        {
            driver.FindElement(Enter_lessonsData).SendKeys("mock test on physics");
        }


        public void ClickOnEnterData2()
        {
            driver.FindElement(Click_On_EnterData2).Click();
        }
    }
}
