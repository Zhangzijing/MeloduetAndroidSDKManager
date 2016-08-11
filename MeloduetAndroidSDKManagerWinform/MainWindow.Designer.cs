namespace MeloduetAndroidSDKManagerWinform
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.packageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.bottomContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.ListView();
            this.mainImageList = new System.Windows.Forms.ImageList(this.components);
            this.sdkListView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderApi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHostOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCheckNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextInsertSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNormal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarDownload = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelDownload = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButtonReFetch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).BeginInit();
            this.centerContainer.Panel1.SuspendLayout();
            this.centerContainer.Panel2.SuspendLayout();
            this.centerContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomContainer)).BeginInit();
            this.bottomContainer.Panel1.SuspendLayout();
            this.bottomContainer.Panel2.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.menuStrip1);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.centerContainer);
            this.mainContainer.Size = new System.Drawing.Size(856, 646);
            this.mainContainer.SplitterDistance = 26;
            this.mainContainer.TabIndex = 0;
            this.mainContainer.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // packageToolStripMenuItem
            // 
            this.packageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refetchToolStripMenuItem});
            this.packageToolStripMenuItem.Name = "packageToolStripMenuItem";
            this.packageToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.packageToolStripMenuItem.Text = "文件(&F)";
            // 
            // refetchToolStripMenuItem
            // 
            this.refetchToolStripMenuItem.Enabled = false;
            this.refetchToolStripMenuItem.Name = "refetchToolStripMenuItem";
            this.refetchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refetchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.refetchToolStripMenuItem.Text = "刷新(&R)";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRepoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.optionToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // selectRepoToolStripMenuItem
            // 
            this.selectRepoToolStripMenuItem.Name = "selectRepoToolStripMenuItem";
            this.selectRepoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.selectRepoToolStripMenuItem.Text = "选择源(&S)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.optionToolStripMenuItem.Text = "选项(&O)";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonSetting_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助(&H)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 6);
            // 
            // aboutMeloduetAndroidSDKManagerToolStripMenuItem
            // 
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem.Name = "aboutMeloduetAndroidSDKManagerToolStripMenuItem";
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem.Text = "关于Meloduet Android SDK Manager(&A)";
            this.aboutMeloduetAndroidSDKManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutMeloduetAndroidSDKManagerToolStripMenuItem_Click);
            // 
            // centerContainer
            // 
            this.centerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.centerContainer.IsSplitterFixed = true;
            this.centerContainer.Location = new System.Drawing.Point(0, 0);
            this.centerContainer.Name = "centerContainer";
            this.centerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // centerContainer.Panel1
            // 
            this.centerContainer.Panel1.Controls.Add(this.toolStrip1);
            // 
            // centerContainer.Panel2
            // 
            this.centerContainer.Panel2.Controls.Add(this.bottomContainer);
            this.centerContainer.Size = new System.Drawing.Size(856, 616);
            this.centerContainer.SplitterDistance = 25;
            this.centerContainer.TabIndex = 0;
            this.centerContainer.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReFetch,
            this.toolStripButtonSetting,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "搜索:";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBoxSearch.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_TextChanged);
            // 
            // bottomContainer
            // 
            this.bottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.bottomContainer.IsSplitterFixed = true;
            this.bottomContainer.Location = new System.Drawing.Point(0, 0);
            this.bottomContainer.Margin = new System.Windows.Forms.Padding(0);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bottomContainer.Panel1
            // 
            this.bottomContainer.Panel1.Controls.Add(this.splitContainer1);
            // 
            // bottomContainer.Panel2
            // 
            this.bottomContainer.Panel2.Controls.Add(this.statusStrip1);
            this.bottomContainer.Size = new System.Drawing.Size(856, 587);
            this.bottomContainer.SplitterDistance = 558;
            this.bottomContainer.TabIndex = 0;
            this.bottomContainer.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sdkListView);
            this.splitContainer1.Size = new System.Drawing.Size(856, 558);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1MinSize = 20;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabList);
            this.splitContainer2.Size = new System.Drawing.Size(161, 558);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择显示项目:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabList
            // 
            this.tabList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabList.CheckBoxes = true;
            this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList.FullRowSelect = true;
            this.tabList.Location = new System.Drawing.Point(0, 0);
            this.tabList.Name = "tabList";
            this.tabList.Size = new System.Drawing.Size(161, 529);
            this.tabList.SmallImageList = this.mainImageList;
            this.tabList.TabIndex = 0;
            this.tabList.UseCompatibleStateImageBehavior = false;
            this.tabList.View = System.Windows.Forms.View.List;
            this.tabList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tabList_ItemCheck);
            // 
            // mainImageList
            // 
            this.mainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainImageList.ImageStream")));
            this.mainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainImageList.Images.SetKeyName(0, "google-api.png");
            this.mainImageList.Images.SetKeyName(1, "image.png");
            this.mainImageList.Images.SetKeyName(2, "sdk-build-tool.png");
            this.mainImageList.Images.SetKeyName(3, "sdk-tool.png");
            this.mainImageList.Images.SetKeyName(4, "source.png");
            this.mainImageList.Images.SetKeyName(5, "tool.png");
            this.mainImageList.Images.SetKeyName(6, "version.png");
            this.mainImageList.Images.SetKeyName(7, "folder.png");
            // 
            // sdkListView
            // 
            this.sdkListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.sdkListView.CheckBoxes = true;
            this.sdkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderApi,
            this.columnHeaderRev,
            this.columnHeaderUrl,
            this.columnHeaderHostOS,
            this.columnHeaderCheckNum,
            this.columnHeaderSize});
            this.sdkListView.ContextMenuStrip = this.mainContextMenuStrip;
            this.sdkListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdkListView.FullRowSelect = true;
            this.sdkListView.HideSelection = false;
            this.sdkListView.Location = new System.Drawing.Point(0, 0);
            this.sdkListView.Margin = new System.Windows.Forms.Padding(0);
            this.sdkListView.Name = "sdkListView";
            this.sdkListView.Size = new System.Drawing.Size(691, 558);
            this.sdkListView.SmallImageList = this.mainImageList;
            this.sdkListView.TabIndex = 0;
            this.sdkListView.UseCompatibleStateImageBehavior = false;
            this.sdkListView.View = System.Windows.Forms.View.Details;
            this.sdkListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.sdkListView_ColumnClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 177;
            // 
            // columnHeaderApi
            // 
            this.columnHeaderApi.Text = "API";
            // 
            // columnHeaderRev
            // 
            this.columnHeaderRev.Text = "Rev";
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "Url";
            this.columnHeaderUrl.Width = 85;
            // 
            // columnHeaderHostOS
            // 
            this.columnHeaderHostOS.Text = "HostOS";
            this.columnHeaderHostOS.Width = 79;
            // 
            // columnHeaderCheckNum
            // 
            this.columnHeaderCheckNum.Text = "CheckNum";
            this.columnHeaderCheckNum.Width = 180;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextSelectToolStripMenuItem,
            this.contextInsertSelectToolStripMenuItem,
            this.contextSelectAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.contextCopyToolStripMenuItem,
            this.contextCopyUrlToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(183, 120);
            // 
            // contextSelectToolStripMenuItem
            // 
            this.contextSelectToolStripMenuItem.Name = "contextSelectToolStripMenuItem";
            this.contextSelectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contextSelectToolStripMenuItem.Text = "勾选";
            this.contextSelectToolStripMenuItem.Click += new System.EventHandler(this.contextSelectToolStripMenuItem_Click);
            // 
            // contextInsertSelectToolStripMenuItem
            // 
            this.contextInsertSelectToolStripMenuItem.Name = "contextInsertSelectToolStripMenuItem";
            this.contextInsertSelectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contextInsertSelectToolStripMenuItem.Text = "反选";
            this.contextInsertSelectToolStripMenuItem.Click += new System.EventHandler(this.contextInsertSelectToolStripMenuItem_Click);
            // 
            // contextSelectAllToolStripMenuItem
            // 
            this.contextSelectAllToolStripMenuItem.Name = "contextSelectAllToolStripMenuItem";
            this.contextSelectAllToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contextSelectAllToolStripMenuItem.Text = "全选";
            this.contextSelectAllToolStripMenuItem.Click += new System.EventHandler(this.contextSelectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // contextCopyToolStripMenuItem
            // 
            this.contextCopyToolStripMenuItem.Name = "contextCopyToolStripMenuItem";
            this.contextCopyToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contextCopyToolStripMenuItem.Text = "复制勾选项信息";
            this.contextCopyToolStripMenuItem.Click += new System.EventHandler(this.contextCopyToolStripMenuItem_Click);
            // 
            // contextCopyUrlToolStripMenuItem
            // 
            this.contextCopyUrlToolStripMenuItem.Name = "contextCopyUrlToolStripMenuItem";
            this.contextCopyUrlToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.contextCopyUrlToolStripMenuItem.Text = "复制勾选项下载地址";
            this.contextCopyUrlToolStripMenuItem.Click += new System.EventHandler(this.contextCopyUrlToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNormal,
            this.toolStripProgressBarDownload,
            this.toolStripStatusLabelDownload});
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNormal
            // 
            this.toolStripStatusLabelNormal.Name = "toolStripStatusLabelNormal";
            this.toolStripStatusLabelNormal.Size = new System.Drawing.Size(589, 17);
            this.toolStripStatusLabelNormal.Spring = true;
            this.toolStripStatusLabelNormal.Text = "就绪.";
            this.toolStripStatusLabelNormal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBarDownload
            // 
            this.toolStripProgressBarDownload.Name = "toolStripProgressBarDownload";
            this.toolStripProgressBarDownload.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarDownload.Step = 1;
            // 
            // toolStripStatusLabelDownload
            // 
            this.toolStripStatusLabelDownload.AutoSize = false;
            this.toolStripStatusLabelDownload.Name = "toolStripStatusLabelDownload";
            this.toolStripStatusLabelDownload.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabelDownload.Text = "无下载任务";
            this.toolStripStatusLabelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonReFetch
            // 
            this.toolStripButtonReFetch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReFetch.Enabled = false;
            this.toolStripButtonReFetch.Image = global::MeloduetAndroidSDKManagerWinform.Properties.Resources.reload;
            this.toolStripButtonReFetch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReFetch.Name = "toolStripButtonReFetch";
            this.toolStripButtonReFetch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReFetch.Text = "toolStripButton1";
            this.toolStripButtonReFetch.Click += new System.EventHandler(this.toolStripButtonReFetch_Click);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetting.Image = global::MeloduetAndroidSDKManagerWinform.Properties.Resources.setting;
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSetting.Text = "toolStripButton2";
            this.toolStripButtonSetting.Click += new System.EventHandler(this.toolStripButtonSetting_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::MeloduetAndroidSDKManagerWinform.Properties.Resources.down;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "下载(不可用)";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 646);
            this.Controls.Add(this.mainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Meloduet Android SDK Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.centerContainer.Panel1.ResumeLayout(false);
            this.centerContainer.Panel1.PerformLayout();
            this.centerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerContainer)).EndInit();
            this.centerContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bottomContainer.Panel1.ResumeLayout(false);
            this.bottomContainer.Panel2.ResumeLayout(false);
            this.bottomContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomContainer)).EndInit();
            this.bottomContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.mainContextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer centerContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer bottomContainer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView sdkListView;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderApi;
        private System.Windows.Forms.ColumnHeader columnHeaderRev;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNormal;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarDownload;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDownload;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderHostOS;
        private System.Windows.Forms.ColumnHeader columnHeaderCheckNum;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextInsertSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextSelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCopyUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonReFetch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetting;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ImageList mainImageList;
        private System.Windows.Forms.ListView tabList;
        private System.Windows.Forms.ToolStripMenuItem packageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutMeloduetAndroidSDKManagerToolStripMenuItem;
    }
}

