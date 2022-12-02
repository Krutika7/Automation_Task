using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeProject.Hooks;
using OpenQA.Selenium;

namespace PracticeProject.Wait
{
    class Explicitwait
    {
        WebDriverWait wait = new WebDriverWait(Hooks1.driver, TimeSpan.FromSeconds(5));
      //  Wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
    }
}
