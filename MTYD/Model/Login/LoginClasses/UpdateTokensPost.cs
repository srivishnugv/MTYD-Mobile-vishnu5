﻿using System;
namespace MTYD.Model.Login.LoginClasses
{
    public class UpdateTokensPost
    {
        public string uid { get; set; }
        public string mobile_access_token { get; set; }
        public string mobile_refresh_token { get; set; }
    }
}
