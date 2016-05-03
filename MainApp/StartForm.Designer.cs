namespace MainApp
{
    partial class StartForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geneticAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.centerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.activityBottomPanel = new System.Windows.Forms.Panel();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.resourceBottomPanel = new System.Windows.Forms.Panel();
            this.buttonAddResource = new System.Windows.Forms.Button();
            this.resourcesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteResources = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).BeginInit();
            this.centerSplitContainer.Panel1.SuspendLayout();
            this.centerSplitContainer.Panel2.SuspendLayout();
            this.centerSplitContainer.SuspendLayout();
            this.activityBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.resourceBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.mainMenuStrip);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(830, 32);
            this.topPanel.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(830, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.helpMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(164, 26);
            this.helpMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geneticAlgorithmToolStripMenuItem,
            this.originalArticleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // geneticAlgorithmToolStripMenuItem
            // 
            this.geneticAlgorithmToolStripMenuItem.Name = "geneticAlgorithmToolStripMenuItem";
            this.geneticAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.geneticAlgorithmToolStripMenuItem.Text = "Genetic Algorithm";
            // 
            // originalArticleToolStripMenuItem
            // 
            this.originalArticleToolStripMenuItem.Name = "originalArticleToolStripMenuItem";
            this.originalArticleToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.originalArticleToolStripMenuItem.Text = "Original Article";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 302);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(830, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // centerSplitContainer
            // 
            this.centerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerSplitContainer.Location = new System.Drawing.Point(0, 32);
            this.centerSplitContainer.Name = "centerSplitContainer";
            // 
            // centerSplitContainer.Panel1
            // 
            this.centerSplitContainer.Panel1.Controls.Add(this.activityBottomPanel);
            this.centerSplitContainer.Panel1.Controls.Add(this.activitiesDataGridView);
            // 
            // centerSplitContainer.Panel2
            // 
            this.centerSplitContainer.Panel2.Controls.Add(this.resourceBottomPanel);
            this.centerSplitContainer.Panel2.Controls.Add(this.resourcesDataGridView);
            this.centerSplitContainer.Size = new System.Drawing.Size(830, 270);
            this.centerSplitContainer.SplitterDistance = 530;
            this.centerSplitContainer.TabIndex = 2;
            // 
            // activityBottomPanel
            // 
            this.activityBottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityBottomPanel.Controls.Add(this.addActivityButton);
            this.activityBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activityBottomPanel.Location = new System.Drawing.Point(0, 220);
            this.activityBottomPanel.Name = "activityBottomPanel";
            this.activityBottomPanel.Size = new System.Drawing.Size(530, 50);
            this.activityBottomPanel.TabIndex = 1;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(12, 10);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(106, 30);
            this.addActivityButton.TabIndex = 0;
            this.addActivityButton.Text = "Add Activity";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.RowHeadersVisible = false;
            this.activitiesDataGridView.RowTemplate.Height = 24;
            this.activitiesDataGridView.Size = new System.Drawing.Size(530, 270);
            this.activitiesDataGridView.TabIndex = 0;
            // 
            // resourceBottomPanel
            // 
            this.resourceBottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resourceBottomPanel.Controls.Add(this.buttonDeleteResources);
            this.resourceBottomPanel.Controls.Add(this.buttonAddResource);
            this.resourceBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resourceBottomPanel.Location = new System.Drawing.Point(0, 220);
            this.resourceBottomPanel.Name = "resourceBottomPanel";
            this.resourceBottomPanel.Size = new System.Drawing.Size(296, 50);
            this.resourceBottomPanel.TabIndex = 2;
            // 
            // buttonAddResource
            // 
            this.buttonAddResource.Location = new System.Drawing.Point(16, 10);
            this.buttonAddResource.Name = "buttonAddResource";
            this.buttonAddResource.Size = new System.Drawing.Size(110, 30);
            this.buttonAddResource.TabIndex = 1;
            this.buttonAddResource.Text = "Add Resource";
            this.buttonAddResource.UseVisualStyleBackColor = true;
            this.buttonAddResource.Click += new System.EventHandler(this.buttonAddResource_Click);
            // 
            // resourcesDataGridView
            // 
            this.resourcesDataGridView.AllowUserToAddRows = false;
            this.resourcesDataGridView.AllowUserToDeleteRows = false;
            this.resourcesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ResourceName,
            this.LimitPerDay});
            this.resourcesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resourcesDataGridView.Name = "resourcesDataGridView";
            this.resourcesDataGridView.RowHeadersVisible = false;
            this.resourcesDataGridView.RowTemplate.Height = 24;
            this.resourcesDataGridView.Size = new System.Drawing.Size(296, 270);
            this.resourcesDataGridView.TabIndex = 1;
            this.resourcesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.resourcesDataGridView_DataError);
            // 
            // buttonDeleteResources
            // 
            this.buttonDeleteResources.Location = new System.Drawing.Point(151, 10);
            this.buttonDeleteResources.Name = "buttonDeleteResources";
            this.buttonDeleteResources.Size = new System.Drawing.Size(123, 30);
            this.buttonDeleteResources.TabIndex = 2;
            this.buttonDeleteResources.Text = "Delete selected";
            this.buttonDeleteResources.UseVisualStyleBackColor = true;
            this.buttonDeleteResources.Click += new System.EventHandler(this.buttonDeleteResources_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // ResourceName
            // 
            this.ResourceName.DataPropertyName = "ResourceName";
            this.ResourceName.HeaderText = "Name";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.Width = 120;
            // 
            // LimitPerDay
            // 
            this.LimitPerDay.DataPropertyName = "LimitPerDay";
            this.LimitPerDay.HeaderText = "Limit Per Day";
            this.LimitPerDay.Name = "LimitPerDay";
            this.LimitPerDay.Width = 130;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 402);
            this.Controls.Add(this.centerSplitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "StartForm";
            this.Text = "Construction Project Manager";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.centerSplitContainer.Panel1.ResumeLayout(false);
            this.centerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).EndInit();
            this.centerSplitContainer.ResumeLayout(false);
            this.activityBottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.resourceBottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geneticAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.SplitContainer centerSplitContainer;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.DataGridView resourcesDataGridView;
        private System.Windows.Forms.Panel activityBottomPanel;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.Panel resourceBottomPanel;
        private System.Windows.Forms.Button buttonAddResource;
        private System.Windows.Forms.Button buttonDeleteResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitPerDay;
    }
}

