using OpenQA.Selenium;
using PracticeProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Pom
{
    class Oneproduct
    {
        public void clickshop()
        {
            string shop = "//a[normalize-space()='Shop']";
            Hooks1.driver.FindElement(By.XPath(shop)).Click();

        }

        public void clickimage()
        {
            string image = "//img[@title='Mastering JavaScript']";
            Hooks1.driver.FindElement(By.XPath(image)).Click();

        }

        //public void refresh()
        //{
        //    string ad = "//span[@class='ns-3s9gy-";
        //    Hooks1.driver.FindElement(By.XPath(ad)).SendKeys(Keys.F5);
        //}

        public void addtocart()
        {
            string addtobasket = "//button[@type='submit']";    

            Hooks1.driver.FindElement(By.XPath(addtobasket)).Click();
        }

        public void viewbasket()
        {
            string item = "//a[@class='button wc-forward']";     
            Hooks1.driver.FindElement(By.XPath(item)).Click();
        }

        public void clickcheckout()
        {
            string checkout = "//a[@class='checkout-button button alt wc-forward']";
            Hooks1.driver.FindElement(By.XPath(checkout)).Click();
             
        }


        public void enterfirstname()
        {
            string firstname = "//input[@id='billing_first_name']";
            Hooks1.driver.FindElement(By.XPath(firstname)).SendKeys("Sona");
        }

        public void enterlastname()
        {
            string lastname = "//input[@id='billing_last_name']";
            Hooks1.driver.FindElement(By.XPath(lastname)).SendKeys("Kumar");
        }

        public void entercompanyname()
        {
            string company = "//input[@id='billing_company']";
            Hooks1.driver.FindElement(By.XPath(company)).SendKeys("Sona");
        }

        public void enteremail()
        {
            string company = "//input[@id='billing_email']";
            Hooks1.driver.FindElement(By.XPath(company)).SendKeys("Sonakumar@gmail.com");
        }

        

        public void enterphone()
        {
            string phone = "//input[@id='billing_phone']";
            Hooks1.driver.FindElement(By.XPath(phone)).SendKeys("9989765467");
        }

        public void enteraddress()
        {
            string address1 = "//input[@id='billing_address_1']";
            string address2 = "//input[@id='billing_address_2']";
            Hooks1.driver.FindElement(By.XPath(address1)).SendKeys("Kush nagar");
            Hooks1.driver.FindElement(By.XPath(address2)).SendKeys("house no 56");
        }

        public void entercity()
        {
            string city = "//input[@id='billing_city']";
            Hooks1.driver.FindElement(By.XPath(city)).SendKeys("Jamshedpur");
        }

        public void enterstate()
        {
            
            Hooks1.driver.FindElement(By.XPath("//span[@id='select2-chosen-2']")).Click(); 
            string state = "//input[@id='s2id_autogen2_search']"; 
            Hooks1.driver.FindElement(By.XPath(state)).SendKeys("Jharkhand"); 
            Hooks1.driver.FindElement(By.XPath(state)).SendKeys(Keys.Enter);
        }

        public void enterzipcode()
        {
            string zipcode = "//input[@id='billing_postcode']";
            Hooks1.driver.FindElement(By.XPath(zipcode)).SendKeys("831002");
        }

        public void enterpayment()
        {
            string payment = "//input[@id='payment_method_cod']";
            Hooks1.driver.FindElement(By.XPath(payment)).Click();
        }

        public void placeorder()
        {
            string payment = "//input[@id='place_order']";
            Hooks1.driver.FindElement(By.XPath(payment)).Click();
        }

        
        
    }
}
