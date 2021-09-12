
namespace Craps
{
    partial class window_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Group_Objectives = new System.Windows.Forms.GroupBox();
            this.Label_Wager = new System.Windows.Forms.Label();
            this.Label_WagerTxt = new System.Windows.Forms.Label();
            this.Label_PointObj = new System.Windows.Forms.Label();
            this.Label_Point = new System.Windows.Forms.Label();
            this.Label_ChipCount = new System.Windows.Forms.Label();
            this.Label_Chips = new System.Windows.Forms.Label();
            this.Btn_RollDice = new System.Windows.Forms.Button();
            this.Group_RollHistory = new System.Windows.Forms.GroupBox();
            this.Tb_RollHistory = new System.Windows.Forms.RichTextBox();
            this.Label_Wins = new System.Windows.Forms.Label();
            this.Label_WinsCount = new System.Windows.Forms.Label();
            this.Label_LossesCount = new System.Windows.Forms.Label();
            this.Label_Losses = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Group_Objectives.SuspendLayout();
            this.Group_RollHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_Objectives
            // 
            this.Group_Objectives.Controls.Add(this.Label_Wager);
            this.Group_Objectives.Controls.Add(this.Label_WagerTxt);
            this.Group_Objectives.Controls.Add(this.Label_PointObj);
            this.Group_Objectives.Controls.Add(this.Label_Point);
            this.Group_Objectives.Controls.Add(this.Label_ChipCount);
            this.Group_Objectives.Controls.Add(this.Label_Chips);
            this.Group_Objectives.Location = new System.Drawing.Point(12, 12);
            this.Group_Objectives.Name = "Group_Objectives";
            this.Group_Objectives.Size = new System.Drawing.Size(180, 123);
            this.Group_Objectives.TabIndex = 0;
            this.Group_Objectives.TabStop = false;
            this.Group_Objectives.Text = "Objectives";
            // 
            // Label_Wager
            // 
            this.Label_Wager.AutoSize = true;
            this.Label_Wager.Location = new System.Drawing.Point(104, 85);
            this.Label_Wager.Name = "Label_Wager";
            this.Label_Wager.Size = new System.Drawing.Size(22, 25);
            this.Label_Wager.TabIndex = 5;
            this.Label_Wager.Text = "0";
            // 
            // Label_WagerTxt
            // 
            this.Label_WagerTxt.AutoSize = true;
            this.Label_WagerTxt.Location = new System.Drawing.Point(7, 85);
            this.Label_WagerTxt.Name = "Label_WagerTxt";
            this.Label_WagerTxt.Size = new System.Drawing.Size(63, 25);
            this.Label_WagerTxt.TabIndex = 4;
            this.Label_WagerTxt.Text = "Wager";
            // 
            // Label_PointObj
            // 
            this.Label_PointObj.AutoSize = true;
            this.Label_PointObj.Location = new System.Drawing.Point(104, 56);
            this.Label_PointObj.Name = "Label_PointObj";
            this.Label_PointObj.Size = new System.Drawing.Size(22, 25);
            this.Label_PointObj.TabIndex = 3;
            this.Label_PointObj.Text = "0";
            // 
            // Label_Point
            // 
            this.Label_Point.AutoSize = true;
            this.Label_Point.Location = new System.Drawing.Point(7, 56);
            this.Label_Point.Name = "Label_Point";
            this.Label_Point.Size = new System.Drawing.Size(52, 25);
            this.Label_Point.TabIndex = 2;
            this.Label_Point.Text = "Point";
            // 
            // Label_ChipCount
            // 
            this.Label_ChipCount.AutoSize = true;
            this.Label_ChipCount.Location = new System.Drawing.Point(104, 27);
            this.Label_ChipCount.Name = "Label_ChipCount";
            this.Label_ChipCount.Size = new System.Drawing.Size(42, 25);
            this.Label_ChipCount.TabIndex = 1;
            this.Label_ChipCount.Text = "100";
            // 
            // Label_Chips
            // 
            this.Label_Chips.AutoSize = true;
            this.Label_Chips.Location = new System.Drawing.Point(6, 27);
            this.Label_Chips.Name = "Label_Chips";
            this.Label_Chips.Size = new System.Drawing.Size(56, 25);
            this.Label_Chips.TabIndex = 0;
            this.Label_Chips.Text = "Chips";
            // 
            // Btn_RollDice
            // 
            this.Btn_RollDice.Location = new System.Drawing.Point(12, 368);
            this.Btn_RollDice.Name = "Btn_RollDice";
            this.Btn_RollDice.Size = new System.Drawing.Size(180, 34);
            this.Btn_RollDice.TabIndex = 1;
            this.Btn_RollDice.Text = "Roll Dice";
            this.Btn_RollDice.UseVisualStyleBackColor = true;
            this.Btn_RollDice.Click += new System.EventHandler(this.Btn_RollDice_Click);
            // 
            // Group_RollHistory
            // 
            this.Group_RollHistory.Controls.Add(this.Tb_RollHistory);
            this.Group_RollHistory.Location = new System.Drawing.Point(199, 68);
            this.Group_RollHistory.Name = "Group_RollHistory";
            this.Group_RollHistory.Size = new System.Drawing.Size(226, 334);
            this.Group_RollHistory.TabIndex = 2;
            this.Group_RollHistory.TabStop = false;
            this.Group_RollHistory.Text = "Rolls";
            // 
            // Tb_RollHistory
            // 
            this.Tb_RollHistory.Location = new System.Drawing.Point(7, 29);
            this.Tb_RollHistory.Name = "Tb_RollHistory";
            this.Tb_RollHistory.ReadOnly = true;
            this.Tb_RollHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Tb_RollHistory.Size = new System.Drawing.Size(213, 299);
            this.Tb_RollHistory.TabIndex = 0;
            this.Tb_RollHistory.Text = "New Round";
            this.Tb_RollHistory.TextChanged += new System.EventHandler(this.Tb_RollHistory_TextChanged);
            // 
            // Label_Wins
            // 
            this.Label_Wins.AutoSize = true;
            this.Label_Wins.Location = new System.Drawing.Point(206, 13);
            this.Label_Wins.Name = "Label_Wins";
            this.Label_Wins.Size = new System.Drawing.Size(55, 25);
            this.Label_Wins.TabIndex = 3;
            this.Label_Wins.Text = "Wins:";
            // 
            // Label_WinsCount
            // 
            this.Label_WinsCount.AutoSize = true;
            this.Label_WinsCount.Location = new System.Drawing.Point(264, 13);
            this.Label_WinsCount.Name = "Label_WinsCount";
            this.Label_WinsCount.Size = new System.Drawing.Size(22, 25);
            this.Label_WinsCount.TabIndex = 4;
            this.Label_WinsCount.Text = "0";
            // 
            // Label_LossesCount
            // 
            this.Label_LossesCount.AutoSize = true;
            this.Label_LossesCount.Location = new System.Drawing.Point(397, 13);
            this.Label_LossesCount.Name = "Label_LossesCount";
            this.Label_LossesCount.Size = new System.Drawing.Size(22, 25);
            this.Label_LossesCount.TabIndex = 5;
            this.Label_LossesCount.Text = "0";
            this.Label_LossesCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label_Losses
            // 
            this.Label_Losses.AutoSize = true;
            this.Label_Losses.Location = new System.Drawing.Point(332, 13);
            this.Label_Losses.Name = "Label_Losses";
            this.Label_Losses.Size = new System.Drawing.Size(68, 25);
            this.Label_Losses.TabIndex = 6;
            this.Label_Losses.Text = "Losses:";
            this.Label_Losses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 221);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_Losses);
            this.Controls.Add(this.Label_LossesCount);
            this.Controls.Add(this.Label_WinsCount);
            this.Controls.Add(this.Label_Wins);
            this.Controls.Add(this.Group_RollHistory);
            this.Controls.Add(this.Btn_RollDice);
            this.Controls.Add(this.Group_Objectives);
            this.MaximizeBox = false;
            this.Name = "window_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.window_Main_Load);
            this.Group_Objectives.ResumeLayout(false);
            this.Group_Objectives.PerformLayout();
            this.Group_RollHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_Objectives;
        private System.Windows.Forms.Label Label_PointObj;
        private System.Windows.Forms.Label Label_Point;
        private System.Windows.Forms.Label Label_ChipCount;
        private System.Windows.Forms.Label Label_Chips;
        private System.Windows.Forms.Button Btn_RollDice;
        private System.Windows.Forms.GroupBox Group_RollHistory;
        private System.Windows.Forms.RichTextBox Tb_RollHistory;
        private System.Windows.Forms.Label Label_Wager;
        private System.Windows.Forms.Label Label_WagerTxt;
        private System.Windows.Forms.Label Label_Wins;
        private System.Windows.Forms.Label Label_WinsCount;
        private System.Windows.Forms.Label Label_LossesCount;
        private System.Windows.Forms.Label Label_Losses;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

