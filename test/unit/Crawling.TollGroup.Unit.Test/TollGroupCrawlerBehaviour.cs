using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.TollGroup;
using CluedIn.Crawling.TollGroup.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.TollGroup.Unit.Test
{
    public class TollGroupCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public TollGroupCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ITollGroupClientFactory>();

            _sut = new TollGroupCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
