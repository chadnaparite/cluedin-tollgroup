using CluedIn.Core;
using CluedIn.Crawling.TollGroup.Core;

using ComponentHost;

namespace CluedIn.Crawling.TollGroup
{
    [Component(TollGroupConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class TollGroupCrawlerComponent : CrawlerComponentBase
    {
        public TollGroupCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

