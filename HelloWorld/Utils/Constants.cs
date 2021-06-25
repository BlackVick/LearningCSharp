using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Utils
{
    public enum UserType
    {
        Admin = 1,
        Users = 2,
    }

    public enum UserClearance
    {
        Overlord = 10,
        ManagementStaff = 8,
        MidLevelStaff = 6,
        TeamLeads = 5,
        Developers = 4,
        Testers = 3,
        HR = 2,
        Others = 1
    }
}
