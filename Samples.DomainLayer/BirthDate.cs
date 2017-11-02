using Samples.Utilities;
using System;

namespace Samples.DomainLayer
{
    public class BirthDate
    {
        public BirthDate() => Date = DefaultDate;

        public BirthDate(DateTime dateOfBirth)
        {
            if (dateOfBirth > SystemTime.Now)
            {
                throw new ArgumentException("Birthday is never after the current time.");
            }

            Date = dateOfBirth;
        }

        public static DateTime DefaultDate => new DateTime(1900, 1, 1);

        public DateTime Date { get; }

        public int Age()
        {
            var now = SystemTime.Now;

            int age = now.Year - Date.Year;

            if (now < Date.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}