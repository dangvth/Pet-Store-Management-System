namespace PetStore
{
    partial class CommentStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentStaff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDeleteCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcComment = new DevExpress.XtraGrid.GridControl();
            this.gvComment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmt_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmt_content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmt_published = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmt_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colp_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colu_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceComment = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComment)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDeleteCmt,
            this.btnRefreshCmt,
            this.btnRestore,
            this.btnDetail});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1235, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDeleteCmt
            // 
            this.btnDeleteCmt.Caption = "Delete Comment";
            this.btnDeleteCmt.Id = 2;
            this.btnDeleteCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCmt.ImageOptions.Image")));
            this.btnDeleteCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCmt.ImageOptions.LargeImage")));
            this.btnDeleteCmt.LargeWidth = 60;
            this.btnDeleteCmt.Name = "btnDeleteCmt";
            this.btnDeleteCmt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteCmt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCmt_ItemClick);
            // 
            // btnRefreshCmt
            // 
            this.btnRefreshCmt.Caption = "Refresh";
            this.btnRefreshCmt.Id = 3;
            this.btnRefreshCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.Image")));
            this.btnRefreshCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.LargeImage")));
            this.btnRefreshCmt.Name = "btnRefreshCmt";
            this.btnRefreshCmt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshCmt_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore comment";
            this.btnRestore.Id = 4;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.LargeWidth = 70;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnDetail
            // 
            this.btnDetail.Caption = "View comment detail";
            this.btnDetail.Id = 6;
            this.btnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetail.ImageOptions.Image")));
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroup,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // rbPageGroup
            // 
            this.rbPageGroup.ItemLinks.Add(this.btnDeleteCmt);
            this.rbPageGroup.ItemLinks.Add(this.btnRestore);
            this.rbPageGroup.ItemLinks.Add(this.btnRefreshCmt);
            this.rbPageGroup.Name = "rbPageGroup";
            this.rbPageGroup.Text = "Comment Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDetail);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment Detail";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 728);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1235, 37);
            // 
            // gcComment
            // 
            this.gcComment.DataSource = this.bindingSourceComment;
            this.gcComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcComment.Location = new System.Drawing.Point(0, 178);
            this.gcComment.MainView = this.gvComment;
            this.gcComment.MenuManager = this.ribbon;
            this.gcComment.Name = "gcComment";
            this.gcComment.Size = new System.Drawing.Size(1235, 550);
            this.gcComment.TabIndex = 3;
            this.gcComment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvComment});
            // 
            // gvComment
            // 
            this.gvComment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cmt_id,
            this.cmt_content,
            this.colcmt_published,
            this.colcmt_status,
            this.colp_name,
            this.colu_name});
            this.gvComment.GridControl = this.gcComment;
            this.gvComment.Name = "gvComment";
            this.gvComment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvComment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvComment.OptionsBehavior.Editable = false;
            this.gvComment.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvComment_RowClick);
            // 
            // cmt_id
            // 
            this.cmt_id.Caption = "ID";
            this.cmt_id.FieldName = "cmt_id";
            this.cmt_id.MinWidth = 25;
            this.cmt_id.Name = "cmt_id";
            this.cmt_id.Visible = true;
            this.cmt_id.VisibleIndex = 0;
            this.cmt_id.Width = 94;
            // 
            // cmt_content
            // 
            this.cmt_content.Caption = "Content";
            this.cmt_content.FieldName = "cmt_content";
            this.cmt_content.MinWidth = 25;
            this.cmt_content.Name = "cmt_content";
            this.cmt_content.Visible = true;
            this.cmt_content.VisibleIndex = 1;
            this.cmt_content.Width = 94;
            // 
            // colcmt_published
            // 
            this.colcmt_published.Caption = "Published";
            this.colcmt_published.FieldName = "cmt_published";
            this.colcmt_published.MinWidth = 25;
            this.colcmt_published.Name = "colcmt_published";
            this.colcmt_published.Visible = true;
            this.colcmt_published.VisibleIndex = 2;
            this.colcmt_published.Width = 94;
            // 
            // colcmt_status
            // 
            this.colcmt_status.Caption = "Status";
            this.colcmt_status.FieldName = "cmt_status";
            this.colcmt_status.MinWidth = 25;
            this.colcmt_status.Name = "colcmt_status";
            this.colcmt_status.Visible = true;
            this.colcmt_status.VisibleIndex = 5;
            this.colcmt_status.Width = 94;
            // 
            // colp_name
            // 
            this.colp_name.Caption = "Pet\'s name";
            this.colp_name.FieldName = "p_name";
            this.colp_name.MinWidth = 25;
            this.colp_name.Name = "colp_name";
            this.colp_name.Visible = true;
            this.colp_name.VisibleIndex = 3;
            this.colp_name.Width = 94;
            // 
            // colu_name
            // 
            this.colu_name.Caption = "Name of user";
            this.colu_name.FieldName = "u_name";
            this.colu_name.MinWidth = 25;
            this.colu_name.Name = "colu_name";
            this.colu_name.Visible = true;
            this.colu_name.VisibleIndex = 4;
            this.colu_name.Width = 94;
            // 
            // CommentStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 765);
            this.Controls.Add(this.gcComment);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "CommentStaff";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CommentStaff";
            this.Load += new System.EventHandler(this.CommentStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCmt;
        private DevExpress.XtraBars.BarButtonItem btnRefreshCmt;
        private DevExpress.XtraGrid.GridControl gcComment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvComment;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn cmt_id;
        private DevExpress.XtraGrid.Columns.GridColumn cmt_content;
        private DevExpress.XtraGrid.Columns.GridColumn colcmt_published;
        private DevExpress.XtraGrid.Columns.GridColumn colcmt_status;
        private DevExpress.XtraGrid.Columns.GridColumn colp_name;
        private DevExpress.XtraGrid.Columns.GridColumn colu_name;
        private System.Windows.Forms.BindingSource bindingSourceComment;
    }
}