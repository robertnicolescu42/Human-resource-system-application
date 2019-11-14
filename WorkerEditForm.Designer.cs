namespace Task_4_IDE_coursework
{
    partial class WorkerEditForm
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
            this.taskDataSet = new Task_4_IDE_coursework.taskDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Task_4_IDE_coursework.taskDataSetTableAdapters.workersTableAdapter();
            this.tableAdapterManager = new Task_4_IDE_coursework.taskDataSetTableAdapters.TableAdapterManager();
            this.workeridTextBox = new System.Windows.Forms.TextBox();
            this.workernameTextBox = new System.Windows.Forms.TextBox();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            workeridLabel = new System.Windows.Forms.Label();
            workernameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskDataSet
            // 
            this.taskDataSet.DataSetName = "taskDataSet";
            this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.positionsTableAdapter = null;
            this.tableAdapterManager.salariesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Task_4_IDE_coursework.taskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // workeridLabel
            // 
            workeridLabel.AutoSize = true;
            workeridLabel.Location = new System.Drawing.Point(3, 9);
            workeridLabel.Name = "workeridLabel";
            workeridLabel.Size = new System.Drawing.Size(50, 13);
            workeridLabel.TabIndex = 1;
            workeridLabel.Text = "workerid:";
            // 
            // workeridTextBox
            // 
            this.workeridTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "workerid", true));
            this.workeridTextBox.Location = new System.Drawing.Point(77, 6);
            this.workeridTextBox.Name = "workeridTextBox";
            this.workeridTextBox.Size = new System.Drawing.Size(139, 20);
            this.workeridTextBox.TabIndex = 2;
            // 
            // workernameLabel
            // 
            workernameLabel.AutoSize = true;
            workernameLabel.Location = new System.Drawing.Point(3, 35);
            workernameLabel.Name = "workernameLabel";
            workernameLabel.Size = new System.Drawing.Size(68, 13);
            workernameLabel.TabIndex = 3;
            workernameLabel.Text = "workername:";
            // 
            // workernameTextBox
            // 
            this.workernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "workername", true));
            this.workernameTextBox.Location = new System.Drawing.Point(77, 32);
            this.workernameTextBox.Name = "workernameTextBox";
            this.workernameTextBox.Size = new System.Drawing.Size(139, 20);
            this.workernameTextBox.TabIndex = 4;
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "salaries";
            this.salariesBindingSource.DataSource = this.taskDataSet;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(3, 61);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(37, 13);
            salaryLabel.TabIndex = 7;
            salaryLabel.Text = "salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(77, 58);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(139, 20);
            this.salaryTextBox.TabIndex = 8;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.taskDataSet;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(3, 87);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(46, 13);
            positionLabel.TabIndex = 8;
            positionLabel.Text = "position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.positionsBindingSource, "position", true));
            this.positionTextBox.Location = new System.Drawing.Point(77, 84);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(139, 20);
            this.positionTextBox.TabIndex = 9;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(2, 138);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 20);
            this.btnFirst.TabIndex = 56;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(46, 138);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(38, 21);
            this.btnPrev.TabIndex = 55;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(183, 138);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(33, 20);
            this.btnLast.TabIndex = 58;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(141, 138);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 20);
            this.btnNext.TabIndex = 57;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(77, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // WorkerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 211);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(workeridLabel);
            this.Controls.Add(this.workeridTextBox);
            this.Controls.Add(workernameLabel);
            this.Controls.Add(this.workernameTextBox);
            this.Name = "WorkerEditForm";
            this.Text = "WorkerEditForm";
            this.Load += new System.EventHandler(this.WorkerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taskDataSet taskDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private taskDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private taskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox workeridTextBox;
        private System.Windows.Forms.TextBox workernameTextBox;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUpdate;
    }
}