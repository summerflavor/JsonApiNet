using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonApiNet.Attributes;

namespace JsonApiNet.Tests
{

    public class Authentication
    {

    }

    [JsonApiResourceType("sessions")]
    public class Sessions
    {
        [JsonApiId]
        public Guid Identifier { get; set; }

        [JsonApiType]
        public string ResourceType { get; set; }

        public string Id { get; set; }
        public string Type { get; set; }
        public int SiteId { get; set; }
        public int LocationId { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int LocationSelectionOption { get; set; }
        public int? LocationId { get; set; }
        public bool ChangePassword { get; set; }
        public bool? Disabled { get; set; }
        public string LastLogin { get; set; }
        public bool? MaxAdmin { get; set; }
        public bool? SiteAdmin { get; set; }
    }

}
