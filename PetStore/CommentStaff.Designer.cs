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
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.gvComment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmtID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commentTableAdapter = new PetStore.PetStoreDataSetTableAdapters.CommentTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.petStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource1)).BeginInit();
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
            this.gcComment.DataSource = this.commentBindingSource;
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
            // commentBindingSource
            // 
            this.commentBindingSource.DataMember = "Comment";
            this.commentBindingSource.DataSource = this.petStoreDataSet;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvComment
            // 
            this.gvComment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CmtID,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5});
            this.gvComment.GridControl = this.gcComment;
            this.gvComment.Name = "gvComment";
            this.gvComment.OptionsBehavior.Editable = false;
            this.gvComment.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvComment_RowClick);
            // 
            // CmtID
            // 
            this.CmtID.Caption = "ID";
            this.CmtID.FieldName = "cmt_id";
            this.CmtID.MinWidth = 25;
            this.CmtID.Name = "CmtID";
            this.CmtID.Visible = true;
            this.CmtID.VisibleIndex = 0;
            this.CmtID.Width = 178;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Content";
            this.gridColumn2.FieldName = "cmt_content";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 423;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Published";
            this.gridColumn3.FieldName = "cmt_published";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 116;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Pet\'s Comment";
            this.gridColumn4.FieldName = "p_id";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "User\'s comment";
            this.gridColumn1.FieldName = "u_id";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Status";
            this.gridColumn5.FieldName = "cmt_status";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 119;
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // petStoreDataSetBindingSource
            // 
            this.petStoreDataSetBindingSource.DataSource = this.petStoreDataSet;
            this.petStoreDataSetBindingSource.Position = 0;
            // 
            // commentBindingSource1
            // 
            this.commentBindingSource1.DataMember = "Comment";
            this.commentBindingSource1.DataSource = this.petStoreDataSetBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn CmtID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private PetStoreDataSetTableAdapters.CommentTableAdapter commentTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource petStoreDataSetBindingSource;
        private System.Windows.Forms.BindingSource commentBindingSource1;
    }
}