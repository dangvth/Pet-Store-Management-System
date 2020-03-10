﻿namespace PetStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentStaff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshCmt = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcComment = new DevExpress.XtraGrid.GridControl();
            this.gvComment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmtID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAddCmt,
            this.btnDeleteCmt,
            this.btnRefreshCmt,
            this.btnRestore});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1235, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAddCmt
            // 
            this.btnAddCmt.Caption = "Add Comment";
            this.btnAddCmt.Id = 1;
            this.btnAddCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCmt.ImageOptions.Image")));
            this.btnAddCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddCmt.ImageOptions.LargeImage")));
            this.btnAddCmt.LargeWidth = 60;
            this.btnAddCmt.Name = "btnAddCmt";
            this.btnAddCmt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // 
            // btnRefreshCmt
            // 
            this.btnRefreshCmt.Caption = "Refresh";
            this.btnRefreshCmt.Id = 3;
            this.btnRefreshCmt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.Image")));
            this.btnRefreshCmt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCmt.ImageOptions.LargeImage")));
            this.btnRefreshCmt.Name = "btnRefreshCmt";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore comment";
            this.btnRestore.Id = 4;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.LargeWidth = 70;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tool";
            // 
            // rbPageGroup
            // 
            this.rbPageGroup.ItemLinks.Add(this.btnAddCmt);
            this.rbPageGroup.ItemLinks.Add(this.btnDeleteCmt);
            this.rbPageGroup.ItemLinks.Add(this.btnRefreshCmt);
            this.rbPageGroup.ItemLinks.Add(this.btnRestore);
            this.rbPageGroup.Name = "rbPageGroup";
            this.rbPageGroup.Text = "Comment Management";
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
            this.CmtID,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5});
            this.gvComment.GridControl = this.gcComment;
            this.gvComment.Name = "gvComment";
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
            this.gridColumn4.FieldName = "p_name";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "User\'s comment";
            this.gridColumn1.FieldName = "u_name";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
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
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "CommentStaff";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAddCmt;
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
    }
}