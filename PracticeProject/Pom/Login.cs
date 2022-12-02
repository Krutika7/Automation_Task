
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PracticeProject.Hooks;

namespace PracticeProject.Pom
{
    class Login
    {
        public void clickmyaccount()
        {
            string myaccount = "//a[normalize-space()='My Account']";
            Hooks1.driver.FindElement(By.XPath(myaccount)).Click();

        }


        public void fillusername(string email)
        {
            string username = "//input[@id='username']";
            Hooks1.driver.FindElement(By.XPath(username)).SendKeys(email);
        }


        public void enterpassword(string password)
        {
            string password1 = "//input[@id='password']";
            Hooks1.driver.FindElement(By.XPath(password1)).SendKeys(password);

        }


         
        public void clicklogin()
        {
            string loginbutton = "//input[@name='login']";
            Hooks1.driver.FindElement(By.XPath(loginbutton)).Click();

        }

        //public void validation1()
        //{
        //    string text = Hooks1.driver.FindElement(By.XPath("//strong[normalize-space()='Krutikasardar07']")).Text;
        //  //string s1=  Hooks1.driver.FindElement(By.XPath(text)).Text();
          

        //}

    }
}
