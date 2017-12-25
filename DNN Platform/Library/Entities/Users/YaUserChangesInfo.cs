using System;

namespace DotNetNuke.Entities.Users
{
    public class YaUserChangesInfo
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public bool IsSuperUser { get; set; }
        public string DisplayName { get; set; }

        public int? AffiliateID { get; set; }

        public string LastIPAddress { get; set; }

        public int? CreatedByUserID { get; set; }

        public DateTime? CreatedOnDate { get; set; }

        public int? LastModifiedByUserID { get; set; }

        public DateTime? LastModifiedOnDate { get; set; }
    }

    public class UserChangesLoggerVm
    {
        public YaUserChangesInfo UserInfo { get; set; }
        public bool IsAdd { get; set; }

        public string OldUserName { get; set; }

        // Current Logged in user id
        public int CurrentUserId { get; set; }

        public string Url { get; set; }
        public string RawUrl { get; set; }
        public string IpAddress { get; set; }
        public string BrowserInfo { get; set; }
    }
}