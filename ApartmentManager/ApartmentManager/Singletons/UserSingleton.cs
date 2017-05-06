﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.Model
{
    class UserSingleton
    {
        private static UserSingleton instance;
        public static User CurrentUser;

        private UserSingleton() { }

        public static UserSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSingleton();
                }
                return instance;
            }
        }
    }
}