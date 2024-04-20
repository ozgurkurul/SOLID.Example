namespace SOLIDs.SingleResponsibilityPrinciple.Unsuitable
{
    /// <summary>
    /// Single Responsibility Principle'e uymuyor
    /// </summary>
    public class SendMail
    {
        public bool SendMailForX(string mail, string subject, string body)
        {
            if (!IsMailAddressValid(mail))
                return false;

            return true;
        }
        private bool IsMailAddressValid(string mail)
        {
            return true;
        }
    }
}

namespace SOLIDs.SingleResponsibilityPrinciple.Suitable
{
    /// <summary>
    ///  Single Responsibility Principle'e uyuyor
    /// </summary>
    public class SendMail
    {
        private readonly MailValidator _mailValidator = new MailValidator();
        public bool SendMailForX(string mail, string subject, string body)
        {
            if (!_mailValidator.IsMailAddressValid(mail))
                return false;

            return true;
        }
    }
    public class MailValidator
    {
        public bool IsMailAddressValid(string mail)
        {
            return true;
        }
    }
}
