namespace SalesforceOrgManager.Model
{
    class ApexPageStub
    {
        string id;
        string name;
        string body;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }

        public ApexPageStub(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.body = "";
        }
        public ApexPageStub(string id, string name, string body)
        {
            this.id = id;
            this.name = name;
            this.body = body;
        }
    }
}
