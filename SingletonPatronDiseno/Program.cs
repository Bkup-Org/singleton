using System;

namespace SingletonPatronDiseno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "Hola Luis";
            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
