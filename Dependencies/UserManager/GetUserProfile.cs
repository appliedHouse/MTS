using DB;
using Microsoft.AspNetCore.Identity;

namespace LoginManager
{

       // AOG9m++/kTrBlvJSrtXe3lSMnAZtsPK1JZ40j+wkvAXTfa6sYaEtwxrxyb0Z7Y/VAg==
       // AFnyBHhtWqGka//7Tw/C42m67RhrK4fbAgCmZCLnNSNQYJV/58lU3IckX4R12+XP4Q==


    public class GetUserProfile
    {

        public static bool LogedIn(string _UserName, string _Password)
        {
            var _UserProfile = GetUser(_UserName);
            if (_UserProfile == null) { return false; }

            PasswordHasher<DB.Models.UserAccount> _hasher = new();
            var result = _hasher.VerifyHashedPassword(_UserProfile, _UserProfile.PasswordHash, _Password);
            return result == PasswordVerificationResult.Success;
        }

        public static DB.Models.UserAccount GetUser(string _UserName)
        {
            try
            {
                using (var Context = new AppDbContext())
                {
                    var _User = Context.UserAccounts.Where(x => x.UserName == _UserName).
                        Select(x => new DB.Models.UserAccount()
                        {
                            UserId = x.UserId,
                            UserName = x.UserName,
                            Id = x.Id,
                            IsActive = x.IsActive,
                            PasswordHash = x.PasswordHash ?? "",
                            SecurityStamp = x.SecurityStamp ?? "",
                            FullName = x.FullName,
                            Email = x.Email,
                            PhoneNumber = x.PhoneNumber,
                            //MustChangePasswordNextLogin = x.MustChangePasswordNextLogin ?? false,
                            //DefaultLanguageID = x.DefaultLanguageId,
                            //LastLoginDate = x.LastLoginDate ?? DateTime.MinValue,
                            //LockoutEnabled  = x.LockoutEnabled,
                            //LockoutEndDateUtc = x.LockoutEndDateUtc ?? DateTime.Now,
                            //TwoFactorEnabled = x.TwoFactorEnabled,
                            //AddTransactionID = x.AddTransactionId.ToString() ?? "",
                            //UpdateTransactionID = x.UpdateTransactionId.ToString() ?? "",
                        }).FirstOrDefault();

                    if (_User != null)
                    {
                        return _User;
                    }
                    else
                    {
                        return new();
                    }
                }
            }
            catch (Exception error)
            {

                return new();
            }
        }
    }
}

