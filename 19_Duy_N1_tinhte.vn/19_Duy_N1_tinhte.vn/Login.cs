using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _19_Duy_N1_tinhte.vn
{
    public class Login
    {
        public IWebDriver driver = new ChromeDriver();

        public void InputLogin(string username, string password)
        {
            // Điều hướng đến trang web
            driver.Navigate().GoToUrl("https://tinhte.vn/login/");

            // Lấy element nhập username
            IWebElement elementUsername = driver.FindElement(By.Id("ctrl_pageLogin_login2"));

            // Nhập username
            elementUsername.SendKeys(username);

            // Lấy element nhập password
            IWebElement elementPassword = driver.FindElement(By.Id("ctrl_pageLogin_password2"));

            // Nhập password
            elementPassword.SendKeys(password);

            // Lấy nút đăng nhập
            IWebElement elementLogin = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/div/form/div[2]/input[3]"));

            // Click đăng nhập
            elementLogin.Click();
        }

        public string GetInfo()
        {
            // Đợi 5s để đăng nhập
            Thread.Sleep(5000);

            // Điều hướng đến trang cá nhân
            driver.Navigate().GoToUrl("https://tinhte.vn/account/personal-details");

            // Tìm element username 
            IWebElement elementUsername = driver.FindElement(By.ClassName("accountUsername"));

            return elementUsername.Text;
        }

        public void QuitWeb()
        {
            driver.Quit();
        }
    }
}
