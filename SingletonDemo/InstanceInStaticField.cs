using System;

namespace SingletonDemo
{
    public sealed class InstanceInStaticField
    {
         private static readonly InstanceInStaticField _instance =
        new InstanceInStaticField();

        private InstanceInStaticField() { }

        public static InstanceInStaticField Instance => _instance;

        public string Property { get; set; } = "Domyślna wartość pola";

        public void Metoda()
        {
            Console.WriteLine(Property);
        }
    }
}
