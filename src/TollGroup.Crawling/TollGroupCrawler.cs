using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.TollGroup.Core;
using CluedIn.Crawling.TollGroup.Infrastructure.Factories;

namespace CluedIn.Crawling.TollGroup
{
    public class TollGroupCrawler : ICrawlerDataGenerator
    {
        private readonly ITollGroupClientFactory clientFactory;
        public TollGroupCrawler(ITollGroupClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is TollGroupCrawlJobData TollGroupcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(TollGroupcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
