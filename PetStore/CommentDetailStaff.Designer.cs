﻿namespace PetStore
{
    partial class CommentDetailStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentDetailStaff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcCmtDetail = new DevExpress.XtraGrid.GridControl();
            this.commentDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet = new PetStore.PetStoreDataSet();
            this.gvCommentDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcmt_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmtd_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmtd_content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmtd_published = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmtd_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.commentDetailTableAdapter = new PetStore.PetStoreDataSetTableAdapters.CommentDetailTableAdapter();
            this.commentDetailTableAdapter1 = new PetStore.PetStoreDataSet1TableAdapters.CommentDetailTableAdapter();
            this.commentDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petStoreDataSet1 = new PetStore.PetStoreDataSet1();
            this.petStoreDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCmtDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnRemove,
            this.btnRestore,
            this.btnRefresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1222, 178);
            // 
            // btnRemove
            // 
            this.btnRemove.Caption = "Remove";
            this.btnRemove.Id = 1;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.LargeImage")));
            this.btnRemove.LargeWidth = 60;
            this.btnRemove.Name = "btnRemove";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore";
            this.btnRestore.Id = 2;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.LargeWidth = 60;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.LargeWidth = 60;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRemove);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment detail management";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcCmtDetail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1222, 527);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcCmtDetail
            // 
            this.gcCmtDetail.DataSource = this.commentDetailBindingSource1;
            this.gcCmtDetail.Location = new System.Drawing.Point(12, 12);
            this.gcCmtDetail.MainView = this.gvCommentDetail;
            this.gcCmtDetail.MenuManager = this.ribbon;
            this.gcCmtDetail.Name = "gcCmtDetail";
            this.gcCmtDetail.Size = new System.Drawing.Size(1198, 503);
            this.gcCmtDetail.TabIndex = 4;
            this.gcCmtDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCommentDetail});
            // 
            // commentDetailBindingSource
            // 
            this.commentDetailBindingSource.DataMember = "CommentDetail";
            this.commentDetailBindingSource.DataSource = this.petStoreDataSet;
            // 
            // petStoreDataSet
            // 
            this.petStoreDataSet.DataSetName = "PetStoreDataSet";
            this.petStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCommentDetail
            // 
            this.gvCommentDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcmt_id,
            this.cmtd_id,
            this.colcmtd_content,
            this.colcmtd_published,
            this.colcmtd_status,
            this.UserID});
            this.gvCommentDetail.GridControl = this.gcCmtDetail;
            this.gvCommentDetail.GroupCount = 1;
            this.gvCommentDetail.Name = "gvCommentDetail";
            this.gvCommentDetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcmt_id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colcmt_id
            // 
            this.colcmt_id.Caption = "cmtID";
            this.colcmt_id.FieldName = "cmt_id";
            this.colcmt_id.MinWidth = 25;
            this.colcmt_id.Name = "colcmt_id";
            this.colcmt_id.Visible = true;
            this.colcmt_id.VisibleIndex = 0;
            this.colcmt_id.Width = 94;
            // 
            // cmtd_id
            // 
            this.cmtd_id.Caption = "ID";
            this.cmtd_id.FieldName = "cmtd_id";
            this.cmtd_id.MinWidth = 25;
            this.cmtd_id.Name = "cmtd_id";
            this.cmtd_id.Visible = true;
            this.cmtd_id.VisibleIndex = 0;
            this.cmtd_id.Width = 94;
            // 
            // colcmtd_content
            // 
            this.colcmtd_content.Caption = "Content";
            this.colcmtd_content.FieldName = "cmtd_content";
            this.colcmtd_content.MinWidth = 25;
            this.colcmtd_content.Name = "colcmtd_content";
            this.colcmtd_content.Visible = true;
            this.colcmtd_content.VisibleIndex = 1;
            this.colcmtd_content.Width = 94;
            // 
            // colcmtd_published
            // 
            this.colcmtd_published.Caption = "Published";
            this.colcmtd_published.FieldName = "cmtd_published";
            this.colcmtd_published.MinWidth = 25;
            this.colcmtd_published.Name = "colcmtd_published";
            this.colcmtd_published.Visible = true;
            this.colcmtd_published.VisibleIndex = 2;
            this.colcmtd_published.Width = 94;
            // 
            // colcmtd_status
            // 
            this.colcmtd_status.Caption = "Status";
            this.colcmtd_status.FieldName = "cmtd_status";
            this.colcmtd_status.MinWidth = 25;
            this.colcmtd_status.Name = "colcmtd_status";
            this.colcmtd_status.Visible = true;
            this.colcmtd_status.VisibleIndex = 4;
            this.colcmtd_status.Width = 94;
            // 
            // UserID
            // 
            this.UserID.Caption = "User ID";
            this.UserID.FieldName = "u_id";
            this.UserID.MinWidth = 25;
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 3;
            this.UserID.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1222, 527);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcCmtDetail;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1202, 507);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // commentDetailTableAdapter
            // 
            this.commentDetailTableAdapter.ClearBeforeFill = true;
            // 
            // commentDetailTableAdapter1
            // 
            this.commentDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // commentDetailBindingSource1
            // 
            this.commentDetailBindingSource1.DataMember = "CommentDetail";
            this.commentDetailBindingSource1.DataSource = this.petStoreDataSet1;
            // 
            // petStoreDataSet1
            // 
            this.petStoreDataSet1.DataSetName = "PetStoreDataSet1";
            this.petStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petStoreDataSet1BindingSource
            // 
            this.petStoreDataSet1BindingSource.DataSource = this.petStoreDataSet1;
            this.petStoreDataSet1BindingSource.Position = 0;
            // 
            // CommentDetailStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 706);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "CommentDetailStaff";
            this.Ribbon = this.ribbon;
            this.Text = "CommentDetailStaff";
            this.Load += new System.EventHandler(this.CommentDetailStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCmtDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petStoreDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRemove;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcCmtDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCommentDetail;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private PetStoreDataSet petStoreDataSet;
        private System.Windows.Forms.BindingSource commentDetailBindingSource;
        private PetStoreDataSetTableAdapters.CommentDetailTableAdapter commentDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcmt_id;
        private DevExpress.XtraGrid.Columns.GridColumn cmtd_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcmtd_content;
        private DevExpress.XtraGrid.Columns.GridColumn colcmtd_published;
        private DevExpress.XtraGrid.Columns.GridColumn colcmtd_status;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private System.Windows.Forms.BindingSource commentDetailBindingSource1;
        private PetStoreDataSet1 petStoreDataSet1;
        private PetStoreDataSet1TableAdapters.CommentDetailTableAdapter commentDetailTableAdapter1;
        private System.Windows.Forms.BindingSource petStoreDataSet1BindingSource;
    }
}