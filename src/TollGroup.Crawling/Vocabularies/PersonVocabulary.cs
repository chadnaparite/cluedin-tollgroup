using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.TollGroup.Vocabularies
{
    public class  PersonVocabulary : SimpleVocabulary
    {
        public  PersonVocabulary()
        {
            VocabularyName = "TollGroup Person"; 
            KeyPrefix      = "tollgroup.person"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Person; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("TollGroup Person Details", group =>
            {
                Title = group.Add(new VocabularyKey("Title", "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHaveAMiddleName = group.Add(new VocabularyKey("IHaveAMiddleName", "I Have A Middle Name", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey("MiddleName", "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Surname = group.Add(new VocabularyKey("Surname", "Surname", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurnameAtBirth = group.Add(new VocabularyKey("SurnameAtBirth", "Surname At Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey("Email", "Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfBirth = group.Add(new VocabularyKey("DateOfBirth", "Date Of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Consent = group.Add(new VocabularyKey("Consent", "Consent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey("Gender", "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaritalStatus = group.Add(new VocabularyKey("MaritalStatus", "Marital Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHaveDependants = group.Add(new VocabularyKey("IHaveDependants", "I Have Dependants", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DependantsChildrenTotal = group.Add(new VocabularyKey("DependantsChildrenTotal", "Dependants Children Total", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DependantsOtherTotal = group.Add(new VocabularyKey("DependantsOtherTotal", "Dependants Other Total", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SecondTelephoneNumber = group.Add(new VocabularyKey("SecondTelephoneNumber", "Second Telephone Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TelephoneNumber = group.Add(new VocabularyKey("TelephoneNumber", "Telephone Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredContactMethod = group.Add(new VocabularyKey("PreferredContactMethod", "Preferred Contact Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitNumber = group.Add(new VocabularyKey("UnitNumber", "Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey("StreetNumber", "Street Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName = group.Add(new VocabularyKey("StreetName", "Street Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetType = group.Add(new VocabularyKey("StreetType", "Street Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Postcode = group.Add(new VocabularyKey("Postcode", "Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suburb = group.Add(new VocabularyKey("Suburb", "Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHaveADifferentMailingAddress = group.Add(new VocabularyKey("IHaveADifferentMailingAddress", "I Have A Different Mailing Address", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", "Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingUnitNumber = group.Add(new VocabularyKey("MailingUnitNumber", "Mailing Unit Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingStreetNumber = group.Add(new VocabularyKey("MailingStreetNumber", "Mailing Street Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingStreetName = group.Add(new VocabularyKey("MailingStreetName", "Mailing Street Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingPostcode = group.Add(new VocabularyKey("MailingPostcode", "Mailing Postcode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingSuburb = group.Add(new VocabularyKey("MailingSuburb", "Mailing Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MailingState = group.Add(new VocabularyKey("MailingState", "Mailing State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResidencyType = group.Add(new VocabularyKey("ResidencyType", "Residency Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryOfBirth = group.Add(new VocabularyKey("CountryOfBirth", "Country Of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearOfArrivalInAustralia = group.Add(new VocabularyKey("YearOfArrivalInAustralia", "Year Of Arrival In Australia", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FathersCountryOfBirth = group.Add(new VocabularyKey("FathersCountryOfBirth", "Father's Country Of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MothersCountryOfBirth = group.Add(new VocabularyKey("MothersCountryOfBirth", "Mother's Country Of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Religion = group.Add(new VocabularyKey("Religion", "Religion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AboriginalAustralian = group.Add(new VocabularyKey("AboriginalAustralian", "Aboriginal Australian", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TorresStraitIslander = group.Add(new VocabularyKey("TorresStraitIslander", "Torres Strait Islander", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstLanguage = group.Add(new VocabularyKey("FirstLanguage", "First Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageSpokenAtHome = group.Add(new VocabularyKey("LanguageSpokenAtHome", "Language Spoken At Home", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HighestEducationQualification = group.Add(new VocabularyKey("HighestEducationQualification", "Highest Education Qualification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearLastStudied = group.Add(new VocabularyKey("YearLastStudied", "Year Last Studied", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHaveServedBeforeInTheAustralianDefenceForce = group.Add(new VocabularyKey("IHaveServedBeforeInTheAustralianDefenceForce", "I Have Served Before In The Australian Defence Force", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHavePreviouslyAppliedForTheAustralianDefenceForce = group.Add(new VocabularyKey("IHavePreviouslyAppliedForTheAustralianDefenceForce", "I Have Previously Applied For The Australian Defence Force", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IHavePreviouslyBeenInAForeignMilitaryService = group.Add(new VocabularyKey("IHavePreviouslyBeenInAForeignMilitaryService", "I Have Previously Been In A Foreign Military Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IAmInAForeignMilitaryService = group.Add(new VocabularyKey("IAmInAForeignMilitaryService", "I Am In A Foreign Military Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IAmInOrHaveBeenInTheCadets = group.Add(new VocabularyKey("IAmIn/HaveBeenInTheCadets", "I Am In / Have Been In The Cadets", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IAmStillServingInTheAustralianDefenceForce = group.Add(new VocabularyKey("IAmStillServingInTheAustralianDefenceForce", "I Am Still Serving In The Australian Defence Force", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstJobIntrest = group.Add(new VocabularyKey("FirstJobIntrest", "1st Job Intrest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondJobIntrest = group.Add(new VocabularyKey("SecondJobIntrest", "Second Job Intrest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdJobIntrest = group.Add(new VocabularyKey("ThirdJobIntrest", "Third Job Intrest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneNumber = group.Add(new VocabularyKey("PhoneNumber", "Phone Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey("EmailAddress", "Email Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resume = group.Add(new VocabularyKey("Resume", "Resume", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CoverLetter = group.Add(new VocabularyKey("CoverLetter", "Cover Letter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTitle = group.Add(new VocabularyKey("JobTitle", "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey("CompanyName", "Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Started = group.Add(new VocabularyKey("Started", "Started", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ended = group.Add(new VocabularyKey("Ended", "Ended", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Institution = group.Add(new VocabularyKey("Institution", "Institution", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CourseOrQualification = group.Add(new VocabularyKey("CourseOrQualification", "Course Or Qualification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Completed = group.Add(new VocabularyKey("Completed", "Completed", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Finished = group.Add(new VocabularyKey("Finished", "Finished", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedFinish = group.Add(new VocabularyKey("ExpectedFinish", "Expected Finish", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CourseHighlights = group.Add(new VocabularyKey("CourseHighlights", "Course Highlights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddedSkills1 = group.Add(new VocabularyKey("AddedSkills1", "Added Skills 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddedSkills2 = group.Add(new VocabularyKey("AddedSkills2", "Added Skills 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddedSkills3 = group.Add(new VocabularyKey("AddedSkills3", "Added Skills 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddedSkills4 = group.Add(new VocabularyKey("AddedSkills4", "Added Skills 4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddedSkills5 = group.Add(new VocabularyKey("AddedSkills5", "Added Skills 5", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CareerHistoryRoles = group.Add(new VocabularyKey("CareerHistoryRoles", "Career History - Roles", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicencesAndCertifications = group.Add(new VocabularyKey("LicencesAndCertifications", "Licences & Certifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Skills = group.Add(new VocabularyKey("Skills", "Skills", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Indigenous = group.Add(new VocabularyKey("Indigenous", "Indigenous", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            AddMapping(Title, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Title);
            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            AddMapping(MiddleName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.MiddleName);
            AddMapping(Surname, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Email);
            AddMapping(DateOfBirth, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Birthday);
            AddMapping(DateOfBirth, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Gender);
            AddMapping(PhoneNumber, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.PhoneNumber);
            AddMapping(JobTitle, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.JobTitle);
        }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey IHaveAMiddleName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Surname { get; private set; }
        public VocabularyKey SurnameAtBirth { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey DateOfBirth { get; private set; }
        public VocabularyKey Consent { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey MaritalStatus { get; private set; }
        public VocabularyKey IHaveDependants { get; private set; }
        public VocabularyKey DependantsChildrenTotal { get; private set; }
        public VocabularyKey DependantsOtherTotal { get; private set; }
        public VocabularyKey SecondTelephoneNumber { get; private set; }
        public VocabularyKey TelephoneNumber { get; private set; }
        public VocabularyKey PreferredContactMethod { get; private set; }
        public VocabularyKey UnitNumber { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey StreetName { get; private set; }
        public VocabularyKey StreetType { get; private set; }
        public VocabularyKey Postcode { get; private set; }
        public VocabularyKey Suburb { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey IHaveADifferentMailingAddress { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey MailingUnitNumber { get; private set; }
        public VocabularyKey MailingStreetNumber { get; private set; }
        public VocabularyKey MailingStreetName { get; private set; }
        public VocabularyKey MailingPostcode { get; private set; }
        public VocabularyKey MailingSuburb { get; private set; }
        public VocabularyKey MailingState { get; private set; }
        public VocabularyKey ResidencyType { get; private set; }
        public VocabularyKey CountryOfBirth { get; private set; }
        public VocabularyKey YearOfArrivalInAustralia { get; private set; }
        public VocabularyKey FathersCountryOfBirth { get; private set; }
        public VocabularyKey MothersCountryOfBirth { get; private set; }
        public VocabularyKey Religion { get; private set; }
        public VocabularyKey AboriginalAustralian { get; private set; }
        public VocabularyKey TorresStraitIslander { get; private set; }
        public VocabularyKey FirstLanguage { get; private set; }
        public VocabularyKey LanguageSpokenAtHome { get; private set; }
        public VocabularyKey HighestEducationQualification { get; private set; }
        public VocabularyKey YearLastStudied { get; private set; }
        public VocabularyKey IHaveServedBeforeInTheAustralianDefenceForce { get; private set; }
        public VocabularyKey IHavePreviouslyAppliedForTheAustralianDefenceForce { get; private set; }
        public VocabularyKey IHavePreviouslyBeenInAForeignMilitaryService { get; private set; }
        public VocabularyKey IAmInAForeignMilitaryService { get; private set; }
        public VocabularyKey IAmInOrHaveBeenInTheCadets { get; private set; }
        public VocabularyKey IAmStillServingInTheAustralianDefenceForce { get; private set; }
        public VocabularyKey FirstJobIntrest { get; private set; }
        public VocabularyKey SecondJobIntrest { get; private set; }
        public VocabularyKey ThirdJobIntrest { get; private set; }
        public VocabularyKey PhoneNumber { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Resume { get; private set; }
        public VocabularyKey CoverLetter { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey Started { get; private set; }
        public VocabularyKey Ended { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Institution { get; private set; }
        public VocabularyKey CourseOrQualification { get; private set; }
        public VocabularyKey Completed { get; private set; }
        public VocabularyKey Finished { get; private set; }
        public VocabularyKey ExpectedFinish { get; private set; }
        public VocabularyKey CourseHighlights { get; private set; }
        public VocabularyKey AddedSkills1 { get; private set; }
        public VocabularyKey AddedSkills2 { get; private set; }
        public VocabularyKey AddedSkills3 { get; private set; }
        public VocabularyKey AddedSkills4 { get; private set; }
        public VocabularyKey AddedSkills5 { get; private set; }
        public VocabularyKey CareerHistoryRoles { get; private set; }
        public VocabularyKey LicencesAndCertifications { get; private set; }
        public VocabularyKey Skills { get; private set; }
        public VocabularyKey Indigenous { get; private set; }
    }
}
