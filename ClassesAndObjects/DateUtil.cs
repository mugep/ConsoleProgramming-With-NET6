    internal static class DateUtil
    {
        public static int YearOfBirth(int age)
        {
            return DateTime.Now.Year - age;
        }

        public static int YearOfBirth(DateTime dateofBirth)
        {
            if (dateofBirth == null)
                return 0;
            return dateofBirth.Year;
        }

        public static int Age(DateTime dateofBirth)
        {
            if (dateofBirth == null)
                return 0;
            return DateTime.Now.Year - dateofBirth.Year;
        }
    }
