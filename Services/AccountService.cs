﻿using BusinessObjects;
using DataAccessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService()
        {
            accountRepository = new AccountRepository();
        }

        public AccountMember GetAccountById(string accountId)
        {
            return accountRepository.GetAccountById(accountId);
        }

    }
}
