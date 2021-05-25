using System;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guid = new Guid();
            Console.WriteLine(guid);

            Guid guid1 = Guid.NewGuid();
            Console.WriteLine(guid1);

            Console.WriteLine(Guid.NewGuid()); //by creating new instance it will create new GUID
        }
    }
}
