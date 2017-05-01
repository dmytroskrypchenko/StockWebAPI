namespace Stock.Clients.ProductsShop
{
    public static class Parsers
    {
        public static int? IntParse(string data)
        {
            int parsedData;
            return int.TryParse(data, out parsedData) && parsedData > 0
                ? parsedData
                : default(int?);
        }

        public static decimal? DecimalParse(string data)
        {
            decimal parsedData;
            return decimal.TryParse(data, out parsedData) && parsedData > 0
                ? parsedData
                : default(decimal?);
        }

        public static double? DoubleParse(string data)
        {
            double parsedData;
            return double.TryParse(data, out parsedData) && parsedData > 0
                ? parsedData
                : default(double?);
        }
    }
}