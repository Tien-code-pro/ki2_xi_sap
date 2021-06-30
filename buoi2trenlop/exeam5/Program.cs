using System;

namespace exeam5
{
    using System;
    class OptionalParameterExample
    {
        void printMessage(String message = "Hello user!")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string[] args)
        {
            OptionalParameterExample opExample = new OptionalParameterExample();
            opExample.printMessage("Welcome User!");
            opExample.printMessage();
        }
    }
}
