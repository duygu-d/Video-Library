
namespace Video_Library
{
    partial class History
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.viewButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.historyListView = new System.Windows.Forms.ListView();
            this.searchedVideos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favouritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLmenuStrip = new System.Windows.Forms.MenuStrip();
            this.VLmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Red;
            this.deleteButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(633, 530);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 52);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BorderRadius = 5;
            this.viewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.viewButton.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(512, 530);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(95, 52);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "View";
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // historyListView
            // 
            this.historyListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchedVideos});
            this.historyListView.FullRowSelect = true;
            this.historyListView.GridLines = true;
            this.historyListView.HideSelection = false;
            this.historyListView.Location = new System.Drawing.Point(12, 22);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(716, 487);
            this.historyListView.TabIndex = 10;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.Click += new System.EventHandler(this.historyListView_Click);
            // 
            // searchedVideos
            // 
            this.searchedVideos.Text = "";
            this.searchedVideos.Width = 0;
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
            // VLmenuStrip
            // 
            this.VLmenuStrip.AutoSize = false;
            this.VLmenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VLmenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.VLmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.VLmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesMenuItem});
            this.VLmenuStrip.Location = new System.Drawing.Point(744, 0);
            this.VLmenuStrip.Name = "VLmenuStrip";
            this.VLmenuStrip.Size = new System.Drawing.Size(245, 594);
            this.VLmenuStrip.TabIndex = 5;
            this.VLmenuStrip.Text = "VLmenuStrip";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 594);
            this.Controls.Add(this.historyListView);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.VLmenuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.Text = "Video Library | History";
            this.Load += new System.EventHandler(this.History_Load);
            this.VLmenuStrip.ResumeLayout(false);
            this.VLmenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GradientTileButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton viewButton;
        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader searchedVideos;
        private System.Windows.Forms.ToolStripMenuItem favouritesMenuItem;
        private System.Windows.Forms.MenuStrip VLmenuStrip;
    }
}