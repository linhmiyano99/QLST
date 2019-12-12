using QLSTDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSTBUS
{
    
    public class LoginBUS
    {
       LoginDAL loginDAL = new LoginDAL();

        public bool IsValid(string accountID, string password)
        {
            string pass = (password);
            DataTable temp = loginDAL.CheckAccount(accountID, password);
            return temp.Rows.Count != 0;
        }

        public DataTable GetAccountType(string accountID)
        {
            return loginDAL.GetAccountType(accountID);
        }
    }
}
