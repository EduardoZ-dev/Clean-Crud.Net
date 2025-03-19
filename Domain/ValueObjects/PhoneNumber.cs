using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const int DefaultLenght = 15;

        private const string Pattern = @"^\+\d{1,2}[\s-]?\d{8,12}$";

        private PhoneNumber(string value) => Value = value;

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) ||
                value.Length < 10 || value.Length > DefaultLenght)
            {
                return null;
            }

            return new PhoneNumber(value);
        }

        public string Value { get; init; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();

    }
}
