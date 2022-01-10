using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp
{
    internal abstract class Email
    {
        protected string _emailAddress;
        protected Email(string address)
        {
            _emailAddress = address;
        }

        public abstract void SendEmail();
    }
}
