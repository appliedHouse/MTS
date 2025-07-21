using DB;
using Microsoft.EntityFrameworkCore;




namespace Authentication
{
    public class AuthClass
    {
        private readonly AppDbContext Context;
        public UserClass UserProfile { get; set; } = new();
        
        public AuthClass(AppDbContext _context)
        {
            Context = _context;
        }

        public bool Login(string username, string password)
        {
            var user = Context.UserAccounts.FirstOrDefault(u => u.UserName == username);
            if (user != null && user.PasswordHash == password) // use hashing in real case
            {
                return true;
            }
            return false;
        }


    }
}
