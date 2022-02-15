using System.Collections.Generic;
using System.Linq;
using Astra.EmailPriceChecker.Data.Model;

namespace Astra.EmailPriceChecker.Data
{
    public sealed class DataRepository
    {
        public IEnumerable<string> GetWatchListItems(int bwicId)
        {
            using (var context = new AstraInfrastructureContext())
            {
                var query = from bwicFilter in context.EmailBwicFilter
                    where bwicFilter.EmailBwicMonitor.Any(t => t.Id == bwicId)
                    select bwicFilter.Filter;

                return query.ToList();
            }
        }

        public IEnumerable<string> GetBwicMonitorEmailDistributionListByEmailId(int emailId)
        {
            using (var context = new AstraInfrastructureContext())
            {
                var query = from user in context.Users
                    join emailUser in context.EmailUser
                        on user.Id equals emailUser.UserId
                    join email in context.Email
                        on emailUser.EmailId equals email.Id
                    where user.UserStatusId == 1
                          && email.Id == emailId
                    select (user.EmailAddress);

                return query.ToList();
            }
        }
    }
}
