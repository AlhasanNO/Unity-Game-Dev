namespace Assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public static string RepeatString(this string str, int times)
        {
            string finalStr = str;

            while (times > 1)
            {
                finalStr += str;
                times--;
            }
            return finalStr;
        }
    }
}
