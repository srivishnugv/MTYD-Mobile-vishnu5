﻿using System;
namespace MTYD.Model.Login.LoginClasses
{
    public class LogInPost
    {
        public string email { get; set; }
        public string password { get; set; }
        public string social_id { get; set; }
        public string signup_platform { get; set; }
    }
}
