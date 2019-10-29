﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model.ModelOld;

namespace Data.Interfaces
{
    public interface IUserContext
    {
        List<User> GetAllUsers();
        User GetbyID(int id);
        QueryFeedback AddUser(User user);
        QueryFeedback UpdateUser(User user);
        Task<User>  Authenticate(User user);
        QueryFeedback AddActivity(Activity activity);
    }
}
