﻿using System.Collections.Generic;

namespace IAttendanceWebAPI.Core.ViewModels
{
    // Models returned by AccountController actions.

    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    public class UserInfoViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LoggedOn { get; set; }
        public string DateOfBirth { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}