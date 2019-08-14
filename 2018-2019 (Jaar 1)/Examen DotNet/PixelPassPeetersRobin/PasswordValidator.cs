using System;

namespace PixelPass
{
    public class PasswordValidator
    {
        private const int MinimumLength = 5;
        private const int AverageLength = 10;

        private const string alfabetSmallCaps = "abcdefghijklmnopqrstuvwxyz";
        private const string alfabetUpperCaps = "ABCEDFGHIJKLMNOPQRSTUVWXYZ";
        private const string digits = "0123456789";

        public static Strength CalculateStrength(string password)
        {
            var containsLower = false;
            var containsUpper = false;
            var containsDigit = false;
            for (var i = 0; i < password.Length; i++)
            {
                var c = (password.Substring(i, 1));
                if (alfabetSmallCaps.Contains(c))
                {
                    containsLower = true;
                }
                else if (alfabetUpperCaps.Contains(c))
                {
                    containsUpper = true;
                }
                else if (digits.Contains(c))
                {
                    containsDigit = true;
                }
            }

            if (password.Length > 10 && containsLower && containsDigit && containsUpper)
            {
                return Strength.Strong;
            }
            else if (password.Length > 5 && ((containsDigit && containsLower) || (containsDigit && containsUpper) ||
                                             (containsLower && containsUpper)))
            {
                return Strength.Average;
            }
            else
            {
                return Strength.Weak;
            }
        }
    }

    public enum Strength
    {
        Weak,
        Average,
        Strong
    }
}