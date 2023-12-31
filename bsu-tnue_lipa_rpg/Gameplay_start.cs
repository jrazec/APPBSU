﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsu_tnue_lipa_rpg
{
    public partial class Gameplay_start : Form
    {
        public static bool free;
        public Gameplay_start()
        {
            InitializeComponent();
            options_btn.Click += options_btn_Click;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure log out your account?", "Log-out", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                Form1.STUDENT_USER_SR_CODE = "";
                this.Hide();
                Log_in logIn = new Log_in();
                logIn.ShowDialog();
                this.Close();
            }
            
            
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctFREEDAY= $@"
                SELECT gameplay_records.status AS stat
                FROM gameplay_records
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}' AND task_id =5;"
            ;

            string slctGmplyRec = $@"
                SELECT gameplay_records.status
                FROM gameplay_records
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}' AND task_id =1;"
            ;//Unsure here yet
             //Basta I want to check here if there is a record na the user already started a task inorder
             //for the player to not daan the tutorial/character selection part

            try
            {
                mysqlConnection.Open();

                MySqlCommand slctFreeCmd = new MySqlCommand(slctFREEDAY, mysqlConnection);

                using (MySqlDataReader reader = slctFreeCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        free = (bool)reader["stat"];
                    }
                    else
                    {
                        free = false;
                    }
                }


                MySqlDataAdapter slctGmplyRecCmd = new MySqlDataAdapter(slctGmplyRec, mysqlConnection);

                DataTable dt = new DataTable();
                slctGmplyRecCmd.Fill(dt);

                if (dt.Rows.Count == 1)//if makikita ung gameplay record na task # 1 nya na nag iisa naman
                {
                    if (free)
                    {
                        MessageBox.Show("Its Free day! For you! redirecting where you left out..");
                        this.Hide();
                        Bedroom bd = new Bedroom();
                        Bedroom.instance.DAY = "FREE DAY";
                        bd.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gameplay found, redirecting where you left out..");
                        this.Hide();
                        Bedroom bd = new Bedroom();
                        bd.ShowDialog();
                        this.Close();
                    }
                }
                else//if walang magpopop up na query, ito lalabas
                {
                    MessageBox.Show("No Gameplay Record found, proceeding to the tutorial..");
                    this.Hide();
                    Game_mechanics gMech = new Game_mechanics();
                    gMech.ShowDialog();
                    this.Close();
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

        }


   
        private void options_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opps showns!");
        }
        public static void checkFree()
        {//Draft Yet, use proper try catch handling
            MySqlConnection mysqlConnection = new MySqlConnection(Form1.mysqlConn);

            string slctFREEDAY = $@"
                SELECT gameplay_records.status AS stat
                FROM gameplay_records
                WHERE sr_code = '{Form1.STUDENT_USER_SR_CODE}' AND task_id =5;"
            ;
            mysqlConnection.Open();
            MySqlCommand slctFreeCmd = new MySqlCommand(slctFREEDAY, mysqlConnection);

            using (MySqlDataReader reader = slctFreeCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    free = (bool)reader["stat"];
                }
                else
                {
                    free = false;
                }
            }
            mysqlConnection.Close();
        }
    }
}
