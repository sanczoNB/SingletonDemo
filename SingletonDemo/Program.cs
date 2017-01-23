using System;

namespace SingletonDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StaticClass.Property = "Wartość pola ustalona w metodzie Programu.Main";
            StaticClass.Method();

            InstanceInStaticField.Instance.Property = "Wartość pola ustalona w metodzie Programu.Main";
            InstanceInStaticField.Instance.Metoda();

            /*Można także utworzyć zmienną referencyjną i korzystając z niej,
             wywoływać metody i właśności:*/

            InstanceInStaticField reference = InstanceInStaticField.Instance;
            reference.Property = "Odwołanie za pomocą referencji";

            Console.ReadKey();
        }
    }
}
