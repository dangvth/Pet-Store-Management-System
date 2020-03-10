﻿namespace PetStore
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnOnlineOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnSellProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnPet = new DevExpress.XtraBars.BarButtonItem();
            this.btnPFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnPAccessories = new DevExpress.XtraBars.BarButtonItem();
            this.btnPToy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPMed = new DevExpress.XtraBars.BarButtonItem();
            this.btnCmtList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiftList = new DevExpress.XtraBars.BarButtonItem();
            this.rbpSales = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgBillSale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpProduct = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgPet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgGift = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpComment = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TabManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1158, 34);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnOnlineOrder,
            this.btnSellProduct,
            this.btnPet,
            this.btnPFood,
            this.btnPAccessories,
            this.btnPToy,
            this.btnPMed,
            this.btnCmtList,
            this.barButtonItem2,
            this.btnGiftList,
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpSales,
            this.rbpProduct,
            this.rbpComment});
            this.ribbon.Size = new System.Drawing.Size(1158, 176);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnOnlineOrder
            // 
            this.btnOnlineOrder.Caption = "Online Order";
            this.btnOnlineOrder.Hint = "Show Bill Order Online";
            this.btnOnlineOrder.Id = 2;
            this.btnOnlineOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnlineOrder.ImageOptions.Image")));
            this.btnOnlineOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOnlineOrder.ImageOptions.LargeImage")));
            this.btnOnlineOrder.LargeWidth = 75;
            this.btnOnlineOrder.Name = "btnOnlineOrder";
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Caption = "Sell Product";
            this.btnSellProduct.Id = 3;
            this.btnSellProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSellProduct.ImageOptions.Image")));
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPet
            // 
            this.btnPet.Caption = "Pet ";
            this.btnPet.Id = 4;
            this.btnPet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPet.ImageOptions.Image")));
            this.btnPet.Name = "btnPet";
            this.btnPet.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPFood
            // 
            this.btnPFood.Caption = "Food";
            this.btnPFood.Id = 7;
            this.btnPFood.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPFood.ImageOptions.Image")));
            this.btnPFood.LargeWidth = 65;
            this.btnPFood.Name = "btnPFood";
            this.btnPFood.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPAccessories
            // 
            this.btnPAccessories.Caption = "Accessories";
            this.btnPAccessories.Id = 8;
            this.btnPAccessories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPAccessories.ImageOptions.Image")));
            this.btnPAccessories.Name = "btnPAccessories";
            this.btnPAccessories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPToy
            // 
            this.btnPToy.Caption = "Toys";
            this.btnPToy.Id = 9;
            this.btnPToy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPToy.ImageOptions.Image")));
            this.btnPToy.LargeWidth = 65;
            this.btnPToy.Name = "btnPToy";
            this.btnPToy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPMed
            // 
            this.btnPMed.Caption = "Medicine";
            this.btnPMed.Id = 10;
            this.btnPMed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPMed.ImageOptions.Image")));
            this.btnPMed.Name = "btnPMed";
            this.btnPMed.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCmtList
            // 
            this.btnCmtList.Caption = "Comment List";
            this.btnCmtList.Id = 11;
            this.btnCmtList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCmtList.ImageOptions.Image")));
            this.btnCmtList.LargeWidth = 75;
            this.btnCmtList.Name = "btnCmtList";
            this.btnCmtList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnGiftList
            // 
            this.btnGiftList.Caption = "Gift List";
            this.btnGiftList.Id = 13;
            this.btnGiftList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiftList.ImageOptions.Image")));
            this.btnGiftList.LargeWidth = 75;
            this.btnGiftList.Name = "btnGiftList";
            this.btnGiftList.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rbpSales
            // 
            this.rbpSales.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgBillSale});
            this.rbpSales.Name = "rbpSales";
            this.rbpSales.Text = "Sales";
            // 
            // rbpgBillSale
            // 
            this.rbpgBillSale.ItemLinks.Add(this.btnSellProduct);
            this.rbpgBillSale.ItemLinks.Add(this.btnOnlineOrder);
            this.rbpgBillSale.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rbpgBillSale.Name = "rbpgBillSale";
            this.rbpgBillSale.Text = "Bill";
            // 
            // rbpProduct
            // 
            this.rbpProduct.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgPet,
            this.rbpgGift});
            this.rbpProduct.KeyTip = "ABC";
            this.rbpProduct.Name = "rbpProduct";
            this.rbpProduct.Text = "Product";
            // 
            // rbpgPet
            // 
            this.rbpgPet.ItemLinks.Add(this.btnPet);
            this.rbpgPet.ItemLinks.Add(this.btnPFood);
            this.rbpgPet.ItemLinks.Add(this.btnPAccessories);
            this.rbpgPet.ItemLinks.Add(this.btnPToy);
            this.rbpgPet.ItemLinks.Add(this.btnPMed);
            this.rbpgPet.Name = "rbpgPet";
            this.rbpgPet.Text = "View";
            // 
            // rbpgGift
            // 
            this.rbpgGift.ItemLinks.Add(this.btnGiftList);
            this.rbpgGift.Name = "rbpgGift";
            this.rbpgGift.Text = "Gift";
            // 
            // rbpComment
            // 
            this.rbpComment.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpComment.Name = "rbpComment";
            this.rbpComment.Text = "Comment Managment";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCmtList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Comment";
            // 
            // TabManager
            // 
            this.TabManager.MdiParent = this;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 14;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // Staff
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 702);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnOnlineOrder;
        private DevExpress.XtraBars.BarButtonItem btnSellProduct;
        private DevExpress.XtraBars.BarButtonItem btnPet;
        private DevExpress.XtraBars.BarButtonItem btnPFood;
        private DevExpress.XtraBars.BarButtonItem btnPAccessories;
        private DevExpress.XtraBars.BarButtonItem btnPToy;
        private DevExpress.XtraBars.BarButtonItem btnPMed;
        private DevExpress.XtraBars.BarButtonItem btnCmtList;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgBillSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgPet;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpComment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabManager;
        private DevExpress.XtraBars.BarButtonItem btnGiftList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgGift;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
    }
}