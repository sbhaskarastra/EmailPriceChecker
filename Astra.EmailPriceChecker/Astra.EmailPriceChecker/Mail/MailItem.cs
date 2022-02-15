using System;

namespace Astra.EmailPriceChecker.Mail
{
    public class MailItem
    {
        public string Body;
        public string From;
        public string NormalisedBody;
        public string[] Recipients;
        public string Subject;
        public string[] Lines;
        public DateTime DateReceived;

        public override string ToString()
        {
            return string.Format("From: {0}{1}To: {2}{1}Subject: {3}{1}Date Received: {5}{1}Contents: {4}{1}", From, Environment.NewLine,
                Recipients[0], Subject, Body, DateReceived);
        }
    }
}