namespace TranslateGame.Desktop.Forms
{
    partial class UserSettings
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
            this.firstnameTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dateTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernameTextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainMenuLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.BorderColorFocused = System.Drawing.Color.Lime;
            this.firstnameTextbox.BorderColorIdle = System.Drawing.Color.White;
            this.firstnameTextbox.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.firstnameTextbox.BorderThickness = 3;
            this.firstnameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextbox.ForeColor = System.Drawing.Color.White;
            this.firstnameTextbox.isPassword = false;
            this.firstnameTextbox.Location = new System.Drawing.Point(52, 66);
            this.firstnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(405, 48);
            this.firstnameTextbox.TabIndex = 4;
            this.firstnameTextbox.Text = "First Name";
            this.firstnameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateTextbox
            // 
            this.dateTextbox.BorderColorFocused = System.Drawing.Color.Lime;
            this.dateTextbox.BorderColorIdle = System.Drawing.Color.White;
            this.dateTextbox.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.dateTextbox.BorderThickness = 3;
            this.dateTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextbox.ForeColor = System.Drawing.Color.White;
            this.dateTextbox.isPassword = false;
            this.dateTextbox.Location = new System.Drawing.Point(52, 139);
            this.dateTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.Size = new System.Drawing.Size(405, 48);
            this.dateTextbox.TabIndex = 4;
            this.dateTextbox.Text = "Date Of Birth";
            this.dateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dateTextbox.OnValueChanged += new System.EventHandler(this.dateTextbox_OnValueChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderColorFocused = System.Drawing.Color.Lime;
            this.usernameTextbox.BorderColorIdle = System.Drawing.Color.White;
            this.usernameTextbox.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.usernameTextbox.BorderThickness = 3;
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.White;
            this.usernameTextbox.isPassword = false;
            this.usernameTextbox.Location = new System.Drawing.Point(52, 215);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(405, 48);
            this.usernameTextbox.TabIndex = 4;
            this.usernameTextbox.Text = "Username";
            this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Update ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.GreenYellow;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(52, 302);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(405, 44);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Update ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.LinkColor = System.Drawing.Color.White;
            this.mainMenuLabel.Location = new System.Drawing.Point(52, 390);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(56, 25);
            this.mainMenuLabel.TabIndex = 6;
            this.mainMenuLabel.TabStop = true;
            this.mainMenuLabel.Text = "Back";
            this.mainMenuLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainMenuLabel_LinkClicked);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(524, 470);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.dateTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Name = "UserSettings";
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox firstnameTextbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox dateTextbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernameTextbox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.LinkLabel mainMenuLabel;
    }
}