using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class LightningItemDefinition
    {
        string defType;
        string format;
        string source;

        public string DefType { get => defType; set => defType = value; }
        public string Format { get => format; set => format = value; }
        public string Source { get => source; set => source = value; }

        public LightningItemDefinition(string defType, string format, string source)
        {
            this.defType = defType;
            this.format = format;
            this.source = source;
        }
    }
    class LightningItemBundle
    {
        string id;
        double apiversion;
        string developerName;
        string masterLabel;
        string description;

        public string Id { get => id; set => id = value; }
        public double Apiversion { get => apiversion; set => apiversion = value; }
        public string DeveloperName { get => developerName; set => developerName = value; }
        public string MasterLabel { get => masterLabel; set => masterLabel = value; }
        public string Description { get => description; set => description = value; }

        public LightningItemBundle(string id, string masterLabel)
        {
            this.id = id;
            this.masterLabel = masterLabel;
        }
        public LightningItemBundle(string id, double apiversion, string developerName, string masterLabel, string description)
        {
            this.id = id;
            this.apiversion = apiversion;
            this.developerName = developerName;
            this.masterLabel = masterLabel;
            this.description = description;
        }
    }
}
