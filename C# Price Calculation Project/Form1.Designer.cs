namespace Lab_4_1
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
            this.saleLabel = new System.Windows.Forms.Label();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.countyGroupBox = new System.Windows.Forms.GroupBox();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stateSalesTaxLabel1 = new System.Windows.Forms.Label();
            this.propertyPriceLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commissionLabel1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.stateSalesTaxaLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.updatePropertyPriceButton = new System.Windows.Forms.Button();
            this.propertyTypeGroupBox.SuspendLayout();
            this.countyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Location = new System.Drawing.Point(54, 24);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(57, 13);
            this.saleLabel.TabIndex = 0;
            this.saleLabel.Text = "Sale Date:";
            this.saleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(57, 53);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(159, 100);
            this.propertyTypeGroupBox.TabIndex = 1;
            this.propertyTypeGroupBox.TabStop = false;
            this.propertyTypeGroupBox.Text = "Property Type";
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(21, 36);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(80, 17);
            this.residentialRadioButton.TabIndex = 2;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential ";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(21, 59);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(79, 17);
            this.commercialRadioButton.TabIndex = 3;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            this.commercialRadioButton.CheckedChanged += new System.EventHandler(this.commercialRadioButton_CheckedChanged);
            // 
            // countyGroupBox
            // 
            this.countyGroupBox.Controls.Add(this.polkRadioButton);
            this.countyGroupBox.Controls.Add(this.pascoRadioButton);
            this.countyGroupBox.Controls.Add(this.hillsboroughRadioButton);
            this.countyGroupBox.Location = new System.Drawing.Point(57, 159);
            this.countyGroupBox.Name = "countyGroupBox";
            this.countyGroupBox.Size = new System.Drawing.Size(159, 100);
            this.countyGroupBox.TabIndex = 0;
            this.countyGroupBox.TabStop = false;
            this.countyGroupBox.Text = "County";
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(21, 65);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(46, 17);
            this.polkRadioButton.TabIndex = 4;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(21, 42);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(55, 17);
            this.pascoRadioButton.TabIndex = 5;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.AutoSize = true;
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(21, 19);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(85, 17);
            this.hillsboroughRadioButton.TabIndex = 6;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hilllsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            this.hillsboroughRadioButton.CheckedChanged += new System.EventHandler(this.hillsboroughRadioButton_CheckedChanged);
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(116, 21);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(70, 20);
            this.dateMaskedTextBox.TabIndex = 0;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // stateSalesTaxLabel1
            // 
            this.stateSalesTaxLabel1.AutoSize = true;
            this.stateSalesTaxLabel1.Location = new System.Drawing.Point(54, 324);
            this.stateSalesTaxLabel1.Name = "stateSalesTaxLabel1";
            this.stateSalesTaxLabel1.Size = new System.Drawing.Size(85, 13);
            this.stateSalesTaxLabel1.TabIndex = 2;
            this.stateSalesTaxLabel1.Text = "State Sales Tax:";
            // 
            // propertyPriceLabel
            // 
            this.propertyPriceLabel.AutoSize = true;
            this.propertyPriceLabel.Location = new System.Drawing.Point(54, 275);
            this.propertyPriceLabel.Name = "propertyPriceLabel";
            this.propertyPriceLabel.Size = new System.Drawing.Size(76, 13);
            this.propertyPriceLabel.TabIndex = 3;
            this.propertyPriceLabel.Text = "Property Price:";
            // 
            // countySalesTaxLabel1
            // 
            this.countySalesTaxLabel1.AutoSize = true;
            this.countySalesTaxLabel1.Location = new System.Drawing.Point(54, 357);
            this.countySalesTaxLabel1.Name = "countySalesTaxLabel1";
            this.countySalesTaxLabel1.Size = new System.Drawing.Size(93, 13);
            this.countySalesTaxLabel1.TabIndex = 4;
            this.countySalesTaxLabel1.Text = "County Sales Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Price";
            // 
            // commissionLabel1
            // 
            this.commissionLabel1.AutoSize = true;
            this.commissionLabel1.Location = new System.Drawing.Point(82, 388);
            this.commissionLabel1.Name = "commissionLabel1";
            this.commissionLabel1.Size = new System.Drawing.Size(65, 13);
            this.commissionLabel1.TabIndex = 6;
            this.commissionLabel1.Text = "Commission:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(22, 461);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 461);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 461);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(146, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(70, 4);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(156, 268);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(64, 20);
            this.propertyPriceTextBox.TabIndex = 0;
            this.propertyPriceTextBox.Text = "0.00";
            this.propertyPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // stateSalesTaxaLabel
            // 
            this.stateSalesTaxaLabel.BackColor = System.Drawing.Color.White;
            this.stateSalesTaxaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxaLabel.Location = new System.Drawing.Point(156, 314);
            this.stateSalesTaxaLabel.Name = "stateSalesTaxaLabel";
            this.stateSalesTaxaLabel.Size = new System.Drawing.Size(64, 23);
            this.stateSalesTaxaLabel.TabIndex = 11;
            this.stateSalesTaxaLabel.Text = "$0.00";
            this.stateSalesTaxaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // commissionLabel
            // 
            this.commissionLabel.BackColor = System.Drawing.Color.White;
            this.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionLabel.Location = new System.Drawing.Point(155, 380);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(65, 21);
            this.commissionLabel.TabIndex = 12;
            this.commissionLabel.Text = "$0.00";
            this.commissionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BackColor = System.Drawing.Color.White;
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(156, 350);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(64, 20);
            this.countySalesTaxLabel.TabIndex = 13;
            this.countySalesTaxLabel.Text = "$0.00";
            this.countySalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.White;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(156, 420);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(74, 23);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "$0.00";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updatePropertyPriceButton
            // 
            this.updatePropertyPriceButton.AutoSize = true;
            this.updatePropertyPriceButton.Location = new System.Drawing.Point(78, 291);
            this.updatePropertyPriceButton.Name = "updatePropertyPriceButton";
            this.updatePropertyPriceButton.Size = new System.Drawing.Size(121, 23);
            this.updatePropertyPriceButton.TabIndex = 7;
            this.updatePropertyPriceButton.Text = "Update Property Price";
            this.updatePropertyPriceButton.UseVisualStyleBackColor = true;
            this.updatePropertyPriceButton.Click += new System.EventHandler(this.updatePropertyPriceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 496);
            this.Controls.Add(this.updatePropertyPriceButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.stateSalesTaxaLabel);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.commissionLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countySalesTaxLabel1);
            this.Controls.Add(this.propertyPriceLabel);
            this.Controls.Add(this.stateSalesTaxLabel1);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.countyGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.saleLabel);
            this.Name = "Form1";
            this.Text = "Real Estate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.propertyTypeGroupBox.PerformLayout();
            this.countyGroupBox.ResumeLayout(false);
            this.countyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.GroupBox countyGroupBox;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label stateSalesTaxLabel1;
        private System.Windows.Forms.Label propertyPriceLabel;
        private System.Windows.Forms.Label countySalesTaxLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label commissionLabel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Label stateSalesTaxaLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button updatePropertyPriceButton;
    }
}

