namespace Task_4_IDE_coursework
{
    partial class WorkerAddForm
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
            System.Windows.Forms.Label workeridLabel;
            System.Windows.Forms.Label workernameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label positionLabel;
            this.btnSave = new System.Windows.Forms.Button();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDataSet = new Task_4_IDE_coursework.taskDataSet();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Task_4_IDE_coursework.taskDataSetTableAdapters.workersTableAdapter();
            this.tableAdapterManager = new Task_4_IDE_coursework.taskDataSetTableAdapters.TableAdapterManager();
            this.positionsTableAdapter = new Task_4_IDE_coursework.taskDataSetTableAdapters.positionsTableAdapter();
            this.salariesTableAdapter = new Task_4_IDE_coursework.taskDataSetTableAdapters.salariesTableAdapter();
            this.workersRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workeridTextBox = new System.Windows.Forms.TextBox();
            this.workernameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            workeridLabel = new System.Windows.Forms.Label();
            workernameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workeridLabel
            // 
            workeridLabel.AutoSize = true;
            workeridLabel.Location = new System.Drawing.Point(12, 7);
            workeridLabel.Name = "workeridLabel";
            workeridLabel.Size = new System.Drawing.Size(59, 13);
            workeridLabel.TabIndex = 13;
            workeridLabel.Text = "Worker ID:";
            // 
            // workernameLabel
            // 
            workernameLabel.AutoSize = true;
            workernameLabel.Location = new System.Drawing.Point(12, 33);
            workernameLabel.Name = "workernameLabel";
            workernameLabel.Size = new System.Drawing.Size(38, 13);
            workernameLabel.TabIndex = 15;
            workernameLabel.Text = "Name:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(12, 59);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 18;
            salaryLabel.Text = "Salary:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(12, 85);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "salaries";
            this.salariesBindingSource.DataSource = this.taskDataSet;
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "taskDataSet";
            this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.taskDataSet;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.taskDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.positionsTableAdapter = this.positionsTableAdapter;
            this.tableAdapterManager.salariesTableAdapter = this.salariesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Task_4_IDE_coursework.taskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // workersRowBindingSource
            // 
            this.workersRowBindingSource.DataSource = typeof(Task_4_IDE_coursework.taskDataSet.workersRow);
            // 
            // workeridTextBox
            // 
            this.workeridTextBox.Location = new System.Drawing.Point(86, 4);
            this.workeridTextBox.Name = "workeridTextBox";
            this.workeridTextBox.Size = new System.Drawing.Size(100, 20);
            this.workeridTextBox.TabIndex = 14;
            // 
            // workernameTextBox
            // 
            this.workernameTextBox.Location = new System.Drawing.Point(86, 30);
            this.workernameTextBox.Name = "workernameTextBox";
            this.workernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workernameTextBox.TabIndex = 16;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(86, 56);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 19;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(86, 82);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 20;
            // 
            // WorkerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 162);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(workeridLabel);
            this.Controls.Add(this.workeridTextBox);
            this.Controls.Add(workernameLabel);
            this.Controls.Add(this.workernameTextBox);
            this.Controls.Add(this.btnSave);
            this.Name = "WorkerAddForm";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.WorkerAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taskDataSet taskDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private taskDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private taskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private taskDataSetTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private taskDataSetTableAdapters.salariesTableAdapter salariesTableAdapter;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource workersRowBindingSource;
        private System.Windows.Forms.TextBox workeridTextBox;
        private System.Windows.Forms.TextBox workernameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
    }
}