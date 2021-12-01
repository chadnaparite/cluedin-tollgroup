using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.TollGroup.ClueProducers;
using CluedIn.Crawling.TollGroup.Core.Models;

namespace Crawling.TollGroup.Unit.Test.ClueProducers
{
    public class OrganizationClueProducerTests : BaseClueProducerTest<Organization>
    {
        protected override BaseClueProducer<Organization> Sut =>
            new OrganizationClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Organization;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Organization organization)
        {
            var clue = Sut.MakeClue(organization, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
