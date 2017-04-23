// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:07 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_061/toolbar03/toolbar03.cs
 * url:  form/form_061/toolbar03/toolbar03.cs
 * created: Time-stamp: <2016-08-24 13:15:07 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_61.htm
 * description: 
 *
 *================================================================*/
// toolbar03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class toolbar03 : Form
{
    MenuItem miFile, miEnd, miEdit, miView, miSearch, miOpen, miCut, miDelete,
        miHelp, miFlat, miNormal, miRight, miUnder;
    ToolBar tb;
    ToolBarButton tbbOpen, tbbCut, tbbDelete, tbbSearch, tbbHelp;
    StatusBar sb;
    StatusBarPanel sbp0, sbp1, sbp2;
    Panel pnl;
    String str = "";
    Font font;
    Label label;

    public static void Main()
    {
        Application.Run(new toolbar03());
    }

    public toolbar03()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        MakeMenu();
        MakePanel();
        MakeToolbar();
        MakeStatusbar();

        Timer timer = new Timer();
        timer.Interval = 500;
        timer.Tick += new EventHandler(timer_Tick);
        timer.Start();

        miNormal.Enabled = false;
        miUnder.Enabled = false;
    }

    void timer_Tick(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        String strtime = String.Format("{0:00}:{1:00}:{2:00}", dt.Hour, dt.Minute, dt.Second);
        sbp2.Text = strtime;
    }

    void MakeMenu()
    {
        MainMenu mm = new MainMenu();
        Menu = mm;

        miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        mm.MenuItems.Add(miFile);

        miOpen = new MenuItem();
        miOpen.Text = "開く(&O)";
        miOpen.Click += new EventHandler(miOpen_Click);
        miOpen.Select += new EventHandler(miOpen_Select);
        miFile.MenuItems.Add(miOpen);


        miEnd = new MenuItem();
        miEnd.Text = "終了(&X)";
        miEnd.Click += new EventHandler(miEnd_Click);
        miEnd.Select += new EventHandler(miEnd_Select);
        miFile.MenuItems.Add(miEnd);

        miEdit = new MenuItem();
        miEdit.Text = "編集(&E)";
        mm.MenuItems.Add(miEdit);

        miCut = new MenuItem();
        miCut.Text = "切り取り(&T)";
        miCut.Click += new EventHandler(miCut_Click);
        miCut.Select += new EventHandler(miCut_Select);
        miEdit.MenuItems.Add(miCut);

        miDelete = new MenuItem();
        miDelete.Text = "削除(&D)";
        miDelete.Click += new EventHandler(miDelete_Click);
        miDelete.Select += new EventHandler(miDelete_Select);
        miEdit.MenuItems.Add(miDelete);

        miSearch = new MenuItem();
        miSearch.Text = "検索(&F)";
        miSearch.Click += new EventHandler(miSearch_Click);
        miSearch.Select += new EventHandler(miSearch_Select);
        miEdit.MenuItems.Add(miSearch);

        miView = new MenuItem();
        miView.Text = "表示(&V)";
        mm.MenuItems.Add(miView);

        miFlat = new MenuItem();
        miFlat.Text = "フラット";
        miFlat.Click += new EventHandler(miFlat_Click);
        miFlat.Select += new EventHandler(miFlat_Select);
        miView.MenuItems.Add(miFlat);

        miNormal = new MenuItem();
        miNormal.Text = "従来型";
        miNormal.Click += new EventHandler(miNormal_Click);
        miNormal.Select += new EventHandler(miNormal_Select);
        miView.MenuItems.Add(miNormal);

        miRight = new MenuItem();
        miRight.Text = "文字の右側表示";
        miRight.Click += new EventHandler(miRight_Click);
        miRight.Select += new EventHandler(miRight_Select);
        miView.MenuItems.Add(miRight);

        miUnder = new MenuItem();
        miUnder.Text = "文字の下方表示";
        miUnder.Click += new EventHandler(miUnder_Click);
        miUnder.Select += new EventHandler(miUnder_Select);
        miView.MenuItems.Add(miUnder);

        miHelp = new MenuItem();
        miHelp.Text = "ヘルプ";
        miHelp.Click += new EventHandler(miHelp_Click);
        mm.MenuItems.Add(miHelp);
    }

    void MakePanel()
    {
        pnl = new Panel();
        pnl.Parent = this;
        pnl.BackColor = Color.Yellow;
        pnl.Dock = DockStyle.Fill;
        pnl.AutoScroll = true;

        pnl.BorderStyle = BorderStyle.Fixed3D;

        font = new Font("ＭＳ ゴシック", 20);
        label = new Label();
        label.Parent = pnl;
        label.AutoSize = true;
        label.Font = font;
    }

    void MakeToolbar()
    {
        tb = new ToolBar();
        tb.Parent = this;

        ImageList iList = new ImageList();
        Bitmap btm = new Bitmap(GetType(), "toolbar03.tool03.bmp");
        iList.Images.AddStrip(btm);
        iList.TransparentColor = Color.Red;

        tb.ImageList = iList;
        tb.ShowToolTips = true;
        tb.ButtonClick += new ToolBarButtonClickEventHandler(tb_ButtonClick);

        tbbOpen = new ToolBarButton();
        tbbOpen.Text = "開く";
        tbbOpen.ToolTipText = "ファイルを開きます";
        tbbOpen.Tag = miOpen;
        tbbOpen.ImageIndex = 0;
        tb.Buttons.Add(tbbOpen);

        tbbCut = new ToolBarButton();
        tbbCut.Text = "切り取り";
        tbbCut.ToolTipText = "切り取ります";
        tbbCut.Tag = miCut;
        tbbCut.ImageIndex = 1;
        tb.Buttons.Add(tbbCut);

        tbbDelete = new ToolBarButton();
        tbbDelete.Text = "削除";
        tbbDelete.ToolTipText = "削除します";
        tbbDelete.Tag = miDelete;
        tbbDelete.ImageIndex = 2;
        tb.Buttons.Add(tbbDelete);

        tbbSearch = new ToolBarButton();
        tbbSearch.Text = "検索";
        tbbSearch.ToolTipText = "検索します";
        tbbSearch.Tag = miSearch;
        tbbSearch.ImageIndex = 3;
        tb.Buttons.Add(tbbSearch);

        tbbHelp = new ToolBarButton();
        tbbHelp.Text = "ヘルプ";
        tbbHelp.ToolTipText = "ヘルプを表示します";
        tbbHelp.Tag = miHelp;
        tbbHelp.ImageIndex = 4;
        tb.Buttons.Add(tbbHelp);
    }

    void MakeStatusbar()
    {
        sb = new StatusBar();
        sb.Parent = this;
        sb.ShowPanels = true;

        sbp0 = new StatusBarPanel();
        sbp0.AutoSize = StatusBarPanelAutoSize.Contents;
        sb.Panels.Add(sbp0);
        sbp0.Text = "待機中...";

        sbp1 = new StatusBarPanel();
        sbp1.AutoSize = StatusBarPanelAutoSize.Spring;
        sb.Panels.Add(sbp1);

        sbp2 = new StatusBarPanel();
        sbp2.AutoSize = StatusBarPanelAutoSize.Contents;
        sb.Panels.Add(sbp2);
    }

    void miOpen_Select(object sender, EventArgs e)
    {
        sbp0.Text = "ファイルを開きます";
    }

    void miEnd_Select(object sender, EventArgs e)
    {
        sbp0.Text = "このプログラムを終了します";
    }

    void miCut_Select(object sender, EventArgs e)
    {
        sbp0.Text = "切り取ります";
    }

    void miDelete_Select(object sender, EventArgs e)
    {
        sbp0.Text = "削除します";
    }

    void miSearch_Select(object sender, EventArgs e)
    {
        sbp0.Text = "検索します";
    }

    void miFlat_Select(object sender, EventArgs e)
    {
        sbp0.Text = "ツールバーボタンをフラットにします";
    }

    void miNormal_Select(object sender, EventArgs e)
    {
        sbp0.Text = "ツールバーボタンを従来型にします";
    }

    void miRight_Select(object sender, EventArgs e)
    {
        sbp0.Text = "ボタンの文字を右側に表示します";
    }

    void miUnder_Select(object sender, EventArgs e)
    {
        sbp0.Text = "ボタンの文字を下方に表示します";
    }

    void miOpen_Click(object sender, EventArgs e)
    {
        str += "開くが選択されました\n";
        label.Text = str;
    }

    void miEnd_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miCut_Click(object sender, EventArgs e)
    {
        str += "切り取りが選択されました\n";
        label.Text = str;
    }

    void miDelete_Click(object sender, EventArgs e)
    {
        str += "削除が選択されました\n";
        label.Text = str;
    }

    void miSearch_Click(object sender, EventArgs e)
    {
        str += "検索が選択されました\n";
        label.Text = str;
    }

    void miFlat_Click(object sender, EventArgs e)
    {
        tb.Appearance = ToolBarAppearance.Flat;
        miFlat.Enabled = false;
        miNormal.Enabled = true;
    }

    void miNormal_Click(object sender, EventArgs e)
    {
        tb.Appearance = ToolBarAppearance.Normal;
        miFlat.Enabled = true;
        miNormal.Enabled = false;
    }

    void miRight_Click(object sender, EventArgs e)
    {
        tb.TextAlign = ToolBarTextAlign.Right;
        miUnder.Enabled = true;
        miRight.Enabled = false;

    }

    void miUnder_Click(object sender, EventArgs e)
    {
        tb.TextAlign = ToolBarTextAlign.Underneath;
        miUnder.Enabled = false;
        miRight.Enabled = true;
    }

    void miHelp_Click(object sender, EventArgs e)
    {
        str += "ヘルプが選択されました\n";
        label.Text = str;
    }

    void tb_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
        ToolBarButton tbb = e.Button;
        MenuItem mi = (MenuItem)tbb.Tag;
        mi.PerformClick();
    }

    protected override void OnMenuComplete(EventArgs e)
    {
        base.OnMenuComplete(e);
        sbp0.Text = "準備中...";
    }
}
