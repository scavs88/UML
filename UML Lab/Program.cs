using System;

namespace UML_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sean", "1702 Buena Vista");
            string result = person1.ToString();
            Console.WriteLine(result);
        }
    }
}
