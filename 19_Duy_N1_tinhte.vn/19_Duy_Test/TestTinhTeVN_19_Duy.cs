using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _19_Duy_N1_tinhte.vn;
using System.Threading;

namespace _19_Duy_Test
{
    [TestClass]
    public class TestTinhTeVN_19_Duy
    {
        Login login = new Login();

        [TestMethod]
        public void TC1_Login_Success()
        {
            string username = "hduy4345@gmail.com";
            string password = "dongnai60";
            string accountUsername = "Hoàng Nguyễn Quốc Duy";

            string expected = accountUsername;
            string actual;

            try
            {
                //đăng nhập với username, password
                login.InputLogin(username, password);

                //sau khi đăng nhập thành công, lấy username vừa đăng nhập
                actual = login.GetInfo();

                Assert.AreEqual(expected, actual);
                login.QuitWeb();
            }
            catch
            {
                login.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC2_Login_Fail_KhongNhapUsername()
        {
            // Không nhập username 
            string username = "";

            string password = "dongnai60";
            string accountUsername = "Hoàng Nguyễn Quốc Duy";

            string expected = accountUsername;
            string actual;

            try
            {
                login.InputLogin(username, password);

                actual = login.GetInfo();

                Assert.AreEqual(expected, actual);
                login.QuitWeb();
            }
            catch
            {
                login.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC3_Login_Fail_KhongNhapPassword()
        {
            string username = "hduy4345@gmail.com";

            //Không nhập password
            string password = "";

            string accountUsername = "Hoàng Nguyễn Quốc Duy";

            string expected = accountUsername;
            string actual;

            try
            {
                login.InputLogin(username, password);

                actual = login.GetInfo();

                Assert.AreEqual(expected, actual);
                login.QuitWeb();
            }
            catch
            {
                login.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC4_Login_Fail_KhongNhapUsernamePassword()
        {
            //Không nhập username và password
            string username = "";
            string password = "";
            string accountUsername = "Hoàng Nguyễn Quốc Duy";

            string expected = accountUsername;
            string actual;

            try
            {
                login.InputLogin(username, password);
                actual = login.GetInfo();

                Assert.AreEqual(expected, actual);
                login.QuitWeb();
            }
            catch
            {
                login.QuitWeb();
                Assert.Fail();
            }
        }

        Post post = new Post();
        [TestMethod]
        public void TC1_CreatePost_Success()
        {
            string title = "19_duy_title_";
            string content = "19_duy_content_";
            string expected = content;
            string actual;

            try
            {
                post.CreatePost(title, content);
                actual = post.GetPostContent(title);

                Assert.AreEqual(expected, actual);
                post.QuitWeb();
            }
            catch
            {
                post.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC2_CreatePost_Fail_KhongNhapTitle()
        {
            //Không nhập title
            string title = "";
            string content = "19_duy_content";
            string expected = content;
            string actual;

            try
            {
                post.CreatePost(title, content);
                actual = post.GetPostContent(title);

                Assert.AreEqual(expected, actual);
                post.QuitWeb();
            }
            catch
            {
                post.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC3_CreatePost_Fail_KhongNhapContent()
        {
            string title = "19_duy_title2";

            //Không nhập content
            string content = "";
            string expected = content;
            string actual;

            try
            {
                post.CreatePost(title, content);
                actual = post.GetPostContent(title);

                Assert.AreEqual(expected, actual);
                post.QuitWeb();
            }
            catch
            {
                post.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC4_CreatePost_Fail_KhongNhapTitleContent()
        {
            //Không nhập title và content
            string title = "";
            string content = "";
            string expected = content;
            string actual;

            try
            {
                post.CreatePost(title, content);
                actual = post.GetPostContent(title);

                Assert.AreEqual(expected, actual);
                post.QuitWeb();
            }
            catch
            {
                post.QuitWeb();
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC1_Triangle_Success()
        {
            try
            {
                Triangle triangle = new Triangle(3, 4, 5);
                double expected = 6;
                double actual = triangle.CalculateArea();

                Assert.AreEqual(expected, actual);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC2_Triangle_Fail()
        {
            try
            {
                //b + c > a
                Triangle triangle = new Triangle(1, 2, 5);
                double expected = 6;
                double actual = triangle.CalculateArea();

                Assert.AreEqual(expected, actual);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC3_Triangle_Fail()
        {
            try
            {
                Triangle triangle = new Triangle(1, 6, 2);
                double expected = 6;
                double actual = triangle.CalculateArea();

                Assert.AreEqual(expected, actual);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TC4_Triangle_Fail()
        {
            try
            {
                Triangle triangle = new Triangle(6, 1, 2);
                double expected = 6;
                double actual = triangle.CalculateArea();

                Assert.AreEqual(expected, actual);
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}
