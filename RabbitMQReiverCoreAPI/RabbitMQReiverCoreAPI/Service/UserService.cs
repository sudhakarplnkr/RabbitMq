﻿namespace RabbitMQReiverCoreAPI.Service
{
    using System.Collections.Generic;
    using System.Threading;
    using RabbitMQReiverCoreAPI.Models;

    public class UserService
    {
        internal UserSaveFeedback InsertUsers(List<User> userList)
        {
            List<User> failList = new List<User>();
            foreach (User user in userList)
            {
                failList.Add(user);
                Thread.Sleep(1000);//fake waiting 
            }

            UserSaveFeedback saveFeedback = new UserSaveFeedback();
            saveFeedback.successCount = 1;
            saveFeedback.failedCount = 1;
            saveFeedback.failedList= failList;//Add fake failed Items

            return saveFeedback;
        }
    }
}
