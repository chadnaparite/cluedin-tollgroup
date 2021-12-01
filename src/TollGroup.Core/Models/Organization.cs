using CluedIn.Core;
using Newtonsoft.Json;

namespace CluedIn.Crawling.TollGroup.Core.Models
{
    public class Organization : IIdentifiable
    {
        [JsonIgnore]
        object IIdentifiable.Id => Id;

        [JsonProperty("ID")]
        public string Id {get; set;}

        [JsonProperty("Role")]
        public string Role {get; set;}

        [JsonProperty("Client")]
        public string Client {get; set;}

        [JsonProperty("City")]
        public string City {get; set;}

        [JsonProperty("Area")]
        public string Area {get; set;}

        [JsonProperty("Hour")]
        public string Hour {get; set;}

        [JsonProperty("Type")]
        public string Type {get; set;}

        [JsonProperty("Description")]
        public string Description {get; set;}

        [JsonProperty("Apply")]
        public string Apply {get; set;}

        [JsonProperty("URL")]
        public string Url {get; set;}

        [JsonProperty("FirstName")]
        public string FirstName {get; set;}

        [JsonProperty("LastName")]
        public string LastName {get; set;}

        [JsonProperty("Number")]
        public string Number {get; set;}

        [JsonProperty("Email")]
        public string Email {get; set;}

        public string FullName => string.Join(" ", FirstName, LastName);
    }
}
