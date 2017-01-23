using System;

namespace SingletonDemo
{
    public sealed class ControlOfInstanceNumber
    {
        private static ControlOfInstanceNumber _instance;

        private ControlOfInstanceNumber() { }

        public static ControlOfInstanceNumber Instance
        {
            get
            {
                if (_instance == null) _instance = new ControlOfInstanceNumber();
                return _instance;
            }
        }

        public string Property { get; set; } = "Domyślna wartość pola";

        public void Metoda()
        {
            Console.WriteLine(Property);
        }

    }
}
