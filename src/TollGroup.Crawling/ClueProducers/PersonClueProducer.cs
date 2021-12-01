using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.TollGroup.Vocabularies;
using CluedIn.Crawling.TollGroup.Core.Models;

namespace CluedIn.Crawling.TollGroup.ClueProducers
{
    public class PersonClueProducer : BaseClueProducer<Person>
    {
        private readonly IClueFactory factory;

        public PersonClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Person input, Guid accountId)
        {
            var personVocabulary = new PersonVocabulary();

            // TODO: Verify EntityType and identifier are correct
            var clue = factory.Create(personVocabulary.Grouping, input.FullName.ToString(), accountId);

            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[personVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[personVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[personVocabulary.Title] = input.Title.PrintIfAvailable();
            data.Properties[personVocabulary.FirstName] = input.FirstName.PrintIfAvailable();
            data.Properties[personVocabulary.IHaveAMiddleName] = input.IHaveAMiddleName.PrintIfAvailable();
            data.Properties[personVocabulary.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[personVocabulary.Surname] = input.Surname.PrintIfAvailable();
            data.Properties[personVocabulary.SurnameAtBirth] = input.SurnameAtBirth.PrintIfAvailable();
            data.Properties[personVocabulary.Email] = input.Email.PrintIfAvailable();
            data.Properties[personVocabulary.DateOfBirth] = input.DateOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.Consent] = input.Consent.PrintIfAvailable();
            data.Properties[personVocabulary.Gender] = input.Gender.PrintIfAvailable();
            data.Properties[personVocabulary.MaritalStatus] = input.MaritalStatus.PrintIfAvailable();
            data.Properties[personVocabulary.IHaveDependants] = input.IHaveDependants.PrintIfAvailable();
            data.Properties[personVocabulary.DependantsChildrenTotal] = input.DependantsChildrenTotal.PrintIfAvailable();
            data.Properties[personVocabulary.DependantsOtherTotal] = input.DependantsOtherTotal.PrintIfAvailable();
            data.Properties[personVocabulary.SecondTelephoneNumber] = input.SecondTelephoneNumber.PrintIfAvailable();
            data.Properties[personVocabulary.TelephoneNumber] = input.TelephoneNumber.PrintIfAvailable();
            data.Properties[personVocabulary.PreferredContactMethod] = input.PreferredContactMethod.PrintIfAvailable();
            data.Properties[personVocabulary.UnitNumber] = input.UnitNumber.PrintIfAvailable();
            data.Properties[personVocabulary.StreetNumber] = input.StreetNumber.PrintIfAvailable();
            data.Properties[personVocabulary.StreetName] = input.StreetName.PrintIfAvailable();
            data.Properties[personVocabulary.StreetType] = input.StreetType.PrintIfAvailable();
            data.Properties[personVocabulary.Postcode] = input.Postcode.PrintIfAvailable();
            data.Properties[personVocabulary.Suburb] = input.Suburb.PrintIfAvailable();
            data.Properties[personVocabulary.State] = input.State.PrintIfAvailable();
            data.Properties[personVocabulary.IHaveADifferentMailingAddress] = input.IHaveADifferentMailingAddress.PrintIfAvailable();
            data.Properties[personVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[personVocabulary.MailingUnitNumber] = input.MailingUnitNumber.PrintIfAvailable();
            data.Properties[personVocabulary.MailingStreetNumber] = input.MailingStreetNumber.PrintIfAvailable();
            data.Properties[personVocabulary.MailingStreetName] = input.MailingStreetName.PrintIfAvailable();
            data.Properties[personVocabulary.MailingPostcode] = input.MailingPostcode.PrintIfAvailable();
            data.Properties[personVocabulary.MailingSuburb] = input.MailingSuburb.PrintIfAvailable();
            data.Properties[personVocabulary.MailingState] = input.MailingState.PrintIfAvailable();
            data.Properties[personVocabulary.ResidencyType] = input.ResidencyType.PrintIfAvailable();
            data.Properties[personVocabulary.CountryOfBirth] = input.CountryOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.YearOfArrivalInAustralia] = input.YearOfArrivalInAustralia.PrintIfAvailable();
            data.Properties[personVocabulary.FathersCountryOfBirth] = input.FathersCountryOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.MothersCountryOfBirth] = input.MothersCountryOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.Religion] = input.Religion.PrintIfAvailable();
            data.Properties[personVocabulary.AboriginalAustralian] = input.AboriginalAustralian.PrintIfAvailable();
            data.Properties[personVocabulary.TorresStraitIslander] = input.TorresStraitIslander.PrintIfAvailable();
            data.Properties[personVocabulary.FirstLanguage] = input.FirstLanguage.PrintIfAvailable();
            data.Properties[personVocabulary.LanguageSpokenAtHome] = input.LanguageSpokenAtHome.PrintIfAvailable();
            data.Properties[personVocabulary.HighestEducationQualification] = input.HighestEducationQualification.PrintIfAvailable();
            data.Properties[personVocabulary.YearLastStudied] = input.YearLastStudied.PrintIfAvailable();
            data.Properties[personVocabulary.IHaveServedBeforeInTheAustralianDefenceForce] = input.IHaveServedBeforeInTheAustralianDefenceForce.PrintIfAvailable();
            data.Properties[personVocabulary.IHavePreviouslyAppliedForTheAustralianDefenceForce] = input.IHavePreviouslyAppliedForTheAustralianDefenceForce.PrintIfAvailable();
            data.Properties[personVocabulary.IHavePreviouslyBeenInAForeignMilitaryService] = input.IHavePreviouslyBeenInAForeignMilitaryService.PrintIfAvailable();
            data.Properties[personVocabulary.IAmInAForeignMilitaryService] = input.IAmInAForeignMilitaryService.PrintIfAvailable();
            data.Properties[personVocabulary.IAmInOrHaveBeenInTheCadets] = input.IAmInOrHaveBeenInTheCadets.PrintIfAvailable();
            data.Properties[personVocabulary.IAmStillServingInTheAustralianDefenceForce] = input.IAmStillServingInTheAustralianDefenceForce.PrintIfAvailable();
            data.Properties[personVocabulary.FirstJobIntrest] = input.FirstJobIntrest.PrintIfAvailable();
            data.Properties[personVocabulary.SecondJobIntrest] = input.SecondJobIntrest.PrintIfAvailable();
            data.Properties[personVocabulary.ThirdJobIntrest] = input.ThirdJobIntrest.PrintIfAvailable();
            data.Properties[personVocabulary.PhoneNumber] = input.PhoneNumber.PrintIfAvailable();
            data.Properties[personVocabulary.EmailAddress] = input.EmailAddress.PrintIfAvailable();
            data.Properties[personVocabulary.Resume] = input.Resume.PrintIfAvailable();
            data.Properties[personVocabulary.CoverLetter] = input.CoverLetter.PrintIfAvailable();
            data.Properties[personVocabulary.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[personVocabulary.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[personVocabulary.Started] = input.Started.PrintIfAvailable();
            data.Properties[personVocabulary.Ended] = input.Ended.PrintIfAvailable();
            data.Properties[personVocabulary.Description] = input.Description.PrintIfAvailable();
            data.Properties[personVocabulary.Institution] = input.Institution.PrintIfAvailable();
            data.Properties[personVocabulary.CourseOrQualification] = input.CourseOrQualification.PrintIfAvailable();
            data.Properties[personVocabulary.Completed] = input.Completed.PrintIfAvailable();
            data.Properties[personVocabulary.Finished] = input.Finished.PrintIfAvailable();
            data.Properties[personVocabulary.ExpectedFinish] = input.ExpectedFinish.PrintIfAvailable();
            data.Properties[personVocabulary.CourseHighlights] = input.CourseHighlights.PrintIfAvailable();
            data.Properties[personVocabulary.AddedSkills1] = input.AddedSkills1.PrintIfAvailable();
            data.Properties[personVocabulary.AddedSkills2] = input.AddedSkills2.PrintIfAvailable();
            data.Properties[personVocabulary.AddedSkills3] = input.AddedSkills3.PrintIfAvailable();
            data.Properties[personVocabulary.AddedSkills4] = input.AddedSkills4.PrintIfAvailable();
            data.Properties[personVocabulary.AddedSkills5] = input.AddedSkills5.PrintIfAvailable();
            data.Properties[personVocabulary.CareerHistoryRoles] = input.CareerHistoryRoles.PrintIfAvailable();
            data.Properties[personVocabulary.LicencesAndCertifications] = input.LicencesAndCertifications.PrintIfAvailable();
            data.Properties[personVocabulary.Skills] = input.Skills.PrintIfAvailable();
            data.Properties[personVocabulary.Indigenous] = input.Indigenous.PrintIfAvailable();

            return clue;
        }
    }
}
