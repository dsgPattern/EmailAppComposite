using System;

namespace EmailApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mary = new EmailLeaf("mary@didyouknow.com");
            var jane = new EmailLeaf("jane@devs.com");
            var john = new EmailLeaf("john@finance.com");

            var devs = new EmailComposite("Developers");
            devs.AddToGroup(mary);
            devs.AddToGroup(jane);

            john.SendEmail();
            devs.SendEmail();

            Console.ReadLine();
        }
    }
}
