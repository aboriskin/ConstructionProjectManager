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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxResources = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Resource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddResource = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTimeConstraint = new System.Windows.Forms.GroupBox();
            this.radioButtonStart = new System.Windows.Forms.RadioButton();
            this.dateTimePickerStartFrom = new System.Windows.Forms.DateTimePicker();
            this.labelStartCondition = new System.Windows.Forms.Label();
            this.dateTimePickerStartTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinishTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFinishFrom = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bottomPanel.SuspendLayout();
            this.groupBoxBase.SuspendLayout();
            this.groupBoxResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTimeConstraint.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.buttonCancel);
            this.bottomPanel.Controls.Add(this.buttonSave);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 461);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(430, 50);
            this.bottomPanel.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(65, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 30);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Controls.Add(this.textBoxName);
            this.groupBoxBase.Controls.Add(this.labelName);
            this.groupBoxBase.Controls.Add(this.textBoxDuration);
            this.groupBoxBase.Controls.Add(this.labelDuration);
            this.groupBoxBase.Controls.Add(this.textBoxId);
            this.groupBoxBase.Controls.Add(this.labelId);
            this.groupBoxBase.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(405, 113);
            this.groupBoxBase.TabIndex = 1;
            this.groupBoxBase.TabStop = false;
            this.groupBoxBase.Text = "Base Information";
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
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(79, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(130, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(79, 50);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(130, 22);
            this.textBoxDuration.TabIndex = 3;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // groupBoxResources
            // 
            this.groupBoxResources.Controls.Add(this.button1);
            this.groupBoxResources.Controls.Add(this.buttonAddResource);
            this.groupBoxResources.Controls.Add(this.dataGridView1);
            this.groupBoxResources.Location = new System.Drawing.Point(13, 132);
            this.groupBoxResources.Name = "groupBoxResources";
            this.groupBoxResources.Size = new System.Drawing.Size(404, 192);
            this.groupBoxResources.TabIndex = 2;
            this.groupBoxResources.TabStop = false;
            this.groupBoxResources.Text = "Resources";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resource,
            this.Amount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(268, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // Resource
            // 
            this.Resource.HeaderText = "Resource";
            this.Resource.Name = "Resource";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // buttonAddResource
            // 
            this.buttonAddResource.Location = new System.Drawing.Point(293, 18);
            this.buttonAddResource.Name = "buttonAddResource";
            this.buttonAddResource.Size = new System.Drawing.Size(90, 30);
            this.buttonAddResource.TabIndex = 1;
            this.buttonAddResource.Text = "Add";
            this.buttonAddResource.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimeConstraint
            // 
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerFinishTo);
            this.groupBoxTimeConstraint.Controls.Add(this.label1);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerFinishFrom);
            this.groupBoxTimeConstraint.Controls.Add(this.radioButton1);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerStartTo);
            this.groupBoxTimeConstraint.Controls.Add(this.labelStartCondition);
            this.groupBoxTimeConstraint.Controls.Add(this.dateTimePickerStartFrom);
            this.groupBoxTimeConstraint.Controls.Add(this.radioButtonStart);
            this.groupBoxTimeConstraint.Location = new System.Drawing.Point(16, 342);
            this.groupBoxTimeConstraint.Name = "groupBoxTimeConstraint";
            this.groupBoxTimeConstraint.Size = new System.Drawing.Size(401, 118);
            this.groupBoxTimeConstraint.TabIndex = 3;
            this.groupBoxTimeConstraint.TabStop = false;
            this.groupBoxTimeConstraint.Text = "Time Constraints";
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
            // 
            // dateTimePickerStartFrom
            // 
            this.dateTimePickerStartFrom.Checked = false;
            this.dateTimePickerStartFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartFrom.Location = new System.Drawing.Point(40, 42);
            this.dateTimePickerStartFrom.Name = "dateTimePickerStartFrom";
            this.dateTimePickerStartFrom.ShowCheckBox = true;
            this.dateTimePickerStartFrom.Size = new System.Drawing.Size(137, 22);
            this.dateTimePickerStartFrom.TabIndex = 1;
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
            // dateTimePickerStartTo
            // 
            this.dateTimePickerStartTo.Checked = false;
            this.dateTimePickerStartTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartTo.Location = new System.Drawing.Point(253, 42);
            this.dateTimePickerStartTo.Name = "dateTimePickerStartTo";
            this.dateTimePickerStartTo.ShowCheckBox = true;
            this.dateTimePickerStartTo.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerStartTo.TabIndex = 5;
            // 
            // dateTimePickerFinishTo
            // 
            this.dateTimePickerFinishTo.Checked = false;
            this.dateTimePickerFinishTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishTo.Location = new System.Drawing.Point(253, 79);
            this.dateTimePickerFinishTo.Name = "dateTimePickerFinishTo";
            this.dateTimePickerFinishTo.ShowCheckBox = true;
            this.dateTimePickerFinishTo.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerFinishTo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "≤ Finish ≤";
            // 
            // dateTimePickerFinishFrom
            // 
            this.dateTimePickerFinishFrom.Checked = false;
            this.dateTimePickerFinishFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishFrom.Location = new System.Drawing.Point(40, 79);
            this.dateTimePickerFinishFrom.Name = "dateTimePickerFinishFrom";
            this.dateTimePickerFinishFrom.ShowCheckBox = true;
            this.dateTimePickerFinishFrom.Size = new System.Drawing.Size(137, 22);
            this.dateTimePickerFinishFrom.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AddEditActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 511);
            this.Controls.Add(this.groupBoxTimeConstraint);
            this.Controls.Add(this.groupBoxResources);
            this.Controls.Add(this.groupBoxBase);
            this.Controls.Add(this.bottomPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddEditActivityForm";
            this.Text = "Add Activity";
            this.bottomPanel.ResumeLayout(false);
            this.groupBoxBase.ResumeLayout(false);
            this.groupBoxBase.PerformLayout();
            this.groupBoxResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddResource;
        private System.Windows.Forms.DataGridViewComboBoxColumn Resource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.GroupBox groupBoxTimeConstraint;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartFrom;
        private System.Windows.Forms.RadioButton radioButtonStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTo;
        private System.Windows.Forms.Label labelStartCondition;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishFrom;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}