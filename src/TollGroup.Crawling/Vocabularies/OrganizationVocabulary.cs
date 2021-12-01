using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.TollGroup.Vocabularies
{
    public class  OrganizationVocabulary : SimpleVocabulary
    {
        public  OrganizationVocabulary()
        {
            VocabularyName = "TollGroup Organization"; 
            KeyPrefix      = "tollgroup.organization"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Organization; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("TollGroup Organization Details", group =>
            {
                Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey("Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Client = group.Add(new VocabularyKey("Client", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey("City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Area = group.Add(new VocabularyKey("Area", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hour = group.Add(new VocabularyKey("Hour", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey("Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey("Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Apply = group.Add(new VocabularyKey("Apply", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey("Url", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey("FirstName", "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey("LastName", "Last Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey("Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey("Email", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });

            AddMapping(FirstName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.FirstName);
            AddMapping(LastName, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.LastName);
            AddMapping(Number, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.MobileNumber);
            AddMapping(Email, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInPerson.Email);
        }


        
        public VocabularyKey Id { get; private set; }
        
        public VocabularyKey Role { get; private set; }
        
        public VocabularyKey Client { get; private set; }
        
        public VocabularyKey City { get; private set; }
        
        public VocabularyKey Area { get; private set; }
        
        public VocabularyKey Hour { get; private set; }
        
        public VocabularyKey Type { get; private set; }
        
        public VocabularyKey Description { get; private set; }
        
        public VocabularyKey Apply { get; private set; }
        
        public VocabularyKey Url { get; private set; }
        
        public VocabularyKey FirstName { get; private set; }
        
        public VocabularyKey LastName { get; private set; }
        
        public VocabularyKey Number { get; private set; }
        
        public VocabularyKey Email { get; private set; }
        
    }
}
