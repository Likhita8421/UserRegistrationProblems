using System.Text.RegularExpressions;

namespace TestEmail
{
    public class Tests
    {
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {
            UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Valid.txt");
            foreach (string input in inputId)
            {
                Assert.IsTrue(regex.email(input));
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            UserRegistration.RegularExpression regex = new UserRegistration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Invalid.txt");
            foreach (string input in inputId)
            {
                Assert.IsFalse(regex.email(input));
            }
        }
    }
}