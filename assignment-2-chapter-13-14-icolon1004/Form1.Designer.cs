
namespace assignment_2_chapter_13_14_icolon1004
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
            this.components = new System.ComponentModel.Container();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productDBDataSet = new assignment_2_chapter_13_14_icolon1004.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new assignment_2_chapter_13_14_icolon1004.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchForProductNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchForProductNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchForProductDescriptionContainingTextBox = new System.Windows.Forms.TextBox();
            this.searchForProductDescriptionContainingSpecificTextButton = new System.Windows.Forms.Button();
            this.lesserThanTextBox = new System.Windows.Forms.Button();
            this.greaterthanTextBox = new System.Windows.Forms.Button();
            this.unitsOnHandTextBox = new System.Windows.Forms.TextBox();
            this.highRangeTextBox = new System.Windows.Forms.TextBox();
            this.lowRangeTextBox = new System.Windows.Forms.TextBox();
            this.priceRangeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(168, 12);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(443, 162);
            this.productDataGridView.TabIndex = 0;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // searchForProductNumberTextBox
            // 
            this.searchForProductNumberTextBox.Location = new System.Drawing.Point(168, 217);
            this.searchForProductNumberTextBox.Name = "searchForProductNumberTextBox";
            this.searchForProductNumberTextBox.Size = new System.Drawing.Size(126, 20);
            this.searchForProductNumberTextBox.TabIndex = 0;
            // 
            // searchForProductNumberButton
            // 
            this.searchForProductNumberButton.Location = new System.Drawing.Point(168, 249);
            this.searchForProductNumberButton.Name = "searchForProductNumberButton";
            this.searchForProductNumberButton.Size = new System.Drawing.Size(126, 37);
            this.searchForProductNumberButton.TabIndex = 1;
            this.searchForProductNumberButton.Text = "Search for product number";
            this.toolTip1.SetToolTip(this.searchForProductNumberButton, "This button searches for the product number entered by the user.");
            this.searchForProductNumberButton.UseVisualStyleBackColor = true;
            this.searchForProductNumberButton.Click += new System.EventHandler(this.searchForProductNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter the product number\r\nyou would like to look up.";
            // 
            // searchForProductDescriptionContainingTextBox
            // 
            this.searchForProductDescriptionContainingTextBox.Location = new System.Drawing.Point(337, 217);
            this.searchForProductDescriptionContainingTextBox.Name = "searchForProductDescriptionContainingTextBox";
            this.searchForProductDescriptionContainingTextBox.Size = new System.Drawing.Size(135, 20);
            this.searchForProductDescriptionContainingTextBox.TabIndex = 2;
            // 
            // searchForProductDescriptionContainingSpecificTextButton
            // 
            this.searchForProductDescriptionContainingSpecificTextButton.Location = new System.Drawing.Point(337, 249);
            this.searchForProductDescriptionContainingSpecificTextButton.Name = "searchForProductDescriptionContainingSpecificTextButton";
            this.searchForProductDescriptionContainingSpecificTextButton.Size = new System.Drawing.Size(135, 37);
            this.searchForProductDescriptionContainingSpecificTextButton.TabIndex = 3;
            this.searchForProductDescriptionContainingSpecificTextButton.Text = "Search for product desciption";
            this.toolTip1.SetToolTip(this.searchForProductDescriptionContainingSpecificTextButton, "This button searches for the product matching the description entered by the user" +
        ".");
            this.searchForProductDescriptionContainingSpecificTextButton.UseVisualStyleBackColor = true;
            this.searchForProductDescriptionContainingSpecificTextButton.Click += new System.EventHandler(this.searchForProductDescriptionContainingSpecificTextButton_Click);
            // 
            // lesserThanTextBox
            // 
            this.lesserThanTextBox.Location = new System.Drawing.Point(337, 374);
            this.lesserThanTextBox.Name = "lesserThanTextBox";
            this.lesserThanTextBox.Size = new System.Drawing.Size(135, 33);
            this.lesserThanTextBox.TabIndex = 6;
            this.lesserThanTextBox.Text = "Sort by lesser than";
            this.toolTip1.SetToolTip(this.lesserThanTextBox, "This button sorts the Units on Hand by lesser than the amount entered by the user" +
        ".");
            this.lesserThanTextBox.UseVisualStyleBackColor = true;
            this.lesserThanTextBox.Click += new System.EventHandler(this.lesserThanTextBox_Click);
            // 
            // greaterthanTextBox
            // 
            this.greaterthanTextBox.Location = new System.Drawing.Point(168, 374);
            this.greaterthanTextBox.Name = "greaterthanTextBox";
            this.greaterthanTextBox.Size = new System.Drawing.Size(126, 33);
            this.greaterthanTextBox.TabIndex = 5;
            this.greaterthanTextBox.Text = "Sort by greater than";
            this.toolTip1.SetToolTip(this.greaterthanTextBox, "This button sorts the Units on Hand by greater than the amount entered by the use" +
        "r.");
            this.greaterthanTextBox.UseVisualStyleBackColor = true;
            this.greaterthanTextBox.Click += new System.EventHandler(this.greaterthanTextBox_Click);
            // 
            // unitsOnHandTextBox
            // 
            this.unitsOnHandTextBox.Location = new System.Drawing.Point(253, 348);
            this.unitsOnHandTextBox.Name = "unitsOnHandTextBox";
            this.unitsOnHandTextBox.Size = new System.Drawing.Size(126, 20);
            this.unitsOnHandTextBox.TabIndex = 4;
            // 
            // highRangeTextBox
            // 
            this.highRangeTextBox.Location = new System.Drawing.Point(79, 76);
            this.highRangeTextBox.Name = "highRangeTextBox";
            this.highRangeTextBox.Size = new System.Drawing.Size(53, 20);
            this.highRangeTextBox.TabIndex = 1;
            // 
            // lowRangeTextBox
            // 
            this.lowRangeTextBox.Location = new System.Drawing.Point(6, 76);
            this.lowRangeTextBox.Name = "lowRangeTextBox";
            this.lowRangeTextBox.Size = new System.Drawing.Size(53, 20);
            this.lowRangeTextBox.TabIndex = 0;
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.Location = new System.Drawing.Point(24, 106);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(97, 39);
            this.priceRangeButton.TabIndex = 2;
            this.priceRangeButton.Text = "Sort by price in Range";
            this.toolTip1.SetToolTip(this.priceRangeButton, "This button sorts the prices by the range entered by the user.");
            this.priceRangeButton.UseVisualStyleBackColor = true;
            this.priceRangeButton.Click += new System.EventHandler(this.priceRangeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter the max and min price\r\n to sort the prices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Please enter the \r\ndescription of the Product ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Please enter the \r\nnumber of Units on Hand";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(161, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 124);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(161, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 111);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lowRangeTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.priceRangeButton);
            this.groupBox3.Controls.Add(this.highRangeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(488, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 187);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(567, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 26);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "This button exits the program.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(497, 200);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(59, 26);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.clearButton, "This button clears all text boxes and resets the grid view.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(488, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 51);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.clearButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitsOnHandTextBox);
            this.Controls.Add(this.greaterthanTextBox);
            this.Controls.Add(this.lesserThanTextBox);
            this.Controls.Add(this.searchForProductDescriptionContainingSpecificTextButton);
            this.Controls.Add(this.searchForProductDescriptionContainingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchForProductNumberButton);
            this.Controls.Add(this.searchForProductNumberTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment-2-Chapter-13-14-Isaiah-Colon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGridView;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchForProductNumberTextBox;
        private System.Windows.Forms.Button searchForProductNumberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchForProductDescriptionContainingTextBox;
        private System.Windows.Forms.Button searchForProductDescriptionContainingSpecificTextButton;
        private System.Windows.Forms.Button lesserThanTextBox;
        private System.Windows.Forms.Button greaterthanTextBox;
        private System.Windows.Forms.TextBox unitsOnHandTextBox;
        private System.Windows.Forms.TextBox highRangeTextBox;
        private System.Windows.Forms.TextBox lowRangeTextBox;
        private System.Windows.Forms.Button priceRangeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

