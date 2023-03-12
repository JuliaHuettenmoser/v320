using Ninject.Activation;
using System.Globalization;


namespace StringCalculator
{
    public class Add
    {
        //public int Addition(string numberString)
        //{
        //    int res = 0;
        //    if (numberString.Length < 0)
        //    {
        //        return res;
        //    }
        //    string[] numbers = numberString.Split(',');
        //        foreach (string strNumber in numbers)
        //        {
        //            int number = int.Parse(strNumber);
        //            res += number;
        //        }
        //        return res;

        //}

        public int Addition(string numberString)
        {
            int res = 0;
            String[] numbers = numberString.Split(',');

            foreach(string strNumber in numbers)
            {
                int number = Convert.ToInt32(strNumber);
                res += number;
            }
            return res;
        }
    }
}