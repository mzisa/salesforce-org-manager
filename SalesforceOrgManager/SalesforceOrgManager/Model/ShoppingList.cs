using SfTooling.com.salesforce.tooling;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesforceOrgManager.Model
{
    static class ShoppingList
    {
        public enum currentOp
        {
            Initial,
            Create,
            Open
        };

        // Pointer to current operation
        public static int currentOperation;

        // Authentication
        public static string orgUserName;
        public static string orgPassword;
        public static string orgToken;

        // Tooling API information
        public static string serverUrl;
        public static string restServicesBaseUri;
        public static string toolingApiLoginUri;
        public static SforceServiceService toolingService;

        // Project related properties
        public static object[] workspaces;
        public static object[] defaultProjectContent;
        public static Dictionary<string, object> logins;
        public static string workspaceDir;
        public static string projectRootDir;
        public static string projectOrgContentRootDir;
        public static string classesRootDir;
        public static string pagesRootDir;
        public static string triggersRootDir;
        public static string staticResourcesRootDir;
        public static string auraRootDir;
        public static string lwcRootDir;
        public static string orgManifest;
        public static string projectName;

        // Project related data
        public static List<string> projectClasses = new List<string>();
        public static List<string> projectPages = new List<string>();
        public static List<string> projectTriggers = new List<string>();
        public static List<string> projectStaticResources = new List<string>();
        public static List<string> projectLightningItems = new List<string>();
        public static List<string> projectLwcItems = new List<string>();
        public static List<ApexClassStub> testClasses = new List<ApexClassStub>();
        public static string currentTestsJobId;
        public static int logTicketNum = 0;

        // Pointer(s) to Forms
        public static SalesforceOrgManager.View.Principale principalePointer;
        public static SalesforceOrgManager.View.frmLogin LoginPointer;
        public static SalesforceOrgManager.View.OrgTree orgTreePointer;

        public static void destroy()
        {
            ShoppingList.projectOrgContentRootDir = null;
            ShoppingList.projectRootDir = null;
            ShoppingList.auraRootDir = null;
            ShoppingList.lwcRootDir = null;
            ShoppingList.classesRootDir = null;
            ShoppingList.currentOperation = 0;
            ShoppingList.LoginPointer = null;
            ShoppingList.orgManifest = null;
            ShoppingList.orgPassword = null;
            ShoppingList.orgToken = null;
            ShoppingList.orgTreePointer = null;
            ShoppingList.orgUserName = null;
            ShoppingList.pagesRootDir = null;
            ShoppingList.triggersRootDir = null;
            ShoppingList.staticResourcesRootDir = null;
            //ShoppingList.principalePointer = null;

            ShoppingList.projectClasses = new List<string>();
            ShoppingList.projectPages = new List<string>();
            ShoppingList.projectTriggers = new List<string>();
            ShoppingList.projectStaticResources = new List<string>();
            ShoppingList.projectLightningItems = new List<string>();
            ShoppingList.projectLwcItems = new List<string>();
            ShoppingList.testClasses = new List<ApexClassStub>();
            ShoppingList.currentTestsJobId = null;

            ShoppingList.restServicesBaseUri = null;
            ShoppingList.serverUrl = null;
            ShoppingList.staticResourcesRootDir = null;
            ShoppingList.toolingService = null;
            ShoppingList.toolingApiLoginUri = null;
            ShoppingList.workspaceDir = null;
        }
    }
}
