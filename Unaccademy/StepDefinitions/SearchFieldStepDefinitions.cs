using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Unacademy.StepDefinitions
{
    [Binding]
    public class SearchFieldStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is Launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }

        [When(@"User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Thread.Sleep(1000);
            LP.LoginButton();
        }

        [When(@"User enters Registered Phone number ""([^""]*)""")]
        public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
        {
            Thread.Sleep(1000);
            LP.MobileNumberTextBox(RegisteredPhoneNumber);
            LP.LoginButton1();
            Thread.Sleep(30000);
            LP.Verify_OTP_Button();
        }

        [Then(@"It shows home Page")]
        public void ThenItShowsHomePage()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Home Page Is Displayed");
        }

        [When(@"User click on the Search text box")]
        public void WhenUserClickOnTheSearchTextBox()
        {
            Thread.Sleep(7000);
            SFP.SearchText_Box();
           
        }

      

        [When(@"enter the educators")]
        public void WhenEnterTheEducators()
        {
            Thread.Sleep(2000);
            SFP.Entereducators();
        }

        [When(@"Click on educators")]
        public void WhenClickOnEducators()
        {
            Thread.Sleep(2000);

            SFP.ClickOnEnter();
        }

        [Then(@"educators page will be display")]
        public void ThenEducatorsPageWillBeDisplay()
        {

            string expectedTitle = "IIT JEE Exam Preparation 2022 | Crack IIT JEE | Unacademy";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            Thread.Sleep(2000);
            driver.Quit();
        }



        //Lessons

        [When(@"User click on the search text box")]
        public void WhenUserClickOnTheSearchTextBox1()
        {
            Thread.Sleep(2000);
            SFP.SearchText_Box();
        }


        [When(@"enter the lessons")]
       public void WhenEnterTheLessons()
       {

            Thread.Sleep(2000);
            SFP.Enterlessons();
        }

       [When(@"Click on lessons")]
       public void WhenClickOnLessons()
       {
            Thread.Sleep(2000);

            SFP.ClickOnEnter1();
            Thread.Sleep(5000);
           // driver.Quit();

        }

       [Then(@"lessons page will be display")]
       public void ThenLessonsPageWillBeDisplay()
       {
            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            


        }
      

        /* [When(@"enter the lessons")]
         public void WhenEnterTheLessons()
         {
             Thread.Sleep(2000);
             SFP.Enterlessons();
         }

         [When(@"Click on lessons")]
         public void WhenClickOnLessons()
         {
             Thread.Sleep(2000);

             SFP.ClickOnEnter1();
             Thread.Sleep(5000);
         }

         [Then(@"lessons page will be display")]
         public void ThenLessonsPageWillBeDisplay()
         {
             string expectedTitle = "Unacademy - India's largest learning platform";
             string actualTitle = ValidatePageTitle();
             Assert.That(actualTitle, Is.EqualTo(expectedTitle));
             Console.WriteLine(actualTitle);
         }*/






        //Courses

        [Given(@"Chrome is Launched and Unaccademy application is launched")]
        public void GivenChromeIsLaunchedAndUnaccademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }
       

        [When(@"User clicks on Search text box")]
          public void WhenUserClicksOnSearchTextBox2()
          {
              Thread.Sleep(2000);
              SFP.SearchText_Box();
          }

          [When(@"enter the courses")]
          public void WhenEnterTheCourses()
          {
              Thread.Sleep(2000);
              SFP.Entercourses(); ;
          }

          [When(@"Click on courses")]
          public void WhenClickOnCourses()
          {
              Thread.Sleep(2000);

              SFP.ClickOnEnter2();
              Thread.Sleep(5000);
          }

          [Then(@"courses page will be display")]
          public void ThenCoursesPageWillBeDisplay()
          {
              string expectedTitle = "Unacademy - India's largest learning platform";
              string actualTitle = ValidatePageTitle();
              Assert.That(actualTitle, Is.EqualTo(expectedTitle));
              Console.WriteLine(actualTitle);

              Thread.Sleep(2000);
              driver.Quit();
          }

       //Educators Data

        [When(@"User clicks on search text Box")]
        public void WhenUserClicksOnSearchTextBox()
        {
            Thread.Sleep(2000);
            SFP.SearchText_Box();
        }

        [When(@"enter the educators From karnataka")]
        public void WhenEnterTheEducatorsFromKarnataka()
        {
            Thread.Sleep(2000);
            SFP.EnterEducatorsData();
        }

        [When(@"Click on educators From karnataka")]
        public void WhenClickOnEducatorsFromKarnataka()
        {
            Thread.Sleep(2000);

            SFP.ClickOnEnterData1();
        }

        [Then(@"educators from Karnataka page will be display")]
        public void ThenEducatorsFromKarnatakaPageWillBeDisplay()
        {
            string expectedTitle = "IIT JEE Exam Preparation 2022 | Crack IIT JEE | Unacademy";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            driver.Quit();
        }


       //Courses Data

        [When(@"User clicks on Sarch text Box")]
        public void WhenUserClicksOnSarchTextBox()
        {
            Thread.Sleep(2000);
            SFP.SearchText_Box();
        }

        [When(@"enter the lessons On Antropology")]
        public void WhenEnterTheLessonsOnAntropology()
        {
            Thread.Sleep(2000);
            SFP.EnterlessonsData();
        }

        [When(@"Click on lessons On Antropology")]
        public void WhenClickOnLessonsOnAntropology()
        {
            Thread.Sleep(2000);

            SFP.ClickOnEnterData2();
        }

        [Then(@"lessons on Antropolog Page will be display")]
        public void ThenLessonsOnAntropologPageWillBeDisplay()
        {
            SFP.scroll();
            string expectedTitle = "Unacademy - India's largest learning platform";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);

            driver.Quit();
        }


    }
}

