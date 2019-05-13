using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;
using GLaDOS.BLL;
using GLaDOS.BLL.Entity;
using GLaDOS.BLL.Public;
using GLaDOS.Properties;

namespace GLaDOS
{
    public partial class FormMain : Office2007Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region "声明"

        List<Function> FunctionMenuList = new List<Function>();

        #endregion

        #region "界面初始化"

        private void FormMain_Load(object sender, EventArgs e)
        {
            GetFunctionMenuList();
            SetFunctionMenu();
        }

        private void btnRefreashFunctionMenu_Click(object sender, EventArgs e)
        {
            GetFunctionMenuList();
            SetFunctionMenu();
        }

        #region "初始化主界面功能菜单"

        /// <summary>
        /// 获取功菜单能列表
        /// </summary>
        private void GetFunctionMenuList()
        {
            FunctionMenuList = FunctionMenuService.GetFunctionMenu(GlobalInformation.Login_User_Group);
        }

        /// <summary>
        /// 设置用户功能菜单
        /// </summary>
        private void SetFunctionMenu()
        {
            treeFunctionMenu.Nodes.Clear();
            ConvertFunctionMenuListToNode(FunctionMenuList, treeFunctionMenu.Nodes);
        }

        /// <summary>
        /// 将菜单列表转为菜单树，并将菜单对象赋值给成员Tag
        /// </summary>
        /// <param name="sourceList">菜单列表</param>
        /// <param name="targetNodeCollection">菜单Node</param>
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

        /// <summary>
        /// 递归填充子Node
        /// </summary>
        /// <param name="sourceList">菜单列表</param>
        /// <param name="parentName">父Node名</param>
        /// <param name="parentNode">父Node</param>
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

        #endregion

        #endregion

        #region "加载功能界面"

        /// <summary>
        /// 通过反射获取窗体对象
        /// </summary>
        /// <param name="assemblyFile">窗体所在文件名</param>
        /// <param name="assemblyName">窗体所在类全名</param>
        /// <returns>窗体对象</returns>
        public static Form GetFormByReflection(string assemblyFile, string assemblyName)
        {
            try
            {
                Type formType = null;
                if (assemblyFile == Assembly.GetExecutingAssembly().GetName().Name) //如果AssemblyFile与当前主程序一致，则从.exe文件中获取界面
                {
                    formType = Assembly.LoadFrom(assemblyFile + ".exe").GetType(assemblyName);
                }
                else //否则，从.dll文件中获取界面
                {
                    formType = Assembly.LoadFrom(assemblyFile + ".dll").GetType(assemblyName);
                }
                if (formType != null)//查看反射是否成功
                {
                    if (typeof(Form).IsAssignableFrom(formType)) //反射结果是否为窗体Form
                    {
                        return (Form)Activator.CreateInstance(formType); //返回窗体对象实例
                    }
                    else
                    { MessageBox.Show(Language.Msg_TargetClass_IsNot_Form, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
                }
                else
                { MessageBox.Show(Language.Msg_TargetClass_IsNot_Exist, Language.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }
            catch { throw; }
        }

        /// <summary>
        /// 将界面添加至Tab页中
        /// </summary>
        /// <param name="form">界面对象</param>
        /// <param name="tabName">Tab名称</param>
        /// <param name="tabText">Tab显示页签名称</param>
        public void AddFormToTab(Form form, string tabName, string tabText)
        {
            try
            {
                foreach (SuperTabItem tab in tabMain.Tabs)
                {
                    //如果界面已打开，则切换至该界面
                    if (tab.Name == tabName)
                    {
                        tabMain.SelectedTab = tab;
                        return;
                    }
                }
                //配置子窗体必要属性
                form.TopLevel = false;
                form.Visible = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                //新增Tab，并将页面Dock进新Tab页
                SuperTabItem tabItem = tabMain.CreateTab(tabName);
                if (tabText == null || tabText == string.Empty)
                    tabItem.Text = tabName;
                else
                    tabItem.Text = tabText;
                tabItem.Name = tabName;
                tabItem.AttachedControl.Controls.Add(form);

                //选中新增的Tab
                tabMain.SelectedTab = tabItem;
            }
            catch { throw; }
        }

        /// <summary>
        /// 通过功能菜单对象在Tab中打开功能界面
        /// </summary>
        /// <param name="function"></param>
        private void OpenNewTabForm(Function function)
        {
            AddFormToTab(GetFormByReflection(function.AssemblyFile, function.AssemblyName), function.FunctionName, function.FunctionDesc);
        }

        private void treeFunctionMenu_Click(object sender, EventArgs e)
        {
            if (treeFunctionMenu.SelectedNode == null) return;
            if (treeFunctionMenu.SelectedNode.Nodes.Count != 0) return;
            if (((Function)treeFunctionMenu.SelectedNode.Tag).FunctionType == "M") return;
            OpenNewTabForm((Function)treeFunctionMenu.SelectedNode.Tag);
        }

        #endregion
    }
}
