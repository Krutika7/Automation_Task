using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PracticeProject.Hooks
{
    [Binding]
    public  class Hooks1
    {
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest scenario;
        AventStack.ExtentReports.ExtentTest step;
        static string reportpath = System.IO.Directory.GetParent(@"C:\Users\Lenovo\source\repos\PracticeProject\PracticeProject\Reports").FullName
            + Path.DirectorySeparatorChar + "Result"
            + Path.DirectorySeparatorChar + "Result" + DateTime.Now.ToString("ddMMyyyy HHmmss");
       

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }


        public static IWebDriver driver = new ChromeDriver();
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            scenario = feature.CreateNode(context.ScenarioInfo.Title);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practice.automationtesting.in/");
            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
        }
        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                step.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                step.Log(Status.Fail, context.StepContext.StepInfo.Text);
            }
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            //screenshot.SaveAsFile("C:\\Users\\Lenovo\\source\\repos\\PracticeProject\\PracticeProject\\Screenshots\\Krutika.png", ScreenshotImageFormat.Png);

            driver.Quit();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
