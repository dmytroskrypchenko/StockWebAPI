namespace Stock.BL.Models
{
    public class ColumnMapping<T> where T : struct
    {
        public T Column { get; set; }
        public string ColumnRealName { get; set; }

        public ColumnMapping(T column, string name)
        {
            Column = column;
            ColumnRealName = name;
        }
    }
}