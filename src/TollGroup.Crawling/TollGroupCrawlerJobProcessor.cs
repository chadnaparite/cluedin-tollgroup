using CluedIn.Crawling.TollGroup.Core;

namespace CluedIn.Crawling.TollGroup
{
    public class TollGroupCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<TollGroupCrawlJobData>
    {
        public TollGroupCrawlerJobProcessor(TollGroupCrawlerComponent component) : base(component)
        {
        }
    }
}
