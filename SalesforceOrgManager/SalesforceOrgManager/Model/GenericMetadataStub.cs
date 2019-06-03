using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class GenericMetadataStub
    {
        string name;
        string body;
        string nameWithExt;
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }
        public string NameWithExt { get => nameWithExt; set => nameWithExt = value; }

        public GenericMetadataStub(string name, string body, string nameWithExt)
        {
            this.name = name;
            this.body = body;
            this.nameWithExt = nameWithExt;
        }
    }
}
