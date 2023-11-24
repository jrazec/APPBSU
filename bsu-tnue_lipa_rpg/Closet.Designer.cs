﻿namespace bsu_tnue_lipa_rpg
{
    partial class Closet
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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.top_pbox = new System.Windows.Forms.PictureBox();
            this.pants_pbox = new System.Windows.Forms.PictureBox();
            this.necklace_pbox = new System.Windows.Forms.PictureBox();
            this.shoes_pbox = new System.Windows.Forms.PictureBox();
            this.backtoroom_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.top_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pants_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.necklace_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoes_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Maroon;
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1151, 50);
            this.menu_panel.TabIndex = 0;
            // 
            // top_pbox
            // 
            this.top_pbox.BackColor = System.Drawing.Color.Transparent;
            this.top_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.top_icon;
            this.top_pbox.Location = new System.Drawing.Point(177, 102);
            this.top_pbox.Name = "top_pbox";
            this.top_pbox.Size = new System.Drawing.Size(110, 83);
            this.top_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.top_pbox.TabIndex = 1;
            this.top_pbox.TabStop = false;
            // 
            // pants_pbox
            // 
            this.pants_pbox.BackColor = System.Drawing.Color.Transparent;
            this.pants_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.pants_icon;
            this.pants_pbox.Location = new System.Drawing.Point(180, 238);
            this.pants_pbox.Name = "pants_pbox";
            this.pants_pbox.Size = new System.Drawing.Size(107, 82);
            this.pants_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pants_pbox.TabIndex = 2;
            this.pants_pbox.TabStop = false;
            // 
            // necklace_pbox
            // 
            this.necklace_pbox.BackColor = System.Drawing.Color.Transparent;
            this.necklace_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.neck_icon;
            this.necklace_pbox.Location = new System.Drawing.Point(176, 363);
            this.necklace_pbox.Name = "necklace_pbox";
            this.necklace_pbox.Size = new System.Drawing.Size(110, 86);
            this.necklace_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.necklace_pbox.TabIndex = 3;
            this.necklace_pbox.TabStop = false;
            // 
            // shoes_pbox
            // 
            this.shoes_pbox.BackColor = System.Drawing.Color.Transparent;
            this.shoes_pbox.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.shoes_icon;
            this.shoes_pbox.Location = new System.Drawing.Point(178, 498);
            this.shoes_pbox.Name = "shoes_pbox";
            this.shoes_pbox.Size = new System.Drawing.Size(108, 90);
            this.shoes_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shoes_pbox.TabIndex = 4;
            this.shoes_pbox.TabStop = false;
            // 
            // backtoroom_btn
            // 
            this.backtoroom_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backtoroom_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoroom_btn.Location = new System.Drawing.Point(12, 67);
            this.backtoroom_btn.Name = "backtoroom_btn";
            this.backtoroom_btn.Size = new System.Drawing.Size(75, 33);
            this.backtoroom_btn.TabIndex = 5;
            this.backtoroom_btn.Text = "Back";
            this.backtoroom_btn.UseVisualStyleBackColor = false;
            this.backtoroom_btn.Click += new System.EventHandler(this.backtoroom_btn_Click);
            // 
            // Closet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.closet;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.backtoroom_btn);
            this.Controls.Add(this.shoes_pbox);
            this.Controls.Add(this.necklace_pbox);
            this.Controls.Add(this.pants_pbox);
            this.Controls.Add(this.top_pbox);
            this.Controls.Add(this.menu_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Closet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Closet";
            ((System.ComponentModel.ISupportInitialize)(this.top_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pants_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.necklace_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoes_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox top_pbox;
        private System.Windows.Forms.PictureBox pants_pbox;
        private System.Windows.Forms.PictureBox necklace_pbox;
        private System.Windows.Forms.PictureBox shoes_pbox;
        private System.Windows.Forms.Button backtoroom_btn;
    }
}