namespace wfaWeekThree
{
    partial class Form1
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
            this.radioButtonDisplayThree = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplayFive = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplayAll = new System.Windows.Forms.RadioButton();
            this.dataGridViewEmpInfo = new System.Windows.Forms.DataGridView();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDevType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileEmpInfo = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDisplayThree
            // 
            this.radioButtonDisplayThree.AutoSize = true;
            this.radioButtonDisplayThree.Location = new System.Drawing.Point(12, 12);
            this.radioButtonDisplayThree.Name = "radioButtonDisplayThree";
            this.radioButtonDisplayThree.Size = new System.Drawing.Size(154, 23);
            this.radioButtonDisplayThree.TabIndex = 0;
            this.radioButtonDisplayThree.Text = "Display 3 Employees";
            this.radioButtonDisplayThree.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisplayFive
            // 
            this.radioButtonDisplayFive.AutoSize = true;
            this.radioButtonDisplayFive.Location = new System.Drawing.Point(172, 12);
            this.radioButtonDisplayFive.Name = "radioButtonDisplayFive";
            this.radioButtonDisplayFive.Size = new System.Drawing.Size(154, 23);
            this.radioButtonDisplayFive.TabIndex = 1;
            this.radioButtonDisplayFive.Text = "Display 5 Employees";
            this.radioButtonDisplayFive.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisplayAll
            // 
            this.radioButtonDisplayAll.AutoSize = true;
            this.radioButtonDisplayAll.Location = new System.Drawing.Point(332, 12);
            this.radioButtonDisplayAll.Name = "radioButtonDisplayAll";
            this.radioButtonDisplayAll.Size = new System.Drawing.Size(162, 23);
            this.radioButtonDisplayAll.TabIndex = 2;
            this.radioButtonDisplayAll.Text = "Display All Employees";
            this.radioButtonDisplayAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmpInfo
            // 
            this.dataGridViewEmpInfo.AllowUserToAddRows = false;
            this.dataGridViewEmpInfo.AllowUserToDeleteRows = false;
            this.dataGridViewEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.ColumnLastName,
            this.ColumnAddress,
            this.ColumnCity,
            this.ColumnState,
            this.ColumnZip,
            this.ColumnEmpType,
            this.ColumnCostCenter,
            this.ColumnDevType,
            this.ColumnSupervisor,
            this.ColumnTaxType});
            this.dataGridViewEmpInfo.Location = new System.Drawing.Point(13, 47);
            this.dataGridViewEmpInfo.Name = "dataGridViewEmpInfo";
            this.dataGridViewEmpInfo.Size = new System.Drawing.Size(1185, 311);
            this.dataGridViewEmpInfo.TabIndex = 3;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnFirstName.DataPropertyName = "firstName";
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.Width = 102;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnLastName.DataPropertyName = "lastName";
            this.ColumnLastName.HeaderText = "Last Name";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.Width = 101;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAddress.DataPropertyName = "address";
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 85;
            // 
            // ColumnCity
            // 
            this.ColumnCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCity.DataPropertyName = "city";
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.Width = 59;
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnState.DataPropertyName = "state";
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.Width = 65;
            // 
            // ColumnZip
            // 
            this.ColumnZip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnZip.DataPropertyName = "zipCode";
            this.ColumnZip.HeaderText = "Zip Code";
            this.ColumnZip.Name = "ColumnZip";
            this.ColumnZip.Width = 92;
            // 
            // ColumnEmpType
            // 
            this.ColumnEmpType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEmpType.DataPropertyName = "empType";
            this.ColumnEmpType.HeaderText = "Employee Type";
            this.ColumnEmpType.Name = "ColumnEmpType";
            this.ColumnEmpType.Width = 128;
            // 
            // ColumnCostCenter
            // 
            this.ColumnCostCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCostCenter.DataPropertyName = "costCenter";
            this.ColumnCostCenter.HeaderText = "Cost Center";
            this.ColumnCostCenter.Name = "ColumnCostCenter";
            this.ColumnCostCenter.Width = 108;
            // 
            // ColumnDevType
            // 
            this.ColumnDevType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDevType.DataPropertyName = "devType";
            this.ColumnDevType.HeaderText = "Developer Type";
            this.ColumnDevType.Name = "ColumnDevType";
            this.ColumnDevType.Width = 131;
            // 
            // ColumnSupervisor
            // 
            this.ColumnSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSupervisor.DataPropertyName = "supervisor";
            this.ColumnSupervisor.HeaderText = "Supervisor";
            this.ColumnSupervisor.Name = "ColumnSupervisor";
            this.ColumnSupervisor.Width = 99;
            // 
            // ColumnTaxType
            // 
            this.ColumnTaxType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTaxType.DataPropertyName = "taxType";
            this.ColumnTaxType.HeaderText = "Tax Type";
            this.ColumnTaxType.Name = "ColumnTaxType";
            this.ColumnTaxType.Width = 90;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(500, 6);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(252, 35);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load File Information";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Employee Record";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewEmpInfo);
            this.Controls.Add(this.radioButtonDisplayAll);
            this.Controls.Add(this.radioButtonDisplayFive);
            this.Controls.Add(this.radioButtonDisplayThree);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDisplayThree;
        private System.Windows.Forms.RadioButton radioButtonDisplayFive;
        private System.Windows.Forms.RadioButton radioButtonDisplayAll;
        private System.Windows.Forms.DataGridView dataGridViewEmpInfo;
        private System.Windows.Forms.OpenFileDialog fileEmpInfo;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDevType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

