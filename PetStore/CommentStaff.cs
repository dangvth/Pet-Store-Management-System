﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PetStore.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Collections;

namespace PetStore
{
    public partial class CommentStaff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private String cmtIDSelected = "";
        public CommentStaff()
        {
            InitializeComponent();
        }

        private void CommentStaff_Load(object sender, EventArgs e)
        {
            CommentModel cm = new CommentModel();
            bindingSourceComment.DataSource = cm.LoadTableData();
            gcComment.DataSource = bindingSourceComment;
        }

        private void btnDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            CommentDetailStaff cmds = new CommentDetailStaff();
            cmds.ShowDialog();
        }

        private void gvComment_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int idx = gvComment.FocusedRowHandle;
            if (gvComment.GetRowCellValue(idx, "cmt_id") != null)
            {
                cmtIDSelected = gvComment.GetRowCellValue(idx, "cmt_id").ToString();
            }
        }

        private void btnDeleteCmt_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmtIDSelected != "")
            {
                CommentModel cm = new CommentModel();
                cm.DeleteComment(cmtIDSelected);
                XtraMessageBox.Show("Delete successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'delete' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmtIDSelected != "")
            {
                CommentModel cm = new CommentModel();
                cm.RestoreComment(cmtIDSelected);
                XtraMessageBox.Show("Restore successful !!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Please choose a food item to 'restore' !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshCmt_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}