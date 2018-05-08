using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOneTry to = new TaskOneTry();
            to.startBrowser();
            to.test();
            to.clickOnChapterOneLink();
            to.assertText(); 
            to.loadButtonCheck();
            to.homePageLinkCheck();
          //  to.closeBrowser();
    } 
    }
}
