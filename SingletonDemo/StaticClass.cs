using System;

namespace SingletonDemo
{
    public static class StaticClass
    {
        private static string field = "Domyślna wartość pola";

        public static string Property
        {
            get { return field; }

            set { field = value; }
        }

        public static void Method()
        {
            Console.WriteLine(field);
        }
    }
}
