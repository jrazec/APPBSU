﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg.Closet_garments_uc
{
    public partial class top : UserControl
    {
        #region FIX : PictureBox Flickering!
        //THIS SOLVED THE PROBLEM HUUHUH FINALYY!!!!!!!!!!
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        #endregion

        public static top instance;
        public top()
        {
            InitializeComponent();
            instance = this;
            Bedroom.instance.checkCharac();
            if (Bedroom.instance.CHARAC_ID == 1)
            {
                top1_pbox.Image = Properties.Resources.CICS_Org_Shirt;
                top2_pbox.Image = Properties.Resources.College_Barong;
                top3_pbox.Image = Properties.Resources.PE_T_Shirt;
                top4_pbox.Image = Properties.Resources.Civilian_Top_2;
            }
            else
            {
                top1_pbox.Image = Properties.Resources.CICS_Org_Shirt;
                top2_pbox.Image = Properties.Resources.College_Blouse;
                top3_pbox.Image = Properties.Resources.Civilian_Top_1;
                top4_pbox.Image = Properties.Resources.PE_T_Shirt;
            }
        }
        public bool top1_sel = false;
        public bool top2_sel = false;
        public bool top3_sel = false;
        public bool top4_sel = false;
        private void top1_pbox_Click(object sender, EventArgs e)
        {
            if(top1_sel == false)
            {
                top1_sel = true;
                top2_sel = false;
                top3_sel = false;
                top4_sel = false;
                top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                top1_pbox.BackColor = Color.DarkGray;

                top2_pbox.BorderStyle = BorderStyle.None;
                top2_pbox.BackColor = Color.Transparent;
                top3_pbox.BorderStyle = BorderStyle.None;
                top3_pbox.BackColor = Color.Transparent;
                top4_pbox.BorderStyle = BorderStyle.None;
                top4_pbox.BackColor = Color.Transparent;

                Closet.Garments_Worn[0, 0] = "org-top";
                Closet.instance.top_pbox.Image = Properties.Resources.CICS_Org_Shirt;
            }
            else
            {
                top1_sel = false;
                top1_pbox.BorderStyle = BorderStyle.None;
                top1_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top2_pbox_Click(object sender, EventArgs e)
        {
            if (top2_sel == false)
            {
                top2_sel = true;
                top1_sel = false;
                top3_sel = false;
                top4_sel = false;
                top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                top2_pbox.BackColor= Color.DarkGray;

                top1_pbox.BorderStyle = BorderStyle.None;
                top1_pbox.BackColor = Color.Transparent;
                top3_pbox.BorderStyle = BorderStyle.None;
                top3_pbox.BackColor = Color.Transparent;
                top4_pbox.BorderStyle = BorderStyle.None;
                top4_pbox.BackColor = Color.Transparent;

                Closet.Garments_Worn[0, 0] = "uni-top";
                if(Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.instance.top_pbox.Image = Properties.Resources.College_Barong;
                }
                else
                {
                    Closet.instance.top_pbox.Image = Properties.Resources.College_Blouse;
                }
            }
            else
            {
                top2_sel = false;
                top2_pbox.BorderStyle = BorderStyle.None;
                top2_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top3_pbox_Click(object sender, EventArgs e)
        {
            if (top3_sel == false)
            {
                top3_sel = true;
                top1_sel = false;
                top2_sel = false;
                top4_sel = false;
                top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                top3_pbox.BackColor = Color.DarkGray;

                top2_pbox.BorderStyle = BorderStyle.None;
                top2_pbox.BackColor = Color.Transparent;
                top1_pbox.BorderStyle = BorderStyle.None;
                top1_pbox.BackColor = Color.Transparent;
                top4_pbox.BorderStyle = BorderStyle.None;
                top4_pbox.BackColor = Color.Transparent;

                if(Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.Garments_Worn[0, 0] = "pe-top";
                    Closet.instance.top_pbox.Image = Properties.Resources.PE_T_Shirt;
                }
                else
                {
                    Closet.Garments_Worn[0, 0] = "cas-top";
                    Closet.instance.top_pbox.Image = Properties.Resources.Civilian_Top_1;
                }
            }
            else
            {
                top3_sel = false;
                top3_pbox.BorderStyle = BorderStyle.None;
                top3_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top4_pbox_Click(object sender, EventArgs e)
        {
            if (top4_sel == false)
            {
                top4_sel = true;
                top1_sel = false;
                top2_sel = false;
                top3_sel = false;
                top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                top4_pbox.BackColor = Color.DarkGray;

                top2_pbox.BorderStyle = BorderStyle.None;
                top2_pbox.BackColor = Color.Transparent;
                top3_pbox.BorderStyle = BorderStyle.None;
                top3_pbox.BackColor = Color.Transparent;
                top1_pbox.BorderStyle = BorderStyle.None;
                top1_pbox.BackColor = Color.Transparent;

                if (Bedroom.instance.CHARAC_ID == 1)
                {
                    Closet.Garments_Worn[0, 0] = "cas-top";
                    Closet.instance.top_pbox.Image = Properties.Resources.Civilian_Top_2;
                }
                else
                {
                    Closet.Garments_Worn[0, 0] = "pe-top";
                    Closet.instance.top_pbox.Image = Properties.Resources.PE_T_Shirt;
                }
            }
            else
            {
                top4_sel = false;
                top4_pbox.BorderStyle = BorderStyle.None;
                top4_pbox.BackColor = Color.Transparent;
                emptyIcon();
            }
            Closet.instance.label1.Text = Closet.Garments_Worn[0, 0];
        }

        private void top1_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 0, 0, () =>{
                if (top1_sel) { 
                    emptyIcon();
                    top1_sel = false;
                    top1_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
            
        }

        private void top2_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 0, 1, () =>{
                if (top2_sel) {
                    emptyIcon();
                    top2_sel = false;
                    top2_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
        }

        private void top3_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 0, 2, () =>{
                if (top3_sel) { 
                    emptyIcon();
                    top3_sel = false;
                    top3_pbox.BorderStyle = BorderStyle.Fixed3D;
                }
            });
        }

        private void top4_desc_Click(object sender, EventArgs e)
        {
            Closet.instance.buy_refundItems(Closet.instance.ITEM_PRICE, Closet.instance.ITEMS, 0, 3, () =>{
                if (top4_sel){
                    emptyIcon();
                    top4_sel = false;
                    top4_pbox.BorderStyle = BorderStyle.Fixed3D;
                }  
            });

        }
        private void top4_lbl_Click(object sender, EventArgs e)
        {

        }


        private void emptyIcon()
        {
            Closet.Garments_Worn[0, 0] = "";
            Closet.instance.top_pbox.Image = Properties.Resources.top_icon;
        }
    }
}
