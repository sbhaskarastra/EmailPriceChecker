using System;
using System.Collections.Generic;
using System.Linq;

namespace Astra.EmailPriceChecker.Mail
{
    public class EmailReport
    {
        public string From { get; set; }
        public IList<string> EmailLine { get; set; }
        public string Subject { get; set; }
        public DateTime DateReceived { get; set; }

        public override string ToString()
        {
            var lines = EmailLine.Aggregate("", (current, line) => current + string.Format("{0}{1}", line, Environment.NewLine));

            return string.Format("From: {0}{2}Date Received: {1:yyyy-MM-dd}{3}{2}{2} ", From, DateReceived, Environment.NewLine, lines);
        }
    }
}