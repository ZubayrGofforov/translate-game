using System;
using TranslateGame.Desktop.Enums;

namespace TranslateGame.Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.translateBox = new System.Windows.Forms.TextBox();
            this.nextButton = new XanderUI.XUIButton();
            this.resultLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // wordBox
            // 
            this.wordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordBox.Location = new System.Drawing.Point(161, 68);
            this.wordBox.Multiline = true;
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(423, 35);
            this.wordBox.TabIndex = 1;
            this.wordBox.TextChanged += new System.EventHandler(this.wordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Translate";
            // 
            // translateBox
            // 
            this.translateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBox.Location = new System.Drawing.Point(161, 151);
            this.translateBox.Multiline = true;
            this.translateBox.Name = "translateBox";
            this.translateBox.Size = new System.Drawing.Size(423, 35);
            this.translateBox.TabIndex = 1;
            this.translateBox.TextChanged += new System.EventHandler(this.translateBox_TextChanged);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("nextButton.ButtonImage")));
            this.nextButton.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.nextButton.ButtonText = "Next";
            this.nextButton.ClickBackColor = System.Drawing.Color.Yellow;
            this.nextButton.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.nextButton.CornerRadius = 5;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.nextButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.nextButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nextButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.nextButton.Location = new System.Drawing.Point(384, 236);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(200, 42);
            this.nextButton.TabIndex = 2;
            this.nextButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nextButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.nextButton.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(52, 336);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(667, 414);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.translateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox translateBox;
        private XanderUI.XUIButton nextButton;
        private int count;
        private TestLevel level;
        public void SetConfigureValues(int count, TestLevel level, Guid userId)
        {
            this.count = count;
            this.level = level;
            this.userId = userId;

            GetTestCollection();
        }

        private Bunifu.Framework.UI.BunifuCustomLabel resultLabel;
    }
}

