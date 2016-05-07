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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geneticAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.buttonRunAlgorithm = new System.Windows.Forms.Button();
            this.textBoxMutationProbability = new System.Windows.Forms.TextBox();
            this.labelMutationProbability = new System.Windows.Forms.Label();
            this.textBoxCrossoverProbability = new System.Windows.Forms.TextBox();
            this.labelCrossoverProbability = new System.Windows.Forms.Label();
            this.textBoxMaxIterations = new System.Windows.Forms.TextBox();
            this.labelMaxIterations = new System.Windows.Forms.Label();
            this.textBoxPopulationSize = new System.Windows.Forms.TextBox();
            this.labelPopulationSize = new System.Windows.Forms.Label();
            this.centerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.ActivityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreactivitiesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityResources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityTimeConstraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBottomPanel = new System.Windows.Forms.Panel();
            this.buttonDeleteActivies = new System.Windows.Forms.Button();
            this.buttonEditActivity = new System.Windows.Forms.Button();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.resourcesDataGridView = new System.Windows.Forms.DataGridView();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourceBottomPanel = new System.Windows.Forms.Panel();
            this.buttonDeleteResources = new System.Windows.Forms.Button();
            this.buttonAddResource = new System.Windows.Forms.Button();
            this.saveActivityDialog = new System.Windows.Forms.SaveFileDialog();
            this.openActivityDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelAlgorithmParamsContainer = new System.Windows.Forms.Panel();
            this.panelAlgorithmStartControls = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).BeginInit();
            this.centerSplitContainer.Panel1.SuspendLayout();
            this.centerSplitContainer.Panel2.SuspendLayout();
            this.centerSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.activityBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataGridView)).BeginInit();
            this.resourceBottomPanel.SuspendLayout();
            this.panelAlgorithmStartControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.mainMenuStrip);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(919, 32);
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
            this.mainMenuStrip.Size = new System.Drawing.Size(919, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadToolStripMenuItem,
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
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.geneticAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.geneticAlgorithmToolStripMenuItem_Click);
            // 
            // originalArticleToolStripMenuItem
            // 
            this.originalArticleToolStripMenuItem.Name = "originalArticleToolStripMenuItem";
            this.originalArticleToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.originalArticleToolStripMenuItem.Text = "Original Article";
            this.originalArticleToolStripMenuItem.Click += new System.EventHandler(this.originalArticleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panelAlgorithmStartControls);
            this.bottomPanel.Controls.Add(this.textBoxMutationProbability);
            this.bottomPanel.Controls.Add(this.labelMutationProbability);
            this.bottomPanel.Controls.Add(this.textBoxCrossoverProbability);
            this.bottomPanel.Controls.Add(this.labelCrossoverProbability);
            this.bottomPanel.Controls.Add(this.textBoxMaxIterations);
            this.bottomPanel.Controls.Add(this.labelMaxIterations);
            this.bottomPanel.Controls.Add(this.textBoxPopulationSize);
            this.bottomPanel.Controls.Add(this.labelPopulationSize);
            this.bottomPanel.Controls.Add(this.panelAlgorithmParamsContainer);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 375);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(919, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Location = new System.Drawing.Point(0, 54);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelStatus.Size = new System.Drawing.Size(326, 46);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Enter the data and click \"Run\"";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(222, 19);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLoading.TabIndex = 10;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // buttonRunAlgorithm
            // 
            this.buttonRunAlgorithm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunAlgorithm.Location = new System.Drawing.Point(107, 15);
            this.buttonRunAlgorithm.Name = "buttonRunAlgorithm";
            this.buttonRunAlgorithm.Size = new System.Drawing.Size(109, 30);
            this.buttonRunAlgorithm.TabIndex = 9;
            this.buttonRunAlgorithm.Text = "Run";
            this.buttonRunAlgorithm.UseVisualStyleBackColor = true;
            this.buttonRunAlgorithm.Click += new System.EventHandler(this.buttonRunAlgorithm_Click);
            // 
            // textBoxMutationProbability
            // 
            this.textBoxMutationProbability.Location = new System.Drawing.Point(453, 57);
            this.textBoxMutationProbability.Name = "textBoxMutationProbability";
            this.textBoxMutationProbability.Size = new System.Drawing.Size(123, 22);
            this.textBoxMutationProbability.TabIndex = 7;
            // 
            // labelMutationProbability
            // 
            this.labelMutationProbability.AutoSize = true;
            this.labelMutationProbability.Location = new System.Drawing.Point(300, 57);
            this.labelMutationProbability.Name = "labelMutationProbability";
            this.labelMutationProbability.Size = new System.Drawing.Size(136, 17);
            this.labelMutationProbability.TabIndex = 6;
            this.labelMutationProbability.Text = "Mutation Probability:";
            // 
            // textBoxCrossoverProbability
            // 
            this.textBoxCrossoverProbability.Location = new System.Drawing.Point(453, 19);
            this.textBoxCrossoverProbability.Name = "textBoxCrossoverProbability";
            this.textBoxCrossoverProbability.Size = new System.Drawing.Size(123, 22);
            this.textBoxCrossoverProbability.TabIndex = 5;
            // 
            // labelCrossoverProbability
            // 
            this.labelCrossoverProbability.AutoSize = true;
            this.labelCrossoverProbability.Location = new System.Drawing.Point(300, 19);
            this.labelCrossoverProbability.Name = "labelCrossoverProbability";
            this.labelCrossoverProbability.Size = new System.Drawing.Size(146, 17);
            this.labelCrossoverProbability.TabIndex = 4;
            this.labelCrossoverProbability.Text = "Crossover Probability:";
            // 
            // textBoxMaxIterations
            // 
            this.textBoxMaxIterations.Location = new System.Drawing.Point(130, 54);
            this.textBoxMaxIterations.Name = "textBoxMaxIterations";
            this.textBoxMaxIterations.Size = new System.Drawing.Size(123, 22);
            this.textBoxMaxIterations.TabIndex = 3;
            // 
            // labelMaxIterations
            // 
            this.labelMaxIterations.AutoSize = true;
            this.labelMaxIterations.Location = new System.Drawing.Point(13, 54);
            this.labelMaxIterations.Name = "labelMaxIterations";
            this.labelMaxIterations.Size = new System.Drawing.Size(99, 17);
            this.labelMaxIterations.TabIndex = 2;
            this.labelMaxIterations.Text = "Max Iterations:";
            // 
            // textBoxPopulationSize
            // 
            this.textBoxPopulationSize.Location = new System.Drawing.Point(130, 16);
            this.textBoxPopulationSize.Name = "textBoxPopulationSize";
            this.textBoxPopulationSize.Size = new System.Drawing.Size(123, 22);
            this.textBoxPopulationSize.TabIndex = 1;
            // 
            // labelPopulationSize
            // 
            this.labelPopulationSize.AutoSize = true;
            this.labelPopulationSize.Location = new System.Drawing.Point(13, 16);
            this.labelPopulationSize.Name = "labelPopulationSize";
            this.labelPopulationSize.Size = new System.Drawing.Size(110, 17);
            this.labelPopulationSize.TabIndex = 0;
            this.labelPopulationSize.Text = "Population Size:";
            // 
            // centerSplitContainer
            // 
            this.centerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerSplitContainer.Location = new System.Drawing.Point(0, 32);
            this.centerSplitContainer.Name = "centerSplitContainer";
            // 
            // centerSplitContainer.Panel1
            // 
            this.centerSplitContainer.Panel1.Controls.Add(this.activitiesDataGridView);
            this.centerSplitContainer.Panel1.Controls.Add(this.activityBottomPanel);
            this.centerSplitContainer.Panel1MinSize = 500;
            // 
            // centerSplitContainer.Panel2
            // 
            this.centerSplitContainer.Panel2.Controls.Add(this.resourcesDataGridView);
            this.centerSplitContainer.Panel2.Controls.Add(this.resourceBottomPanel);
            this.centerSplitContainer.Panel2MinSize = 260;
            this.centerSplitContainer.Size = new System.Drawing.Size(919, 343);
            this.centerSplitContainer.SplitterDistance = 647;
            this.centerSplitContainer.TabIndex = 2;
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.AllowUserToAddRows = false;
            this.activitiesDataGridView.AllowUserToDeleteRows = false;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityId,
            this.PreactivitiesColumn,
            this.ActivityName,
            this.ActivityDuration,
            this.ActivityResources,
            this.ActivityTimeConstraint});
            this.activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.RowHeadersVisible = false;
            this.activitiesDataGridView.RowTemplate.Height = 24;
            this.activitiesDataGridView.Size = new System.Drawing.Size(647, 293);
            this.activitiesDataGridView.TabIndex = 0;
            // 
            // ActivityId
            // 
            this.ActivityId.DataPropertyName = "Id";
            this.ActivityId.HeaderText = "Id";
            this.ActivityId.Name = "ActivityId";
            this.ActivityId.ReadOnly = true;
            this.ActivityId.Width = 50;
            // 
            // PreactivitiesColumn
            // 
            this.PreactivitiesColumn.DataPropertyName = "PreActivitiesDescription";
            this.PreactivitiesColumn.HeaderText = "Pre-activities";
            this.PreactivitiesColumn.Name = "PreactivitiesColumn";
            this.PreactivitiesColumn.ReadOnly = true;
            // 
            // ActivityName
            // 
            this.ActivityName.DataPropertyName = "Name";
            this.ActivityName.HeaderText = "Name";
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            // 
            // ActivityDuration
            // 
            this.ActivityDuration.DataPropertyName = "Duration";
            this.ActivityDuration.HeaderText = "Duration";
            this.ActivityDuration.Name = "ActivityDuration";
            this.ActivityDuration.ReadOnly = true;
            // 
            // ActivityResources
            // 
            this.ActivityResources.DataPropertyName = "ResourceDescription";
            this.ActivityResources.HeaderText = "Resources";
            this.ActivityResources.Name = "ActivityResources";
            this.ActivityResources.ReadOnly = true;
            // 
            // ActivityTimeConstraint
            // 
            this.ActivityTimeConstraint.DataPropertyName = "TimeConstraintDescription";
            this.ActivityTimeConstraint.HeaderText = "Time Constraints";
            this.ActivityTimeConstraint.Name = "ActivityTimeConstraint";
            this.ActivityTimeConstraint.ReadOnly = true;
            this.ActivityTimeConstraint.Width = 150;
            // 
            // activityBottomPanel
            // 
            this.activityBottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activityBottomPanel.Controls.Add(this.buttonDeleteActivies);
            this.activityBottomPanel.Controls.Add(this.buttonEditActivity);
            this.activityBottomPanel.Controls.Add(this.addActivityButton);
            this.activityBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activityBottomPanel.Location = new System.Drawing.Point(0, 293);
            this.activityBottomPanel.Name = "activityBottomPanel";
            this.activityBottomPanel.Size = new System.Drawing.Size(647, 50);
            this.activityBottomPanel.TabIndex = 1;
            // 
            // buttonDeleteActivies
            // 
            this.buttonDeleteActivies.Location = new System.Drawing.Point(254, 10);
            this.buttonDeleteActivies.Name = "buttonDeleteActivies";
            this.buttonDeleteActivies.Size = new System.Drawing.Size(122, 30);
            this.buttonDeleteActivies.TabIndex = 2;
            this.buttonDeleteActivies.Text = "Delete Selected";
            this.buttonDeleteActivies.UseVisualStyleBackColor = true;
            this.buttonDeleteActivies.Click += new System.EventHandler(this.buttonDeleteActivies_Click);
            // 
            // buttonEditActivity
            // 
            this.buttonEditActivity.Location = new System.Drawing.Point(133, 10);
            this.buttonEditActivity.Name = "buttonEditActivity";
            this.buttonEditActivity.Size = new System.Drawing.Size(106, 30);
            this.buttonEditActivity.TabIndex = 1;
            this.buttonEditActivity.Text = "Edit Selected";
            this.buttonEditActivity.UseVisualStyleBackColor = true;
            this.buttonEditActivity.Click += new System.EventHandler(this.buttonEditActivity_Click);
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
            // resourcesDataGridView
            // 
            this.resourcesDataGridView.AllowUserToAddRows = false;
            this.resourcesDataGridView.AllowUserToDeleteRows = false;
            this.resourcesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceName,
            this.LimitPerDay});
            this.resourcesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.resourcesDataGridView.Name = "resourcesDataGridView";
            this.resourcesDataGridView.RowHeadersVisible = false;
            this.resourcesDataGridView.RowTemplate.Height = 24;
            this.resourcesDataGridView.Size = new System.Drawing.Size(268, 293);
            this.resourcesDataGridView.TabIndex = 1;
            this.resourcesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.resourcesDataGridView_CellValueChanged);
            this.resourcesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.resourcesDataGridView_DataError);
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
            // resourceBottomPanel
            // 
            this.resourceBottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resourceBottomPanel.Controls.Add(this.buttonDeleteResources);
            this.resourceBottomPanel.Controls.Add(this.buttonAddResource);
            this.resourceBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resourceBottomPanel.Location = new System.Drawing.Point(0, 293);
            this.resourceBottomPanel.Name = "resourceBottomPanel";
            this.resourceBottomPanel.Size = new System.Drawing.Size(268, 50);
            this.resourceBottomPanel.TabIndex = 2;
            // 
            // buttonDeleteResources
            // 
            this.buttonDeleteResources.Location = new System.Drawing.Point(131, 10);
            this.buttonDeleteResources.Name = "buttonDeleteResources";
            this.buttonDeleteResources.Size = new System.Drawing.Size(123, 30);
            this.buttonDeleteResources.TabIndex = 2;
            this.buttonDeleteResources.Text = "Delete Selected";
            this.buttonDeleteResources.UseVisualStyleBackColor = true;
            this.buttonDeleteResources.Click += new System.EventHandler(this.buttonDeleteResources_Click);
            // 
            // buttonAddResource
            // 
            this.buttonAddResource.Location = new System.Drawing.Point(15, 10);
            this.buttonAddResource.Name = "buttonAddResource";
            this.buttonAddResource.Size = new System.Drawing.Size(110, 30);
            this.buttonAddResource.TabIndex = 1;
            this.buttonAddResource.Text = "Add Resource";
            this.buttonAddResource.UseVisualStyleBackColor = true;
            this.buttonAddResource.Click += new System.EventHandler(this.buttonAddResource_Click);
            // 
            // saveActivityDialog
            // 
            this.saveActivityDialog.Filter = "JSON|*.json|All Files|*.*";
            this.saveActivityDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveActivityDialog_FileOk);
            // 
            // openActivityDialog
            // 
            this.openActivityDialog.Filter = "JSON|*.json|All Files|*.*";
            this.openActivityDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openActivityDialog_FileOk);
            // 
            // panelAlgorithmParamsContainer
            // 
            this.panelAlgorithmParamsContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAlgorithmParamsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelAlgorithmParamsContainer.Name = "panelAlgorithmParamsContainer";
            this.panelAlgorithmParamsContainer.Size = new System.Drawing.Size(593, 100);
            this.panelAlgorithmParamsContainer.TabIndex = 12;
            // 
            // panelAlgorithmStartControls
            // 
            this.panelAlgorithmStartControls.Controls.Add(this.labelStatus);
            this.panelAlgorithmStartControls.Controls.Add(this.buttonRunAlgorithm);
            this.panelAlgorithmStartControls.Controls.Add(this.pictureBoxLoading);
            this.panelAlgorithmStartControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlgorithmStartControls.Location = new System.Drawing.Point(593, 0);
            this.panelAlgorithmStartControls.Name = "panelAlgorithmStartControls";
            this.panelAlgorithmStartControls.Size = new System.Drawing.Size(326, 100);
            this.panelAlgorithmStartControls.TabIndex = 13;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 475);
            this.Controls.Add(this.centerSplitContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(937, 522);
            this.Name = "StartForm";
            this.Text = "Construction Project Manager";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.centerSplitContainer.Panel1.ResumeLayout(false);
            this.centerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerSplitContainer)).EndInit();
            this.centerSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.activityBottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDataGridView)).EndInit();
            this.resourceBottomPanel.ResumeLayout(false);
            this.panelAlgorithmStartControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitPerDay;
        private System.Windows.Forms.Button buttonEditActivity;
        private System.Windows.Forms.Button buttonDeleteActivies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreactivitiesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTimeConstraint;
        private System.Windows.Forms.SaveFileDialog saveActivityDialog;
        private System.Windows.Forms.OpenFileDialog openActivityDialog;
        private System.Windows.Forms.Button buttonRunAlgorithm;
        private System.Windows.Forms.TextBox textBoxMutationProbability;
        private System.Windows.Forms.Label labelMutationProbability;
        private System.Windows.Forms.TextBox textBoxCrossoverProbability;
        private System.Windows.Forms.Label labelCrossoverProbability;
        private System.Windows.Forms.TextBox textBoxMaxIterations;
        private System.Windows.Forms.Label labelMaxIterations;
        private System.Windows.Forms.TextBox textBoxPopulationSize;
        private System.Windows.Forms.Label labelPopulationSize;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelAlgorithmStartControls;
        private System.Windows.Forms.Panel panelAlgorithmParamsContainer;
    }
}

