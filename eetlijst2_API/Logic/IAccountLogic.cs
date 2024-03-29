﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Logic
{
    public interface IAccountLogic
    {

        List<Account> GetAllAccounts();
        Account getAccountById(int id);
        QueryFeedback AddAccount(Account account);
        QueryFeedback UpdateAccount(Account account);
        Task<Account> Authenticate(Account account);
        QueryFeedback AdvanceForRoomate(int[] people, Activaty activaty);
        QueryFeedback CookForRoommates(int[] people, Activaty activaty);
    }
}
