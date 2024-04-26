
namespace ManagmentInfoSystem
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
            this.btnRead = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.line2 = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cityLabel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line1Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line2Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCodeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Departments = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRead.Location = new System.Drawing.Point(481, 90);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(131, 51);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(429, 169);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(221, 41);
            this.firstName.TabIndex = 1;
            // 
            // line1
            // 
            this.line1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1.Location = new System.Drawing.Point(429, 240);
            this.line1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(221, 41);
            this.line1.TabIndex = 2;
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(429, 369);
            this.state.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.state.Multiline = true;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(221, 41);
            this.state.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(939, 169);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(221, 41);
            this.lastName.TabIndex = 4;
            // 
            // line2
            // 
            this.line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.Location = new System.Drawing.Point(939, 240);
            this.line2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line2.Multiline = true;
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(221, 41);
            this.line2.TabIndex = 5;
            // 
            // zipCode
            // 
            this.zipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCode.Location = new System.Drawing.Point(939, 307);
            this.zipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zipCode.Multiline = true;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(221, 41);
            this.zipCode.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(295, 169);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(92, 20);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            // 
            // line1Label
            // 
            this.line1Label.AutoSize = true;
            this.line1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1Label.Location = new System.Drawing.Point(295, 240);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(117, 20);
            this.line1Label.TabIndex = 8;
            this.line1Label.Text = "Address Line1";
            this.line1Label.Click += new System.EventHandler(this.line1Label_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(295, 369);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(48, 20);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "State";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(743, 169);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(91, 20);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // line2Label
            // 
            this.line2Label.AutoSize = true;
            this.line2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2Label.Location = new System.Drawing.Point(743, 240);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(125, 20);
            this.line2Label.TabIndex = 11;
            this.line2Label.Text = "Line2 (optional)";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(747, 307);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(75, 20);
            this.zipCodeLabel.TabIndex = 12;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(299, 90);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 49);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(675, 88);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 51);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(863, 88);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 51);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(295, 307);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(38, 20);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City";
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(429, 301);
            this.city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(221, 41);
            this.city.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGrid,
            this.FirstNameGrid,
            this.LastNameGrid,
            this.Line1Grid,
            this.Line2Grid,
            this.CityGrid,
            this.StateGrid,
            this.ZipCodeGrid,
            this.DepartmentName});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 447);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1413, 250);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdGrid
            // 
            this.IdGrid.DataPropertyName = "Id";
            this.IdGrid.HeaderText = "Id";
            this.IdGrid.MinimumWidth = 2;
            this.IdGrid.Name = "IdGrid";
            this.IdGrid.ReadOnly = true;
            this.IdGrid.Width = 150;
            // 
            // FirstNameGrid
            // 
            this.FirstNameGrid.DataPropertyName = "FirstName";
            this.FirstNameGrid.HeaderText = "First Name";
            this.FirstNameGrid.MinimumWidth = 8;
            this.FirstNameGrid.Name = "FirstNameGrid";
            this.FirstNameGrid.ReadOnly = true;
            this.FirstNameGrid.Width = 150;
            // 
            // LastNameGrid
            // 
            this.LastNameGrid.DataPropertyName = "LastName";
            this.LastNameGrid.HeaderText = "Last Name";
            this.LastNameGrid.MinimumWidth = 8;
            this.LastNameGrid.Name = "LastNameGrid";
            this.LastNameGrid.ReadOnly = true;
            this.LastNameGrid.Width = 150;
            // 
            // Line1Grid
            // 
            this.Line1Grid.DataPropertyName = "Line1";
            this.Line1Grid.HeaderText = "Line1";
            this.Line1Grid.MinimumWidth = 8;
            this.Line1Grid.Name = "Line1Grid";
            this.Line1Grid.ReadOnly = true;
            this.Line1Grid.Width = 150;
            // 
            // Line2Grid
            // 
            this.Line2Grid.DataPropertyName = "Line2";
            this.Line2Grid.HeaderText = "Line2";
            this.Line2Grid.MinimumWidth = 8;
            this.Line2Grid.Name = "Line2Grid";
            this.Line2Grid.ReadOnly = true;
            this.Line2Grid.Width = 150;
            // 
            // CityGrid
            // 
            this.CityGrid.DataPropertyName = "City";
            this.CityGrid.HeaderText = "City";
            this.CityGrid.MinimumWidth = 8;
            this.CityGrid.Name = "CityGrid";
            this.CityGrid.ReadOnly = true;
            this.CityGrid.Width = 150;
            // 
            // StateGrid
            // 
            this.StateGrid.DataPropertyName = "State";
            this.StateGrid.HeaderText = "State";
            this.StateGrid.MinimumWidth = 8;
            this.StateGrid.Name = "StateGrid";
            this.StateGrid.ReadOnly = true;
            this.StateGrid.Width = 150;
            // 
            // ZipCodeGrid
            // 
            this.ZipCodeGrid.DataPropertyName = "ZipCode";
            this.ZipCodeGrid.HeaderText = "Zip Code";
            this.ZipCodeGrid.MinimumWidth = 8;
            this.ZipCodeGrid.Name = "ZipCodeGrid";
            this.ZipCodeGrid.ReadOnly = true;
            this.ZipCodeGrid.Width = 150;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "Department Name";
            this.DepartmentName.MinimumWidth = 8;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DepartmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DepartmentName.Width = 150;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(1046, 88);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 49);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(747, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department\r\n";
            // 
            // Departments
            // 
            this.Departments.DisplayMember = "Name";
            this.Departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departments.FormattingEnabled = true;
            this.Departments.Location = new System.Drawing.Point(939, 373);
            this.Departments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(221, 28);
            this.Departments.TabIndex = 21;
            this.Departments.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "Management Information System(MIS)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 717);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.state);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.btnRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox line1;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox line2;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Departments;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line1Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line2Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCodeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.Label label3;
    }
}

