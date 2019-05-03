namespace SalesforceOrgManager.Model
{
    class ApexClassStub
    {
        string id;
        string name;
        string body;
        bool isTest;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }
        public bool IsTest { get => isTest; set => isTest = value; }

        public ApexClassStub(string id, string name)
        {
            this.Id = id;
            this.name = name;
            this.body = "";
        }
        public ApexClassStub(string id, string name, string body)
        {
            this.Id = id;
            this.name = name;
            this.body = body;
        }
        public ApexClassStub(string id, string name, string body, bool isTest)
        {
            this.Id = id;
            this.name = name;
            this.body = body;
            this.isTest = isTest;
        }

    }
}
