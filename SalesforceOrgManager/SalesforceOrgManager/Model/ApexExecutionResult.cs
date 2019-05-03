using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    class ApexExecutionResult
    {
        bool compiled;
        bool success;
        string compileProblem;
        string exceptionStackTrace;
        string exceptionMessage;
        string logId;
        string logBody;

        public bool Compiled { get => compiled; set => compiled = value; }
        public bool Success { get => success; set => success = value; }
        public string CompileProblem { get => compileProblem; set => compileProblem = value; }
        public string ExceptionStackTrace { get => exceptionStackTrace; set => exceptionStackTrace = value; }
        public string ExceptionMessage { get => exceptionMessage; set => exceptionMessage = value; }
        public string LogId { get => logId; set => logId = value; }
        public string LogBody { get => logBody; set => logBody = value; }

        public ApexExecutionResult(bool compiled, bool success, string compileProblem, string exceptionStackTrace, string exceptionMessage, string logId, string logBody)
        {
            this.compiled = compiled;
            this.success = success;
            this.compileProblem = compileProblem;
            this.exceptionStackTrace = exceptionStackTrace;
            this.exceptionMessage = exceptionMessage;
            this.logId = logId;
            this.logBody = logBody;
        }
    }
}
