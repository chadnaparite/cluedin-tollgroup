using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.TollGroup.Vocabularies;
using CluedIn.Crawling.TollGroup.Core.Models;

namespace CluedIn.Crawling.TollGroup.ClueProducers
{
    public class OrganizationClueProducer : BaseClueProducerDistinctIdentifyable<Organization>
    {
        private readonly IClueFactory factory;

        public OrganizationClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Organization input, Guid accountId)
        {
            var organizationVocabulary = new OrganizationVocabulary();

            // TODO: Verify EntityType and identifier are correct
            var clue = factory.Create(organizationVocabulary.Grouping, input.Id.ToString(), accountId);

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }
            if (input.Description != null)
                data.Description = input.Description;



            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[organizationVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[organizationVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }


            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, TollGroupConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, TollGroupConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[organizationVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[organizationVocabulary.Role] = input.Role.PrintIfAvailable();
            data.Properties[organizationVocabulary.Client] = input.Client.PrintIfAvailable();
            data.Properties[organizationVocabulary.City] = input.City.PrintIfAvailable();
            data.Properties[organizationVocabulary.Area] = input.Area.PrintIfAvailable();
            data.Properties[organizationVocabulary.Hour] = input.Hour.PrintIfAvailable();
            data.Properties[organizationVocabulary.Type] = input.Type.PrintIfAvailable();
            data.Properties[organizationVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[organizationVocabulary.Apply] = input.Apply.PrintIfAvailable();
            data.Properties[organizationVocabulary.Url] = input.Url.PrintIfAvailable();
            data.Properties[organizationVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[organizationVocabulary.LastName] = input.LastName.PrintIfAvailable();
            data.Properties[organizationVocabulary.Number] = input.Number.PrintIfAvailable();
            data.Properties[organizationVocabulary.Email] = input.Email.PrintIfAvailable();

            return clue;
        }
    }
}
