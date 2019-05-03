using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceOrgManager.Model
{
    public class TestResult
    {
        string apexTestClassId;
        string apexTestClassName;
        string message;
        string methodName;
        string outcome;

        public string ApexTestClassId { get => apexTestClassId; set => apexTestClassId = value; }
        public string ApexClassName { get => apexTestClassName; set => apexTestClassName = value; }
        public string Message { get => message; set => message = value; }
        public string MethodName { get => methodName; set => methodName = value; }
        public string Outcome { get => outcome; set => outcome = value; }

        public TestResult(string apexTestClassId, string apexTestClassName, string message, string methodName, string outcome)
        {
            this.apexTestClassId = apexTestClassId;
            this.apexTestClassName = apexTestClassName;
            this.message = message;
            this.methodName = methodName;
            this.outcome = outcome;
        }
    }
    public class ItemCodeCoverage
    {
        string itemId;
        string itemName;
        int numLinesCovered;
        int numLinesUncovered;
        double codeCoveragePercent;
        bool isTrigger;
        Dictionary<string, object> coverage;

        public string ItemId { get => itemId; set => itemId = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public double CodeCoveragePercent { get => codeCoveragePercent; set => codeCoveragePercent = value; }
        public bool IsTrigger { get => isTrigger; set => isTrigger = value; }
        public int NumLinesCovered { get => numLinesCovered; set => numLinesCovered = value; }
        public int NumLinesUncovered { get => numLinesUncovered; set => numLinesUncovered = value; }
        public Dictionary<string, object> Coverage { get => coverage; set => coverage = value; }

        public ItemCodeCoverage(string itemId, string itemName, int numLinesCovered, int numLinesUncovered, double codeCoveragePercent, bool isTrigger, Dictionary<string, object> coverage)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.numLinesCovered = numLinesCovered;
            this.numLinesUncovered = numLinesUncovered;
            this.codeCoveragePercent = codeCoveragePercent;
            this.isTrigger = isTrigger;
            this.coverage = coverage;
        }
    }
}
