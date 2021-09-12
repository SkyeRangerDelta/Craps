
namespace Craps
{
    partial class WagerDialog
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
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.Label_Wager = new System.Windows.Forms.Label();
            this.Tb_WagerBox = new System.Windows.Forms.TextBox();
            this.Label_WagerHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.Location = new System.Drawing.Point(81, 49);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(144, 34);
            this.Btn_Accept.TabIndex = 0;
            this.Btn_Accept.Text = "Place Wager";
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // Label_Wager
            // 
            this.Label_Wager.AutoSize = true;
            this.Label_Wager.Location = new System.Drawing.Point(12, 15);
            this.Label_Wager.Name = "Label_Wager";
            this.Label_Wager.Size = new System.Drawing.Size(133, 25);
            this.Label_Wager.TabIndex = 1;
            this.Label_Wager.Text = "Wager Amount";
            // 
            // Tb_WagerBox
            // 
            this.Tb_WagerBox.Location = new System.Drawing.Point(151, 12);
            this.Tb_WagerBox.Name = "Tb_WagerBox";
            this.Tb_WagerBox.Size = new System.Drawing.Size(150, 31);
            this.Tb_WagerBox.TabIndex = 2;
            // 
            // Label_WagerHint
            // 
            this.Label_WagerHint.AutoSize = true;
            this.Label_WagerHint.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_WagerHint.Location = new System.Drawing.Point(6, 95);
            this.Label_WagerHint.Name = "Label_WagerHint";
            this.Label_WagerHint.Size = new System.Drawing.Size(295, 38);
            this.Label_WagerHint.TabIndex = 3;
            this.Label_WagerHint.Text = "(New games always start with 100 chips -\r\nRounds start with the amount after last" +
    " wager)";
            this.Label_WagerHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WagerDialog
            // 
            this.AcceptButton = this.Btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 142);
            this.ControlBox = false;
            this.Controls.Add(this.Label_WagerHint);
            this.Controls.Add(this.Tb_WagerBox);
            this.Controls.Add(this.Label_Wager);
            this.Controls.Add(this.Btn_Accept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WagerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wager?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WagerDialog_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WagerDialog_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Accept;
        private System.Windows.Forms.Label Label_Wager;
        private System.Windows.Forms.TextBox Tb_WagerBox;
        private System.Windows.Forms.Label Label_WagerHint;
    }
}