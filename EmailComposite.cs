using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp
{
    internal class EmailComposite:Email
    {
        private List<Email> _emails = new List<Email>();

        public EmailComposite(string address) : base(address)
        {

        }

        public void AddToGroup(Email email)
        {
            _emails.Add(email);
        }

        public void Remove(Email email)
        {
            _emails.Remove(email);
        }

        public override void SendEmail()
        {
            Console.WriteLine($"Email sent to composite(group) {_emailAddress}");
            foreach (var email in _emails)
            {
                email.SendEmail();
            }
        }
    }
}
