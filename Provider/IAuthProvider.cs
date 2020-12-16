﻿using AuthService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Provider
{
    public interface IAuthProvider
    {
        string GetUser(User user);
    }
}
