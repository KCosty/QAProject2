using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project
{
    class WebElements
    {
    public static IWebElement notifications(IWebDriver driver)
    {
        IWebElement btnnotify = driver.FindElement(By.CssSelector("[href*='notifications.php']"));
        return btnnotify;
    }
    public static IWebElement messages(IWebDriver driver)
    {
        IWebElement btnmsg = driver.FindElement(By.CssSelector("[href*='DirectMessage']"));
        return btnmsg;
    }
    public static IWebElement contact(IWebDriver driver)
    {
        IWebElement btncontact = driver.FindElement(By.CssSelector("[href*='contactus']"));
        return btncontact;
    }
    public static IWebElement contacttohome(IWebDriver driver)
    {
        IWebElement btnconhome = driver.FindElement(By.CssSelector("[href*='index.php']"));
        return btnconhome;
    }
    public static IWebElement retweet(IWebDriver driver)
    {
        IWebElement btnretweet = driver.FindElement(By.Name("retweetClick"));
        return  btnretweet;
    }
    public static IWebElement reply(IWebDriver driver)
    {
        IWebElement btnreply = driver.FindElement(By.Name("replyClick"));
        return btnreply;
    }
    public static IWebElement replymsg(IWebDriver driver)
    {
         IWebElement txtreply = driver.FindElement(By.Id("replyText"));
         return txtreply;
    }
    public static IWebElement replybtn(IWebDriver driver)
    {
        IWebElement btnreplymsg = driver.FindElement(By.Name("submit"));
        return btnreplymsg;
    }
    public static IWebElement dropdown(IWebDriver driver)
    {
         IWebElement btndropdown = driver.FindElement(By.Id("dropdown01"));
         return btndropdown;
    }
    public static IWebElement logout(IWebDriver driver)
    {
        IWebElement btnlogout = driver.FindElement(By.CssSelector("[href*='logout.php']"));
        return btnlogout;
    }
    }
}
