using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.AdvTree;
using GLaDOS.BLL;
using GLaDOS.BLL.Entity;
using GLaDOS.BLL.Public;
using GLaDOS.BLL.System;
using GLaDOS.Properties;
using GLaDOS.UIL.BaseForms;

namespace GLaDOS.UIL.Forms
{
    public partial class FormMenuManager : BaseForm01
    {
        public FormMenuManager()
        {
            InitializeComponent();
        }

        #region "界面初始化"

        private void FormMenuManager_Load(object sender, EventArgs e)
        {
            cmbFunctionTypeCondition.DataSource = new GlobalOption().MenuType;
            cmbFunctionTypeSetup.DataSource = new GlobalOption().MenuType;
            cmbUserGroup.DataSource = UserService.GetUserGroupNameList();
            ViewFunctionList();
        }

        private void ClearControls(int step)
        {
            switch (step)
            {
                case 1:
                    txtFunctionName.Text = string.Empty;
                    txtFunctionDesc.Text = string.Empty;
                    txtAssemblyFile.Text = string.Empty;
                    txtAssemblyName.Text = string.Empty;
                    cmbFunctionTypeSetup.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region "Function管理"

        private void ViewFunctionList()
        {
            dgvFunctionList.DataSource = FunctionMenuService.GetFunctionList(cmbFunctionTypeCondition.Text.Trim());
        }

        private void ViewFunction(string functionName)
        {
            Function function = FunctionMenuService.GetFunction(functionName.Trim());
            if (function != null && function != default(Function))
            {
                txtFunctionName.Text = function.FunctionName;
                txtFunctionDesc.Text = function.FunctionDesc;
                txtAssemblyFile.Text = function.AssemblyFile;
                txtAssemblyName.Text = function.AssemblyName;
                cmbFunctionTypeSetup.Text = function.FunctionType;
            }
        }

        private bool CreateFunction()
        {
            if (FunctionMenuService.GetFunction(txtFunctionName.Text) != null)
            {
                MessageBox.Show(Language.Msg_PK_Already_Exist, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Function function = new Function
            {
                FunctionName = txtFunctionName.Text.Trim(),
                FunctionDesc = txtFunctionDesc.Text.Trim(),
                FunctionType = cmbFunctionTypeSetup.Text.Trim(),
                AssemblyFile = txtAssemblyFile.Text.Trim(),
                AssemblyName = txtAssemblyName.Text.Trim()
            };
            if (FunctionMenuService.CreateFunction(function) == false)
            {
                MessageBox.Show(Language.Msg_Operation_Failed, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show(Language.Msg_Operation_Succeeded, Language.Caption_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool DeleteFunction(string functionName)
        {
            if (FunctionMenuService.DeleteFunction(functionName) == false)
            {
                MessageBox.Show(Language.Msg_Operation_Failed, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show(Language.Msg_Operation_Succeeded, Language.Caption_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        #region "界面事件"
        private void btnViewFunctionList_Click(object sender, EventArgs e)
        {
            ViewFunctionList();
        }

        private void dgvFunctionList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFunctionList.SelectedRows.Count > 0)
            {
                ViewFunction(dgvFunctionList.SelectedRows[0].Cells["FunctionName"].Value.ToString());
            }
        }

        private void btnViewFunction_Click(object sender, EventArgs e)
        {
            if (txtFunctionName.Text.Trim() == string.Empty) return;
            ViewFunction(txtFunctionName.Text);
        }

        private void btnCreateFunction_Click(object sender, EventArgs e)
        {
            if (txtFunctionName.Text.Trim() == string.Empty) return;
            if (CreateFunction() == true)
            {
                ViewFunctionList();
            }
        }

        private void btnDeleteFunction_Click(object sender, EventArgs e)
        {
            if (txtFunctionName.Text.Trim() == string.Empty) return;
            if (MessageBox.Show(Language.Meg_Delete_Confirm, Language.Caption_Worning, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (DeleteFunction(txtFunctionName.Text) == true)
                {
                    ClearControls(1);
                    ViewFunctionList();
                }
            }
        }

        #endregion

        #endregion

        #region "FunctionMenu管理"

        private void SetFunctionMenu(string userGroup)
        {
            treeFunctionMenu.Nodes.Clear();
            ConvertFunctionMenuListToNode(FunctionMenuService.GetFunctionMenu(userGroup), treeFunctionMenu.Nodes);
        }

        public void ConvertFunctionMenuListToNode(List<Function> sourceList, NodeCollection targetNodeCollection)
        {
            for (int i = 0; i < sourceList.Count; i++)
            {
                if (sourceList[i].ParentName == null || sourceList[i].ParentName == string.Empty || sourceList[i].FunctionType == "M")
                {
                    Node parentNode = new Node
                    {
                        Name = sourceList[i].FunctionName,
                        Text = sourceList[i].FunctionDesc,
                        Tag = sourceList[i]
                    };
                    targetNodeCollection.Add(parentNode);
                    AddChildNode(sourceList, sourceList[i].FunctionName, parentNode);
                }
            }
        }

        public void AddChildNode(List<Function> sourceList, string parentName, Node parentNode)
        {
            for (int i = 0; i < sourceList.Count; i++)
            {
                if (sourceList[i].ParentName == parentName)
                {
                    Node childNode = new Node
                    {
                        Name = sourceList[i].FunctionName,
                        Text = sourceList[i].FunctionDesc,
                        Tag = sourceList[i]
                    };
                    parentNode.Nodes.Add(childNode);
                    AddChildNode(sourceList, sourceList[i].FunctionName, childNode);
                }
            }
        }

        private void AddFunction(Function function, Node node)
        {
            if (IsFunctionExistInMenu(function) == false) return;
            Node newFunction = new Node
            {
                Text = function.FunctionDesc,
                Tag = function
            };
            if (node == null)
            {
                treeFunctionMenu.Nodes.Add(newFunction);
            }
            else if (node.Parent == null)
            {
                treeFunctionMenu.Nodes.Add(newFunction);
            }
            else
            {
                node.Parent.Nodes.AddRange(new Node[] { newFunction });
            }
        }

        private void AddChildFunction(Function function, Node node)
        {
            if (IsFunctionExistInMenu(function) == false) return;
            Node newFunction = new Node
            {
                Name = function.FunctionName,
                Text = function.FunctionDesc,
                Tag = function
            };
            node.Nodes.AddRange(new Node[] { newFunction });
            node.Expand();
        }

        private void RemoveFunction(Node node)
        {
            node.Remove();
        }

        private void RemoveChildFunction(Node node)
        {
            node.Nodes.Clear();
        }

        private bool IsFunctionExistInMenu(Function function)
        {
            foreach (Node node in treeFunctionMenu.Nodes)
            {
                if (IsFunctionExistInChildMenu(function, node) == false)
                {
                    MessageBox.Show(Language.Msg_Function_Already_Exist_In_Menu, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool IsFunctionExistInChildMenu(Function function, Node parentNode)
        {
            if (parentNode.Name == function.FunctionName)
            {
                return false;
            }
            foreach (Node node in parentNode.Nodes)
            {
                if (node.Name == function.FunctionName)
                {
                    return false;
                }
                if (IsFunctionExistInChildMenu(function, node) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void MoveFunctionUp(Node node)
        {
            if (node != null && node.Index > 0)
            {
                Node newNode = node.Copy();
                if (node.Parent == null)
                {
                    treeFunctionMenu.Nodes.Insert(node.PrevNode.Index, newNode);
                }
                else
                {
                    node.Parent.Nodes.Insert(node.PrevNode.Index, newNode);
                }
                CopyChildNode(node, newNode);
                node.Remove();
                treeFunctionMenu.SelectedNode = newNode;
            }
        }

        private void MoveFunctionDown(Node node)
        {
            if (node != null)
            {
                Node nextNode = node.NextNode;
                if (nextNode != null)
                {
                    Node newNode = node.Copy();
                    if (node.Parent == null)
                    {
                        treeFunctionMenu.Nodes.Insert(node.Index + 2, newNode);
                    }
                    else
                    {
                        node.Parent.Nodes.Insert(node.Index + 2, newNode);
                    }
                    CopyChildNode(node, newNode);
                    node.Remove();
                    treeFunctionMenu.SelectedNode = newNode;
                }
            }
        }

        private void CopyChildNode(Node sourceNode, Node targetNode)
        {
            foreach (Node node in sourceNode.Nodes)
            {
                Node newNode = node.Copy();
                targetNode.Nodes.Add(newNode);
                CopyChildNode(node, newNode);
            }
        }

        #region "界面事件"

        private void btnViewFunctionMenu_Click(object sender, EventArgs e)
        {
            SetFunctionMenu(cmbUserGroup.Text);
        }

        private void cmbUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFunctionMenu(cmbUserGroup.Text);
        }

        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            if (dgvFunctionList.SelectedRows.Count > 0)
            {
                Function function = FunctionMenuService.GetFunction(dgvFunctionList.SelectedRows[0].Cells[0].Value.ToString());
                if (function != null && function != default(Function))
                {
                    AddFunction(function, treeFunctionMenu.SelectedNode);
                }
            }
        }

        private void btnAddChildFunction_Click(object sender, EventArgs e)
        {
            if (dgvFunctionList.SelectedRows.Count > 0 && treeFunctionMenu.SelectedNode != null)
            {
                Function function = FunctionMenuService.GetFunction(dgvFunctionList.SelectedRows[0].Cells[0].Value.ToString());
                if (function != null && function != default(Function))
                {
                    AddChildFunction(function, treeFunctionMenu.SelectedNode);
                }
            }
        }

        private void btnRemoveFunction_Click(object sender, EventArgs e)
        {
            if (treeFunctionMenu.SelectedNode != null)
            {
                RemoveFunction(treeFunctionMenu.SelectedNode);
            }
        }

        private void btnRemoveChildFunction_Click(object sender, EventArgs e)
        {
            if (treeFunctionMenu.SelectedNode != null)
            {
                RemoveChildFunction(treeFunctionMenu.SelectedNode);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveFunctionUp(treeFunctionMenu.SelectedNode);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveFunctionDown(treeFunctionMenu.SelectedNode);
        }

        private void btnSaveFunctionMenu_Click(object sender, EventArgs e)
        {
            if (cmbUserGroup.Text.Trim() != string.Empty)
            {
                if (FunctionMenuService.SaveFunctionMenu(treeFunctionMenu.Nodes, cmbUserGroup.Text) == false)
                {
                    MessageBox.Show(Language.Msg_Operation_Failed, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(Language.Msg_Operation_Succeeded, Language.Caption_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #endregion
    }
}
