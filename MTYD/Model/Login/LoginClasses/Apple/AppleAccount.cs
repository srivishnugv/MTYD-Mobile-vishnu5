﻿using System;
namespace MTYD.Model.Login.LoginClasses.Apple
{
    public class AppleAccount
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string RealUserStatus { get; set; }
        public string UserId { get; set; }
    }

    public enum AppleSignInCredentialState
    {
        Authorized,
        Revoked,
        NotFound,
        Unknown
    }
}
