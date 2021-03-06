﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Test;

namespace IdentityServer4Proj.Models
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser> {
                new TestUser {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "bane",
                    Password = "bane",
                    Claims = new List<Claim> {
                        //new Claim("role")
                        new Claim(JwtClaimTypes.Email, "bane@new.me"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                }
            };
        }
    }

}
