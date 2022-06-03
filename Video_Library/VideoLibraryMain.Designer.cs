
namespace Video_Library
{
    partial class VideoLibraryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoLibraryMain));
            this.URLtextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.unvalidURLlabel = new System.Windows.Forms.Label();
            this.VLmenuStrip = new System.Windows.Forms.MenuStrip();
            this.favouritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLtextBox
            // 
            this.URLtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.URLtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.URLtextBox.DefaultText = "";
            this.URLtextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.URLtextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.URLtextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.URLtextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.URLtextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.URLtextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.URLtextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.URLtextBox.Location = new System.Drawing.Point(12, 223);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.PasswordChar = '\0';
            this.URLtextBox.PlaceholderText = "Paste link here...";
            this.URLtextBox.SelectedText = "";
            this.URLtextBox.Size = new System.Drawing.Size(639, 52);
            this.URLtextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.FillColor2 = System.Drawing.Color.MediumPurple;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(647, 223);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 52);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // unvalidURLlabel
            // 
            this.unvalidURLlabel.AutoSize = true;
            this.unvalidURLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unvalidURLlabel.Location = new System.Drawing.Point(12, 278);
            this.unvalidURLlabel.Name = "unvalidURLlabel";
            this.unvalidURLlabel.Size = new System.Drawing.Size(0, 17);
            this.unvalidURLlabel.TabIndex = 5;
            // 
            // VLmenuStrip
            // 
            this.VLmenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VLmenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.VLmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.VLmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesMenuItem,
            this.historyMenuItem});
            this.VLmenuStrip.Location = new System.Drawing.Point(808, 0);
            this.VLmenuStrip.Name = "VLmenuStrip";
            this.VLmenuStrip.Size = new System.Drawing.Size(181, 594);
            this.VLmenuStrip.TabIndex = 6;
            this.VLmenuStrip.Text = "VLmenuStrip";
            // 
            // favouritesMenuItem
            // 
            this.favouritesMenuItem.AutoSize = false;
            this.favouritesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("favouritesMenuItem.Image")));
            this.favouritesMenuItem.Name = "favouritesMenuItem";
            this.favouritesMenuItem.Size = new System.Drawing.Size(175, 50);
            this.favouritesMenuItem.Text = "Favourites";
            this.favouritesMenuItem.Click += new System.EventHandler(this.favouritesMenuItem_Click);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.AutoSize = false;
            this.historyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historyMenuItem.Image")));
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(175, 50);
            this.historyMenuItem.Text = "History";
            this.historyMenuItem.Click += new System.EventHandler(this.historyMenuItem_Click);
            // 
            // VideoLibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 594);
            this.Controls.Add(this.VLmenuStrip);
            this.Controls.Add(this.unvalidURLlabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.URLtextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoLibraryMain";
            this.Text = "Video Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoLibraryMain_FormClosing);
            this.Load += new System.EventHandler(this.VideoLibraryMain_Load);
            this.VLmenuStrip.ResumeLayout(false);
            this.VLmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientTileButton searchButton;
        private Guna.UI2.WinForms.Guna2TextBox URLtextBox;
        private System.Windows.Forms.Label unvalidURLlabel;
        private System.Windows.Forms.MenuStrip VLmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem favouritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
    }
}

