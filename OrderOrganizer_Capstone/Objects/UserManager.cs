using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderOrganizer_Capstone.Objects;
using DatabaseLib;

namespace OrderOrganizer_Capstone
{
    public class UserManager
    {
        private OO_dbEntities dbcontext;
        private CryptoManager cryptoManager = new CryptoManager();

        public UserManager(OO_dbEntities _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public user ValidateUser(string username, string password)
        {
            var matchedUser = dbcontext.users.Local.Where(u => u.user_name == username).FirstOrDefault();

            if (matchedUser is null) return null;

            if (cryptoManager.CheckPasswordMatch(password, matchedUser.user_pass_hash, matchedUser.user_pass_salt.Value.ToByteArray()))
                return matchedUser;
            else return null;
        }

        // Expanding the application would include adding methods here for user addition, modification, and deletion.
    }
}
