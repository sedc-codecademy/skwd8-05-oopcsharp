using SEDC.eStore.Entities.Models;

namespace SEDC.eStore.Business.Services
{
    public class ValidationService
    {
        public bool ValidateEmail(string email)
        {
            if (!email.Contains('@'))
            {
                return false;
            }

            // "trajanstevkovski@gmail.com" -> Split '@' ->  [ "trajanstevkovski", "gmail.com" ]
            string[] emailParts = email.Split('@');
            if (emailParts.Length != 2)
            {
                return false;
            }

            if (emailParts[emailParts.Length - 1].Length <= 6
                && !emailParts[emailParts.Length - 1].Contains('.'))
            {
                return false;
            }

            return true;
        }

        public bool ValidatePassword(string password)
        {
            // min length 8 char, min 1 upper letter, min 1 digit
            if (password.Length < 8)
            {
                return false;
            }

            char[] passwordParts = password.ToCharArray();

            int countUpperLetters = 0;
            int countDigits = 0;
            foreach (char part in passwordParts)
            {
                if (char.IsWhiteSpace(part))
                {
                    return false;
                }

                if (char.IsUpper(part))
                {
                    countUpperLetters++;
                }

                if (char.IsDigit(part))
                {
                    countDigits++;
                }
            }

            return countUpperLetters != 0 && countDigits != 0;
        }

        public bool IsEmailUnique(string email, User[] users)
        {
            foreach (var user in users)
            {
                if (user.Email.ToLower() == email.ToLower())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
