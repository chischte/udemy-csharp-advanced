using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> date = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

            DateTime? dateNullable = new DateTime(2014, 1, 1);
            DateTime date2 = dateNullable.GetValueOrDefault();

            DateTime date3 = dateNullable ?? DateTime.Today;
        }
    }
}
