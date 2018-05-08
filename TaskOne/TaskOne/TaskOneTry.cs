using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskOne
{
    class TaskOneTry
    {
        IWebDriver driver;

       // [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:/Users/preetisaxena/Downloads/chromedriver_win32");
            driver.Manage().Window.Maximize();
         }
     
       // [Test]
        public void test() {
          //  driver.Url = "http://www.google.co.in";
            driver.Url = "http://book.theautomatedtester.co.uk/";
            
        }

        public void clickOnChapterOneLink() {
            driver.FindElement(By.XPath("//a[contains(text(), 'Chapter1')]")).Click();
        }

        public void assertText() {
           String res =  driver.FindElement(By.XPath("//div[@id='divontheleft']")).Text;
           
            Boolean val;
            if (res.Equals("Assert that this text is on the page"))
            {
                val = true;
                Assert.True(val);
                 Console.WriteLine("Assert Passed.. ");
            
            }
            else {
                val = false;
                Assert.False(val);
                 Console.WriteLine("Assert Fail.. Try Again");
            }
           // Assert.AreEqual("Assert that this text is on the page", res,"Asset Fail Write Again...");  
                                     
        }

        public void loadButtonCheck() {
            driver.FindElement(By.XPath("//input[@id='secondajaxbutton']")).Click();
            String str = driver.FindElement(By.XPath("//div[@id='html5div']")).Text;
            Boolean val;
            // Console.WriteLine(str);
            MessageBox.Show(str);
           if(str.Contains("I have been added with a timeout")){
           //if(str == ("I have been added with a timeout")){
                val = true;
                Assert.True(val);
                Console.WriteLine("Load Button Assert is Passed.");
            }
           else{
                val = false;
                Assert.False(val);
                Console.WriteLine("Load Button Assert is Failed.");
            }
        }

        public void homePageLinkCheck() {
           System.Threading.Thread.Sleep(400);
           driver.FindElement(By.XPath("//a[text()='Home Page']")).Click();
           Console.ReadKey(); 
        } 

        
      /*  public void closeBrowser() {
            driver.Close();
        }*/
    }
}
