
namespace Video_Library
{
    partial class VideoLibrarySearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoLibrarySearchResult));
            this.VLmenuStrip = new System.Windows.Forms.MenuStrip();
            this.favouritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.favouritesImgButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.titleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewsTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.channelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.likesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VLmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VLmenuStrip
            // 
            this.VLmenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VLmenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.VLmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.VLmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesMenuItem,
            this.historyMenuItem});
            this.VLmenuStrip.Location = new System.Drawing.Point(1100, 0);
            this.VLmenuStrip.Name = "VLmenuStrip";
            this.VLmenuStrip.Size = new System.Drawing.Size(181, 636);
            this.VLmenuStrip.TabIndex = 4;
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
            // videoPictureBox
            // 
            this.videoPictureBox.ImageRotate = 0F;
            this.videoPictureBox.Location = new System.Drawing.Point(12, 13);
            this.videoPictureBox.Name = "videoPictureBox";
            this.videoPictureBox.Size = new System.Drawing.Size(307, 240);
            this.videoPictureBox.TabIndex = 6;
            this.videoPictureBox.TabStop = false;
            // 
            // favouritesImgButton
            // 
            this.favouritesImgButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.favouritesImgButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.favouritesImgButton.Image = ((System.Drawing.Image)(resources.GetObject("favouritesImgButton.Image")));
            this.favouritesImgButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.favouritesImgButton.ImageRotate = 0F;
            this.favouritesImgButton.ImageSize = new System.Drawing.Size(32, 32);
            this.favouritesImgButton.Location = new System.Drawing.Point(844, 215);
            this.favouritesImgButton.Name = "favouritesImgButton";
            this.favouritesImgButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.favouritesImgButton.Size = new System.Drawing.Size(48, 51);
            this.favouritesImgButton.TabIndex = 12;
            this.favouritesImgButton.Click += new System.EventHandler(this.favouritesImgButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.titleTextBox.BorderRadius = 2;
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.DefaultText = "";
            this.titleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleTextBox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.titleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleTextBox.Location = new System.Drawing.Point(426, 13);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PasswordChar = '\0';
            this.titleTextBox.PlaceholderText = "";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.titleTextBox.SelectedText = "";
            this.titleTextBox.Size = new System.Drawing.Size(601, 36);
            this.titleTextBox.TabIndex = 15;
            // 
            // viewsTextBox
            // 
            this.viewsTextBox.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.viewsTextBox.BorderRadius = 2;
            this.viewsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.viewsTextBox.DefaultText = "";
            this.viewsTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.viewsTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.viewsTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.viewsTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.viewsTextBox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewsTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.viewsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewsTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.viewsTextBox.Location = new System.Drawing.Point(426, 139);
            this.viewsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewsTextBox.Name = "viewsTextBox";
            this.viewsTextBox.PasswordChar = '\0';
            this.viewsTextBox.PlaceholderText = "";
            this.viewsTextBox.ReadOnly = true;
            this.viewsTextBox.SelectedText = "";
            this.viewsTextBox.Size = new System.Drawing.Size(132, 36);
            this.viewsTextBox.TabIndex = 16;
            // 
            // channelTextBox
            // 
            this.channelTextBox.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.channelTextBox.BorderRadius = 2;
            this.channelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.channelTextBox.DefaultText = "";
            this.channelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.channelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.channelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.channelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.channelTextBox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.channelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.channelTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.channelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.channelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.channelTextBox.Location = new System.Drawing.Point(426, 55);
            this.channelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.PasswordChar = '\0';
            this.channelTextBox.PlaceholderText = "";
            this.channelTextBox.ReadOnly = true;
            this.channelTextBox.SelectedText = "";
            this.channelTextBox.Size = new System.Drawing.Size(267, 36);
            this.channelTextBox.TabIndex = 17;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dateTextBox.BorderRadius = 2;
            this.dateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTextBox.DefaultText = "";
            this.dateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dateTextBox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateTextBox.Location = new System.Drawing.Point(426, 97);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.PasswordChar = '\0';
            this.dateTextBox.PlaceholderText = "";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.SelectedText = "";
            this.dateTextBox.Size = new System.Drawing.Size(132, 36);
            this.dateTextBox.TabIndex = 18;
            // 
            // likesTextBox
            // 
            this.likesTextBox.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.likesTextBox.BorderRadius = 2;
            this.likesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.likesTextBox.DefaultText = "";
            this.likesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.likesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.likesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.likesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.likesTextBox.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.likesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.likesTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.likesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.likesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.likesTextBox.Location = new System.Drawing.Point(426, 181);
            this.likesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.likesTextBox.Name = "likesTextBox";
            this.likesTextBox.PasswordChar = '\0';
            this.likesTextBox.PlaceholderText = "";
            this.likesTextBox.ReadOnly = true;
            this.likesTextBox.SelectedText = "";
            this.likesTextBox.Size = new System.Drawing.Size(132, 36);
            this.likesTextBox.TabIndex = 19;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(12, 356);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(983, 248);
            this.descriptionRichTextBox.TabIndex = 20;
            this.descriptionRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(328, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(328, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(328, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Views:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(328, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Likes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(898, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Favourite";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Description:";
            // 
            // VideoLibrarySearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1281, 636);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.likesTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.viewsTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.favouritesImgButton);
            this.Controls.Add(this.videoPictureBox);
            this.Controls.Add(this.VLmenuStrip);
            this.MainMenuStrip = this.VLmenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoLibrarySearchResult";
            this.Text = "Video Library | Search";
            this.Load += new System.EventHandler(this.VideoLibrarySearchResult_Load);
            this.VLmenuStrip.ResumeLayout(false);
            this.VLmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip VLmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem favouritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox videoPictureBox;
        private Guna.UI2.WinForms.Guna2ImageButton favouritesImgButton;
        private Guna.UI2.WinForms.Guna2TextBox titleTextBox;
        private Guna.UI2.WinForms.Guna2TextBox viewsTextBox;
        private Guna.UI2.WinForms.Guna2TextBox channelTextBox;
        private Guna.UI2.WinForms.Guna2TextBox dateTextBox;
        private Guna.UI2.WinForms.Guna2TextBox likesTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

