﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class BoxProjectSettings : Form
    {
        public BoxProjectSettings()
        {
            InitializeComponent();
            if ((bool) Program.getPrjConfig()["fullCache"])
            {
                initializeWithAllMetadata();
                chkShowAllMetadata.Checked = true;
            }
            else
            {
                initializeWithProgrammingMetadata();
                chkShowAllMetadata.Checked = false;
            }
        }
        private void initializeWithAllMetadata()
        {
            lstBoxLeft.Items.Clear();
            lstBoxRight.Items.Clear();
            TreeNode rootNode = ShoppingList.orgTreePointer.treeView.Nodes["mainNode"];
            TreeNodeCollection rootNodeChildren = rootNode.Nodes;

            foreach (TreeNode node in rootNodeChildren)
            {
                lstBoxRight.Items.Add(node.Text);
            }
            IEnumerable<string> metadataToKeep =
                from string x in ShoppingList.metadataBible
                where !((IEnumerable<string>)lstBoxRight.Items.OfType<string>()).Contains(x)
                select x;

            lstBoxLeft.Items.AddRange(metadataToKeep.ToArray());
        }
        private void initializeWithProgrammingMetadata()
        {
            lstBoxLeft.Items.Clear();
            lstBoxRight.Items.Clear();
            TreeNode rootNode = ShoppingList.orgTreePointer.treeView.Nodes["mainNode"];
            TreeNodeCollection rootNodeChildren = rootNode.Nodes;

            foreach (TreeNode node in rootNodeChildren)
            {
                if (Program.getProgrammingMetadata().Contains(node.Text))
                {
                    lstBoxRight.Items.Add(node.Text);
                }
            }
            IEnumerable<string> metadataToKeep = Program.getProgrammingMetadata().Except(lstBoxRight.Items.OfType<string>());
            lstBoxLeft.Items.AddRange(metadataToKeep.ToArray());
        }
        private void btnLeftToRight_Click(object sender, EventArgs e)
        {
            moveItems(lstBoxLeft, lstBoxRight);
        }
        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            moveItems(lstBoxRight, lstBoxLeft);
        }
        private void moveItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
            destination.Sorted = true;
            source.Sorted = true;
        }
        private void BoxProjectSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, object> metadataToUse = new Dictionary<string, object>();
            metadataToUse.Add("metadataToUse", lstBoxRight.Items.OfType<string>().ToList());
            metadataToUse.Add("fullCache", chkShowAllMetadata.Checked);
            if (Program.setPrjConfig(metadataToUse)) {
                ShoppingList.metadataToUse = lstBoxRight.Items.OfType<string>().ToList();
            }
        }
        private void chkShowAllMetadata_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                initializeWithAllMetadata();
            }
            else
            {
                initializeWithProgrammingMetadata();
            }
        }
    }
}
