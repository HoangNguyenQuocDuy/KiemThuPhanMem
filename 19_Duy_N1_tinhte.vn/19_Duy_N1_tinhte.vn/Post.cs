using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _19_Duy_N1_tinhte.vn
{
    public class Post
    {
        public IWebDriver driver = new ChromeDriver();

        public void CreatePost(string title, string content)
        {
            // Đăng nhập trước khi tạo post
            driver.Navigate().GoToUrl("https://tinhte.vn/login/");
            IWebElement elementUsername = driver.FindElement(By.Id("ctrl_pageLogin_login2"));
            elementUsername.SendKeys("hduy4345@gmail.com");
            IWebElement elementPassword = driver.FindElement(By.Id("ctrl_pageLogin_password2"));
            elementPassword.SendKeys("dongnai60");
            IWebElement elementLogin = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/div/form/div[2]/input[3]"));
            elementLogin.Click();

            Thread.Sleep(5000);

            // Điều hướng đến trang thêm bài viết
            driver.Navigate().GoToUrl("https://tinhte.vn/editorv2/create/767/");

            // Lấy element nhập tiêu đề
            IWebElement elementTitle = driver.FindElement(By.ClassName("title-input"));

            // Nhập tiêu đề
            elementTitle.SendKeys(title);

            // Lấy element nhập nội dung
            IWebElement elementContent = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div[1]/div/div[2]/div[3]/div"));

            // Nhập nội dung
            elementContent.SendKeys(content);

            // Chờ 15s để đăng bài
            Thread.Sleep(15000);

            // Lấy nút đăng bài
            IWebElement elementPost = driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div[1]/div/div[2]/div[4]/button[3]"));

            // Click đăng bài
            elementPost.Click();
        }

        public string GetPostContent(string title)
        {
            // Điều hướng đến trang bài viết nháp
            driver.Navigate().GoToUrl("https://tinhte.vn/my-draft/");

            // Lấy link bài viết theo tiêu đề
            IWebElement elementTitle = driver.FindElement(By.LinkText(title));

            Thread.Sleep(5000);

            // Điều hướng đến trang bài viết theo tiêu đề
            driver.Navigate().GoToUrl(elementTitle.GetAttribute("href"));

            Thread.Sleep(2000);

            // Lấy nội dung bài viết
            IWebElement elementContent = driver.FindElement(By.ClassName("xf-body-paragraph"));

            return elementContent.Text;
        }

        public void QuitWeb()
        {
            driver.Quit();
        }
    }
}
