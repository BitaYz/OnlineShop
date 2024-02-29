using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTools.Constants
{
    public static class DatabaseConstants
    {
        #region [- Schemas -]
        public static class Schemas
        {
            public const string Infrustructure = "Infrustructure";
            public const string Sale = "Sale";
            public const string UserManagement = "UserManagement";
        }
        #endregion
        public static class CheckConstraints
        {
            public enum ReturnValueTypes
            {
                ScriptTitles = 1,
                ScriptCodes = 2,
            }

            public static string SetOnlyNumericalCheckConstraint(string propertytTitle, ReturnValueTypes returnValueTypes)
            {

                return returnValueTypes switch
                {
                    (ReturnValueTypes)1 => $"Check_{propertytTitle}_OnlyNumerical",
                    (ReturnValueTypes)2 => $"Check_{propertytTitle} Not Like '%[^0-9]%'",
                    _ => string.Empty,
                };

            }
            public static string SetDigitLimitCheckConstraint(string propertytTitle, int digitLimit, ReturnValueTypes returnValueTypes)
            {
                var script = new StringBuilder();
                while (digitLimit != 0)
                {
                    script.Append("[0-9]");
                    digitLimit -= digitLimit;
                }
                return returnValueTypes switch
                {
                    (ReturnValueTypes)1 => $"Check_{propertytTitle}_DigitLimit",
                    (ReturnValueTypes)2 => $"Check_{propertytTitle}  Like '{script}'",
                    _ => string.Empty,
                };
            }
        }
        public static class DefaultRoles
        {
            public const string GodAdminId = "1";
            public const string GodAdminName = "GodAdmin";
            //public const string GodAadminNormalizedName = "GODADMIN";
            //public const string GodAadminCuncurencyStamp = "1";

            public const string AdminId = "2";
            public const string AdminName = "Admin";
            //public const string AdminNormalizedName = "ADMIN";
            //public const string AdminCuncurencyStamp = "2";

            public const string SupportId = "3";
            public const string SupportName = "Support";
            //public const string SupportNormalizedName = "SUPPORT";
            //public const string SupportCuncurencyStamp = "3";
        }
        public static class GodAdminUsers
        {
            public const string KhosroshahiUserId = "1";
            public const string KhosroshahiFirstName = "Bita";
            public const string KhosroshahiLastName = "Khosroshahi";
            public const string KhosroshahiCellPhone = "0992188441";
            public const string KhosroshahiPassword = "!QAZ1qaz";
        }

    }
}
