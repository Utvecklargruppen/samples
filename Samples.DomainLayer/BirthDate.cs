using Samples.Utilities;
using System;

namespace Samples.DomainLayer
{
    public class BirthDate
    {
        public BirthDate() => Date = SystemTime.DateTimeDefault;

        public BirthDate(DateTime dateOfBirth)
        {
            ValidateAge(dateOfBirth);

            Date = dateOfBirth;
        }

        public int Age => CurrentAge(Date, SystemTime.Now);

        public DateTime Date { get; }

        public static int CurrentAge(DateTime dateOfBirth, DateTime now)
        {
            int age = now.Year - dateOfBirth.Year;

            if (now < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }

        private static void ValidateAge(DateTime dateOfBirth)
        {
            if (dateOfBirth > SystemTime.Now)
            {
                throw new ArgumentException("Birthday is never after the current time.");
            }

            if (CurrentAge(dateOfBirth, SystemTime.Now) > 150)
            {
                throw new ArgumentException("Only people that are alive are allowed.");
            }
        }
    }
}