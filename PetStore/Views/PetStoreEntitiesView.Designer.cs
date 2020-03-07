namespace PetStore.Views.PetStoreEntitiesView {
    partial class PetStoreEntitiesView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
			this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
									this.navigationBarItemAccountCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemAccountCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemBillCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemBillCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemBillDetailCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemBillDetailCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemCommentCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemCommentCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemCommentDetailCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemCommentDetailCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemGiftCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemGiftCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemOriginCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemOriginCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPetCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPetCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPetAccessoryCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPetAccessoryCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPetFoodCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPetFoodCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPetMedicineCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPetMedicineCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemPetToyCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemPetToyCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemRoleCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemRoleCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemTypeCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemTypeCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemUserCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemUserCollectionView = new DevExpress.XtraBars.BarButtonItem();
						            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.skinRibbonGalleryBarItem, this.barSubItemNavigation });
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
			this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
			this.ribbonPage.MergeOrder = -1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
			// 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
			 // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
			            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
			this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
			// 
            // ribbonStatusBar
            // 
			this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // officeNavigationBar
            //
			this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            			this.navigationBarItemAccountCollectionView,
						this.navigationBarItemBillCollectionView,
						this.navigationBarItemBillDetailCollectionView,
						this.navigationBarItemCommentCollectionView,
						this.navigationBarItemCommentDetailCollectionView,
						this.navigationBarItemGiftCollectionView,
						this.navigationBarItemOriginCollectionView,
						this.navigationBarItemPetCollectionView,
						this.navigationBarItemPetAccessoryCollectionView,
						this.navigationBarItemPetFoodCollectionView,
						this.navigationBarItemPetMedicineCollectionView,
						this.navigationBarItemPetToyCollectionView,
						this.navigationBarItemRoleCollectionView,
						this.navigationBarItemTypeCollectionView,
						this.navigationBarItemUserCollectionView,
									
			});
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Text = "officeNavigationBar";
						// 
            // navigationBarItemAccountCollectionView
            // 
			this.navigationBarItemAccountCollectionView.Name = "navigationBarItemAccountCollectionView";
            this.navigationBarItemAccountCollectionView.Text = "Accounts";
			// 
            // barButtonItemAccountCollectionView
            // 
			this.barButtonItemAccountCollectionView.Name = "barButtonItemAccountCollectionView";
            this.barButtonItemAccountCollectionView.Caption = "Accounts";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAccountCollectionView));
					
						// 
            // navigationBarItemBillCollectionView
            // 
			this.navigationBarItemBillCollectionView.Name = "navigationBarItemBillCollectionView";
            this.navigationBarItemBillCollectionView.Text = "Bills";
			// 
            // barButtonItemBillCollectionView
            // 
			this.barButtonItemBillCollectionView.Name = "barButtonItemBillCollectionView";
            this.barButtonItemBillCollectionView.Caption = "Bills";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemBillCollectionView));
					
						// 
            // navigationBarItemBillDetailCollectionView
            // 
			this.navigationBarItemBillDetailCollectionView.Name = "navigationBarItemBillDetailCollectionView";
            this.navigationBarItemBillDetailCollectionView.Text = "Bill Details";
			// 
            // barButtonItemBillDetailCollectionView
            // 
			this.barButtonItemBillDetailCollectionView.Name = "barButtonItemBillDetailCollectionView";
            this.barButtonItemBillDetailCollectionView.Caption = "Bill Details";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemBillDetailCollectionView));
					
						// 
            // navigationBarItemCommentCollectionView
            // 
			this.navigationBarItemCommentCollectionView.Name = "navigationBarItemCommentCollectionView";
            this.navigationBarItemCommentCollectionView.Text = "Comments";
			// 
            // barButtonItemCommentCollectionView
            // 
			this.barButtonItemCommentCollectionView.Name = "barButtonItemCommentCollectionView";
            this.barButtonItemCommentCollectionView.Caption = "Comments";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCommentCollectionView));
					
						// 
            // navigationBarItemCommentDetailCollectionView
            // 
			this.navigationBarItemCommentDetailCollectionView.Name = "navigationBarItemCommentDetailCollectionView";
            this.navigationBarItemCommentDetailCollectionView.Text = "Comment Details";
			// 
            // barButtonItemCommentDetailCollectionView
            // 
			this.barButtonItemCommentDetailCollectionView.Name = "barButtonItemCommentDetailCollectionView";
            this.barButtonItemCommentDetailCollectionView.Caption = "Comment Details";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCommentDetailCollectionView));
					
						// 
            // navigationBarItemGiftCollectionView
            // 
			this.navigationBarItemGiftCollectionView.Name = "navigationBarItemGiftCollectionView";
            this.navigationBarItemGiftCollectionView.Text = "Gifts";
			// 
            // barButtonItemGiftCollectionView
            // 
			this.barButtonItemGiftCollectionView.Name = "barButtonItemGiftCollectionView";
            this.barButtonItemGiftCollectionView.Caption = "Gifts";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemGiftCollectionView));
					
						// 
            // navigationBarItemOriginCollectionView
            // 
			this.navigationBarItemOriginCollectionView.Name = "navigationBarItemOriginCollectionView";
            this.navigationBarItemOriginCollectionView.Text = "Origins";
			// 
            // barButtonItemOriginCollectionView
            // 
			this.barButtonItemOriginCollectionView.Name = "barButtonItemOriginCollectionView";
            this.barButtonItemOriginCollectionView.Caption = "Origins";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemOriginCollectionView));
					
						// 
            // navigationBarItemPetCollectionView
            // 
			this.navigationBarItemPetCollectionView.Name = "navigationBarItemPetCollectionView";
            this.navigationBarItemPetCollectionView.Text = "Pets";
			// 
            // barButtonItemPetCollectionView
            // 
			this.barButtonItemPetCollectionView.Name = "barButtonItemPetCollectionView";
            this.barButtonItemPetCollectionView.Caption = "Pets";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPetCollectionView));
					
						// 
            // navigationBarItemPetAccessoryCollectionView
            // 
			this.navigationBarItemPetAccessoryCollectionView.Name = "navigationBarItemPetAccessoryCollectionView";
            this.navigationBarItemPetAccessoryCollectionView.Text = "Pet Accessories";
			// 
            // barButtonItemPetAccessoryCollectionView
            // 
			this.barButtonItemPetAccessoryCollectionView.Name = "barButtonItemPetAccessoryCollectionView";
            this.barButtonItemPetAccessoryCollectionView.Caption = "Pet Accessories";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPetAccessoryCollectionView));
					
						// 
            // navigationBarItemPetFoodCollectionView
            // 
			this.navigationBarItemPetFoodCollectionView.Name = "navigationBarItemPetFoodCollectionView";
            this.navigationBarItemPetFoodCollectionView.Text = "Pet Foods";
			// 
            // barButtonItemPetFoodCollectionView
            // 
			this.barButtonItemPetFoodCollectionView.Name = "barButtonItemPetFoodCollectionView";
            this.barButtonItemPetFoodCollectionView.Caption = "Pet Foods";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPetFoodCollectionView));
					
						// 
            // navigationBarItemPetMedicineCollectionView
            // 
			this.navigationBarItemPetMedicineCollectionView.Name = "navigationBarItemPetMedicineCollectionView";
            this.navigationBarItemPetMedicineCollectionView.Text = "Pet Medicines";
			// 
            // barButtonItemPetMedicineCollectionView
            // 
			this.barButtonItemPetMedicineCollectionView.Name = "barButtonItemPetMedicineCollectionView";
            this.barButtonItemPetMedicineCollectionView.Caption = "Pet Medicines";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPetMedicineCollectionView));
					
						// 
            // navigationBarItemPetToyCollectionView
            // 
			this.navigationBarItemPetToyCollectionView.Name = "navigationBarItemPetToyCollectionView";
            this.navigationBarItemPetToyCollectionView.Text = "Pet Toys";
			// 
            // barButtonItemPetToyCollectionView
            // 
			this.barButtonItemPetToyCollectionView.Name = "barButtonItemPetToyCollectionView";
            this.barButtonItemPetToyCollectionView.Caption = "Pet Toys";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPetToyCollectionView));
					
						// 
            // navigationBarItemRoleCollectionView
            // 
			this.navigationBarItemRoleCollectionView.Name = "navigationBarItemRoleCollectionView";
            this.navigationBarItemRoleCollectionView.Text = "Roles";
			// 
            // barButtonItemRoleCollectionView
            // 
			this.barButtonItemRoleCollectionView.Name = "barButtonItemRoleCollectionView";
            this.barButtonItemRoleCollectionView.Caption = "Roles";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemRoleCollectionView));
					
						// 
            // navigationBarItemTypeCollectionView
            // 
			this.navigationBarItemTypeCollectionView.Name = "navigationBarItemTypeCollectionView";
            this.navigationBarItemTypeCollectionView.Text = "Types";
			// 
            // barButtonItemTypeCollectionView
            // 
			this.barButtonItemTypeCollectionView.Name = "barButtonItemTypeCollectionView";
            this.barButtonItemTypeCollectionView.Caption = "Types";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemTypeCollectionView));
					
						// 
            // navigationBarItemUserCollectionView
            // 
			this.navigationBarItemUserCollectionView.Name = "navigationBarItemUserCollectionView";
            this.navigationBarItemUserCollectionView.Text = "Users";
			// 
            // barButtonItemUserCollectionView
            // 
			this.barButtonItemUserCollectionView.Name = "barButtonItemUserCollectionView";
            this.barButtonItemUserCollectionView.Caption = "Users";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUserCollectionView));
					
							
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(PetStore.ViewModels.PetStoreEntitiesViewModel);
			 // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // PetStoreEntitiesView
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "PetStoreEntitiesView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
		private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
		private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame; 
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemAccountCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemAccountCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemBillCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemBillCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemBillDetailCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemBillDetailCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemCommentCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemCommentCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemCommentDetailCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemCommentDetailCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemGiftCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemGiftCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemOriginCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemOriginCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPetCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPetCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPetAccessoryCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPetAccessoryCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPetFoodCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPetFoodCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPetMedicineCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPetMedicineCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemPetToyCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemPetToyCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemRoleCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemRoleCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemTypeCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemTypeCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemUserCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemUserCollectionView;
					}
}
