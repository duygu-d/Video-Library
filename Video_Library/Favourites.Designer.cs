
namespace Video_Library
{
    partial class Favourites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favourites));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.VLmenuStrip = new System.Windows.Forms.MenuStrip();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesListView = new System.Windows.Forms.ListView();
            this.favouriteVideos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.removeButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.statisticsButton = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.VLmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // VLmenuStrip
            // 
            this.VLmenuStrip.AutoSize = false;
            this.VLmenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VLmenuStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.VLmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.VLmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyMenuItem});
            this.VLmenuStrip.Location = new System.Drawing.Point(808, 0);
            this.VLmenuStrip.Name = "VLmenuStrip";
            this.VLmenuStrip.Size = new System.Drawing.Size(181, 594);
            this.VLmenuStrip.TabIndex = 8;
            this.VLmenuStrip.Text = "VLmenuStrip";
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
            // favouritesListView
            // 
            this.favouritesListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.favouritesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.favouriteVideos});
            this.favouritesListView.FullRowSelect = true;
            this.favouritesListView.GridLines = true;
            this.favouritesListView.HideSelection = false;
            this.favouritesListView.Location = new System.Drawing.Point(12, 21);
            this.favouritesListView.Name = "favouritesListView";
            this.favouritesListView.Size = new System.Drawing.Size(788, 455);
            this.favouritesListView.TabIndex = 11;
            this.favouritesListView.UseCompatibleStateImageBehavior = false;
            this.favouritesListView.Click += new System.EventHandler(this.favouritesListView_Click);
            // 
            // favouriteVideos
            // 
            this.favouriteVideos.Text = "";
            this.favouriteVideos.Width = 0;
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
            this.viewButton.Location = new System.Drawing.Point(444, 530);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(95, 52);
            this.viewButton.TabIndex = 12;
            this.viewButton.Text = "View";
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BorderRadius = 5;
            this.removeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeButton.FillColor = System.Drawing.Color.Red;
            this.removeButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(705, 530);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(95, 52);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BorderRadius = 5;
            this.statisticsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.statisticsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.statisticsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.statisticsButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.statisticsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.statisticsButton.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.statisticsButton.FillColor2 = System.Drawing.Color.DarkSeaGreen;
            this.statisticsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Location = new System.Drawing.Point(567, 530);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(110, 52);
            this.statisticsButton.TabIndex = 14;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.Visible = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // Favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 594);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.favouritesListView);
            this.Controls.Add(this.VLmenuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Favourites";
            this.Text = "Video Library | Favourites";
            this.Load += new System.EventHandler(this.Favourites_Load);
            this.VLmenuStrip.ResumeLayout(false);
            this.VLmenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip VLmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ListView favouritesListView;
        private System.Windows.Forms.ColumnHeader favouriteVideos;
        private Guna.UI2.WinForms.Guna2GradientTileButton viewButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton removeButton;
        private Guna.UI2.WinForms.Guna2GradientTileButton statisticsButton;
    }
}