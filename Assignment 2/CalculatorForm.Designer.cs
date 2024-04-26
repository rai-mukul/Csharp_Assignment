namespace Assignment2
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtOperand1 = new TextBox();
            lblOperand1 = new Label();
            txtOperand2 = new TextBox();
            lblOperand2 = new Label();
            cmbOperator = new ComboBox();
            btnCalculate = new Button();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(12, 62);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(100, 27);
            txtOperand1.TabIndex = 0;
            // 
            // lblOperand1
            // 
            lblOperand1.AutoSize = true;
            lblOperand1.Location = new Point(12, 29);
            lblOperand1.Name = "lblOperand1";
            lblOperand1.Size = new Size(78, 20);
            lblOperand1.TabIndex = 0;
            lblOperand1.Text = "First Input ";
            lblOperand1.Click += lblOperand1_Click;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(144, 66);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(100, 27);
            txtOperand2.TabIndex = 1;
            // 
            // lblOperand2
            // 
            lblOperand2.AutoSize = true;
            lblOperand2.Location = new Point(144, 29);
            lblOperand2.Name = "lblOperand2";
            lblOperand2.Size = new Size(96, 20);
            lblOperand2.TabIndex = 1;
            lblOperand2.Text = "Second Input";
            // 
            // cmbOperator
            // 
            cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "x", "/" });
            cmbOperator.Location = new Point(325, 65);
            cmbOperator.Margin = new Padding(4, 5, 4, 5);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(114, 28);
            cmbOperator.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(496, 66);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 35);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ControlLightLight;
            txtResult.Location = new Point(13, 155);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(231, 27);
            txtResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 119);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 5;
            label1.Text = "Output";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 29);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Select Operator";
            label2.Click += label2_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 589);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOperand1);
            Controls.Add(lblOperand2);
            Controls.Add(txtResult);
            Controls.Add(btnCalculate);
            Controls.Add(cmbOperator);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperand1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculatorForm";
            Text = "Unsigned 32-64 Integer Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private Label lblOperand1;
        private Label lblOperand2;
        private Label label1;
        private Label label2;
    }
}