using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Login.Test
{
    using Login.Core;

    [TestClass]
    public class LoginServiceTest
    {
        private string noUse = "";

        [TestMethod]
        public void TestCheckUserWithUserNameEmpty()
        {
            LoginService loginService = new LoginService(new DatabaseStub());
            try
            {
                loginService.CheckUser("", "abc");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentException));
                Assert.AreEqual(ex.Message, "The Username don't allow null or empty");                
            }
            
        }

        [TestMethod]
        public void TestCheckUserSuccessfully()
        {
            LoginService loginService = new LoginService(new DatabaseStub());
            bool result = loginService.CheckUser("abc", "abc");
            Assert.AreEqual(result, true);
            

        }
    }
}
