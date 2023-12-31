﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bsu_tnue_lipa_rpg
{
    public partial class Character_sel : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        public string[] CHAR_NAME = new string[2];
        public string[] CHAR_DESC = new string[2];
        public Character_sel()
        {
            InitializeComponent();
            dg1_clicknxt_lbl.BackColor = Color.FromArgb(179, 0, 0, 0);
            dg_chracter_sel1.BackColor = Color.FromArgb(179, 0, 0, 0);
            dg_chracter_sel2.BackColor = Color.FromArgb(179, 0, 0, 0);
            dg_chracter_sel3.BackColor = Color.FromArgb(179, 0, 0, 0);
            displayCharacters();
        }



        private void enter_btn_Click(object sender, EventArgs e)
        {

            if (ign_tbox.Text != string.Empty)
            {

                dg_chracter_sel1.Visible = false;
                dg1_pbox.Visible = false;
                ign_tbox.Visible = false;
                label1.Visible = false;
                dg1_pbox.SendToBack();
                //code here to insert into  ign tbox to students table
                MySqlConnection mySqlConnection = new MySqlConnection(Form1.mysqlConn);
                try
                {
                    mySqlConnection.Open();
                    string insertIGN = $@"UPDATE students 
                                          SET in_game_name='{ign_tbox.Text}'
                                          WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}';";
                    MySqlCommand insIgnCmd = new MySqlCommand(insertIGN, mySqlConnection);
                    insIgnCmd.ExecuteNonQuery();
                    MessageBox.Show("IGN Saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
                hideOrShowDialogue2entities(true);
                dg_chracter_sel2.BringToFront();
                enter_btn.Visible = false;
            }
            else
            {
                MessageBox.Show("Please type your ign.");
            }
        }

        private void baddey_pbox_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("You are choosing Baddey?", "Choosing", MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(Form1.mysqlConn);
                try
                {
                    mySqlConnection.Open();
                    string updateChar_insrtStudItems = $@"
                                           UPDATE students 
                                           SET charac_id=2
                                           WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                                           INSERT INTO student_items(sr_code,item_id,is_owned) 
                                           VALUES   ('{Form1.STUDENT_USER_SR_CODE}',1001,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1002,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1005,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1006,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1007,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1008,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1009,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1010,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1011,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1014,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1015,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1017,false),
                                                    ('{Form1.STUDENT_USER_SR_CODE}',1018,false);
                                           ";
                    MySqlCommand updtChar_insrtStudItemsCmd = new MySqlCommand(updateChar_insrtStudItems, mySqlConnection);
                    updtChar_insrtStudItemsCmd.ExecuteNonQuery();
                    messagebox msg = new messagebox();
                    msg.label1.Text = "CHARACTER SAVED...";
                    msg.label2.Text = "YOU CHOSE BADDEY!";
                    msg.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
                //sql here to insert into character with SRCODEVARIABLE sa forms1, ung student character
                hideOrShowDialogue2entities(false); 
                dg2_pbox.SendToBack();
                dg_chracter_sel3.BringToFront();
                label1.BringToFront();

                dg3_pbox.Visible = true;
                dg_chracter_sel3.Visible = true;
                label1.Visible = true;
            }
        }

        private void yuhgie_pbox_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("You are choosing Yuh Gie?","Choosing",MessageBoxButtons.YesNo);
            if (choose == DialogResult.Yes)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(Form1.mysqlConn);
                try
                {
                    mySqlConnection.Open();
                    string updateChar_insrtStudItems = $@"
                                           UPDATE students 
                                           SET charac_id=1
                                           WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';

                                           INSERT INTO student_items(sr_code,item_id,is_owned) 
                                           VALUES ('{Form1.STUDENT_USER_SR_CODE}',1003,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1004,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1005,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1006,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1007,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1008,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1009,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1012,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1013,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1014,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1015,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1016,false),
                                                  ('{Form1.STUDENT_USER_SR_CODE}',1018,false);
                                           ";
                    MySqlCommand updtChar_insrtStudItemsCmd = new MySqlCommand(updateChar_insrtStudItems, mySqlConnection);
                    updtChar_insrtStudItemsCmd.ExecuteNonQuery();
                    messagebox msg = new messagebox();
                    msg.label1.Text = "CHARACTER SAVED...";
                    msg.label2.Text = "YOU CHOSE YUH GIE!";
                    msg.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }
                //sql here to insert into character with SRCODEVARIABLE sa forms1, ung student character
                hideOrShowDialogue2entities(false);
                dg2_pbox.SendToBack();
                dg_chracter_sel3.BringToFront();
                label1.BringToFront();

                dg3_pbox.Visible = true;
                dg_chracter_sel3.Visible = true;
                label1.Visible = true;
            }
        }

        private void dg3_pbox_Click(object sender, EventArgs e)
        {
            //Will create tasks in database
            MySqlConnection mySqlConnection = new MySqlConnection(Form1.mysqlConn);
            try
            {
                mySqlConnection.Open();
                string updateChar = $@"INSERT INTO gameplay_records(sr_code,task_id,status, date_finished)
                                       VALUES ('{Form1.STUDENT_USER_SR_CODE}',1,false, CURRENT_DATE);
                                        
                                       UPDATE students SET current_money=850.00 WHERE sr_code='{Form1.STUDENT_USER_SR_CODE}';";
                MySqlCommand updtCharCmd = new MySqlCommand(updateChar, mySqlConnection);
                updtCharCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            this.Hide();
            Bedroom signUp = new Bedroom();
            signUp.ShowDialog();
            this.Close();

        }
        private void hideOrShowDialogue2entities(bool H_S)
        {
            dg2_pbox.Visible = H_S;
            dg_chracter_sel2.Visible = H_S;
            yuhgie_pbox.Visible = H_S;
            baddey_pbox.Visible = H_S;
            c1name_lbl.Visible = H_S;
            c2name_lbl.Visible = H_S;
            c1desc_lbl.Visible = H_S;
            c2desc_lbl.Visible = H_S;
            cs_lbl.Visible = H_S;
            cs_panel.Visible = H_S;
        }
        private void Character_sel_Load(object sender, EventArgs e)
        {

        }


        private void displayCharacters()
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctChars = $@"
                        SELECT charac_name AS nm,charac_desc AS dsc
                        FROM characters
                        ORDER BY charac_id DESC;";
            try
            {
                mysqlConnection.Open();
                MySqlCommand slctCharCmd = new MySqlCommand(slctChars, mysqlConnection);

                using (MySqlDataReader reader = slctCharCmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        CHAR_NAME[i] = (string)reader["nm"];
                        CHAR_DESC[i] = (string)reader["dsc"];
                        i++;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysqlConnection.Close();
            }
            c1name_lbl.Text = CHAR_NAME[0];
            c2name_lbl.Text = CHAR_NAME[1];
            c1desc_lbl.Text = CHAR_DESC[0];
            c2desc_lbl.Text = CHAR_DESC[1];
        }

        private void dg2_pbox_Click(object sender, EventArgs e)
        {

        }

        private void dg1_pbox_Click(object sender, EventArgs e)
        {

        }
    }
}
