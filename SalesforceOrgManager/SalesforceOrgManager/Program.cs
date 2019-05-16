using System;
using System.Windows.Forms;
using SfTooling.com.salesforce.tooling;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using SalesforceOrgManager.Model;
using System.Xml;
using System.Threading.Tasks;
using System.Linq;
using System.IO.Compression;
using System.Text;

namespace SalesforceOrgManager
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShoppingList.principalePointer = new View.Principale();
            Application.Run(ShoppingList.principalePointer);
        }

        //--------- PROJECT RELATED METHODS -- START ----
        public static void initProject(string projName)
        {
            ShoppingList.projectRootDir = projName;
            ShoppingList.projectName = Path.GetFileName(ShoppingList.projectRootDir);
            ShoppingList.projectOrgContentRootDir = ShoppingList.projectRootDir + "\\force-app\\main\\default";
            ShoppingList.orgManifest = ShoppingList.projectOrgContentRootDir + "\\package.xml";
            //ShoppingList.orgManifest = ShoppingList.projectRootDir + "\\manifest\\package.xml";
            ShoppingList.classesRootDir = ShoppingList.projectOrgContentRootDir + "\\classes";
            ShoppingList.pagesRootDir = ShoppingList.projectOrgContentRootDir + "\\pages";
            ShoppingList.triggersRootDir = ShoppingList.projectOrgContentRootDir + "\\triggers";
            ShoppingList.staticResourcesRootDir = ShoppingList.projectOrgContentRootDir + "\\staticresources";
            ShoppingList.auraRootDir = ShoppingList.projectOrgContentRootDir + "\\aura";
            ShoppingList.lwcRootDir = ShoppingList.projectOrgContentRootDir + "\\lwc";
        }
        public static void createNewProject()
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C sfdx force:project:create --projectname " + ShoppingList.projectName + " --outputdir " + ShoppingList.workspaceDir;
            using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
        }
        public static void createManifestForNewProject()
        {
            string manifestTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            manifestTemplate += "<Package xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
            manifestTemplate += "<version>45.0</version>";
            manifestTemplate += "</Package>";

            File.AppendAllText(ShoppingList.orgManifest, manifestTemplate);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(ShoppingList.orgManifest);
            xmlDocument.Save(ShoppingList.orgManifest);
        }
        public static void readExistingProjectContent()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(ShoppingList.orgManifest);

            // create ns manager
            XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlnsManager.AddNamespace("a", "http://soap.sforce.com/2006/04/metadata");

            // Retrieve classes, pages, static reources already present in the project
            XmlNodeList classNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='ApexClass']//a:members", xmlnsManager);
            XmlNodeList pageNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='ApexPage']//a:members", xmlnsManager);
            XmlNodeList triggerNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='ApexTrigger']//a:members", xmlnsManager);
            XmlNodeList staticResourceNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='StaticResource']//a:members", xmlnsManager);
            XmlNodeList bundleNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='AuraDefinitionBundle']//a:members", xmlnsManager);
            XmlNodeList lwcNodeList = xmlDocument.DocumentElement.SelectNodes("//a:types[a:name='LightningComponentBundle']//a:members", xmlnsManager);

            // Put all the stuff in the Shopping List
            foreach (XmlNode node in classNodeList) {ShoppingList.projectClasses.Add(node.InnerText);}
            foreach (XmlNode node in pageNodeList) {ShoppingList.projectPages.Add(node.InnerText);}
            foreach (XmlNode node in triggerNodeList) {ShoppingList.projectTriggers.Add(node.InnerText);}
            foreach (XmlNode node in staticResourceNodeList) {ShoppingList.projectStaticResources.Add(node.InnerText);}
            foreach (XmlNode node in bundleNodeList) {ShoppingList.projectLightningItems.Add(node.InnerText);}
            foreach (XmlNode node in lwcNodeList) {ShoppingList.projectLwcItems.Add(node.InnerText);}
        }
        public static void updateCurrentProject(List<ApexClassStub> classes, List<ApexPageStub> pages, List<ApexTriggerStub> triggers, List<ApexStaticResourceStub> staticResources, List<LightningItemBundle> bundles, List<LightningWebComponentStub> lwcs)
        {
            if (!Directory.Exists(ShoppingList.classesRootDir)) {Directory.CreateDirectory(ShoppingList.classesRootDir);}
            if (!Directory.Exists(ShoppingList.pagesRootDir)) {Directory.CreateDirectory(ShoppingList.pagesRootDir);}
            if (!Directory.Exists(ShoppingList.triggersRootDir)) {Directory.CreateDirectory(ShoppingList.triggersRootDir);}
            if (!Directory.Exists(ShoppingList.staticResourcesRootDir)) {Directory.CreateDirectory(ShoppingList.staticResourcesRootDir);}
            if (!Directory.Exists(ShoppingList.auraRootDir)) {Directory.CreateDirectory(ShoppingList.auraRootDir);}
            if (!Directory.Exists(ShoppingList.lwcRootDir)) {Directory.CreateDirectory(ShoppingList.lwcRootDir);}

            string[] classFiles = Directory.GetFiles(ShoppingList.classesRootDir);
            string[] pageFiles = Directory.GetFiles(ShoppingList.pagesRootDir);
            string[] triggerFiles = Directory.GetFiles(ShoppingList.triggersRootDir);
            string[] staticResourceFiles = Directory.GetFiles(ShoppingList.staticResourcesRootDir);
            string[] staticResourceDirs = Directory.GetDirectories(ShoppingList.staticResourcesRootDir);
            string[] bundleFiles = Directory.GetFiles(ShoppingList.auraRootDir);
            string[] bundleDirs = Directory.GetDirectories(ShoppingList.auraRootDir);
            string[] lwcFiles = Directory.GetFiles(ShoppingList.lwcRootDir);
            string[] lwcDirs = Directory.GetDirectories(ShoppingList.lwcRootDir);

            foreach (string f in classFiles) {File.Delete(f);}
            foreach (string f in pageFiles) {File.Delete(f);}
            foreach (string f in triggerFiles) {File.Delete(f);}
            foreach (string f in staticResourceFiles) {File.Delete(f);}
            foreach (string f in staticResourceDirs) {Directory.Delete(f, true);}
            foreach (string f in bundleFiles) {File.Delete(f);}
            foreach (string f in bundleDirs) {Directory.Delete(f, true);}
            foreach (string f in lwcFiles) {File.Delete(f);}
            foreach (string f in lwcDirs) {Directory.Delete(f, true);}

            if (classes!=null)
            {
                string classesMetadataTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                classesMetadataTemplate += "<ApexClass xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
                classesMetadataTemplate += "<apiVersion>45.0</apiVersion>";
                classesMetadataTemplate += "<status>Active</status>";
                classesMetadataTemplate += "</ApexClass>";

                foreach (ApexClassStub acs in classes)
                {
                    File.AppendAllText(ShoppingList.classesRootDir + "\\" + acs.Name + ".cls", acs.Body);
                    File.AppendAllText(ShoppingList.classesRootDir + "\\" + acs.Name + ".cls-meta.xml", classesMetadataTemplate);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(ShoppingList.classesRootDir + "\\" + acs.Name + ".cls-meta.xml");

                    using (var writer = new XmlTextWriter(ShoppingList.classesRootDir + "\\" + acs.Name + ".cls-meta.xml", new UTF8Encoding(false)))
                    {
                        writer.Formatting = Formatting.Indented;
                        xmlDocument.Save(writer);
                    }
                }
            }
            if (pages!=null)
            {
                string pagesMetadataTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                pagesMetadataTemplate += "<ApexPage xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
                pagesMetadataTemplate += "<apiVersion>45.0</apiVersion>";
                pagesMetadataTemplate += "<availableInTouch>false</availableInTouch>";
                pagesMetadataTemplate += "<confirmationTokenRequired>false</confirmationTokenRequired>";
                pagesMetadataTemplate += "<label>XXXPAGEXXX</label>";
                pagesMetadataTemplate += "</ApexPage>";

                foreach (ApexPageStub aps in pages)
                {
                    string atemplate = pagesMetadataTemplate.Replace("XXXPAGEXXX", aps.Name);
                    File.AppendAllText(ShoppingList.pagesRootDir + "\\" + aps.Name + ".page", aps.Body);
                    File.AppendAllText(ShoppingList.pagesRootDir + "\\" + aps.Name + ".page-meta.xml", atemplate);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(ShoppingList.pagesRootDir + "\\" + aps.Name + ".page-meta.xml");
                    xmlDocument.Save(ShoppingList.pagesRootDir + "\\" + aps.Name + ".page-meta.xml");

                    using (var writer = new XmlTextWriter(ShoppingList.pagesRootDir + "\\" + aps.Name + ".page-meta.xml", new UTF8Encoding(false)))
                    {
                        writer.Formatting = Formatting.Indented;
                        xmlDocument.Save(writer);
                    }
                }
            }
            if (triggers!=null)
            {
                string triggersMetadataTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                triggersMetadataTemplate += "<ApexTrigger xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
                triggersMetadataTemplate += "<apiVersion>45.0</apiVersion>";
                triggersMetadataTemplate += "<status>active</status>";
                triggersMetadataTemplate += "</ApexTrigger>";

                foreach (ApexTriggerStub ats in triggers)
                {
                    File.AppendAllText(ShoppingList.triggersRootDir + "\\" + ats.Name + ".trigger", ats.Body);
                    File.AppendAllText(ShoppingList.triggersRootDir + "\\" + ats.Name + ".trigger-meta.xml", triggersMetadataTemplate);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(ShoppingList.triggersRootDir + "\\" + ats.Name + ".trigger-meta.xml");

                    using (var writer = new XmlTextWriter(ShoppingList.triggersRootDir + "\\" + ats.Name + ".trigger-meta.xml", new UTF8Encoding(false)))
                    {
                        writer.Formatting = Formatting.Indented;
                        xmlDocument.Save(writer);
                    }
                }
            }
            if (staticResources!=null)
            {
                foreach (ApexStaticResourceStub asr in staticResources)
                {
                    string resourcesMetadataTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                    resourcesMetadataTemplate += "<StaticResource xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
                    resourcesMetadataTemplate += "<cacheControl>" + asr.CacheControl + "</cacheControl>";
                    resourcesMetadataTemplate += "<contentType>" + asr.ContentType + "</contentType>";
                    resourcesMetadataTemplate += "<description>" + asr.Description + "</description>";
                    resourcesMetadataTemplate += "</StaticResource>";

                    if (asr.SingleFile)
                    {
                        string txtContent = Program.getStaticResourceTextContent(asr.Id);
                        File.AppendAllText(ShoppingList.staticResourcesRootDir + "\\" + asr.Name + ".resource", txtContent);
                    }
                    else
                    {
                        if (!Directory.Exists(ShoppingList.staticResourcesRootDir + "\\" + asr.Name))
                        {
                            Directory.CreateDirectory(ShoppingList.staticResourcesRootDir + "\\" + asr.Name);
                        }
                        var destinationDirectory = ShoppingList.staticResourcesRootDir;
                        var tmpZip = ShoppingList.staticResourcesRootDir + "\\" + asr.Name + "\\tmp.zip";
                        var fileStream = File.Create(tmpZip);
                        Program.getStaticResourceZipContent(asr.Id).CopyTo(fileStream);
                        fileStream.Close();
                        ZipFile.ExtractToDirectory(tmpZip, destinationDirectory);
                        File.Delete(tmpZip);
                    }
                    File.AppendAllText(ShoppingList.staticResourcesRootDir + "\\" + asr.Name + ".resource-meta.xml", resourcesMetadataTemplate);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(ShoppingList.staticResourcesRootDir + "\\" + asr.Name + ".resource-meta.xml");

                    using (var writer = new XmlTextWriter(ShoppingList.staticResourcesRootDir + "\\" + asr.Name + ".resource-meta.xml", new UTF8Encoding(false)))
                    {
                        writer.Formatting = Formatting.Indented;
                        xmlDocument.Save(writer);
                    }
                }
            }
            if (bundles!=null)
            {
                foreach (LightningItemBundle lib in bundles)
                {
                    string bundlesMetadataTemplate = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                    bundlesMetadataTemplate += "<AuraDefinitionBundle xmlns=\"http://soap.sforce.com/2006/04/metadata\">";
                    bundlesMetadataTemplate += "<apiVersion>" + lib.Apiversion + "</apiVersion>";
                    bundlesMetadataTemplate += "<description>" + lib.Description + "</description>";
                    bundlesMetadataTemplate += "</AuraDefinitionBundle>";
                    if (!Directory.Exists(ShoppingList.auraRootDir + "\\" + lib.MasterLabel))
                    {
                        Directory.CreateDirectory(ShoppingList.auraRootDir + "\\" + lib.MasterLabel);
                    }
                    List<LightningItemDefinition> lightningItemDefinitions = Program.retrieveLightningDefinitions(lib);

                    foreach(LightningItemDefinition lid in lightningItemDefinitions)
                    {
                        string ext = "";
                        switch(lid.DefType)
                        {
                            case "APPLICATION":
                                ext = "app";
                                Program.createLightningMetafile(ShoppingList.auraRootDir, lib.MasterLabel, ext, bundlesMetadataTemplate);
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "COMPONENT":
                                ext = "cmp";
                                Program.createLightningMetafile(ShoppingList.auraRootDir, lib.MasterLabel, ext, bundlesMetadataTemplate);
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "EVENT":
                                ext = "evt";
                                Program.createLightningMetafile(ShoppingList.auraRootDir, lib.MasterLabel, ext, bundlesMetadataTemplate);
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "INTERFACE":
                                ext = "intf";
                                Program.createLightningMetafile(ShoppingList.auraRootDir, lib.MasterLabel, ext, bundlesMetadataTemplate);
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "CONTROLLER":
                                ext = "js";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel + "Controller", ext, lid.Source);
                                break;
                            case "HELPER":
                                ext = "js";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel + "Helper", ext, lid.Source);
                                break;
                            case "STYLE":
                                ext = "css";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "DOCUMENTATION":
                                ext = "auradoc";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                            case "RENDERER":
                                ext = "js";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel + "Renderer", ext, lid.Source);
                                break;
                            case "SVG":
                                ext = "svg";
                                Program.createLightningItemFile(ShoppingList.auraRootDir, lib.MasterLabel, lib.MasterLabel, ext, lid.Source);
                                break;
                        }
                    }
                }
            }
            if (lwcs != null)
            {
                foreach (LightningWebComponentStub lwc in lwcs)
                {
                    LightningWebComponentStub.LwcResourceStub resource = null;
                    try
                    {
                        resource = lwc.lwcResources.Where(x => x.filePath.Contains("js-meta.xml")).ToList<LightningWebComponentStub.LwcResourceStub>()[0];
                    }
                    catch(Exception ex)
                    {
                        resource = new LightningWebComponentStub.LwcResourceStub("lwc/" + lwc.masterLabel +
                            "/" + lwc.masterLabel + ".js-meta.xml", 
                            System.Text.Encoding.UTF8.GetBytes(createDefaultJsMetaForLwc(lwc.masterLabel)), 
                            createDefaultJsMetaForLwc(lwc.masterLabel));
                    }
                    string lwcMetadataTemplate = resource.resourceText;

                    if (!Directory.Exists(ShoppingList.lwcRootDir + "\\" + lwc.masterLabel))
                    {
                        Directory.CreateDirectory(ShoppingList.lwcRootDir + "\\" + lwc.masterLabel);
                    }
                    foreach (LightningWebComponentStub.LwcResourceStub lwcr in lwc.lwcResources)
                    {
                        if (!lwcr.filePath.Contains(".js-meta.xml"))
                        {
                            string[] extT = lwcr.filePath.Split('.');
                            string ext = extT[extT.Length - 1];
                            Program.createLightningItemFile(ShoppingList.lwcRootDir, lwc.masterLabel, lwc.masterLabel, ext, lwcr.resourceText);
                        }
                    }
                    Program.createLightningMetafile(ShoppingList.lwcRootDir, lwc.masterLabel, "js", lwcMetadataTemplate);
                }
            }
        }
        public static void updateManifestFile(List<ApexClassStub> classes, List<ApexPageStub> pages, List<ApexTriggerStub> triggers, List<ApexStaticResourceStub> staticResources, List<LightningItemBundle> bundles, List<LightningWebComponentStub> lwcs)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(ShoppingList.orgManifest);

            // create ns manager
            XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xmlDocument.NameTable);
            xmlnsManager.AddNamespace("a", "http://soap.sforce.com/2006/04/metadata");
            xmlDocument.DocumentElement.RemoveAll();

            XmlNode nodeTypesClass = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");
            XmlNode nodeTypesPage = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");
            XmlNode nodeTypesTrigger = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");
            XmlNode nodeTypesResource = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");
            XmlNode nodeTypesBundle = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");
            XmlNode nodeTypesLwc = xmlDocument.CreateNode(XmlNodeType.Element, "types", "");

            XmlNode nodeVersion = xmlDocument.CreateNode(XmlNodeType.Element, "version", "");

            XmlNode classRoot = null;
            XmlNode pageRoot = null;
            XmlNode triggerRoot = null;
            XmlNode resourceRoot = null;
            XmlNode bundleRoot = null;
            XmlNode lwcRoot = null;

            // Clean Shopping list from org elements
            ShoppingList.projectClasses.Clear();
            ShoppingList.projectPages.Clear();
            ShoppingList.projectTriggers.Clear();
            ShoppingList.projectStaticResources.Clear();
            ShoppingList.projectLightningItems.Clear();
            ShoppingList.projectLwcItems.Clear();

            if (classes!=null) {classRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesClass);}
            if (pages!=null) {pageRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesPage);}
            if (triggers!=null) {triggerRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesTrigger);}
            if (staticResources!=null) {resourceRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesResource);}
            if (bundles!=null) {bundleRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesBundle);}
            if (lwcs!=null) {lwcRoot = xmlDocument.DocumentElement.AppendChild(nodeTypesLwc);}

            nodeVersion.InnerText = "45.0";
            xmlDocument.DocumentElement.AppendChild(nodeVersion);

            // Add class nodes
            if (classes!=null)
            {
                foreach (ApexClassStub stub in classes)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.Name;
                    classRoot.AppendChild(nodeMembers);
                    ShoppingList.projectClasses.Add(stub.Name);
                }
                XmlNode classNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                classNodeName.InnerText = "ApexClass";
                classRoot.AppendChild(classNodeName);
            }
            // Add page nodes
            if (pages!=null)
            {
                foreach (ApexPageStub stub in pages)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.Name;
                    pageRoot.AppendChild(nodeMembers);
                    ShoppingList.projectPages.Add(stub.Name);
                }
                XmlNode pageNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                pageNodeName.InnerText = "ApexPage";
                pageRoot.AppendChild(pageNodeName);
            }
            // Add trigger nodes
            if (triggers!=null)
            {
                foreach (ApexTriggerStub stub in triggers)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.Name;
                    triggerRoot.AppendChild(nodeMembers);
                    ShoppingList.projectTriggers.Add(stub.Name);
                }
                XmlNode triggerNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                triggerNodeName.InnerText = "ApexTrigger";
                triggerRoot.AppendChild(triggerNodeName);
            }
            // Add static resource nodes
            if (staticResources!=null)
            {
                foreach (ApexStaticResourceStub stub in staticResources)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.Name;
                    resourceRoot.AppendChild(nodeMembers);
                    ShoppingList.projectStaticResources.Add(stub.Name);
                }
                XmlNode resourceNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                resourceNodeName.InnerText = "StaticResource";
                resourceRoot.AppendChild(resourceNodeName);
            }
            // Add lightning bundle nodes
            if (bundles != null)
            {
                foreach (LightningItemBundle stub in bundles)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.MasterLabel;
                    bundleRoot.AppendChild(nodeMembers);
                    ShoppingList.projectLightningItems.Add(stub.MasterLabel);
                }
                XmlNode bundleNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                bundleNodeName.InnerText = "AuraDefinitionBundle";
                bundleRoot.AppendChild(bundleNodeName);
            }
            // Add lightning web component nodes
            if (lwcs != null)
            {
                foreach (LightningWebComponentStub stub in lwcs)
                {
                    XmlNode nodeMembers = xmlDocument.CreateNode(XmlNodeType.Element, "members", "");
                    nodeMembers.InnerText = stub.masterLabel;
                    lwcRoot.AppendChild(nodeMembers);
                    ShoppingList.projectLwcItems.Add(stub.masterLabel);
                }
                XmlNode lwcNodeName = xmlDocument.CreateNode(XmlNodeType.Element, "name", "");
                lwcNodeName.InnerText = "LightningComponentBundle";
                lwcRoot.AppendChild(lwcNodeName);
            }
            // Save changes to manifest file
            xmlDocument.InnerXml = xmlDocument.InnerXml.Replace(" xmlns=\"\"", "");
            using (var writer = new XmlTextWriter(ShoppingList.orgManifest, new UTF8Encoding(false)))
            {
                writer.Formatting = Formatting.Indented;
                xmlDocument.Save(writer);
            }
        }
        //--------- PROJECT RELATED METHODS -- END ----

        //--------- PROJECT DATA RETRIEVE METHODS -- START ----
        public static List<ApexClassStub> retrieveClasses()
        {
            List<ApexClassStub> retValue = new List<ApexClassStub>();
            ShoppingList.testClasses.Clear();
            string retrieveQuery = "SELECT Id, Name, Body FROM ApexClass ORDER BY Name";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string name = Convert.ToString(otemp["Name"]);
                    string body = Convert.ToString(otemp["Body"]);
                    bool isTest = false;
                    if (body.Contains("testMethod") || body.Contains("@isTest"))
                    {
                        isTest = true;
                    }
                    ApexClassStub tmpStub = new ApexClassStub(id, name, body, isTest);
                    retValue.Add(tmpStub);
                    if (tmpStub.IsTest) { ShoppingList.testClasses.Add(tmpStub); }
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<ApexPageStub> retrievePages()
        {
            List<ApexPageStub> retValue = new List<ApexPageStub>();
            string retrieveQuery = "SELECT Id, Name, Markup FROM ApexPage ORDER BY Name";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string name = Convert.ToString(otemp["Name"]);
                    string body = Convert.ToString(otemp["Markup"]);
                    retValue.Add(new ApexPageStub(id, name, body));
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<ApexTriggerStub> retrieveTriggers()
        {
            List<ApexTriggerStub> retValue = new List<ApexTriggerStub>();
            string retrieveQuery = "SELECT Id, Name, Body FROM ApexTrigger ORDER BY Name";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string name = Convert.ToString(otemp["Name"]);
                    string body = Convert.ToString(otemp["Body"]);
                    retValue.Add(new ApexTriggerStub(id, name, body));
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<ApexStaticResourceStub> retrieveStaticResources()
        {
            List<ApexStaticResourceStub> retValue = new List<ApexStaticResourceStub>();
            string retrieveQuery = "SELECT Id, Name, Body, CacheControl, ContentType, Description FROM StaticResource";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string name = Convert.ToString(otemp["Name"]);
                    string body = Convert.ToString(otemp["Body"]);
                    string cacheControl = Convert.ToString(otemp["CacheControl"]);
                    string contentType = Convert.ToString(otemp["ContentType"]);
                    string description = Convert.ToString(otemp["Description"]);
                    bool isSingleFile = !Program.contentIsZip(contentType);
                    retValue.Add(new ApexStaticResourceStub(id, name, body, cacheControl, contentType, description, isSingleFile));
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<LightningItemBundle> retrieveLightningItems()
        {
            List<LightningItemBundle> retValue = new List<LightningItemBundle>();
            string retrieveQuery = "SELECT Id, ApiVersion, DeveloperName, MasterLabel, Description FROM AuraDefinitionBundle ORDER BY MasterLabel";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string masterLabel = Convert.ToString(otemp["MasterLabel"]);
                    double apiVersion = Convert.ToDouble(otemp["ApiVersion"]);
                    string developerName = Convert.ToString(otemp["DeveloperName"]);
                    string description = Convert.ToString(otemp["Description"]);
                    retValue.Add(new LightningItemBundle(id, apiVersion, developerName, masterLabel, description));
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<LightningWebComponentStub> retrieveLightningWebComponents()
        {
            List<LightningWebComponentStub> retValue = new List<LightningWebComponentStub>();
            string retrieveQuery = "SELECT Id, MasterLabel, ApiVersion, Description, IsExposed, TargetConfigs FROM LightningComponentBundle ORDER BY MasterLabel";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string masterLabel = Convert.ToString(otemp["MasterLabel"]);
                    double apiVersion = Convert.ToDouble(otemp["ApiVersion"]);
                    string description = Convert.ToString(otemp["Description"]);
                    bool isExposed = Convert.ToBoolean(otemp["IsExposed"]);
                    string targetConfigs = Convert.ToString(otemp["TargetConfigs"]);

                    string retrieveQueryMt = "SELECT Metadata FROM LightningComponentBundle WHERE Id = '" + id + "'";
                    Dictionary<string, object> queryInformationMt = Program.getApiRecords(false, "/query/?q=" + retrieveQueryMt);
                    object[] records2 = (object[])queryInformationMt["records"];
                    Dictionary<string, object> otemp2 = (Dictionary<string, object>)records2[0];
                    Dictionary<string, object> mt = otemp2["Metadata"] as Dictionary<string, object>;

                    List<object> targets = (mt["targets"] == null) ? null : ((IEnumerable<object>)((Dictionary<string, object>)mt["targets"])["target"]).ToList<object>();
                    Dictionary<string, object> lwcResources = mt["lwcResources"] as Dictionary<string, object>;
                    List<object> resources = ((IEnumerable<object>)lwcResources["lwcResource"]).ToList<object>();
                    List<LwcResource> outResources = new List<LwcResource>();
                    List<string> outResourcesText = new List<string>();

                    foreach (object rr in resources)
                    {
                        Dictionary<string, object> tmp1 = (Dictionary<string, object>)rr;
                        string fPath = Convert.ToString(tmp1["filePath"]);

                        if (!fPath.Contains(".js-meta.xml"))
                        {
                            string xSource = Convert.ToString(((Dictionary<string, object>)tmp1["source"])["asByteArray"]);
                            byte[] bSource = System.Convert.FromBase64String(xSource);
                            string fSource = System.Text.Encoding.UTF8.GetString(bSource);
                            LwcResource l1 = new LwcResource();
                            l1.filePath = fPath;
                            l1.source = bSource;
                            outResources.Add(l1);
                            outResourcesText.Add(fSource);
                        }
                        else
                        {
                            string fSource = createDefaultJsMetaForLwc(masterLabel);
                            byte[] bSource = System.Text.Encoding.UTF8.GetBytes(fSource);
                            LwcResource l1 = new LwcResource();
                            l1.filePath = fPath;
                            l1.source = bSource;
                            outResources.Add(l1);
                            outResourcesText.Add(fSource);
                        }
                    }
                    LightningWebComponentStub lwc = new LightningWebComponentStub(id, apiVersion, masterLabel, description, isExposed, targetConfigs, outResources.ToArray(), targets, outResourcesText);
                    retValue.Add(lwc);
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        public static List<string> retrieveOrgEntities()
        {
            List<string> retValue = new List<string>();
            string retrieveQuery = "SELECT Id, QualifiedApiName FROM EntityDefinition WHERE IsTriggerable = true ORDER BY QualifiedApiName";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string id = Convert.ToString(otemp["Id"]);
                    string name = Convert.ToString(otemp["QualifiedApiName"]);
                    retValue.Add(name);
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        private static List<LightningItemDefinition> retrieveLightningDefinitions(LightningItemBundle bundle)
        {
            List<LightningItemDefinition> retValue = new List<LightningItemDefinition>();
            string retrieveQuery = "SELECT DefType, Format, Source FROM AuraDefinition WHERE AuraDefinitionBundleId = '" + bundle.Id + "'";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);

            do
            {
                object[] records = (object[])queryInformation["records"];
                foreach (object o in records)
                {
                    Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                    string defType = Convert.ToString(otemp["DefType"]);
                    string format = Convert.ToString(otemp["Format"]);
                    string source = Convert.ToString(otemp["Source"]);
                    retValue.Add(new LightningItemDefinition(defType, format, source));
                }
                if (!queryInformation.ContainsKey("nextRecordsUrl")) break;
                string retrieveQueryUri = (string)queryInformation["nextRecordsUrl"];
                retrieveQuery = retrieveQueryUri.Substring(retrieveQueryUri.LastIndexOf("/") + 1);
                queryInformation = Program.getApiRecords(false, "/query/" + retrieveQuery);
            } while (true);
            return retValue;
        }
        private static List<string> retrieveItemNameFromId(string itemId)
        {
            List<string> retValue = new List<string>();
            string retrieveQuery = "SELECT Name FROM ApexClass WHERE Id = '" + itemId + "'";
            Dictionary<string, object> queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery.Replace("\"", ""));

            if (Convert.ToInt32(queryInformation["size"]) == 0)
            {
                // Item is not an ApexClass ==> new tentative for Apex Trigger
                retrieveQuery = "SELECT Name FROM ApexTrigger WHERE Id = '" + itemId + "'";
                queryInformation = Program.getApiRecords(false, "/query/?q=" + retrieveQuery.Replace("\"", ""));
                retValue.Add("trigger");
            }
            else
            {
                retValue.Add("class");
            }
            object[] records = (object[])queryInformation["records"];
            foreach (object o in records)
            {
                Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                retValue.Add(Convert.ToString(otemp["Name"]));
            }
            return retValue;
        }
        //--------- PROJECT DATA RETRIEVE METHODS -- END ----

        //--------- PROJECT DATA CREATE METHODS -- START ----
        public static async Task createApexClassAsync(View.BoxCreazioneClasse bc)
        {
            String operationResult = "";
            String clsName = bc.txtItemName.Text;
            ApexClass1 theNewClass = new ApexClass1();
            theNewClass.Body = "public with sharing class " + bc.txtItemName.Text + "{\n // TODO implemententation\n}";
            ApexClass1[] classes = {theNewClass};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(classes);

            if (result[0].errors == null)
            {
                operationResult += "Apex class " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during apex class creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();
            if (result[0].errors == null)
            {
                ShoppingList.projectClasses.Add(bc.txtItemName.Text);
                ApexClassStub acs = new ApexClassStub(result[0].id, clsName, theNewClass.Body, false);
                ShoppingList.orgTreePointer.updateProjectProcessReverse(acs);
            }
        }
        public static async Task createApexPageAsync(View.BoxCreazioneVisualforce bc)
        {
            String operationResult = "";
            ApexPage1 theNewPage = new ApexPage1();
            theNewPage.Name = bc.txtItemName.Text;
            theNewPage.Markup = "<apex:page showHeader=\"false\" readOnly=\"true\" applyBodyTag=\"false\" cache=\"true\">\n</apex:page>";
            theNewPage.MasterLabel = bc.txtItemName.Text;
            ApexPage1[] pages = {theNewPage};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(pages);

            if (result[0].errors == null)
            {
                operationResult += "Apex page " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during apex page creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();

            if (result[0].errors == null)
            {
                ShoppingList.projectPages.Add(bc.txtItemName.Text);
                ApexPageStub aps = new ApexPageStub(result[0].id, theNewPage.Name, theNewPage.Markup);
                ShoppingList.orgTreePointer.updateProjectProcessReverse(aps);
            }
        }
        public static async Task createApexTriggerAsync(View.BoxCreazioneTrigger bc)
        {
            String operationResult = "";
            ApexTrigger1 theNewTrigger = new ApexTrigger1();
            theNewTrigger.Name = bc.txtItemName.Text;
            theNewTrigger.TableEnumOrId = Convert.ToString(bc.cmbObjects.SelectedItem);

            List<string> selectedEvents = bc.chkEvents.CheckedItems.OfType<string>().ToList();
            string sEvents = "";
            foreach(string s in selectedEvents) {sEvents += s + ",";}
            sEvents = sEvents.Substring(0, sEvents.Length - 1);

            theNewTrigger.Body = "trigger " + bc.txtItemName.Text + " on " + theNewTrigger.TableEnumOrId + "(" + sEvents + ") {}";

            ApexTrigger1[] triggers = {theNewTrigger};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(triggers);

            if (result[0].errors == null)
            {
                operationResult += "Apex trigger " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during apex trigger creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();

            if (result[0].errors == null)
            {
                ShoppingList.projectTriggers.Add(bc.txtItemName.Text);
                ApexTriggerStub ats = new ApexTriggerStub(result[0].id, theNewTrigger.Name, theNewTrigger.Body);
                ShoppingList.orgTreePointer.updateProjectProcessReverse(ats);
            }
        }
        public static async Task createApexStaticResourceAsync(View.BoxCreazioneRisorsaStatica bc)
        {
            String operationResult = "";
            StaticResource1 theNewResource = new StaticResource1();
            theNewResource.Name = bc.txtItemName.Text;

            if (bc.chkSingleFile.Checked)
            {
                string tmp = "some content here";
                theNewResource.Body = System.Text.Encoding.UTF8.GetBytes(tmp);
                theNewResource.ContentType = "text/plain";
            }
            else
            {
                //atps
                Directory.CreateDirectory(ShoppingList.projectRootDir + "\\" + bc.txtItemName.Text);
                File.AppendAllText(ShoppingList.projectRootDir + "\\" + bc.txtItemName.Text + "\\content.txt", "some content here");
                ZipFile.CreateFromDirectory(ShoppingList.projectRootDir + "\\" + bc.txtItemName.Text,
                    ShoppingList.projectRootDir + "\\" + "zuppo.zip",
                    CompressionLevel.Fastest, true);
                theNewResource.Body = (File.ReadAllBytes(ShoppingList.projectRootDir + "\\zuppo.zip"));
                File.Delete(ShoppingList.projectRootDir + "\\" + "zuppo.zip");
                Directory.Delete(ShoppingList.projectRootDir + "\\" + bc.txtItemName.Text,true);
                theNewResource.ContentType = "application/zip";
            }
            theNewResource.Description = "some description here";
            theNewResource.CacheControl = "Public";
            
            StaticResource1[] resources = {theNewResource};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(resources);

            if (result[0].errors == null)
            {
                operationResult += "Apex static resource " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during apex static resource creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();

            if (result[0].errors == null)
            {
                ShoppingList.projectStaticResources.Add(bc.txtItemName.Text);
                ApexStaticResourceStub ars = new ApexStaticResourceStub(result[0].id,
                    theNewResource.Name, theNewResource.Body.ToString(), theNewResource.CacheControl,
                    theNewResource.ContentType, theNewResource.Description, bc.chkSingleFile.Checked);
                ShoppingList.orgTreePointer.updateProjectProcessReverse(ars);
            }
        }
        public static async Task createLightningItemAsync(View.BoxCreazioneLightning bc, string itemType)
        {
            string operationLog = "";
            string operationResult = "";
            SfTooling.com.salesforce.tooling.SaveResult result = Program.createLightningBundle(bc);

            if (result.errors == null)
            {
                operationResult += "Aura definition bundle " + bc.txtItemName.Text + " created successfully!";
                string newBundleId = result.id;
                List<string> selectedDefinitionTypes = bc.chkDefinitionType.CheckedItems.OfType<string>().ToList();
                Program.createLightningDefinitionType(newBundleId, itemType);

                if (itemType.Equals("APPLICATION") || itemType.Equals("COMPONENT"))
                {
                    foreach (string def in selectedDefinitionTypes)
                    {
                        SfTooling.com.salesforce.tooling.SaveResult result2 = Program.createLightningDefinitionType(newBundleId, def);
                        if (result2.errors != null)
                        {
                            operationLog += "Error during aura app creation\n";
                            operationLog += "Error trace is:" + result2.errors[0].message + "\n";
                        }
                    }
                }
            }
            else
            {
                operationResult += "Error during aura definition bundle creation\n";
                operationResult += "Error trace is:" + result.errors[0].message + "\n";
            }
            //-----------------------------
            bool errorOccurred = false;
            if (operationLog.Equals(""))
            {
                operationLog += "Aura App " + bc.txtItemName.Text + " created successfully!\n";
            }
            else
            {
                errorOccurred = true;
            }
            bc.txtLog.Text = operationResult + operationLog;

            if (!errorOccurred)
            {
                ShoppingList.projectLightningItems.Add(bc.txtItemName.Text);
                LightningItemBundle lim = new LightningItemBundle(result.id, 
                    Convert.ToDouble(bc.cmbVersions.SelectedItem), Convert.ToString(bc.txtItemName.Text),
                    Convert.ToString(bc.txtItemName.Text), Convert.ToString(bc.txtItemDescription.Text));
                await Task.Delay(3000);
                bc.Close();
                ShoppingList.orgTreePointer.updateProjectProcessReverse(lim);
            }
        }
        public static async Task createLwcAsync(View.BoxCreazioneLwc bc) {
            String operationResult = "";

            LightningComponentBundle metadata = new LightningComponentBundle();
            metadata.masterLabel = bc.txtItemName.Text;
            metadata.apiVersion = 45.0;
            metadata.description = bc.txtItemDescription.Text;
            metadata.isExposed = true;
            metadata.targets = new string[] {"lightning__AppPage","lightning__HomePage","lightning__RecordPage"};

            const string htmlContent = "<template></template>";
            LwcResource lcrHTML = new LwcResource();
            lcrHTML.source = System.Text.Encoding.UTF8.GetBytes(htmlContent);
            lcrHTML.filePath = "lwc/" + bc.txtItemName.Text + "/" + bc.txtItemName.Text + ".html";

            string jsContent = "import { LightningElement } from 'lwc';\n\n" +
                "export default class " + bc.txtItemName.Text + " extends LightningElement { }";
            LwcResource lcrJs = new LwcResource();
            lcrJs.source = System.Text.Encoding.UTF8.GetBytes(jsContent);
            lcrJs.filePath = "lwc/" + bc.txtItemName.Text + "/" + bc.txtItemName.Text + ".js";

            LwcResource[] resources = {lcrHTML, lcrJs};
            List<string> resourcesText = new List<string>(new string[] { htmlContent, jsContent });
            metadata.lwcResources = resources;

            LightningComponentBundle1 lwc = new LightningComponentBundle1();
            lwc.FullName = bc.txtItemName.Text;
            lwc.Metadata = metadata;

            LightningComponentBundle1[] lwcBundles = {lwc};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(lwcBundles);

            if (result[0].errors == null)
            {
                operationResult += "Lightning web component " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during lightning web component creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();
            if (result[0].errors == null)
            {
                ShoppingList.projectLwcItems.Add(bc.txtItemName.Text);
                LightningWebComponentStub lwcc = 
                    new LightningWebComponentStub(result[0].id, metadata.apiVersion, metadata.masterLabel, metadata.description, 
                    metadata.isExposed, null, resources, metadata.targets.ToList<object>(), resourcesText);
                ShoppingList.orgTreePointer.updateProjectProcessReverse(lwcc);
            }
        }
        private static SfTooling.com.salesforce.tooling.SaveResult createLightningBundle(View.BoxCreazioneLightning bc)
        {
            AuraDefinitionBundle1 theAuraBundle = new AuraDefinitionBundle1();
            theAuraBundle.ApiVersion = Convert.ToDouble(bc.cmbVersions.SelectedItem);
            theAuraBundle.ApiVersionSpecified = true;
            theAuraBundle.DeveloperName = Convert.ToString(bc.txtItemName.Text);
            theAuraBundle.MasterLabel = Convert.ToString(bc.txtItemName.Text);
            theAuraBundle.Description = Convert.ToString(bc.txtItemDescription.Text);

            AuraDefinitionBundle1[] bundles = {theAuraBundle};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result = ShoppingList.toolingService.create(bundles);
            return result[0];
        }
        private static SfTooling.com.salesforce.tooling.SaveResult createLightningDefinitionType(string bundleId, string defType)
        {
            AuraDefinition auraDefinition = new AuraDefinition();
            auraDefinition.AuraDefinitionBundleId = bundleId;
            auraDefinition.DefType = defType;

            switch (defType)
            {
                case "APPLICATION":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<aura:application></aura:application>";
                    break;
                case "COMPONENT":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<aura:component></aura:component>";
                    break;
                case "EVENT":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<aura:event type=\"COMPONENT\" description=\"Event template\">\n";
                    auraDefinition.Source += "</aura:event>";
                    break;
                case "INTERFACE":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<aura:interface description=\"Interface template\">\n";
                    auraDefinition.Source += "<aura:attribute name=\"example\" type=\"String\" default=\"\" description=\"An example attribute.\"/>\n";
                    auraDefinition.Source += "</aura:interface>";
                    break;
                case "CONTROLLER":
                    auraDefinition.Format = "JS";
                    auraDefinition.Source = "({\n";
                    auraDefinition.Source += "\tdoInitWrapper: function(component, event, helper) {\n";
                    auraDefinition.Source += "\t\thelper.doInitWrapper(component, event, helper);\n";
                    auraDefinition.Source += "\t}\n";
                    auraDefinition.Source += "})";
                    break;
                case "HELPER":
                    auraDefinition.Format = "JS";
                    auraDefinition.Source = "({\n";
                    auraDefinition.Source += "\tdoInitWrapper: function(component, event, helper) {\n";
                    auraDefinition.Source += "\t\t//TODO: method implementation\n";
                    auraDefinition.Source += "\t}\n";
                    auraDefinition.Source += "})";
                    break;
                case "STYLE":
                    auraDefinition.Format = "CSS";
                    auraDefinition.Source = ".THIS {}";
                    break;
                case "DOCUMENTATION":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<aura:documentation>\n";
                    auraDefinition.Source += "\t<aura:description>Documentation</aura:description>\n";
                    auraDefinition.Source += "\t<aura:example name=\"ExampleName\" ref=\"exampleComponentName\" label=\"Label\">\n";
                    auraDefinition.Source += "\t\tExample Description\n";
                    auraDefinition.Source += "\t</aura:example>\n";
                    auraDefinition.Source += "</aura:documentation>";
                    break;
                case "RENDERER":
                    auraDefinition.Format = "JS";
                    auraDefinition.Source = "({\n";
                    auraDefinition.Source += "\t// TODO:Your renderer method overrides go here\n";
                    auraDefinition.Source += "})";
                    break;
                case "SVG":
                    auraDefinition.Format = "XML";
                    auraDefinition.Source = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n";
                    auraDefinition.Source += "<svg width=\"120px\" height=\"120px\" viewBox=\"0 0 120 120\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\">\n";
                    auraDefinition.Source += "</svg>";
                    break;
            }
            AuraDefinition[] definitions = {auraDefinition};
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.SaveResult[] result2 = ShoppingList.toolingService.create(definitions);
            return result2[0];
        }
        private static void createLightningMetafile(string rootDir, string fileName, string ext, string metadataTemplate)
        {
            File.AppendAllText(rootDir + "\\" + fileName + "\\" + fileName + "." + ext + "-meta.xml", metadataTemplate, new UTF8Encoding(false));
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(rootDir + "\\" + fileName + "\\" + fileName + "." + ext + "-meta.xml");
            xmlDocument.Save(rootDir + "\\" + fileName + "\\" + fileName + "." + ext + "-meta.xml");

            using (var writer = new XmlTextWriter(rootDir + "\\" + fileName + "\\" + fileName + "." + ext + "-meta.xml", new UTF8Encoding(false)))
            {
                writer.Formatting = Formatting.Indented;
                xmlDocument.Save(writer);
            }
        }
        private static void createLightningItemFile(string rootDir, string dirName, string fileName, string ext, string content)
        {
            File.AppendAllText(rootDir + "\\" + dirName + "\\" + fileName + "." + ext, content, new UTF8Encoding(false));
        }
        private static string createDefaultJsMetaForLwc(string labelName)
        {
            string retVal = "";
            retVal += "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
            retVal += "\t<LightningComponentBundle xmlns=\"http://soap.sforce.com/2006/04/metadata\" fqn=\"" + labelName + "\">\n";
            retVal += "\t<apiVersion>45.0</apiVersion>\n";
            retVal += "\t<isExposed>true</isExposed>\n";
            retVal += "\t<targets>\n";
            retVal += "\t<target>lightning__AppPage</target>\n";
            retVal += "\t<target>lightning__RecordPage</target>\n";
            retVal += "\t<target>lightning__HomePage</target>\n";
            retVal += "\t</targets>\n";
            retVal += "\t</LightningComponentBundle>";
            return retVal;
        }
        /*
        public static async Task deleteApexClassAsync(ApexClass1[] classes)
        {
            String operationResult = "";
            ShoppingList.toolingService.Url = ShoppingList.serverUrl;
            SfTooling.com.salesforce.tooling.DeleteResult[] result = ShoppingList.toolingService.delete(apexClassId);

            // Build a temp form -- START
            Form f = new Form();
            f.Width = 500;
            f.Text = "Delete Apex classes result";
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            Button button = new Button();
            button.Text = "OK";
            button.DialogResult = DialogResult.OK;
            button.Top = textBox.Top + 30;

            foreach (SfTooling.com.salesforce.tooling.DeleteResult dr in result)
            {
                bool success = dr.success;
                int x = 0;
            }

            f.Controls.Add(textBox);
            f.Controls.Add(button);
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                encKey = textBox.Text;
                f.Dispose();
            // Build a temp form -- END

                if (result[0].errors == null)
            {
                operationResult += "Apex class " + bc.txtItemName.Text + " created successfully!";
            }
            else
            {
                operationResult += "Error during apex class creation\n";
                operationResult += "Error trace is:" + result[0].errors[0].message;
            }
            bc.txtLog.Text = operationResult;
            await Task.Delay(3000);
            bc.Close();
            ShoppingList.projectClasses.Add(bc.txtItemName.Text);
            ShoppingList.orgTreePointer.updateProjectProcessReverse();
        }
        */
        //--------- PROJECT DATA CREATE METHODS -- END ----

        //--------- STATIC RESOURCE METHODS -- START ------
        private static Stream getStaticResourceZipContent(string contentId)
        {
            return runToolingRestCallout(false, "/sobjects/StaticResource/" + contentId + "/Body").GetResponseStream();
        }
        private static string getStaticResourceTextContent(string contentId)
        {
            StreamReader reader = new StreamReader(runToolingRestCallout(false, "/sobjects/StaticResource/" + contentId + "/Body").GetResponseStream(), System.Text.Encoding.UTF8);
            return reader.ReadToEnd();
        }
        private static bool contentIsZip(string contentType)
        {
            return contentType.Equals("application/zip") || contentType.Equals("application/x-zip") || contentType.Equals("application/x-zip-compressed");
        }
        //--------- STATIC RESOURCE METHODS -- END ------

        //--------- GENERAL UTILITY METHODS -- START ----
        public static object[] getWorkspaces()
        {
            return (object[])getConfigRecord("orgConfig", null)["workspaces"];
        }
        public static Dictionary<string, object> getLogins()
        {
            Dictionary<string, object> logins = new Dictionary<string, object>();
            try
            {
                logins = (Dictionary<string, object>)getConfigRecord("logins", null)["loginGroups"];
            }
            catch (Exception ex)
            {
                if (logins.ContainsKey("FAILED"))
                {
                    logins.Remove("FAILED");
                    logins = (Dictionary<string, object>)getConfigRecord("loginsMin", null)["loginGroups"];
                }
            }
            return logins;
        }
        public static object[] getDefaultProjectContent()
        {
            object[] defaultProjectContent = (object[])getConfigRecord("orgConfig", null)["defaultProjectContent"];
            return defaultProjectContent;
        }
        public static bool setConfigRecord(object[] source, string key, string strRecordName, bool useEncryption, string encryptKey)
        {
            try
            {
                Dictionary<string, object> configRecord = (Dictionary<string, object>)getConfigRecord(strRecordName, encryptKey);
                if (configRecord == null) return false;
                configRecord[key] = source;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                jss.MaxJsonLength = Int32.MaxValue;
                byte[] encodedContent = System.Text.Encoding.UTF8.GetBytes(jss.Serialize(configRecord));
                File.WriteAllBytes(Application.StartupPath + "\\" + strRecordName + ".json", encodedContent);

                if (useEncryption)
                {
                    CryptoHelper.EncryptFile(encryptKey, Application.StartupPath + "\\" + strRecordName + ".json", Application.StartupPath + "\\" + strRecordName + ".crypt");
                    File.Delete(Application.StartupPath + "\\" + strRecordName + ".json");
                }
                else
                {
                    if (File.Exists(Application.StartupPath + "\\" + strRecordName + ".crypt"))
                    {
                        File.Delete(Application.StartupPath + "\\" + strRecordName + ".crypt");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool setConfigRecord(Dictionary<string, object> source, string key, string strRecordName, bool useEncryption, string encryptKey)
        {
            try
            {
                Dictionary<string, object> configRecord = (Dictionary<string, object>)getConfigRecord(strRecordName, encryptKey);
                if (configRecord == null) return false;
                configRecord[key] = source;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                jss.MaxJsonLength = Int32.MaxValue;
                byte[] encodedContent = System.Text.Encoding.UTF8.GetBytes(jss.Serialize(configRecord));
                File.WriteAllBytes(Application.StartupPath + "\\" + strRecordName + ".json", encodedContent);

                if (useEncryption)
                {
                    CryptoHelper.EncryptFile(encryptKey, Application.StartupPath + "\\" + strRecordName + ".json", Application.StartupPath + "\\" + strRecordName + ".crypt");
                    File.Delete(Application.StartupPath + "\\" + strRecordName + ".json");
                }
                else
                {
                    if (File.Exists(Application.StartupPath + "\\" + strRecordName + ".crypt"))
                    {
                        File.Delete(Application.StartupPath + "\\" + strRecordName + ".crypt");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool doConnect(string username, string password, bool isSandbox)
        {
            // Login to tooling API
            SforceServiceService toolingService = new SforceServiceService();
            toolingService.Url = (isSandbox) ? "https://test.salesforce.com/services/Soap/T/45.0" : "https://login.salesforce.com/services/Soap/T/45.0";
            LoginResult lr = null;

            try
            {
                lr = toolingService.login(username, password);
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                return false;
            }

            if (lr != null)
            {
                // Set session id
                toolingService.SessionHeaderValue = new SfTooling.com.salesforce.tooling.SessionHeader();
                toolingService.SessionHeaderValue.sessionId = lr.sessionId;

                // Store project properties in Shopping List
                ShoppingList.toolingService = toolingService;
                ShoppingList.orgUserName = username;
                ShoppingList.orgPassword = password;
                ShoppingList.serverUrl = lr.serverUrl;
                ShoppingList.restServicesBaseUri = "https://" + new Uri(lr.serverUrl).Host + "/services/data/v45.0/tooling";
                ShoppingList.toolingApiLoginUri = "https://" + new Uri(lr.serverUrl).Host + "/services/data/v45.0";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static ApexExecutionResult runApexCode(string codeToRun)
        {
            ShoppingList.logTicketNum++;
            string logTicket = "LOGTICKET:" + ShoppingList.toolingService.SessionHeaderValue.sessionId + ShoppingList.logTicketNum;
            codeToRun = "System.debug('" + logTicket + "');\n" + codeToRun;
            string urlEncodedApex = System.Web.HttpUtility.UrlEncode(codeToRun);
            Dictionary<string, object> temp = Program.getApiRecords(false, "/executeAnonymous/?anonymousBody=" + urlEncodedApex);
            List<string> debugLog = Program.retrieveApexDebugLog(logTicket);

            bool compiled = Convert.ToBoolean(temp["compiled"]);
            bool success = Convert.ToBoolean(temp["success"]);
            string compileProblem = Convert.ToString(temp["compileProblem"]);
            string exceptionStackTrace = Convert.ToString(temp["exceptionStackTrace"]);
            string exceptionMessage = Convert.ToString(temp["exceptionMessage"]);
            string logId = null;
            string logBody = null;

            if (debugLog.Count > 0)
            {
                logId = debugLog[0];
                logBody = debugLog[1];
            }
            ApexExecutionResult executionResult = new ApexExecutionResult(compiled, success, compileProblem, exceptionStackTrace, exceptionMessage, logId, logBody);
            return executionResult;
        }
        public static List<ApexDebugLog> retrieveApexDebugLogList()
        {
            // Retrieve Apex Log ID
            List<ApexDebugLog> retValue = new List<ApexDebugLog>();
            string retrieveQuery = "SELECT Id,Operation,Request,StartTime,Status,LogLength FROM ApexLog ORDER BY starttime desc LIMIT 50";
            Dictionary<string, object> temp = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);
            object[] records = (object[])temp["records"];
            ShoppingList.testClasses.Clear();

            foreach (object o in records)
            {
                Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                string id = Convert.ToString(otemp["Id"]);                
                string operation = Convert.ToString(otemp["Operation"]);
                string request = Convert.ToString(otemp["Request"]);
                string startTime = Convert.ToString(otemp["StartTime"]);
                string status = Convert.ToString(otemp["Status"]);
                int logLength = Convert.ToInt32(otemp["LogLength"]);
                string body = Program.retrieveApexDebugLogBody(id);

                ApexDebugLog adl = new ApexDebugLog(id, operation, request, startTime, status, logLength, body);
                retValue.Add(adl);
            }
            return retValue;
        }
        public static List<UsageLimit> retrieveApiUsage()
        {
            // Retrieve Apex Log ID
            List<UsageLimit> retValue = new List<UsageLimit>();
            Dictionary<string, object> temp = Program.getApiRecords(true, "/limits/");

            foreach (string key in temp.Keys)
            {
                Dictionary<string, object> alimit = (Dictionary<string, object>)temp[key];
                string limitName = key;
                int limitRemaining = Convert.ToInt32(alimit["Remaining"]);
                int limitMax = Convert.ToInt32(alimit["Max"]);
                UsageLimit ul = new UsageLimit(limitName, limitRemaining, limitMax);
                retValue.Add(ul);
            }
            return retValue;
        }
        public static async void deployToServer(View.BoxDeployToServer box)
        {
            // Create destination directory
            string destinationDir = ShoppingList.projectRootDir + "\\tmpdeploy";
            Directory.CreateDirectory(destinationDir);

            // start the waiting animation --- START
            box.btnRunDeploy.Enabled = false;
            box.progressBar1.Visible = true;
            box.progressBar1.Style = ProgressBarStyle.Marquee;
            // start the waiting animation --- END

            string output = await Task<string>.Run(() => runShellProcessUI("C:\\Program Files\\Salesforce CLI\\bin\\sfdx.cmd", "force:auth:web:login"));
            output += await Task<string>.Run(() => runShellProcessUI("C:\\Program Files\\Salesforce CLI\\bin\\sfdx.cmd", "force:mdapi:deploy -c -d " + "\"" + destinationDir + "\" -u \"sf.marco.zisa.01@workshop.ideas\" --wait 1 --verbose"));

            // end the waiting animation --- START
            box.btnRunDeploy.Enabled = true;
            box.progressBar1.Visible = false;
            // end the waiting animation --- END

            // Update deploy output
            box.txtDeployLog.Text += output;

            // Delete destination directory
            Directory.Delete(destinationDir);
        }
        private static LoginResult doConnectStrangerOrg(string username, string password)
        {
            // Login to tooling API
            SforceServiceService toolingService = new SforceServiceService();
            toolingService.Url = "https://login.salesforce.com/services/Soap/T/45.0";
            LoginResult lr = toolingService.login(username, password);

            if (!String.IsNullOrEmpty(lr.sessionId))
            {
                // Set session id
                return lr;
            }
            else
            {
                return null;
            }
        }
        private static List<string> retrieveApexDebugLog(string logTicket)
        {
            // Retrieve Apex Log ID
            List<string> retValue = new List<string>();
            string retrieveQuery = "SELECT Id FROM ApexLog WHERE Request='Api' AND Operation = '/services/data/v45.0/tooling/executeAnonymous/' ORDER BY SystemModStamp DESC LIMIT 1";
            Dictionary<string, object> temp = Program.getApiRecords(false, "/query/?q=" + retrieveQuery);
            object[] records = (object[])temp["records"];
            ShoppingList.testClasses.Clear();

            foreach (object o in records)
            {
                Dictionary<string, object> otemp = (Dictionary<string, object>)o;
                string id = Convert.ToString(otemp["Id"]);
                retValue.Add(id);
            }
            if (retValue.Count > 0)
            {
                retValue.Add(retValue[0]);
                retValue.Add(Program.retrieveApexDebugLogBody(retValue[0]));
            }
            return retValue;
        }
        private static string retrieveApexDebugLogBody(string logId)
        {
            // Retrieve Apex Log Body
            StreamReader reader = new StreamReader(runToolingRestCallout(false, "/sobjects/ApexLog/" + logId + "/Body").GetResponseStream(), System.Text.Encoding.UTF8);
            string result = reader.ReadToEnd();
            result = result.Replace("\n", "\r\n");

            return result;
        }
        private static Dictionary<string, object> getConfigRecord(string strRecordName, string encryptKey)
        {
            string encKey = (encryptKey == null) ? "" : encryptKey;
            bool encryptAgain = false;

            if (File.Exists(Application.StartupPath + "\\" + strRecordName + ".crypt"))
            {
                if (String.IsNullOrEmpty(encKey))
                {
                    System.Windows.Forms.Form f = new System.Windows.Forms.Form();
                    f.Width = 500;
                    f.Text = "Encrypted credentials file found";
                    f.MinimizeBox = false;
                    f.MaximizeBox = false;
                    Label label = new Label();
                    label.Text = "Credentials file is encrypted. Please provide decrypt key and then press OK";

                    label.Width = 400;
                    TextBox textBox = new TextBox();
                    textBox.UseSystemPasswordChar = true;
                    textBox.Top = label.Top + 20;

                    Button button = new Button();
                    button.Text = "OK";
                    button.DialogResult = DialogResult.OK;
                    button.Top = textBox.Top + 30;

                    f.Controls.Add(label);
                    f.Controls.Add(textBox);
                    f.Controls.Add(button);
                    f.ShowDialog();

                    if (f.DialogResult == DialogResult.OK)
                    {
                        encKey = textBox.Text;
                        f.Dispose();
                        if (!CryptoHelper.DecryptFile(encKey, Application.StartupPath + "\\" + strRecordName + ".crypt", Application.StartupPath + "\\" + strRecordName + ".json"))
                        {
                            MessageBox.Show("Failed to decrypt credentials file", "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Dictionary<string, object> ret = new Dictionary<string, object>();
                            ret.Add("FAILED", "");
                            return ret;
                        }
                        else
                        {
                            encryptAgain = true;
                        }
                    }
                }
                else
                {
                    if (!CryptoHelper.DecryptFile(encKey, Application.StartupPath + "\\" + strRecordName + ".crypt", Application.StartupPath + "\\" + strRecordName + ".json"))
                    {
                        MessageBox.Show("Failed to decrypt credentials file", "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Dictionary<string, object> ret = new Dictionary<string, object>();
                        ret.Add("FAILED", "");
                        return ret;
                    }
                    else
                    {
                        encryptAgain = true;
                    }
                }
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            jss.MaxJsonLength = Int32.MaxValue;

            // Prevents application failure in case login.json or orgConfig.json file does not exist by creating a default empty *.json
            if (!File.Exists(Application.StartupPath + "\\" + strRecordName + ".json"))
            {
                File.Copy(Application.StartupPath + "\\" + strRecordName + "Min.json", Application.StartupPath + "\\" + strRecordName + ".json");
            }
            Dictionary<string, object> configRecord = (Dictionary<string, object>)jss.DeserializeObject(File.ReadAllText(Application.StartupPath + "\\" + strRecordName + ".json"));

            if (encryptAgain) {
                CryptoHelper.EncryptFile(encKey, Application.StartupPath + "\\" + strRecordName + ".json", Application.StartupPath + "\\" + strRecordName + ".crypt");
                File.Delete(Application.StartupPath + "\\" + strRecordName + ".json");
            }
            return configRecord;
        }
        public static bool directoryExists(string dirPath)
        {
            // Check whether the directory exists
            try
            {
                var selection = System.IO.Directory.GetDirectories(dirPath);
                return true;
            }
            catch (System.IO.DirectoryNotFoundException dex)
            {
                return false;
            }
        }
        private static async Task<string> runShellProcessUI(string strCommand, string strCommandParameters)
        {
            string output = await Task<string>.Run(() => runShellProcess(strCommand, strCommandParameters));
            return output;
        }
        private static string runShellProcess(string strCommand, string strCommandParameters)
        {
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = strCommand;

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = strCommandParameters;
            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.RedirectStandardError = true;
            pProcess.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            pProcess.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;
            pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = "";
            while (!pProcess.StandardOutput.EndOfStream)
            {
                strOutput += pProcess.StandardOutput.ReadLine() + "\r\n";
            }

            //Wait for process to finish
            pProcess.WaitForExit();
            return strOutput;
        }
        private static WebResponse runToolingRestCallout(bool useApiUri, string nextRecordPageUrl)
        {
            Uri apxRetrieveUri = (useApiUri) ? new Uri(ShoppingList.toolingApiLoginUri + nextRecordPageUrl) : new Uri(ShoppingList.restServicesBaseUri + nextRecordPageUrl);
            System.Net.HttpWebRequest req = (HttpWebRequest)WebRequest.Create(apxRetrieveUri);
            req.Headers.Add("Authorization", "Bearer " + ShoppingList.toolingService.SessionHeaderValue.sessionId);
            req.ContentType = "application/json";
            WebResponse res = null;

            try
            {
                res = req.GetResponse();
            }
            catch (System.Net.WebException ex)
            {
                Program.doConnect(ShoppingList.orgUserName, ShoppingList.orgPassword, ShoppingList.toolingService.Url.Contains("test.salesforce.com"));
                apxRetrieveUri = (useApiUri) ? new Uri(ShoppingList.toolingApiLoginUri + nextRecordPageUrl) : new Uri(ShoppingList.restServicesBaseUri + nextRecordPageUrl);
                req = (HttpWebRequest)WebRequest.Create(apxRetrieveUri);
                req.Headers.Add("Authorization", "Bearer " + ShoppingList.toolingService.SessionHeaderValue.sessionId);
                req.ContentType = "application/json";
                res = req.GetResponse();
            }
            return res;
        }
        private static Dictionary<string, object> getApiRecords(bool useApiUri, string nextRecordPageUrl)
        {
            StreamReader reader = new StreamReader(runToolingRestCallout(useApiUri, nextRecordPageUrl).GetResponseStream(), System.Text.Encoding.UTF8);
            string result = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;
            return (Dictionary<string, object>)serializer.DeserializeObject(result);
        }
        //--------- GENERAL UTILITY METHODS -- END ----
    }
}