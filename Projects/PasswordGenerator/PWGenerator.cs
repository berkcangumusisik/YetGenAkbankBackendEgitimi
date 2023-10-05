using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PWGenerator
    {

        private readonly Random _random;
        private const string Numbers = "0123456789";
        private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!@#$%^&*()_-+=[{]};:<>|./?";


        public PWGenerator()
        {
            _random = new Random();
        }

        public String GeneratePassword(int passwordLength, bool includeNumbers, bool includeLowerCaseChars, bool includeUpperCase, bool includeSpecialChars)
        {

            var charsBuilder = new StringBuilder();

            if (includeNumbers)
                charsBuilder.Append(Numbers);
            if (includeLowerCaseChars)
                charsBuilder.Append(LowerCaseChars);
            if (includeUpperCase)
                charsBuilder.Append(UpperCaseChars);
            if (includeSpecialChars)
                charsBuilder.Append(SpecialChars);

            var acceptedChars = charsBuilder.ToString();
            var passwordBuilder = new StringBuilder();
            for (int i = 0; i < passwordLength; i++)
            {
                var randomIndex = _random.Next(0, acceptedChars.Length);
                passwordBuilder.Append(acceptedChars[randomIndex]);
            }

            return passwordBuilder.ToString();
        }
    }
}
