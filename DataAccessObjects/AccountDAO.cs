using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            AccountMember accountMember = new AccountMember();
            if (accountID.Equals("hnah"))
            {
                accountMember.MemberId = accountID;
                accountMember.MemberPassword = "123";
                accountMember.MemberRole = 1;
                return accountMember;
            }
            return null;
        }
    }
}
