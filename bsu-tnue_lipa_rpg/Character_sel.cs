﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg
{
    public partial class Character_sel : Form
    {
        public Character_sel()
        {
            InitializeComponent();
            //Doesnt show up... No Braincells left
            //dg1_pbox.Controls.Add(dg_chracter_sel1);
            //dg1_pbox.Controls.Add(label1);
            //dg1_pbox.Controls.Add(ign_tbox);
            //dg1_pbox.Location = new Point(106, 463);
           // dg1_pbox.BackColor = Color.Transparent;
        }





        private void Character_sel_Load(object sender, EventArgs e)
        {

        }

        private void dg1_pbox_Click(object sender, EventArgs e)
        {
            
        }

        private void dg2_pbox_Click(object sender, EventArgs e)
        {
            //dg_chracter_sel2.Visible = false;
            //dg2_pbox.Visible = false;
            //dg2_pbox.SendToBack();
            //code here to insert into  ign tbox to students table

            //dg3_pbox.Visible = true;
            //dg_chracter_sel3.Visible = true;

        }

        private void baddey_pbox_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("You are choosing Baddey?", "Choosing", MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {
                //sql here to insert into character with SRCODEVARIABLE sa forms1, ung student character
                dg2_pbox.SendToBack();

                dg2_pbox.Visible = false;
                dg_chracter_sel2.Visible = false;
                
                yuhgie_pbox.Visible = false;
                baddey_pbox.Visible = false;

                c1name_lbl.Visible = false;
                c2name_lbl.Visible = false;
                c1desc_lbl.Visible = false;
                c2desc_lbl.Visible = false;
                cs_lbl.Visible = false;
                cs_panel.Visible = false;

                dg3_pbox.Visible = true;
                dg_chracter_sel3.Visible = true;
                dg_chracter_sel3.BringToFront();
                label1.Visible = true;
                label1.BringToFront();
            }
        }

        private void yuhgie_pbox_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("You are choosing Yuh Gie?","Choosing",MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {
                //sql here to insert into character with SRCODEVARIABLE sa forms1, ung student character
                dg2_pbox.SendToBack();

                dg2_pbox.Visible = false;
                dg_chracter_sel2.Visible = false;

                yuhgie_pbox.Visible = false;
                baddey_pbox.Visible = false;

                c1name_lbl.Visible = false;
                c2name_lbl.Visible = false;
                c1desc_lbl.Visible = false;
                c2desc_lbl.Visible = false;
                cs_lbl.Visible = false;
                cs_panel.Visible = false;
                

                dg3_pbox.Visible = true;
                dg_chracter_sel3.Visible = true;
                dg_chracter_sel3.BringToFront();
                label1.Visible=true;
                label1.BringToFront();
            }
        }

        private void dg3_pbox_Click(object sender, EventArgs e)
        {
            
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            dg_chracter_sel1.Visible = false;
            dg1_pbox.Visible = false;
            ign_tbox.Visible = false;
            label1.Visible = false;
            dg1_pbox.SendToBack();
            //code here to insert into  ign tbox to students table

            dg2_pbox.Visible = true;
            dg_chracter_sel2.Visible = true;
            dg_chracter_sel2.BringToFront();

            yuhgie_pbox.Visible = true;
            baddey_pbox.Visible = true;

            c1name_lbl.Visible = true;
            c2name_lbl.Visible = true;
            c1desc_lbl.Visible = true;
            c2desc_lbl.Visible = true;
            cs_lbl.Visible = true;
            cs_panel.Visible = true;

            enter_btn.Visible = false;
        }
    }
}
