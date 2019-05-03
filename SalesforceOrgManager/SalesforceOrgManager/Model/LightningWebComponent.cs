using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class LightningWebComponent
    {
        string id;
        double apiversion;
        string developerName;
        string masterLabel;
        string description;
        bool isExposed;
        string targetConfigs;
        public List<LwcResource> lwcResources;
        public List<LwcTarget> lwcTargets;

        public string Id { get => id; set => id = value; }
        public double Apiversion { get => apiversion; set => apiversion = value; }
        public string DeveloperName { get => developerName; set => developerName = value; }
        public string MasterLabel { get => masterLabel; set => masterLabel = value; }
        public string Description { get => description; set => description = value; }
        public bool IsExposed { get => isExposed; set => isExposed = value; }
        public string TargetConfigs { get => targetConfigs; set => targetConfigs = value; }

        public LightningWebComponent(string id, double apiversion, string developerName, string masterLabel, string description, bool isExposed, string targetConfigs)
        {
            this.id = id;
            this.apiversion = apiversion;
            this.developerName = developerName;
            this.masterLabel = masterLabel;
            this.description = description;
            this.isExposed = isExposed;
            this.targetConfigs = targetConfigs;
            lwcResources = new List<LwcResource>();
            lwcTargets = new List<LwcTarget>();
        }
        public class LwcResource
        {
            string id;
            string filePath;
            string source;

            public string Id { get => id; set => id = value; }
            public string FilePath { get => filePath; set => filePath = value; }
            public string Source { get => source; set => source = value; }
        }
        public class LwcTarget
        {
            string target;
            public string Target { get => target; set => target = value; }
        }
    }
}
