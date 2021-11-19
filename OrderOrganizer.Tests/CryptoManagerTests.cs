using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseLib;
using System.Data.Entity;
using System;

namespace OrderOrganizer.Tests
{
    [TestClass]
    public class CryptoManagerTests
    {
        [TestMethod]
        public void CheckPasswordMatchWithWrongInfoReturnsFalse()
        {
            var dbcontext = new OO_dbEntities();
            var crypto = new OrderOrganizer_Capstone.Objects.CryptoManager();
            dbcontext.users.Load();

            var salt = dbcontext.users.Local[0].user_pass_salt.Value.ToByteArray(); // The first user in the list is the default admin user
            var hash = dbcontext.users.Local[0].user_pass_hash;
            dbcontext.Dispose();

            var result = crypto.CheckPasswordMatch("wrongpassword", hash, salt);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPasswordMatchWithCorrectInfoReturnsTrue()
        {
            var dbcontext = new OO_dbEntities();
            var crypto = new OrderOrganizer_Capstone.Objects.CryptoManager();
            dbcontext.users.Load();

            var salt = dbcontext.users.Local[0].user_pass_salt.Value.ToByteArray();
            var hash = dbcontext.users.Local[0].user_pass_hash;
            dbcontext.Dispose();

            var result = crypto.CheckPasswordMatch("password", hash, salt); // This is the correct password by default
            Assert.IsTrue(result);
        }
    }
}
