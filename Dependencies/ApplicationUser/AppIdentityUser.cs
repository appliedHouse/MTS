using Microsoft.AspNetCore.Identity;

public class AppIdentityUser : IdentityUser
{
    public int UserId { get; set; }
    public string UserGUID { get; set; }
    public bool IsActive { get; set; }
    public string UserName { get; set; }
    public string Role { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public bool MustChangePasswordNextLogin { get; set; }
    public int DefaultLanguageID { get; set; }
    public DateTime LastLoginDate { get; set; }
    public bool LockoutEnabled { get; set; }
    public DateTime LockoutEndDateUtc { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public string AddTransactionID { get; set; }
    public string UpdateTransactionID { get; set; }
}

public class UserSession
{
    public int UserId { get; set; }
    public string UserGUID { get; set; }
    public bool IsActive { get; set; }
    public string UserName { get; set; }
    public string Role { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public bool MustChangePasswordNextLogin { get; set; }
    public int DefaultLanguageID { get; set; }
    public DateTime LastLoginDate { get; set; }
    public bool LockoutEnabled { get; set; }
    public DateTime LockoutEndDateUtc { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public string AddTransactionID { get; set; }
    public string UpdateTransactionID { get; set; }
}
