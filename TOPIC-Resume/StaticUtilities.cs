using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TOPIC_Resume.Data;
using TOPIC_Resume.Entities;

namespace TOPIC_Resume
{
    public static class StaticUtilities
    {
        public static CustomIdentityUser? GetCustomIdentityUser(this ApplicationDbContext applicationDbContext, AuthenticationState userAuth)
        {
            var userId = userAuth.User.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
            return applicationDbContext.Users.Find(userId); ;
        }
    }
}
