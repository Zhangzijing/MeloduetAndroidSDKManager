using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using MeloduetAndroidSDKManagerWinform.Helper;
using System.Threading;

namespace MeloduetAndroidSDKManagerWinform
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        delegate void SetTextCallback(int value, string msg);
        delegate void UpdateCheckListCallback();
        public void UpdateProgress(int value, string msg)
        {
                        SetTextCallback d = new SetTextCallback(UpdateProgressByMainThread);
            this.Invoke(d, new object[] { value,msg });

        }
        private void UpdateProgressByMainThread(int value, string msg)
        {
            toolStripProgressBarDownload.Value = value;
            toolStripStatusLabelDownload.Text = msg;
            
        }
        private void UpdateRepo()
        {
            selectRepoToolStripMenuItem.DropDownItems.Clear();
            for (int i = 0; i < Data.AppSet.Repository.Count; i++)
            {
                var item = Data.AppSet.Repository[i];
                var toolStripItm  = new ToolStripMenuItem();
                toolStripItm.Text = item;
                if (i == Data.AppSet.SeletedRepository)
                    toolStripItm.Checked = true;
                toolStripItm.Tag = i;
                selectRepoToolStripMenuItem.DropDownItems.Add(toolStripItm);
                toolStripItm.Click += OnRepoItemClick;
            }
        }

        private void OnRepoItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                var curitm = sender as ToolStripMenuItem;
                var index = (int)curitm.Tag ;
                foreach (ToolStripMenuItem item in selectRepoToolStripMenuItem.DropDownItems)
                {
                    if (item==curitm)
                    {
                        item.Checked = true;
                        Data.AppSet.SeletedRepository = index;
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Data.AppSet = ApplicationSetting.Load("setting.json");
            UpdateRepo();

            toolStripButtonReFetch_Click(this, null);

        }

        int apiIndexMax = -1;
        void UpdateCheckListByMainThread()
        {
            if (!Data.Inited)
            {
                return;

            }
            foreach (var item in Data.SdkRepository.platform)
            {
                ListHelper.AddIfNotExists(Data.ApiLevel, item.apilevel);
            }
            foreach (var api in Data.ApiLevel)
            {
                tabList.Items.Add(Data.AndroidLevel[api] + "(API" + api + ")",6);
            }
            apiIndexMax = tabList.Items.Count - 1;
            //Tools
            tabList.Items.Add("Tools",5);
            //Extras
            tabList.Items.Add("Extras",7);
            Logger.Log("Start Fetching, Repository.Url=" + Data.AppSet.Repository[Data.AppSet.SeletedRepository]);
            Logger.Log("Fetched.");
            toolStripButtonReFetch.Enabled = true;
            refetchToolStripMenuItem.Enabled = true;

        }
        void UpdateCheckList()
        {
            UpdateCheckListCallback d = new UpdateCheckListCallback(UpdateCheckListByMainThread);
            this.Invoke(d);

           
            
        }
        List<int> selectedLevel = new List<int>();
        List<ListViewItem> cacheItems = new List<ListViewItem>();

        void UpdateListView()
        {
            sdkListView.Items.Clear();
            foreach (var item in cacheItems)
            {

                sdkListView.Items.Add(item);
            }
        }
       


        private bool IsListViewItemEqual(ListViewItem a, ListViewItem b)
        {
            if (a.Text == b.Text && a.SubItems[1].Text == b.SubItems[1].Text
                && a.SubItems[2].Text == b.SubItems[2].Text && a.Tag == b.Tag)
            {
                return true;
            } else return false;
        }
        private bool IsAContainsB(List<ListViewItem> a, ListViewItem b)
        {
            foreach (var item in a)
            {
                if (IsListViewItemEqual(item,b))
                {
                    return true;
                }
            }
            return false;
        }

        private void contextSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sdkListView.SelectedItems)
            {
                item.Checked = true;
            }
        }

        private void contextInsertSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sdkListView.SelectedItems)
            {
                item.Checked = !item.Checked;
            }
        }

        private void contextSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sdkListView.Items)
            {
                item.Checked = true;
            }
        }

        private void contextCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (ListViewItem item in sdkListView.CheckedItems)
            {
                
                for (int i = 0; i < sdkListView.Columns.Count; i++)
                {
                    sb.AppendLine(sdkListView.Columns[i].Text + ": " + item.SubItems[i].Text);
                }
                sb.AppendLine();
            }
            Clipboard.SetText(sb.ToString());
        }

        private void contextCopyUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (ListViewItem item in sdkListView.CheckedItems)
            {
                int i = 3;
                sb.AppendLine(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/"+ item.SubItems[i].Text);                
                sb.AppendLine();
            }
            Clipboard.SetText(sb.ToString());
        }
        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string query = toolStripTextBoxSearch.Text;
            if (query == string.Empty)
            {
                foreach (ListViewItem item in sdkListView.Items)
                {
                    item.Selected = false;
                }
                    return;
            }
            foreach (ListViewItem item in sdkListView.Items)
            {
                bool flag = false;
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    if (subitem.Text.Contains(query))
                    {
                        
                        flag = true;
                    }
                }
                if (flag)
                {
                    item.Selected = true;
                }
                else
                {
                    item.Selected = false;
                }
            }
            
        }

        private void toolStripButtonReFetch_Click(object sender, EventArgs e)
        {
            tabList.Clear();
            toolStripButtonReFetch.Enabled = false;
            refetchToolStripMenuItem .Enabled= false;
            Task.Factory.StartNew(() =>
            {
                DataFetch.FetchAll(UpdateProgress, UpdateCheckList);
            });            
            
             
            

        }

        private void tabList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            selectedLevel.Clear();
            cacheItems.Clear();
            for (int i = 0; i < apiIndexMax + 1; i++)
            {
                if (i == e.Index)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        selectedLevel.Add(Data.SdkRepository.platform[i].apilevel);
                    }
                }
                else
                {
                    if (tabList.Items[i].Checked)
                    {
                        selectedLevel.Add(Data.SdkRepository.platform[i].apilevel);
                    }

                }
            }

            //如果tools选中
            if (tabList.Items[apiIndexMax + 1].Checked || (e.Index == apiIndexMax + 1 && e.NewValue == CheckState.Checked))
            {
                if (!(e.Index == apiIndexMax + 1 && tabList.Items[apiIndexMax + 1].Checked))
                {
                    foreach (var tool in Data.SdkRepository.tool)
                    {
                        foreach (var item in tool.archives)
                        {
                            var currentItem = new ListViewItem();
                            currentItem.Text = "Android SDK Tools";
                            currentItem.SubItems.Add("");
                            currentItem.SubItems.Add(tool.revision.major + "." + tool.revision.minor + "." + tool.revision.micro);
                            currentItem.SubItems.Add(item.url);
                            currentItem.SubItems.Add(item.hostos);
                            currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                            currentItem.SubItems.Add(item.size.ToString());
                            currentItem.ImageIndex = 3;
                            cacheItems.Add(currentItem);
                        }
                    }
                    foreach (var buildtool in Data.SdkRepository.buildtool)
                    {
                        foreach (var item in buildtool.archives)
                        {
                            var currentItem = new ListViewItem();
                            currentItem.Text = "Android SDK Build-tools";
                            currentItem.SubItems.Add("");
                            currentItem.SubItems.Add(buildtool.revision.major + "." + buildtool.revision.minor + "." + buildtool.revision.micro);
                            currentItem.SubItems.Add(item.url);
                            currentItem.SubItems.Add(item.hostos);
                            currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                            currentItem.SubItems.Add(item.size.ToString());
                            currentItem.ImageIndex = 2;
                            cacheItems.Add(currentItem);
                        }
                    }
                    foreach (var item in Data.SdkRepository.platformtool.archives)
                    {
                        var currentItem = new ListViewItem();
                        currentItem.Text = "Android SDK Platform-tools";
                        currentItem.SubItems.Add("");
                        currentItem.SubItems.Add(Data.SdkRepository.platformtool.revision.major + "." + Data.SdkRepository.platformtool.revision.minor + "." + Data.SdkRepository.platformtool.revision.micro);
                        currentItem.SubItems.Add(item.url);
                        currentItem.SubItems.Add(item.hostos);
                        currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                        currentItem.SubItems.Add(item.size.ToString());
                        currentItem.ImageIndex = 3;
                        cacheItems.Add(currentItem);
                    }
                }
            }

            //platform
            foreach (var platform in Data.SdkRepository.platform)
            {
                foreach (var item in platform.archives)
                {
                    if (!selectedLevel.Contains(platform.apilevel)) continue;
                    //var index = selectedLevel.FindIndex(a => a == platform.apilevel);
                    var currentItem = new ListViewItem();
                    currentItem.Text = "SDK Platform";
                    currentItem.SubItems.Add(platform.apilevel.ToString());
                    currentItem.SubItems.Add(platform.revision.ToString());
                    currentItem.SubItems.Add(item.url);
                    currentItem.SubItems.Add(item.hostos);
                    currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                    currentItem.SubItems.Add(item.size.ToString());
                    currentItem.ImageIndex = 6;
                    cacheItems.Add(currentItem);
                }

            }
            //source api
            foreach (var source in Data.SdkRepository.source)
            {
                if (!selectedLevel.Contains(source.apilevel)) continue;
                //var index = selectedLevel.FindIndex(a => a == platform.apilevel);
                var currentItem = new ListViewItem();
                currentItem.Text = "Source for Android SDK";
                currentItem.SubItems.Add(source.apilevel.ToString());
                currentItem.SubItems.Add(source.revision.ToString());
                currentItem.SubItems.Add(source.archives.archive.url);
                currentItem.SubItems.Add("");
                currentItem.SubItems.Add(source.archives.archive.checksum.type + ": " + source.archives.archive.checksum.Value);
                currentItem.SubItems.Add(source.archives.archive.size.ToString());
                currentItem.ImageIndex = 4;
                cacheItems.Add(currentItem);
            }

            //addon
            foreach (var addon in Data.SdkAddon.addon)
            {
                if (!selectedLevel.Contains(addon.apilevel)) continue;
                var currentItem = new ListViewItem();
                currentItem.Text = addon.namedisplay;
                currentItem.SubItems.Add(addon.apilevel.ToString());
                currentItem.SubItems.Add(addon.revision.ToString());
                currentItem.SubItems.Add(addon.archives.archive.url);
                currentItem.SubItems.Add("");
                currentItem.SubItems.Add(addon.archives.archive.checksum.type + ": " + addon.archives.archive.checksum.Value);
                currentItem.SubItems.Add(addon.archives.archive.size.ToString());
                currentItem.ImageIndex = 0;
                cacheItems.Add(currentItem);
            }
            //如果extras选中
            if (tabList.Items[apiIndexMax + 2].Checked || (e.Index == apiIndexMax + 2 && e.NewValue == CheckState.Checked))
            {
                if (!(e.Index == apiIndexMax + 2 && tabList.Items[apiIndexMax + 2].Checked))
                {
                    foreach (var extra in Data.SdkAddon.extra)
                    {
                        foreach (var item in extra.archives)
                        {
                            var currentItem = new ListViewItem();
                            currentItem.Text = extra.namedisplay;
                            currentItem.SubItems.Add("");
                            currentItem.SubItems.Add(extra.revision.major + "." + extra.revision.minor + "." + extra.revision.micro);
                            currentItem.SubItems.Add(item.url);
                            currentItem.SubItems.Add(item.hostos);
                            currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                            currentItem.SubItems.Add(item.size.ToString());
                            currentItem.ImageIndex = 5;
                            cacheItems.Add(currentItem);

                        }
                    }
                    //Intel
                    var intelExtra = Data.ExtraIntelSdkAddon.extra;
                    foreach (var item in intelExtra.archives)
                    {
                        var currentItem = new ListViewItem();
                        currentItem.Text = intelExtra.namedisplay;
                        currentItem.SubItems.Add("");
                        currentItem.SubItems.Add(intelExtra.revision.major + "." + intelExtra.revision.minor + "." + intelExtra.revision.micro);
                        currentItem.SubItems.Add("extras/intel/" + item.url);
                        currentItem.SubItems.Add(item.hostos);
                        currentItem.SubItems.Add(item.checksum.type + ": " + item.checksum.Value);
                        currentItem.SubItems.Add(item.size.ToString());
                        currentItem.ImageIndex = 5;
                        cacheItems.Add(currentItem);
                    }


                }
            }
            //google glass
            var glassAddon = Data.GlassSdkAddon.addon;
            if (selectedLevel.Contains(glassAddon.apilevel))
            {

                var currentItem = new ListViewItem();
                currentItem.Text = glassAddon.namedisplay;
                currentItem.SubItems.Add(glassAddon.apilevel.ToString());
                currentItem.SubItems.Add(glassAddon.revision.ToString());
                currentItem.SubItems.Add("glass/" + glassAddon.archives.archive.url);
                currentItem.SubItems.Add("");
                currentItem.SubItems.Add(glassAddon.archives.archive.checksum.type + ": " + glassAddon.archives.archive.checksum.Value);
                currentItem.SubItems.Add(glassAddon.archives.archive.size.ToString());
                currentItem.ImageIndex = 0;
                cacheItems.Add(currentItem);
            }
            //google api image
            foreach (var image in Data.GoogleApiSysimg.systemimage)
            {
                if (selectedLevel.Contains(image.apilevel))
                {
                    var currentItem = new ListViewItem();
                    currentItem.Text = image.description;
                    currentItem.SubItems.Add(image.apilevel.ToString());
                    currentItem.SubItems.Add(image.revision.ToString());
                    currentItem.SubItems.Add("sys-img/google_apis/" + image.archives.archive.url);
                    currentItem.SubItems.Add("");
                    currentItem.SubItems.Add(image.archives.archive.checksum.type + ": " + image.archives.archive.checksum.Value);
                    currentItem.SubItems.Add(image.archives.archive.size.ToString());
                    currentItem.ImageIndex = 1;
                    cacheItems.Add(currentItem);
                }
            }
            foreach (var image in Data.AndroidSysimg.systemimage)
            {
                if (selectedLevel.Contains(image.apilevel))
                {
                    var currentItem = new ListViewItem();
                    currentItem.Text = image.description;
                    currentItem.SubItems.Add(image.apilevel.ToString());
                    currentItem.SubItems.Add(image.revision.ToString());
                    currentItem.SubItems.Add("sys-img/android/" + image.archives.archive.url);
                    currentItem.SubItems.Add("");
                    currentItem.SubItems.Add(image.archives.archive.checksum.type + ": " + image.archives.archive.checksum.Value);
                    currentItem.SubItems.Add(image.archives.archive.size.ToString());
                    currentItem.ImageIndex = 1;
                    cacheItems.Add(currentItem);
                }
            }
            foreach (var image in Data.AndroidTvSysimg.systemimage)
            {
                if (selectedLevel.Contains(image.apilevel))
                {
                    var currentItem = new ListViewItem();
                    currentItem.Text = image.tagdisplay;
                    currentItem.SubItems.Add(image.apilevel.ToString());
                    currentItem.SubItems.Add(image.revision.ToString());
                    currentItem.SubItems.Add("sys-img/android-tv/" + image.archives.archive.url);
                    currentItem.SubItems.Add("");
                    currentItem.SubItems.Add(image.archives.archive.checksum.type + ": " + image.archives.archive.checksum.Value);
                    currentItem.SubItems.Add(image.archives.archive.size.ToString());
                    currentItem.ImageIndex = 1;
                    cacheItems.Add(currentItem);
                }
            }
            foreach (var image in Data.AndroidWearSysimg.systemimage)
            {
                if (selectedLevel.Contains(image.apilevel))
                {
                    var currentItem = new ListViewItem();
                    currentItem.Text = image.tagdisplay;
                    currentItem.SubItems.Add(image.apilevel.ToString());
                    currentItem.SubItems.Add(image.revision.ToString());
                    currentItem.SubItems.Add("sys-img/android-wear/" + image.archives.archive.url);
                    currentItem.SubItems.Add("");
                    currentItem.SubItems.Add(image.archives.archive.checksum.type + ": " + image.archives.archive.checksum.Value);
                    currentItem.SubItems.Add(image.archives.archive.size.ToString());
                    currentItem.ImageIndex = 1;
                    cacheItems.Add(currentItem);
                }
            }

            
            UpdateListView();
        }
        private void sdkListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (sdkListView.Columns[e.Column].Tag == null)
            {
                sdkListView.Columns[e.Column].Tag = true;
            }
            bool tabK = (bool)sdkListView.Columns[e.Column].Tag;
            if (tabK)
            {
                sdkListView.Columns[e.Column].Tag = false;
            }
            else
            {
                sdkListView.Columns[e.Column].Tag = true;
            }
            sdkListView.ListViewItemSorter = new ListViewSort(e.Column, sdkListView.Columns[e.Column].Tag);
            //指定排序器并传送列索引与升序降序关键字
            sdkListView.Sort();//对列表进行自定义排序
        }

        private void toolStripButtonSetting_Click(object sender, EventArgs e)
        {
            new Forms.SettingWindow().ShowDialog();
            UpdateRepo();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ToolStripMenuItem item in selectRepoToolStripMenuItem.DropDownItems)
            {
                if (item.Checked)
                {
                    Data.AppSet.SeletedRepository = (int)item.Tag;
                }
            }
            Data.AppSet.Save("setting.json");
        }

        private void aboutMeloduetAndroidSDKManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.AboutBox().ShowDialog();
        }
    }
}
