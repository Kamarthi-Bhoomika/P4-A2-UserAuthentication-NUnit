using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthenticationNUnit
{
    [TestFixture]
    public class UserAuthenticationTests
    {
        private UserAuthentication userAuthentication;
        [SetUp]
        public void Setup()
        {
            userAuthentication = new UserAuthentication();
        }
        [Test]
        public void TestUserRegistration()
        {
            userAuthentication.UserRegistration("sam", "sam@123");
            Assert.IsTrue(userAuthentication.UserLogin("sam", "sam@123"));
        }
        [Test]
        public void TestUserLogin()
        {
            userAuthentication.UserRegistration("sam", "sam@123");
            Assert.IsTrue(userAuthentication.UserLogin("sam", "sam@123"));
            Assert.IsFalse(userAuthentication.UserLogin("sam", "wrongpwd"));
            Assert.IsFalse(userAuthentication.UserLogin("user1", "pwd"));
        }
        [Test]
        public void TestPasswordReset()
        {
            userAuthentication.UserRegistration("sam", "sam@123");
            userAuthentication.PasswordReset("sam", "newpwd");
            Assert.IsTrue(userAuthentication.UserLogin("sam", "newpwd"));        }
    }
}
