using System.Globalization;

namespace Bridge.ERP.Helpers
{
    public class MathOperations
    {
        public static dynamic DivisionReturnPercentage(double valOne, double valTwo)
        {            
            var calc = (double)valOne / valTwo;
            var result = calc * 100;
            return result;
        }
        public static dynamic DivisionReturnPercentageWithSign(double valOne, double valTwo)
        {
            var calc = (double)valOne / valTwo;
            var result = calc.ToString("P", CultureInfo.CurrentCulture);
            return result;
        }
    }
}
