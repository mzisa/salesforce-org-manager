using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class OrgTree : Form
    {
        // FORM UI METHODS -- START ----
        public OrgTree()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            treeView.AfterCheck += TreeView_AfterCheck;
            this.Text = ShoppingList.projectName;
            refreshMetadataIndex();
        }
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        private void Scheda_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name.Equals("tabPage3") || e.TabPage.Name.Equals("tabPage4"))
            {
                toggleFormButtonsVisibility(false);
            }
            else
            {
                if (treeView.Nodes["mainNode"].Tag.Equals("_TESTCLASSES"))
                {
                    treeView.Nodes.Clear();
                    refreshMetadataIndex();
                }
                toggleFormButtonsVisibility(true);
            }
        }
        private void toggleFormButtonsVisibility(bool toset)
        {
            treeView.Visible = toset;
            btnSelectAll.Visible = toset;
            btnSelectNone.Visible = toset;
            btnRefreshMetadata.Visible = toset;
            btnUpdateProject.Visible = toset;
        }
        private void toggleProjectButtonsVisibility(bool toset)
        {
            btnRefreshMetadata.Visible = toset;
            btnUpdateProject.Visible = toset;
        }
        private void toggleSelectionButtonsVisibility(bool toset)
        {
            btnSelectAll.Visible = toset;
            btnSelectNone.Visible = toset;
        }
        // FORM UI METHODS -- END ----

        // PROJECT CONTENT METHODS -- START ---------------------
        private void btnRefreshMetadata_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            treeView.Visible = false;
            refreshMetadataIndexAsyncCaller();
        }
        private async void refreshMetadataIndexAsyncCaller()
        {
            treeView.Nodes.Clear();
            TreeNode tn = await Task<TreeNode>.Run(() => refreshMetadataIndexAsync());
            treeView.Nodes.Add(tn);
            treeView.Visible = true;
            progressBar1.Visible = false;
        }
        private void refreshMetadataIndex()
        {
            // start off by adding a base treeview node 
            TreeNode root = new TreeNode();
            root.Name = "mainNode";
            root.Text = ShoppingList.orgUserName;
            root.Tag = "_STRUCTURE";
            treeView.Nodes.Add(root);

            // Populate class nodes
            List<ApexClassStub> allClasses = Program.retrieveClasses();
            if (allClasses.Count > 0)
            {
                // Init class nodes
                TreeNode classRoot = new TreeNode();
                classRoot.Name = "ApexClass";
                classRoot.Text = "ApexClass";
                classRoot.ForeColor = (ShoppingList.projectClasses.Count > 0) ? Color.Blue : classRoot.ForeColor;
                root.Nodes.Add(classRoot);

                foreach (ApexClassStub stub in allClasses)
                {
                    TreeNode classNode = new TreeNode();
                    classNode.Name = stub.Id;
                    classNode.Text = stub.Name;
                    classNode.Tag = stub;
                    classNode.Checked = (ShoppingList.projectClasses.Contains(stub.Name) ? true : false);
                    classNode.ForeColor = (ShoppingList.projectClasses.Contains(stub.Name) ? Color.Blue : classNode.ForeColor);
                    classRoot.Nodes.Add(classNode);
                }
            }
            // Populate page nodes
            List<ApexPageStub> allPages = Program.retrievePages();
            if (allPages.Count > 0)
            {
                // Init page nodes
                TreeNode pageRoot = new TreeNode();
                pageRoot.Name = "ApexPage";
                pageRoot.Text = "ApexPage";
                pageRoot.ForeColor = (ShoppingList.projectPages.Count > 0) ? Color.Blue : pageRoot.ForeColor;
                root.Nodes.Add(pageRoot);

                foreach (ApexPageStub stub in allPages)
                {
                    TreeNode pageNode = new TreeNode();
                    pageNode.Name = stub.Id;
                    pageNode.Text = stub.Name;
                    pageNode.Tag = stub;
                    pageNode.Checked = (ShoppingList.projectPages.Contains(stub.Name) ? true : false);
                    pageNode.ForeColor = (ShoppingList.projectPages.Contains(stub.Name) ? Color.Blue : pageNode.ForeColor);
                    pageRoot.Nodes.Add(pageNode);
                }
            }
            // Populate trigger nodes
            List<ApexTriggerStub> allTriggers = Program.retrieveTriggers();
            if (allTriggers.Count > 0)
            {
                // Init trigger nodes
                TreeNode triggerRoot = new TreeNode();
                triggerRoot.Name = "ApexTrigger";
                triggerRoot.Text = "ApexTrigger";
                triggerRoot.ForeColor = (ShoppingList.projectTriggers.Count > 0) ? Color.Blue : triggerRoot.ForeColor;
                root.Nodes.Add(triggerRoot);

                foreach (ApexTriggerStub stub in allTriggers)
                {
                    TreeNode triggerNode = new TreeNode();
                    triggerNode.Name = stub.Id;
                    triggerNode.Text = stub.Name;
                    triggerNode.Tag = stub;
                    triggerNode.Checked = (ShoppingList.projectTriggers.Contains(stub.Name) ? true : false);
                    triggerNode.ForeColor = (ShoppingList.projectTriggers.Contains(stub.Name) ? Color.Blue : triggerNode.ForeColor);
                    triggerRoot.Nodes.Add(triggerNode);
                }
            }
            // Populate static resource nodes
            List<ApexStaticResourceStub> allResources = Program.retrieveStaticResources();
            if (allResources.Count > 0)
            {
                // Init trigger nodes
                TreeNode staticResourceRoot = new TreeNode();
                staticResourceRoot.Name = "StaticResource";
                staticResourceRoot.Text = "StaticResource";
                staticResourceRoot.ForeColor = (ShoppingList.projectStaticResources.Count > 0) ? Color.Blue : staticResourceRoot.ForeColor;
                root.Nodes.Add(staticResourceRoot);

                foreach (ApexStaticResourceStub stub in allResources)
                {
                    TreeNode staticResourceNode = new TreeNode();
                    staticResourceNode.Name = stub.Id;
                    staticResourceNode.Text = stub.Name;
                    staticResourceNode.Tag = stub;
                    staticResourceNode.Checked = (ShoppingList.projectStaticResources.Contains(stub.Name) ? true : false);
                    staticResourceNode.ForeColor = (ShoppingList.projectStaticResources.Contains(stub.Name) ? Color.Blue : staticResourceNode.ForeColor);
                    staticResourceRoot.Nodes.Add(staticResourceNode);
                }
            }
            // Populate lightning apps
            List<LightningItemBundle> allLightningItems = Program.retrieveLightningItems();
            if (allLightningItems.Count > 0)
            {
                // Init class nodes
                TreeNode lightningItemRoot = new TreeNode();
                lightningItemRoot.Name = "AuraDefinitionBundle";
                lightningItemRoot.Text = "AuraDefinitionBundle";
                lightningItemRoot.ForeColor = (ShoppingList.projectLightningItems.Count > 0) ? Color.Blue : lightningItemRoot.ForeColor;
                root.Nodes.Add(lightningItemRoot);

                foreach (LightningItemBundle stub in allLightningItems)
                {
                    TreeNode bundleNode = new TreeNode();
                    bundleNode.Name = stub.Id;
                    bundleNode.Text = stub.MasterLabel;
                    bundleNode.Tag = stub;
                    bundleNode.Checked = (ShoppingList.projectLightningItems.Contains(stub.MasterLabel) ? true : false);
                    bundleNode.ForeColor = (ShoppingList.projectLightningItems.Contains(stub.MasterLabel) ? Color.Blue : bundleNode.ForeColor);
                    lightningItemRoot.Nodes.Add(bundleNode);
                }
            }
            // Populate lightning web components
            List<LightningWebComponent> allLwc = Program.retrieveLightningWebComponents();
            if (allLwc.Count > 0)
            {
                // Init class nodes
                TreeNode lwcItemRoot = new TreeNode();
                lwcItemRoot.Name = "LightningComponentBundle";
                lwcItemRoot.Text = "LightningComponentBundle";
                lwcItemRoot.ForeColor = (ShoppingList.projectLwcItems.Count > 0) ? Color.Blue : lwcItemRoot.ForeColor;
                root.Nodes.Add(lwcItemRoot);

                foreach (LightningWebComponent stub in allLwc)
                {
                    TreeNode lwcNode = new TreeNode();
                    lwcNode.Name = stub.Id;
                    lwcNode.Text = stub.MasterLabel;
                    lwcNode.Tag = stub;
                    lwcNode.Checked = (ShoppingList.projectLwcItems.Contains(stub.MasterLabel) ? true : false);
                    lwcNode.ForeColor = (ShoppingList.projectLwcItems.Contains(stub.MasterLabel) ? Color.Blue : lwcNode.ForeColor);
                    lwcItemRoot.Nodes.Add(lwcNode);
                }
            }
        }
        private TreeNode refreshMetadataIndexAsync()
        {
            // start off by adding a base treeview node 
            TreeNode root = new TreeNode();
            root.Name = "mainNode";
            root.Text = ShoppingList.orgUserName;
            root.Tag = "_STRUCTURE";

            // Populate class nodes
            List<ApexClassStub> allClasses = Program.retrieveClasses();
            if (allClasses.Count > 0)
            {
                // Init class nodes
                TreeNode classRoot = new TreeNode();
                classRoot.Name = "ApexClass";
                classRoot.Text = "ApexClass";
                classRoot.ForeColor = (ShoppingList.projectClasses.Count > 0) ? Color.Blue : classRoot.ForeColor;
                root.Nodes.Add(classRoot);

                foreach (ApexClassStub stub in allClasses)
                {
                    TreeNode classNode = new TreeNode();
                    classNode.Name = stub.Id;
                    classNode.Text = stub.Name;
                    classNode.Tag = stub;
                    classNode.Checked = (ShoppingList.projectClasses.Contains(stub.Name) ? true : false);
                    classNode.ForeColor = (ShoppingList.projectClasses.Contains(stub.Name) ? Color.Blue : classNode.ForeColor);
                    classRoot.Nodes.Add(classNode);
                }
            }
            // Populate page nodes
            List<ApexPageStub> allPages = Program.retrievePages();
            if (allPages.Count > 0)
            {
                // Init page nodes
                TreeNode pageRoot = new TreeNode();
                pageRoot.Name = "ApexPage";
                pageRoot.Text = "ApexPage";
                pageRoot.ForeColor = (ShoppingList.projectPages.Count > 0) ? Color.Blue : pageRoot.ForeColor;
                root.Nodes.Add(pageRoot);

                foreach (ApexPageStub stub in allPages)
                {
                    TreeNode pageNode = new TreeNode();
                    pageNode.Name = stub.Id;
                    pageNode.Text = stub.Name;
                    pageNode.Tag = stub;
                    pageNode.Checked = (ShoppingList.projectPages.Contains(stub.Name) ? true : false);
                    pageNode.ForeColor = (ShoppingList.projectPages.Contains(stub.Name) ? Color.Blue : pageNode.ForeColor);
                    pageRoot.Nodes.Add(pageNode);
                }
            }
            // Populate trigger nodes
            List<ApexTriggerStub> allTriggers = Program.retrieveTriggers();
            if (allTriggers.Count > 0)
            {
                // Init trigger nodes
                TreeNode triggerRoot = new TreeNode();
                triggerRoot.Name = "ApexTrigger";
                triggerRoot.Text = "ApexTrigger";
                triggerRoot.ForeColor = (ShoppingList.projectTriggers.Count > 0) ? Color.Blue : triggerRoot.ForeColor;
                root.Nodes.Add(triggerRoot);

                foreach (ApexTriggerStub stub in allTriggers)
                {
                    TreeNode triggerNode = new TreeNode();
                    triggerNode.Name = stub.Id;
                    triggerNode.Text = stub.Name;
                    triggerNode.Tag = stub;
                    triggerNode.Checked = (ShoppingList.projectTriggers.Contains(stub.Name) ? true : false);
                    triggerNode.ForeColor = (ShoppingList.projectTriggers.Contains(stub.Name) ? Color.Blue : triggerNode.ForeColor);
                    triggerRoot.Nodes.Add(triggerNode);
                }
            }
            // Populate static resource nodes
            List<ApexStaticResourceStub> allResources = Program.retrieveStaticResources();
            if (allResources.Count > 0)
            {
                // Init trigger nodes
                TreeNode staticResourceRoot = new TreeNode();
                staticResourceRoot.Name = "StaticResource";
                staticResourceRoot.Text = "StaticResource";
                staticResourceRoot.ForeColor = (ShoppingList.projectStaticResources.Count > 0) ? Color.Blue : staticResourceRoot.ForeColor;
                root.Nodes.Add(staticResourceRoot);

                foreach (ApexStaticResourceStub stub in allResources)
                {
                    TreeNode staticResourceNode = new TreeNode();
                    staticResourceNode.Name = stub.Id;
                    staticResourceNode.Text = stub.Name;
                    staticResourceNode.Tag = stub;
                    staticResourceNode.Checked = (ShoppingList.projectStaticResources.Contains(stub.Name) ? true : false);
                    staticResourceNode.ForeColor = (ShoppingList.projectStaticResources.Contains(stub.Name) ? Color.Blue : staticResourceNode.ForeColor);
                    staticResourceRoot.Nodes.Add(staticResourceNode);
                }
            }
            // Populate lightning apps
            List<LightningItemBundle> allLightningItems = Program.retrieveLightningItems();
            if (allLightningItems.Count > 0)
            {
                // Init class nodes
                TreeNode lightningItemRoot = new TreeNode();
                lightningItemRoot.Name = "AuraDefinitionBundle";
                lightningItemRoot.Text = "AuraDefinitionBundle";
                lightningItemRoot.ForeColor = (ShoppingList.projectLightningItems.Count > 0) ? Color.Blue : lightningItemRoot.ForeColor;
                root.Nodes.Add(lightningItemRoot);

                foreach (LightningItemBundle stub in allLightningItems)
                {
                    TreeNode bundleNode = new TreeNode();
                    bundleNode.Name = stub.Id;
                    bundleNode.Text = stub.MasterLabel;
                    bundleNode.Tag = stub;
                    bundleNode.Checked = (ShoppingList.projectLightningItems.Contains(stub.MasterLabel) ? true : false);
                    bundleNode.ForeColor = (ShoppingList.projectLightningItems.Contains(stub.MasterLabel) ? Color.Blue : bundleNode.ForeColor);
                    lightningItemRoot.Nodes.Add(bundleNode);
                }
            }
            // Populate lightning web components
            List<LightningWebComponent> allLwc = Program.retrieveLightningWebComponents();
            if (allLwc.Count > 0)
            {
                // Init class nodes
                TreeNode lwcItemRoot = new TreeNode();
                lwcItemRoot.Name = "LightningComponentBundle";
                lwcItemRoot.Text = "LightningComponentBundle";
                lwcItemRoot.ForeColor = (ShoppingList.projectLwcItems.Count > 0) ? Color.Blue : lwcItemRoot.ForeColor;
                root.Nodes.Add(lwcItemRoot);

                foreach (LightningWebComponent stub in allLwc)
                {
                    TreeNode lwcNode = new TreeNode();
                    lwcNode.Name = stub.Id;
                    lwcNode.Text = stub.MasterLabel;
                    lwcNode.Tag = stub;
                    lwcNode.Checked = (ShoppingList.projectLwcItems.Contains(stub.MasterLabel) ? true : false);
                    lwcNode.ForeColor = (ShoppingList.projectLwcItems.Contains(stub.MasterLabel) ? Color.Blue : lwcNode.ForeColor);
                    lwcItemRoot.Nodes.Add(lwcNode);
                }
            }
            return root;
        }
        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            treeView.Visible = false;
            updateProjectProcess();
        }
        public async void updateProjectProcess()
        {
            progressBar1.Visible = true;
            treeView.Visible = false;
            await Task.Run(() => updateProject());
            refreshMetadataIndexAsyncCaller();
        }
        public void updateProjectProcessReverse(object nodeResult)
        {
            updateProject(nodeResult);
            treeView.Sort();
        }
        private void updateProject([Optional] object nodeResult)
        {
            // Get root node, class node, page node
            TreeNode rootNode = treeView.Nodes["mainNode"];

            TreeNode classRootNode = rootNode.Nodes["ApexClass"];
            TreeNode pageRootNode = rootNode.Nodes["ApexPage"];
            TreeNode triggerRootNode = rootNode.Nodes["ApexTrigger"];
            TreeNode staticResourceRootNode = rootNode.Nodes["StaticResource"];
            TreeNode bundleRootNode = rootNode.Nodes["AuraDefinitionBundle"];
            TreeNode lwcRootNode = rootNode.Nodes["LightningComponentBundle"];

            if (nodeResult != null)
            {
                if (nodeResult.GetType() == typeof(ApexClassStub)) {
                    ApexClassStub tmpResult = nodeResult as ApexClassStub;
                    TreeNode classNode = new TreeNode();
                    classNode.Name = tmpResult.Id;
                    classNode.Text = tmpResult.Name;
                    classNode.Tag = nodeResult;
                    classNode.Checked = true;
                    classNode.ForeColor = Color.Blue;
                    classRootNode.Nodes.Add(classNode);
                }
                if (nodeResult.GetType() == typeof(ApexPageStub))
                {
                    ApexPageStub tmpResult = nodeResult as ApexPageStub;
                    TreeNode pageNode = new TreeNode();
                    pageNode.Name = tmpResult.Id;
                    pageNode.Text = tmpResult.Name;
                    pageNode.Tag = tmpResult;
                    pageNode.Checked = true;
                    pageNode.ForeColor = Color.Blue;
                    pageRootNode.Nodes.Add(pageNode);
                }
                if (nodeResult.GetType() == typeof(ApexTriggerStub))
                {
                    ApexTriggerStub tmpResult = nodeResult as ApexTriggerStub;
                    TreeNode triggerNode = new TreeNode();
                    triggerNode.Name = tmpResult.Id;
                    triggerNode.Text = tmpResult.Name;
                    triggerNode.Tag = tmpResult;
                    triggerNode.Checked = true;
                    triggerNode.ForeColor = Color.Blue;
                    triggerRootNode.Nodes.Add(triggerNode);
                }
                if (nodeResult.GetType() == typeof(ApexStaticResourceStub))
                {
                    ApexStaticResourceStub tmpResult = nodeResult as ApexStaticResourceStub;
                    TreeNode staticResourceNode = new TreeNode();
                    staticResourceNode.Name = tmpResult.Id;
                    staticResourceNode.Text = tmpResult.Name;
                    staticResourceNode.Tag = tmpResult;
                    staticResourceNode.Checked = true;
                    staticResourceNode.ForeColor = Color.Blue;
                    staticResourceRootNode.Nodes.Add(staticResourceNode);
                }
                if (nodeResult.GetType() == typeof(LightningItemBundle))
                {
                    LightningItemBundle tmpResult = nodeResult as LightningItemBundle;
                    TreeNode bundleNode = new TreeNode();
                    bundleNode.Name = tmpResult.Id;
                    bundleNode.Text = tmpResult.MasterLabel;
                    bundleNode.Tag = tmpResult;
                    bundleNode.Checked = true;
                    bundleNode.ForeColor = Color.Blue;
                    bundleRootNode.Nodes.Add(bundleNode);
                }
            }

            // Get class names, page names from SF org
            List<ApexClassStub> selectedClasses = new List<ApexClassStub>();
            List<ApexPageStub> selectedPages = new List<ApexPageStub>();
            List<ApexTriggerStub> selectedTriggers = new List<ApexTriggerStub>();
            List<ApexStaticResourceStub> selectedStaticResources = new List<ApexStaticResourceStub>();
            List<LightningItemBundle> selectedBundles = new List<LightningItemBundle>();
            List<LightningWebComponent> selectedWebComponents = new List<LightningWebComponent>();

            if (classRootNode!=null) {foreach (TreeNode node in classRootNode.Nodes) {if (node.Checked) {selectedClasses.Add((ApexClassStub)node.Tag);}}}
            if (pageRootNode!=null) {foreach (TreeNode node in pageRootNode.Nodes) {if (node.Checked) {selectedPages.Add((ApexPageStub)node.Tag);}}}
            if (triggerRootNode!=null) {foreach (TreeNode node in triggerRootNode.Nodes) {if (node.Checked) {selectedTriggers.Add((ApexTriggerStub)node.Tag);}}}
            if (staticResourceRootNode!=null) {foreach (TreeNode node in staticResourceRootNode.Nodes) {if (node.Checked) {selectedStaticResources.Add((ApexStaticResourceStub)node.Tag);}}}
            if (bundleRootNode!=null) {foreach (TreeNode node in bundleRootNode.Nodes) {if (node.Checked) {selectedBundles.Add((LightningItemBundle)node.Tag);}}}
            if (lwcRootNode!=null) {foreach (TreeNode node in lwcRootNode.Nodes) {if (node.Checked) {selectedWebComponents.Add((LightningWebComponent)node.Tag);}}}

            List<ApexClassStub> classesAdder = selectedClasses.Count == 0 ? null : selectedClasses;
            List<ApexPageStub> pagesAdder = selectedPages.Count == 0 ? null : selectedPages;
            List<ApexTriggerStub> triggersAdder = selectedTriggers.Count == 0 ? null : selectedTriggers;
            List<ApexStaticResourceStub> staticResourcesAdder = selectedStaticResources.Count == 0 ? null : selectedStaticResources;
            List<LightningItemBundle> bundlesAdder = selectedBundles.Count == 0 ? null : selectedBundles;
            List<LightningWebComponent> lwcAdder = selectedWebComponents.Count == 0 ? null : selectedWebComponents;

            // Update current project files
            Program.updateCurrentProject(classesAdder, pagesAdder, triggersAdder, staticResourcesAdder, bundlesAdder, lwcAdder);

            // Update the package.xml project manifest file
            Program.updateManifestFile(classesAdder, pagesAdder, triggersAdder, staticResourcesAdder, bundlesAdder, lwcAdder);
        }
        private void btnSelectAll_Click(object sender, EventArgs e) {this.CheckAllNodes(treeView.Nodes);}
        private void btnSelectNone_Click(object sender, EventArgs e) {this.UncheckAllNodes(treeView.Nodes);}
        // PROJECT CONTENT METHODS -- END ---------------------

        // TREEVIEW UTILITY METHODS -- START ---------------------
        public void CheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }
        public void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }
        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }
        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    if (e.Node.Checked) this.CheckAllNodes(e.Node.Nodes); else this.UncheckAllNodes(e.Node.Nodes);
                }
            }
        }
        public Dictionary<string, object> getTreeSelectedNodes()
        {
            Dictionary<string, object> testClassesToRun = new Dictionary<string, object>();
            foreach (System.Windows.Forms.TreeNode aNode in treeView.Nodes["mainNode"].Nodes[0].Nodes)
            {
                if (aNode.Checked == true)
                {
                    testClassesToRun.Add(aNode.Name, aNode.Text);
                }
            }
            return testClassesToRun;
        }
        public TreeNode searchSingleNode(string nodeName)
        {
            TreeNode[] tn = treeView.Nodes.Find(nodeName, true);
            return tn[0];
        }
        // TREEVIEW UTILITY METHODS -- END ---------------------

        // ---- CLASSIC ITEMS -- START -------------
        private void btnNewClass_Click(object sender, EventArgs e)
        {
            BoxCreazioneClasse BoxCreazione = new BoxCreazioneClasse();
            BoxCreazione.Show();
        }
        private void btnNewVisualforce_Click(object sender, EventArgs e)
        {
            BoxCreazioneVisualforce BoxCreazione = new BoxCreazioneVisualforce();
            BoxCreazione.Show();
        }
        private void btnNewTrigger_Click(object sender, EventArgs e)
        {
            BoxCreazioneTrigger BoxCreazione = new BoxCreazioneTrigger();
            BoxCreazione.Show();
        }
        private void btnNewStaticResource_Click(object sender, EventArgs e)
        {
            BoxCreazioneRisorsaStatica BoxCreazione = new BoxCreazioneRisorsaStatica();
            BoxCreazione.Show();
        }
        // ---- CLASSIC ITEMS -- END -------------

        // ----------- LIGHTNING ITEMS -- START ---------
        private void btnNewLightEvent_Click(object sender, EventArgs e)
        {
            BoxCreazioneLightning BoxCreazione = new BoxCreazioneLightning();
            BoxCreazione.radioEvent.Checked = true;
            BoxCreazione.Show();
        }
        private void btnNewLightComponent_Click(object sender, EventArgs e)
        {
            BoxCreazioneLightning BoxCreazione = new BoxCreazioneLightning();
            BoxCreazione.radioComponent.Checked = true;
            BoxCreazione.Show();
        }
        private void btnNewLightApp_Click(object sender, EventArgs e)
        {
            BoxCreazioneLightning BoxCreazione = new BoxCreazioneLightning();
            BoxCreazione.radioApp.Checked = true;
            BoxCreazione.Show();
        }
        private void btnNewLightningInterface_Click(object sender, EventArgs e)
        {
            BoxCreazioneLightning BoxCreazione = new BoxCreazioneLightning();
            BoxCreazione.radioInterface.Checked = true;
            BoxCreazione.Show();
        }
        //----------- LIGHTNING ITEMS -- END ---------

        // TREEVIEW UTILITY METHODS -- START ---------------------
        private async void btnDebugLogs_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            BoxShowLogs bsl = await Task<BoxShowLogs>.Run(() => new BoxShowLogs());
            bsl.Show();
            progressBar1.Visible = false;
        }
        private void btnApiUsage_Click(object sender, EventArgs e)
        {
            BoxApiUsage bas = new BoxApiUsage();
            bas.Show();
        }
        private void btnDeployToServer_Click(object sender, EventArgs e)
        {
            BoxDeployToServer bdts = new BoxDeployToServer();
            bdts.Show();
        }
        // TREEVIEW UTILITY METHODS -- EBD ---------------------

        //----------- TBD ----------------------- START -------------
        //----------- TBD ----------------------- END -------------

        //----------- NON UTILIZZATI: DA DISMETTERE (?) START ---------
        private TreeNode FindRootNode(TreeNode treeNode)
        {
            while (treeNode.Parent != null)
            {
                treeNode = treeNode.Parent;
            }
            return treeNode;
        }
        private void btnExecuteApex_Click(object sender, EventArgs e)
        {
            BoxExecuteAnonymous bea = new BoxExecuteAnonymous();
            bea.Show();
        }

        private void OrgTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShoppingList.principalePointer.Show();
        }
        //----------- NON UTILIZZATI: DA DISMETTERE (?) END ---------
    }
}