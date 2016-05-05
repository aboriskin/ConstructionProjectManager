namespace MainApp.Forms
{
    partial class AddEditActivityForm
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.textBoxPreActivities = new System.Windows.Forms.TextBox();
            this.labelPreActivities = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBoxResources = new System.Windows.Forms.GroupBox();
            this.buttonDeleteResources = new System.Windows.Forms.Button();
            this.buttonAddResource = new System.Windows.Forms.Button();
            this.dataGridViewResources = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTimeConstraint = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinishTo = new System.Windows.Forms.DateTimePicker();
            this.labelFinishCondition = new System.Windows.Forms.Label();
            this.dateTimePickerFinishFrom = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFinish = new System.Windows.Forms.RadioButton();
            this.dateTimePickerStartTo = new System.Windows.Forms.DateTimePicker();
            this.labelStartCondition = new System.Windows.Forms.Label();
            this.dateTimePickerStartFrom = new System.Windows.Forms.DateTimePicker();
            this.radioButtonStart = new System.Windows.Forms.RadioButton();
            this.bottomPanel.SuspendLayout();
            this.groupBoxBase.SuspendLayout();
            this.groupBoxResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
            this.groupBoxTimeConstraint.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.buttonCancel);
            this.bottomPanel.Controls.Add(this.buttonSave);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 513);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(430, 50);
            this.bottomPanel.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(65, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Controls.Add(this.textBoxPreActivities);
            this.groupBoxBase.Controls.Add(this.labelPreActivities);
            this.groupBoxBase.Controls.Add(this.textBoxName);
            this.groupBoxBase.Controls.Add(this.labelName);
            this.groupBoxBase.Controls.Add(this.textBoxDuration);
            this.groupBoxBase.Controls.Add(this.labelDuration);
            this.groupBoxBase.Controls.Add(this.textBoxId);
            this.groupBoxBase.Controls.Add(this.labelId);
            this.groupBoxBase.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(405, 155);
            this.groupBoxBase.TabIndex = 1;
            this.groupBoxBase.TabStop = false;
            this.groupBoxBase.Text = "Base Information";
            // 
            // textBoxPreActivities
            // 
            this.textBoxPreActivities.Location = new System.Drawing.Point(78, 78);
            this.textBoxPreActivities.Name = "textBoxPreActivities";
            this.textBoxPreActivities.Size = new System.Drawing.Size(320, 22);
            this.textBoxPreActivities.TabIndex = 5;
            this.textBoxPreActivities.Enter += new System.EventHandler(this.textBoxPreActivities_Enter);
            this.textBoxPreActivities.Leave += new System.EventHandler(this.textBoxPreActivities_Leave);
            // 
            // labelPreActivities
            // 
            this.labelPreActivities.AutoSize = true;
            this.labelPreActivities.Location = new System.Drawing.Point(6, 78);
            this.labelPreActivities.Name = "labelPreActivities";
            this.labelPreActivities.Size = new System.Drawing.Size(65, 17);
            this.labelPreActivities.TabIndex = 6;
            this.labelPreActivities.Text = "Pre Acts:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 106);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(79, 50);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(130, 22);
            this.textBoxDuration.TabIndex = 3;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(7, 50);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(66, 17);
            this.labelDuration.TabIndex = 2;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(79, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(130, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(7, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // groupBoxResources
            // 
            this.groupBoxResources.Controls.Add(this.buttonDeleteResources);
            this.groupBoxResources.Controls.Add(this.buttonAddResource);
            this.groupBoxResources.Controls.Add(this.dataGridViewResources);
            this.groupBoxResources.Location = new System.Drawing.Point(13, 173);
            this.groupBoxResources.Name = "groupBoxResources";
            this.groupBoxResources.Size = new System.Drawing.Size(404, 192);
            this.groupBoxResources.TabIndex = 2;
            this.groupBoxResources.TabStop = false;
            this.groupBoxResources.Text = "Resources";
            // 
            // buttonDeleteResources
            // 
            this.buttonDeleteResources.Location = new System.Drawing.Point(293, 68);
            this.buttonDeleteResources.Name = "buttonDeleteResources";
            this.buttonDeleteResources.Size = new System.Drawing.Size(90, 30);
            this.buttonDeleteResources.TabIndex = 2;
            this.buttonDeleteResources.Text = "Delete";
            this.buttonDeleteResources.UseVisualStyleBackColor = true;
            this.buttonDeleteResources.Click += new System.EventHandler(this.buttonDeleteResources_Click);
            // 
            // buttonAddResource
            // 
            this.buttonAddResource.Location = new System.Drawing.Point(293, 18);
            this.buttonAddResource.Name = "buttonAddResource";
            this.buttonAddResource.Size = new System.Drawing.Size(90, 30);
            this.buttonAddResource.TabIndex = 1;
            this.buttonAddResource.Text = "Add";
            this.buttonAddResource.UseVisualStyleBackColor = true;
            this.buttonAddResource.Click += new System.EventHandler(this.buttonAddResource_Click);
            // 
            // dataGridViewResources
            // 
            this.dataGridViewResources.AllowUserToAddRows = false;
            this.dataGridViewResources.AllowUserToDeleteRows = false;
            this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Amount});
            this.dataGridViewResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResources.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResources.Name = "dataGridViewResources";
            this.dataGridViewResources.RowHeadersVisible = false;
            this.dataGridViewResources.RowTemplate.Height = 24;
            this.dataGridViewResources.Size = new System.Drawing.Size(268, 171);
            this.dataGridViewResources.TabIndex = 0;
            this.dataGridViewResources.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewResources_DataError);
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Resource";
            this.Resource.Name = "Resource";
            this.Resource.Width = 140;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // groupBoxTimeConstraint
            // 
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerFinishTo);
            this.groupBoxTimeConstraint.Controls.Add(this.labelFinishCondition);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerFinishFrom);
            this.groupBoxTimeConstraint.Controls.Add(this.radioButtonFinish);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerStartTo);
            this.groupBoxTimeConstraint.Controls.Add(this.labelStartCondition);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerStartFrom);
            this.groupBoxTimeConstraint.Controls.Add(this.radioButtonStart);
            this.groupBoxTimeConstraint.Location = new System.Drawing.Point(16, 383);
            this.groupBoxTimeConstraint.Name = "groupBoxTimeConstraint";
            this.groupBoxTimeConstraint.Size = new System.Drawing.Size(401, 118);
            this.groupBoxTimeConstraint.TabIndex = 3;
            this.groupBoxTimeConstraint.TabStop = false;
            this.groupBoxTimeConstraint.Text = "Time Constraints";
            // 
            // dateTimePickerFinishTo
            // 
            this.dateTimePickerFinishTo.Checked = false;
            this.dateTimePickerFinishTo.Enabled = false;
            this.dateTimePickerFinishTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishTo.Location = new System.Drawing.Point(253, 79);
            this.dateTimePickerFinishTo.Name = "dateTimePickerFinishTo";
            this.dateTimePickerFinishTo.ShowCheckBox = true;
            this.dateTimePickerFinishTo.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerFinishTo.TabIndex = 9;
            // 
            // labelFinishCondition
            // 
            this.labelFinishCondition.AutoSize = true;
            this.labelFinishCondition.Location = new System.Drawing.Point(182, 81);
            this.labelFinishCondition.Name = "labelFinishCondition";
            this.labelFinishCondition.Size = new System.Drawing.Size(69, 17);
            this.labelFinishCondition.TabIndex = 8;
            this.labelFinishCondition.Text = "≤ Finish ≤";
            // 
            // dateTimePickerFinishFrom
            // 
            this.dateTimePickerFinishFrom.Checked = false;
            this.dateTimePickerFinishFrom.Enabled = false;
            this.dateTimePickerFinishFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishFrom.Location = new System.Drawing.Point(40, 79);
            this.dateTimePickerFinishFrom.Name = "dateTimePickerFinishFrom";
            this.dateTimePickerFinishFrom.ShowCheckBox = true;
            this.dateTimePickerFinishFrom.Size = new System.Drawing.Size(137, 22);
            this.dateTimePickerFinishFrom.TabIndex = 7;
            // 
            // radioButtonFinish
            // 
            this.radioButtonFinish.AutoSize = true;
            this.radioButtonFinish.Location = new System.Drawing.Point(11, 82);
            this.radioButtonFinish.Name = "radioButtonFinish";
            this.radioButtonFinish.Size = new System.Drawing.Size(17, 16);
            this.radioButtonFinish.TabIndex = 6;
            this.radioButtonFinish.TabStop = true;
            this.radioButtonFinish.UseVisualStyleBackColor = true;
            this.radioButtonFinish.Click += new System.EventHandler(this.radioButtonTimeConstraint_Click);
            // 
            // dateTimePickerStartTo
            // 
            this.dateTimePickerStartTo.Checked = false;
            this.dateTimePickerStartTo.Enabled = false;
            this.dateTimePickerStartTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartTo.Location = new System.Drawing.Point(253, 42);
            this.dateTimePickerStartTo.Name = "dateTimePickerStartTo";
            this.dateTimePickerStartTo.ShowCheckBox = true;
            this.dateTimePickerStartTo.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerStartTo.TabIndex = 5;
            // 
            // labelStartCondition
            // 
            this.labelStartCondition.AutoSize = true;
            this.labelStartCondition.Location = new System.Drawing.Point(184, 44);
            this.labelStartCondition.Name = "labelStartCondition";
            this.labelStartCondition.Size = new System.Drawing.Size(62, 17);
            this.labelStartCondition.TabIndex = 4;
            this.labelStartCondition.Text = "≤ Start ≤";
            // 
            // dateTimePickerStartFrom
            // 
            this.dateTimePickerStartFrom.Checked = false;
            this.dateTimePickerStartFrom.Enabled = false;
            this.dateTimePickerStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartFrom.Location = new System.Drawing.Point(40, 42);
            this.dateTimePickerStartFrom.Name = "dateTimePickerStartFrom";
            this.dateTimePickerStartFrom.ShowCheckBox = true;
            this.dateTimePickerStartFrom.Size = new System.Drawing.Size(137, 22);
            this.dateTimePickerStartFrom.TabIndex = 1;
            // 
            // radioButtonStart
            // 
            this.radioButtonStart.AutoSize = true;
            this.radioButtonStart.Location = new System.Drawing.Point(11, 45);
            this.radioButtonStart.Name = "radioButtonStart";
            this.radioButtonStart.Size = new System.Drawing.Size(17, 16);
            this.radioButtonStart.TabIndex = 0;
            this.radioButtonStart.TabStop = true;
            this.radioButtonStart.UseVisualStyleBackColor = true;
            this.radioButtonStart.Click += new System.EventHandler(this.radioButtonTimeConstraint_Click);
            // 
            // AddEditActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 563);
            this.Controls.Add(this.groupBoxTimeConstraint);
            this.Controls.Add(this.groupBoxResources);
            this.Controls.Add(this.groupBoxBase);
            this.Controls.Add(this.bottomPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddEditActivityForm";
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.AddEditActivityForm_Load);
            this.bottomPanel.ResumeLayout(false);
            this.groupBoxBase.ResumeLayout(false);
            this.groupBoxBase.PerformLayout();
            this.groupBoxResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
            this.groupBoxTimeConstraint.ResumeLayout(false);
            this.groupBoxTimeConstraint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxBase;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxResources;
        private System.Windows.Forms.DataGridView dataGridViewResources;
        private System.Windows.Forms.Button buttonDeleteResources;
        private System.Windows.Forms.Button buttonAddResource;
        private System.Windows.Forms.GroupBox groupBoxTimeConstraint;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartFrom;
        private System.Windows.Forms.RadioButton radioButtonStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTo;
        private System.Windows.Forms.Label labelStartCondition;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishTo;
        private System.Windows.Forms.Label labelFinishCondition;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishFrom;
        private System.Windows.Forms.RadioButton radioButtonFinish;
        private System.Windows.Forms.DataGridViewComboBoxColumn Resource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox textBoxPreActivities;
        private System.Windows.Forms.Label labelPreActivities;
    }
}