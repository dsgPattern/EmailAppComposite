using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp
{
    internal class EmailLeaf:Email
    {
        public EmailLeaf(string address) : base(address)
        {

        }

        public override void SendEmail()
        {
            Console.WriteLine($"Email sent to leaf:{_emailAddress}");
        }
    }
}
