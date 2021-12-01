using System.Collections.Generic;
using CluedIn.Crawling.TollGroup.Core;

namespace CluedIn.Crawling.TollGroup.Integration.Test
{
  public static class TollGroupConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { TollGroupConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
