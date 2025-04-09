using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferApp.Shared.Navigation
{
    public static class NavManagerConfig
    {
        public static readonly string LoginUrl = "/login";
        public static readonly string LogoutUrl = "/logout";
        public static readonly string RegistrationUrl = "/registration";
        public static readonly string DashboardUrl = "/dashboard";

        //meeting
        public static string MeetingUrlFormat = "/meeting/{0}";
    }
}
