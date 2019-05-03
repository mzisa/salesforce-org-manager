using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class ApexDebugLog
    {
        string id;
        string operation;
        string request;
        string startTime;
        string status;
        int logLength;
        string body;

        public string Id { get => id; set => id = value; }
        public string Operation { get => operation; set => operation = value; }
        public string Request { get => request; set => request = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string Status { get => status; set => status = value; }
        public int LogLength { get => logLength; set => logLength = value; }
        public string Body { get => body; set => body = value; }

        public ApexDebugLog(string id, string operation, string request, string startTime, string status, int logLength, string body)
        {
            this.id = id;
            this.operation = operation;
            this.request = request;
            this.startTime = startTime;
            this.status = status;
            this.logLength = logLength;
            this.body = body;
        }
    }
}
