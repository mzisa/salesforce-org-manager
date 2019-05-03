namespace SalesforceOrgManager.Model
{
    class ApexStaticResourceStub
    {
        string id;
        string name;
        string body;
        string cacheControl;
        string contentType;
        string description;
        bool singleFile;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Body { get => body; set => body = value; }
        public string CacheControl { get => cacheControl; set => cacheControl = value; }
        public string ContentType { get => contentType; set => contentType = value; }
        public string Description { get => description; set => description = value; }
        public bool SingleFile { get => singleFile; set => singleFile = value; }

        public ApexStaticResourceStub(string id, string name, string body, string cacheControl, string contentType, string description, bool singleFile)
        {
            this.Id = id;
            this.name = name;
            this.body = body;
            this.cacheControl = cacheControl;
            this.contentType = contentType;
            this.description = description;
            this.singleFile = singleFile;
        }
    }
}
