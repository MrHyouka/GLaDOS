namespace GLaDOS.UIL.Forms
{
    partial class FormMenuManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.expMenuList = new DevComponents.DotNetBar.ExpandablePanel();
            this.dgvFunctionList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewFunctionList = new DevComponents.DotNetBar.ButtonX();
            this.cmbFunctionTypeCondition = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlMenuManager = new System.Windows.Forms.Panel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeFunctionMenu = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveFunctionMenu = new DevComponents.DotNetBar.ButtonX();
            this.btnViewFunctionMenu = new DevComponents.DotNetBar.ButtonX();
            this.cmbUserGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnRemoveChildFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnMoveDown = new DevComponents.DotNetBar.ButtonX();
            this.btnAddChildFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnMoveUp = new DevComponents.DotNetBar.ButtonX();
            this.btnAddFunction = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.pnlFuntionSetup = new System.Windows.Forms.Panel();
            this.btnDeleteFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateFunction = new DevComponents.DotNetBar.ButtonX();
            this.btnViewFunction = new DevComponents.DotNetBar.ButtonX();
            this.cmbFunctionTypeSetup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.txtAssemblyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAssemblyFile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtFunctionDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtFunctionName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.expMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMenuManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeFunctionMenu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.pnlFuntionSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // expMenuList
            // 
            this.expMenuList.CanvasColor = System.Drawing.SystemColors.Control;
            this.expMenuList.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expMenuList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expMenuList.Controls.Add(this.dgvFunctionList);
            this.expMenuList.Controls.Add(this.panel1);
            this.expMenuList.DisabledBackColor = System.Drawing.Color.Empty;
            this.expMenuList.Dock = System.Windows.Forms.DockStyle.Left;
            this.expMenuList.HideControlsWhenCollapsed = true;
            this.expMenuList.Location = new System.Drawing.Point(0, 0);
            this.expMenuList.Name = "expMenuList";
            this.expMenuList.Size = new System.Drawing.Size(382, 686);
            this.expMenuList.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expMenuList.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expMenuList.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expMenuList.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expMenuList.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expMenuList.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expMenuList.Style.GradientAngle = 90;
            this.expMenuList.TabIndex = 10;
            this.expMenuList.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expMenuList.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expMenuList.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expMenuList.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expMenuList.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expMenuList.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expMenuList.TitleStyle.GradientAngle = 90;
            this.expMenuList.TitleText = "菜单列表";
            // 
            // dgvFunctionList
            // 
            this.dgvFunctionList.AllowUserToAddRows = false;
            this.dgvFunctionList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunctionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFunctionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunctionList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFunctionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunctionList.EnableHeadersVisualStyles = false;
            this.dgvFunctionList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvFunctionList.Location = new System.Drawing.Point(0, 70);
            this.dgvFunctionList.MultiSelect = false;
            this.dgvFunctionList.Name = "dgvFunctionList";
            this.dgvFunctionList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunctionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFunctionList.RowTemplate.Height = 23;
            this.dgvFunctionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunctionList.Size = new System.Drawing.Size(382, 616);
            this.dgvFunctionList.TabIndex = 4;
            this.dgvFunctionList.SelectionChanged += new System.EventHandler(this.dgvFunctionList_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnViewFunctionList);
            this.panel1.Controls.Add(this.cmbFunctionTypeCondition);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 44);
            this.panel1.TabIndex = 5;
            // 
            // btnViewFunctionList
            // 
            this.btnViewFunctionList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewFunctionList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewFunctionList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnViewFunctionList.Image = global::GLaDOS.Properties.Resources.search16_gray;
            this.btnViewFunctionList.Location = new System.Drawing.Point(206, 11);
            this.btnViewFunctionList.Name = "btnViewFunctionList";
            this.btnViewFunctionList.Size = new System.Drawing.Size(40, 21);
            this.btnViewFunctionList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewFunctionList.TabIndex = 2;
            this.btnViewFunctionList.Click += new System.EventHandler(this.btnViewFunctionList_Click);
            // 
            // cmbFunctionTypeCondition
            // 
            this.cmbFunctionTypeCondition.DisplayMember = "Text";
            this.cmbFunctionTypeCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFunctionTypeCondition.FormattingEnabled = true;
            this.cmbFunctionTypeCondition.ItemHeight = 15;
            this.cmbFunctionTypeCondition.Location = new System.Drawing.Point(71, 11);
            this.cmbFunctionTypeCondition.Name = "cmbFunctionTypeCondition";
            this.cmbFunctionTypeCondition.Size = new System.Drawing.Size(120, 21);
            this.cmbFunctionTypeCondition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFunctionTypeCondition.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "菜单类型";
            // 
            // pnlMenuManager
            // 
            this.pnlMenuManager.Controls.Add(this.superTabControl1);
            this.pnlMenuManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuManager.Location = new System.Drawing.Point(382, 0);
            this.pnlMenuManager.Name = "pnlMenuManager";
            this.pnlMenuManager.Size = new System.Drawing.Size(705, 686);
            this.pnlMenuManager.TabIndex = 22;
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(705, 686);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.panel4);
            this.superTabControlPanel2.Controls.Add(this.panel3);
            this.superTabControlPanel2.Controls.Add(this.panel2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(705, 658);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.treeFunctionMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(48, 42);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(657, 616);
            this.panel4.TabIndex = 2;
            // 
            // treeFunctionMenu
            // 
            this.treeFunctionMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeFunctionMenu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.treeFunctionMenu.BackgroundStyle.Class = "TreeBorderKey";
            this.treeFunctionMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeFunctionMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFunctionMenu.Location = new System.Drawing.Point(0, 0);
            this.treeFunctionMenu.Name = "treeFunctionMenu";
            this.treeFunctionMenu.NodesConnector = this.nodeConnector1;
            this.treeFunctionMenu.NodeStyle = this.elementStyle1;
            this.treeFunctionMenu.PathSeparator = ";";
            this.treeFunctionMenu.Size = new System.Drawing.Size(647, 616);
            this.treeFunctionMenu.Styles.Add(this.elementStyle1);
            this.treeFunctionMenu.TabIndex = 3;
            this.treeFunctionMenu.Text = "treeFunctionMenu";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnSaveFunctionMenu);
            this.panel3.Controls.Add(this.btnViewFunctionMenu);
            this.panel3.Controls.Add(this.cmbUserGroup);
            this.panel3.Controls.Add(this.labelX7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(48, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 42);
            this.panel3.TabIndex = 1;
            // 
            // btnSaveFunctionMenu
            // 
            this.btnSaveFunctionMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveFunctionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFunctionMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveFunctionMenu.Image = global::GLaDOS.Properties.Resources.check_16_gray;
            this.btnSaveFunctionMenu.Location = new System.Drawing.Point(269, 9);
            this.btnSaveFunctionMenu.Name = "btnSaveFunctionMenu";
            this.btnSaveFunctionMenu.Size = new System.Drawing.Size(40, 21);
            this.btnSaveFunctionMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveFunctionMenu.TabIndex = 3;
            this.btnSaveFunctionMenu.Click += new System.EventHandler(this.btnSaveFunctionMenu_Click);
            // 
            // btnViewFunctionMenu
            // 
            this.btnViewFunctionMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewFunctionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewFunctionMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnViewFunctionMenu.Image = global::GLaDOS.Properties.Resources.search16_gray;
            this.btnViewFunctionMenu.Location = new System.Drawing.Point(212, 9);
            this.btnViewFunctionMenu.Name = "btnViewFunctionMenu";
            this.btnViewFunctionMenu.Size = new System.Drawing.Size(40, 21);
            this.btnViewFunctionMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewFunctionMenu.TabIndex = 2;
            this.btnViewFunctionMenu.Click += new System.EventHandler(this.btnViewFunctionMenu_Click);
            // 
            // cmbUserGroup
            // 
            this.cmbUserGroup.DisplayMember = "Text";
            this.cmbUserGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserGroup.FormattingEnabled = true;
            this.cmbUserGroup.ItemHeight = 15;
            this.cmbUserGroup.Location = new System.Drawing.Point(76, 9);
            this.cmbUserGroup.Name = "cmbUserGroup";
            this.cmbUserGroup.Size = new System.Drawing.Size(120, 21);
            this.cmbUserGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUserGroup.TabIndex = 0;
            this.cmbUserGroup.SelectedIndexChanged += new System.EventHandler(this.cmbUserGroup_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(56, 18);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "用户组别";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnRemoveFunction);
            this.panel2.Controls.Add(this.btnRemoveChildFunction);
            this.panel2.Controls.Add(this.btnMoveDown);
            this.panel2.Controls.Add(this.btnAddChildFunction);
            this.panel2.Controls.Add(this.btnMoveUp);
            this.panel2.Controls.Add(this.btnAddFunction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 658);
            this.panel2.TabIndex = 0;
            // 
            // btnRemoveFunction
            // 
            this.btnRemoveFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemoveFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemoveFunction.Image = global::GLaDOS.Properties.Resources.arrow_left_32_gray;
            this.btnRemoveFunction.Location = new System.Drawing.Point(6, 220);
            this.btnRemoveFunction.Name = "btnRemoveFunction";
            this.btnRemoveFunction.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemoveFunction.TabIndex = 3;
            this.btnRemoveFunction.Click += new System.EventHandler(this.btnRemoveFunction_Click);
            // 
            // btnRemoveChildFunction
            // 
            this.btnRemoveChildFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemoveChildFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveChildFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveChildFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemoveChildFunction.Image = global::GLaDOS.Properties.Resources.page_first_32_gray;
            this.btnRemoveChildFunction.Location = new System.Drawing.Point(6, 332);
            this.btnRemoveChildFunction.Name = "btnRemoveChildFunction";
            this.btnRemoveChildFunction.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveChildFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemoveChildFunction.TabIndex = 4;
            this.btnRemoveChildFunction.Click += new System.EventHandler(this.btnRemoveChildFunction_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMoveDown.Image = global::GLaDOS.Properties.Resources.arrow_down_32_gray;
            this.btnMoveDown.Location = new System.Drawing.Point(6, 109);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(35, 35);
            this.btnMoveDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnAddChildFunction
            // 
            this.btnAddChildFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddChildFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddChildFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddChildFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddChildFunction.Image = global::GLaDOS.Properties.Resources.page_last_32_gray;
            this.btnAddChildFunction.Location = new System.Drawing.Point(6, 291);
            this.btnAddChildFunction.Name = "btnAddChildFunction";
            this.btnAddChildFunction.Size = new System.Drawing.Size(35, 35);
            this.btnAddChildFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddChildFunction.TabIndex = 4;
            this.btnAddChildFunction.Click += new System.EventHandler(this.btnAddChildFunction_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMoveUp.Image = global::GLaDOS.Properties.Resources.arrow_up_32_gray;
            this.btnMoveUp.Location = new System.Drawing.Point(6, 68);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(35, 35);
            this.btnMoveUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddFunction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddFunction.Image = global::GLaDOS.Properties.Resources.arrow_right_32_gray;
            this.btnAddFunction.Location = new System.Drawing.Point(6, 179);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(35, 35);
            this.btnAddFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddFunction.TabIndex = 4;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "界面分配";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.pnlFuntionSetup);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(705, 658);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // pnlFuntionSetup
            // 
            this.pnlFuntionSetup.BackColor = System.Drawing.Color.Transparent;
            this.pnlFuntionSetup.Controls.Add(this.btnDeleteFunction);
            this.pnlFuntionSetup.Controls.Add(this.btnUpdateFunction);
            this.pnlFuntionSetup.Controls.Add(this.btnCreateFunction);
            this.pnlFuntionSetup.Controls.Add(this.btnViewFunction);
            this.pnlFuntionSetup.Controls.Add(this.cmbFunctionTypeSetup);
            this.pnlFuntionSetup.Controls.Add(this.labelX4);
            this.pnlFuntionSetup.Controls.Add(this.line1);
            this.pnlFuntionSetup.Controls.Add(this.line2);
            this.pnlFuntionSetup.Controls.Add(this.txtAssemblyName);
            this.pnlFuntionSetup.Controls.Add(this.txtAssemblyFile);
            this.pnlFuntionSetup.Controls.Add(this.labelX6);
            this.pnlFuntionSetup.Controls.Add(this.txtFunctionDesc);
            this.pnlFuntionSetup.Controls.Add(this.labelX5);
            this.pnlFuntionSetup.Controls.Add(this.txtFunctionName);
            this.pnlFuntionSetup.Controls.Add(this.labelX3);
            this.pnlFuntionSetup.Controls.Add(this.labelX2);
            this.pnlFuntionSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFuntionSetup.Location = new System.Drawing.Point(0, 0);
            this.pnlFuntionSetup.Name = "pnlFuntionSetup";
            this.pnlFuntionSetup.Size = new System.Drawing.Size(705, 658);
            this.pnlFuntionSetup.TabIndex = 2;
            // 
            // btnDeleteFunction
            // 
            this.btnDeleteFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteFunction.Image = global::GLaDOS.Properties.Resources.close_16_gray;
            this.btnDeleteFunction.Location = new System.Drawing.Point(139, 251);
            this.btnDeleteFunction.Name = "btnDeleteFunction";
            this.btnDeleteFunction.Size = new System.Drawing.Size(40, 21);
            this.btnDeleteFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteFunction.TabIndex = 2;
            this.btnDeleteFunction.Click += new System.EventHandler(this.btnDeleteFunction_Click);
            // 
            // btnUpdateFunction
            // 
            this.btnUpdateFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateFunction.Image = global::GLaDOS.Properties.Resources.refresh_16_gray;
            this.btnUpdateFunction.Location = new System.Drawing.Point(81, 251);
            this.btnUpdateFunction.Name = "btnUpdateFunction";
            this.btnUpdateFunction.Size = new System.Drawing.Size(40, 21);
            this.btnUpdateFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateFunction.TabIndex = 2;
            // 
            // btnCreateFunction
            // 
            this.btnCreateFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateFunction.Image = global::GLaDOS.Properties.Resources.check_16_gray;
            this.btnCreateFunction.Location = new System.Drawing.Point(23, 251);
            this.btnCreateFunction.Name = "btnCreateFunction";
            this.btnCreateFunction.Size = new System.Drawing.Size(40, 21);
            this.btnCreateFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateFunction.TabIndex = 2;
            this.btnCreateFunction.Click += new System.EventHandler(this.btnCreateFunction_Click);
            // 
            // btnViewFunction
            // 
            this.btnViewFunction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewFunction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnViewFunction.Image = global::GLaDOS.Properties.Resources.search16_gray;
            this.btnViewFunction.Location = new System.Drawing.Point(247, 21);
            this.btnViewFunction.Name = "btnViewFunction";
            this.btnViewFunction.Size = new System.Drawing.Size(40, 21);
            this.btnViewFunction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewFunction.TabIndex = 2;
            this.btnViewFunction.Click += new System.EventHandler(this.btnViewFunction_Click);
            // 
            // cmbFunctionTypeSetup
            // 
            this.cmbFunctionTypeSetup.DisplayMember = "Text";
            this.cmbFunctionTypeSetup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFunctionTypeSetup.FormattingEnabled = true;
            this.cmbFunctionTypeSetup.ItemHeight = 15;
            this.cmbFunctionTypeSetup.Location = new System.Drawing.Point(81, 114);
            this.cmbFunctionTypeSetup.Name = "cmbFunctionTypeSetup";
            this.cmbFunctionTypeSetup.Size = new System.Drawing.Size(88, 21);
            this.cmbFunctionTypeSetup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFunctionTypeSetup.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(19, 116);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 18);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "菜单类型";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(19, 278);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(658, 23);
            this.line1.TabIndex = 3;
            this.line1.Text = "line2";
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.Location = new System.Drawing.Point(19, 48);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(658, 23);
            this.line2.TabIndex = 3;
            this.line2.Text = "line2";
            // 
            // txtAssemblyName
            // 
            // 
            // 
            // 
            this.txtAssemblyName.Border.Class = "TextBoxBorder";
            this.txtAssemblyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAssemblyName.Location = new System.Drawing.Point(81, 191);
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.PreventEnterBeep = true;
            this.txtAssemblyName.Size = new System.Drawing.Size(300, 21);
            this.txtAssemblyName.TabIndex = 0;
            // 
            // txtAssemblyFile
            // 
            // 
            // 
            // 
            this.txtAssemblyFile.Border.Class = "TextBoxBorder";
            this.txtAssemblyFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAssemblyFile.Location = new System.Drawing.Point(81, 152);
            this.txtAssemblyFile.Name = "txtAssemblyFile";
            this.txtAssemblyFile.PreventEnterBeep = true;
            this.txtAssemblyFile.Size = new System.Drawing.Size(144, 21);
            this.txtAssemblyFile.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(19, 194);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(56, 18);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "组件类名";
            // 
            // txtFunctionDesc
            // 
            // 
            // 
            // 
            this.txtFunctionDesc.Border.Class = "TextBoxBorder";
            this.txtFunctionDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFunctionDesc.Location = new System.Drawing.Point(81, 77);
            this.txtFunctionDesc.Name = "txtFunctionDesc";
            this.txtFunctionDesc.PreventEnterBeep = true;
            this.txtFunctionDesc.Size = new System.Drawing.Size(144, 21);
            this.txtFunctionDesc.TabIndex = 0;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(19, 155);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(56, 18);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "组件包名";
            // 
            // txtFunctionName
            // 
            // 
            // 
            // 
            this.txtFunctionName.Border.Class = "TextBoxBorder";
            this.txtFunctionName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFunctionName.Location = new System.Drawing.Point(81, 21);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.PreventEnterBeep = true;
            this.txtFunctionName.Size = new System.Drawing.Size(144, 21);
            this.txtFunctionName.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(19, 80);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 18);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "菜单名";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 24);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "菜单编码";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "界面注册";
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 686);
            this.Controls.Add(this.pnlMenuManager);
            this.Controls.Add(this.expMenuList);
            this.Name = "FormMenuManager";
            this.Text = "FormMenuManager";
            this.Load += new System.EventHandler(this.FormMenuManager_Load);
            this.expMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenuManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeFunctionMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.pnlFuntionSetup.ResumeLayout(false);
            this.pnlFuntionSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ExpandablePanel expMenuList;
        private System.Windows.Forms.Panel pnlMenuManager;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFunctionTypeCondition;
        private DevComponents.DotNetBar.ButtonX btnViewFunctionList;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlFuntionSetup;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFunctionName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.ButtonX btnViewFunction;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbFunctionTypeSetup;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAssemblyName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAssemblyFile;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFunctionDesc;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFunctionList;
        private DevComponents.DotNetBar.ButtonX btnDeleteFunction;
        private DevComponents.DotNetBar.ButtonX btnUpdateFunction;
        private DevComponents.DotNetBar.ButtonX btnCreateFunction;
        private DevComponents.DotNetBar.ButtonX btnRemoveFunction;
        private DevComponents.DotNetBar.ButtonX btnAddFunction;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUserGroup;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnViewFunctionMenu;
        private DevComponents.AdvTree.AdvTree treeFunctionMenu;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonX btnMoveDown;
        private DevComponents.DotNetBar.ButtonX btnMoveUp;
        private DevComponents.DotNetBar.ButtonX btnRemoveChildFunction;
        private DevComponents.DotNetBar.ButtonX btnAddChildFunction;
        private DevComponents.DotNetBar.ButtonX btnSaveFunctionMenu;
    }
}