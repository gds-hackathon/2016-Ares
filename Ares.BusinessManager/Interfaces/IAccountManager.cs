﻿using Ares.Core.Domain;

namespace Ares.BusinessManager.Interfaces
{
    public interface IAccountManager
    {
        LoginResult Login(string userName, string password);
        void RegistryUser(string loginName, string phoneNum, string password, string name, RoleTypes roleType);
    }
}
