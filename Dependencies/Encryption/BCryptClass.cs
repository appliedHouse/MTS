
namespace Encryption
{
    public class BCryptClass
    {
        public static string EncryptPW(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public static bool VarifyPW(string hashedPassword, string UserTypedPW) {
            try
            {
                bool isMatch = BCrypt.Net.BCrypt.Verify(UserTypedPW, hashedPassword);
                return isMatch;
            }
            catch (Exception error)
            {
                return false;
            }
        }
    }
}
