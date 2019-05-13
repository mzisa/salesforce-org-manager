using System;
using System.Collections.Generic;
using SfTooling.com.salesforce.tooling;

namespace SalesforceOrgManager.Model
{
    class LightningWebComponentStub
    {
        public string id;
        public double apiversion;
        public string masterLabel;
        public string description;
        public bool isExposed;
        public string targetConfigs;
        public List<LwcResourceStub> lwcResources;
        public List<object> lwcTargets;

        public LightningWebComponentStub(string id, double apiversion, string masterLabel, string description, 
            bool isExposed, string targetConfigs, LwcResource[] resources, List<object> targets, List<string> resourcesText)
        {
            this.id = id;
            this.apiversion = apiversion;
            this.masterLabel = masterLabel;
            this.description = description;
            this.isExposed = isExposed;
            this.targetConfigs = targetConfigs;
            lwcResources = new List<LwcResourceStub>();
            lwcTargets = targets;
            int counter = 0;

            foreach (LwcResource r in resources)
            {
                lwcResources.Add(new LwcResourceStub(r.filePath, r.source, resourcesText[counter++]));
            }
        }
        public class LwcResourceStub
        {
            public string filePath;
            public byte[] source;
            public string resourceText;

            public LwcResourceStub(string filePath, byte[] source, string resourceText)
            {
                this.filePath = filePath;
                this.source = source;
                this.resourceText = resourceText;
            }
        }
    }
}
