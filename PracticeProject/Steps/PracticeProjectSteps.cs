using System;
using TechTalk.SpecFlow;
using PracticeProject.Pom;
using OpenQA.Selenium;
using PracticeProject.Hooks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeProject.Steps
{
    [Binding]
    public class PracticeProjectSteps
    {
        Login Apply = new Login();
        IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
        Oneproduct Apply1 = new Oneproduct();
        [Given(@"navigate to website URL")]
        public void GivenNavigateToWebsiteURL()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on My Account")]
        public void WhenClickOnMyAccount()
        {
           // Thread.Sleep(3000);
            Hooks1.driver.Navigate().Refresh();
            Apply.clickmyaccount();
          
        }
        
        [When(@"Enter UserName (.*), Password (.*)")]
        public void WhenEnterUserNamePassword(string email, string password)
        {
            Thread.Sleep(4000);
            Hooks1.driver.Navigate().Refresh();
            Apply.fillusername(email);
            Thread.Sleep(3000);
            //Hooks1.driver.Navigate().Refresh();
            Apply.enterpassword(password);
           
        }
        
        [When(@"Click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            Thread.Sleep(4000);
            Apply.clicklogin();
            Screenshot screenshot = (Hooks1.driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\Lenovo\\source\\repos\\PracticeProject\\PracticeProject\\Screenshots\\Login.png", ScreenshotImageFormat.Png);
            Hooks1.driver.Navigate().Refresh();
            
        }

        // Second scenerio starts from here.
        
        [Then(@"""(.*)"" should display")]
        public void ThenShouldDisplay(string text)
        {

            //Apply.validation1();
            string text1 = Hooks1.driver.FindElement(By.XPath("//strong[normalize-space()='Krutikasardar07']")).Text;
            Assert.AreEqual(text1, text);
           // Assert.AreEqual()
           
        }

        [When(@"Click on Shop,add one product in your cart and go to cart")]
        public void WhenClickOnShopAddOneProductInYourCartAndGoToCart()
        {
            Hooks1.driver.Navigate().Refresh();
            Thread.Sleep(4000);
            Apply1.clickshop();
            Hooks1.driver.Navigate().Refresh();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,4000)");
            Thread.Sleep(4000);
            Apply1.clickimage();
            Hooks1.driver.Navigate().Refresh();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,4000)");
            Thread.Sleep(4000);
            Apply1.clickimage();
            Hooks1.driver.Navigate().Refresh();
            Thread.Sleep(4000);
            Apply1.addtocart();
            Thread.Sleep(4000);
            //            js.ExecuteScript("window.scrollBy(0,4000)");
            Apply1.viewbasket();
            // ScenarioContext.Current.Pending();
        }

        [When(@"Click on proceed to checkout and fill the required details")]
        public void WhenClickOnProceedToCheckoutAndFillTheRequiredDetails()
        {
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,4000)");
            Thread.Sleep(4000);
            Apply1.clickcheckout();
            Thread.Sleep(4000);
            Apply1.enterfirstname();
            Thread.Sleep(4000);
            Apply1.enterlastname();
            Thread.Sleep(4000);
            Apply1.entercompanyname();
            Thread.Sleep(4000);
            Apply1.enteremail();
            Thread.Sleep(4000);
            Apply1.enterphone();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,5000)");
            Thread.Sleep(4000);
            Apply1.enteraddress();
            Thread.Sleep(4000);
            Apply1.entercity();
            Thread.Sleep(4000);
            Apply1.enterstate();
            Thread.Sleep(4000);
            Apply1.enterzipcode();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,900)");


            // ScenarioContext.Current.Pending();
        }

        [When(@"Scroll down,select COD and click on place Order")]
        public void WhenScrollDownSelectCODAndClickOnPlaceOrder()
        {
            Thread.Sleep(4000);
            Apply1.enterpayment();
            Thread.Sleep(4000);
            Apply1.placeorder();
            Thread.Sleep(4000);
            Screenshot screenshot = (Hooks1.driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\Lenovo\\source\\repos\\PracticeProject\\PracticeProject\\Screenshots\\Billing.png", ScreenshotImageFormat.Png);
            //ScenarioContext.Current.Pending();

        }

        [Then(@"""(.*)"" will display")]
        public void ThenWillDisplay(string p0)
        {



         //   ScenarioContext.Current.Pending();
        }

    }
}
