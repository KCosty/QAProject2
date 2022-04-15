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
        public static IWebElement logIn(IWebDriver driver)
        {
            IWebElement txtUserName = driver.FindElement(By.Id("username"));
            return txtUserName;
        }
        public static IWebElement pword(IWebDriver driver)
        {
            IWebElement txtPass = driver.FindElement(By.Id("password"));
            return txtPass;
        }
        public static IWebElement logInbtn(IWebDriver driver)
        {
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }
        public static IWebElement Tweet(IWebDriver driver)
        {
            IWebElement txtTweet = driver.FindElement(By.Id("myTweet"));
            return txtTweet;
        }
        public static IWebElement Tweet1(IWebDriver driver)
        {
            IWebElement btnTweet = driver.FindElement(By.Id("myTweet"));
            return btnTweet;
        }
        public static IWebElement Tweet1(IWebDriver driver)
        {
            IWebElement btnSend = driver.FindElement(By.TagName("btnTweet"));
            return btnSend;
        }
        public static IWebElement follow(IWebDriver driver)
        {
            IWebElement btnfollow = driver.FindElement(By.Name("follow"));
            return btnfollow;
        }
        public static IWebElement homeclick(IWebDriver driver)
        {
            IWebElement btnhome = driver.FindElement(By.CssSelector("[href*='index.php']"));
            return btnhome;
        }
        public static IWebElement momentsclick(IWebDriver driver)
        {
            IWebElement btnmom = driver.FindElement(By.CssSelector("[href*='moments.php']"));
            return btnmom;
        }
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
            return btnretweet;
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

        public static IWebElement tweetSpecChar(IWebDriver driver)
        {
            IWebElement tweetChar= driver.FindElement(By.Id("myTweet"));
            return tweetChar;
        }
        public static IWebElement editProfPic(IWebDriver driver)
        {
            IWebElement profPic = driver.FindElement(By.CssSelector("[href*='edit_photo.php']"));
            return profPic;
        }
        public static IWebElement TrendingPeople(IWebDriver driver)
        {
            IWebElement trending = driver.FindElement(By.Name("Trending"));
            return trending;
        }
        public static IWebElement email(IWebDriver driver)
        {
            IWebElement emailAd = driver.FindElement(By.Id ("email"));
            return emailAd;
        }
        public static IWebElement blankTweet(IWebDriver driver)
        {
            IWebElement blnkTweet = driver.FindElement(By.CssSelector("myTweet"));
            return blnkTweet;
        }
        public static IWebElement signIn(IWebDriver driver)
        {
            IWebElement signInForm = driver.FindElement(By.Id("login_form"));
            return signInForm;
        }
        public static IWebElement register(IWebDriver driver)
        {
            IWebElement btnreg = driver.FindElement(By.ClassName ("btn btn-primary btn-lg btn-block login-button"));
            return btnreg;
        }
        public static IWebElement phoneNum(IWebDriver driver)
        {
            IWebElement phoneNum= driver.FindElement(By.Id("phone"));
            return phoneNum;
        }
        public static IWebElement blankSignUp(IWebDriver driver)
        {
            IWebElement signUp= driver.FindElement(By.CssSelector("[href*='signup_proc.php']"));
            return signUp;
        }
        public static IWebElement pwrdMatch(IWebDriver driver)
        {
            IWebElement pwrd = driver.FindElement(By.Id("confirm"));
            return pwrd;
        }
        public static IWebElement address(IWebDriver driver)
        {
            IWebElement addresstxt= driver.FindElement(By.Id("address"));
            return addresstxt;
        }
        public static IWebElement postalCode(IWebDriver driver)
        {
            IWebElement pCode = driver.FindElement(By.Id("postalCode"));
            return pCode;
        }
    }
}
