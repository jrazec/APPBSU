﻿namespace bsu_tnue_lipa_rpg.OB_floors_uc
{
    partial class OB_fourthflr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.staircollision_pbox = new System.Windows.Forms.PictureBox();
            this.upflrcollision_pbox = new System.Windows.Forms.PictureBox();
            this.obfourthflr_charac = new System.Windows.Forms.PictureBox();
            this.obfourthWalkTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obfourthflr_charac)).BeginInit();
            this.SuspendLayout();
            // 
            // staircollision_pbox
            // 
            this.staircollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.staircollision_pbox.Location = new System.Drawing.Point(3, 253);
            this.staircollision_pbox.Name = "staircollision_pbox";
            this.staircollision_pbox.Size = new System.Drawing.Size(16, 117);
            this.staircollision_pbox.TabIndex = 4;
            this.staircollision_pbox.TabStop = false;
            this.staircollision_pbox.Tag = "go_down";
            // 
            // upflrcollision_pbox
            // 
            this.upflrcollision_pbox.BackColor = System.Drawing.Color.DimGray;
            this.upflrcollision_pbox.Location = new System.Drawing.Point(1412, 230);
            this.upflrcollision_pbox.Name = "upflrcollision_pbox";
            this.upflrcollision_pbox.Size = new System.Drawing.Size(21, 162);
            this.upflrcollision_pbox.TabIndex = 5;
            this.upflrcollision_pbox.TabStop = false;
            this.upflrcollision_pbox.Tag = "go_up";
            // 
            // obfourthflr_charac
            // 
            this.obfourthflr_charac.BackColor = System.Drawing.Color.Transparent;
            this.obfourthflr_charac.Image = global::bsu_tnue_lipa_rpg.Properties.Resources.female_org_front;
            this.obfourthflr_charac.Location = new System.Drawing.Point(295, 220);
            this.obfourthflr_charac.Name = "obfourthflr_charac";
            this.obfourthflr_charac.Size = new System.Drawing.Size(111, 135);
            this.obfourthflr_charac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obfourthflr_charac.TabIndex = 6;
            this.obfourthflr_charac.TabStop = false;
            // 
            // obfourthWalkTimer
            // 
            this.obfourthWalkTimer.Enabled = true;
            this.obfourthWalkTimer.Interval = 50;
            this.obfourthWalkTimer.Tick += new System.EventHandler(this.obfourthWalkTimer_Tick);
            // 
            // OB_fourthflr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::bsu_tnue_lipa_rpg.Properties.Resources.ob_hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.obfourthflr_charac);
            this.Controls.Add(this.upflrcollision_pbox);
            this.Controls.Add(this.staircollision_pbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OB_fourthflr";
            this.Size = new System.Drawing.Size(1436, 589);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_is_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_is_up);
            ((System.ComponentModel.ISupportInitialize)(this.staircollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upflrcollision_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obfourthflr_charac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox staircollision_pbox;
        private System.Windows.Forms.PictureBox upflrcollision_pbox;
        private System.Windows.Forms.PictureBox obfourthflr_charac;
        public System.Windows.Forms.Timer obfourthWalkTimer;
    }
}
