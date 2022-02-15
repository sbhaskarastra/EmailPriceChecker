using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Exchange.WebServices.Data;
using Astra.EmailPriceChecker.Logger;
namespace Astra.EmailPriceChecker.ExchangeService
{
    public class ExchangeService
    {

        private Microsoft.Exchange.WebServices.Data.ExchangeService _service;
        private readonly List<PullSubscription> _subscriptions;

        private readonly string _emailAccount ;
        private readonly string _emailAccountPassword ;
        private readonly string _emailAccountUri;
        private readonly Logger.Logger _logger;
        public ExchangeService(string emailAccount, string emailAccountPassword, string emailAccountUri)
        {
            _subscriptions = new List<PullSubscription>();
            _emailAccount = emailAccount;
            _emailAccountPassword = emailAccountPassword;
            _emailAccountUri = emailAccountUri;
        }

        public void AddSubscription(string mailbox)
        {
            var folderId = new FolderId(WellKnownFolderName.Inbox);
            AddSubscription(folderId);
        }

        private void AddSubscription(FolderId folderId)
        {
            try
            {
                if (folderId == null) throw new ArgumentNullException("folderId");

                //toDo: try this instead...
                //https://msdn.microsoft.com/en-us/library/hh312849(EXCHG.140).aspx
                //http://stackoverflow.com/questions/6377085/increasing-the-lifetime-element-for-ews-streaming-subscription-connection/6490642#6490642

                var subscription = _service.SubscribeToPullNotifications(new List<FolderId> { folderId }, 60, "", EventType.NewMail);

                
                if (_subscriptions.Count == 0)
                    _subscriptions.Add(subscription);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Authenticate()
        {
            _service = new  Microsoft.Exchange.WebServices.Data.ExchangeService(ExchangeVersion.Exchange2013)
            {
                Credentials = new WebCredentials(_emailAccount, _emailAccountPassword),
                TraceEnabled = true,
                TraceFlags = TraceFlags.All,
                Url = new Uri(_emailAccountUri)
            };
        }

        public List<PullSubscription> GetSubscriptions()
        {
            return _subscriptions;
        }

        public Microsoft.Exchange.WebServices.Data.ExchangeService GetService()
        {
            return _service;
        }
    }
}