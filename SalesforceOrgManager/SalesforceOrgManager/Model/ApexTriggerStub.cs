namespace SalesforceOrgManager.Model
{
    class ApexTriggerStub
    {
        string id;
        string name;
        string body;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }

        public ApexTriggerStub(string id, string name)
        {
            this.Id = id;
            this.name = name;
            this.body = "";
        }
        public ApexTriggerStub(string id, string name, string body)
        {
            this.Id = id;
            this.name = name;
            this.body = body;
        }

    }
}
