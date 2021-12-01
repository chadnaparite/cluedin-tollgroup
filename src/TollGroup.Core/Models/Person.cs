using Newtonsoft.Json;

namespace CluedIn.Crawling.TollGroup.Core.Models
{
    public class Person 
    {
        public string FullName => string.Join(" ", FirstName, MiddleName, Surname);

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string IHaveAMiddleName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string SurnameAtBirth { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Consent { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string IHaveDependants { get; set; }
        public string DependantsChildrenTotal { get; set; }
        public string DependantsOtherTotal { get; set; }
        public string SecondTelephoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string PreferredContactMethod { get; set; }
        public string UnitNumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string Postcode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string IHaveADifferentMailingAddress { get; set; }
        public string Country { get; set; }
        public string MailingUnitNumber { get; set; }
        public string MailingStreetNumber { get; set; }
        public string MailingStreetName { get; set; }
        public string MailingPostcode { get; set; }
        public string MailingSuburb { get; set; }
        public string MailingState { get; set; }
        public string ResidencyType { get; set; }
        public string CountryOfBirth { get; set; }
        public string YearOfArrivalInAustralia { get; set; }
        public string FathersCountryOfBirth { get; set; }
        public string MothersCountryOfBirth { get; set; }
        public string Religion { get; set; }
        public string AboriginalAustralian { get; set; }
        public string TorresStraitIslander { get; set; }
        public string FirstLanguage { get; set; }
        public string LanguageSpokenAtHome { get; set; }
        public string HighestEducationQualification { get; set; }
        public string YearLastStudied { get; set; }
        public string IHaveServedBeforeInTheAustralianDefenceForce { get; set; }
        public string IHavePreviouslyAppliedForTheAustralianDefenceForce { get; set; }
        public string IHavePreviouslyBeenInAForeignMilitaryService { get; set; }
        public string IAmInAForeignMilitaryService { get; set; }
        public string IAmInOrHaveBeenInTheCadets { get; set; }
        public string IAmStillServingInTheAustralianDefenceForce { get; set; }
        public string FirstJobIntrest { get; set; }
        public string SecondJobIntrest { get; set; }
        public string ThirdJobIntrest { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Resume { get; set; }
        public string CoverLetter { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Started { get; set; }
        public string Ended { get; set; }
        public string Description { get; set; }
        public string Institution { get; set; }
        public string CourseOrQualification { get; set; }
        public string Completed { get; set; }
        public string Finished { get; set; }
        public string ExpectedFinish { get; set; }
        public string CourseHighlights { get; set; }
        public string AddedSkills1 { get; set; }
        public string AddedSkills2 { get; set; }
        public string AddedSkills3 { get; set; }
        public string AddedSkills4 { get; set; }
        public string AddedSkills5 { get; set; }
        public string CareerHistoryRoles { get; set; }
        public string LicencesAndCertifications { get; set; }
        public string Skills { get; set; }
        public string Indigenous { get; set; }

    }
}
