using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.TollGroup.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.TollGroup.Unit.Test.TollGroupProvider
{
    public abstract class TollGroupProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ITollGroupClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected TollGroupProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ITollGroupClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new TollGroup.TollGroupProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
