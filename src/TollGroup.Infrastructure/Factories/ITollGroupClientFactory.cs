using CluedIn.Crawling.TollGroup.Core;

namespace CluedIn.Crawling.TollGroup.Infrastructure.Factories
{
    public interface ITollGroupClientFactory
    {
        TollGroupClient CreateNew(TollGroupCrawlJobData TollGroupCrawlJobData);
    }
}
