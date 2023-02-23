namespace Lab_3
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
            this.ownerPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petDOBMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.petOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.ownerPhoneLabel = new System.Windows.Forms.Label();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petDOBLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.typeIfOtherLabel = new System.Windows.Forms.Label();
            this.typeIfOtherTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.furTrimmingPriceLabel = new System.Windows.Forms.Label();
            this.shampooPriceLabel = new System.Windows.Forms.Label();
            this.nailClippingPriceLabel = new System.Windows.Forms.Label();
            this.fleaRemovalPriceLabel = new System.Windows.Forms.Label();
            this.totalFee1Label = new System.Windows.Forms.Label();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.servicesGroupBox.SuspendLayout();
            this.petOwnerGroupBox.SuspendLayout();
            this.petGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerPhoneMaskedTextBox
            // 
            this.ownerPhoneMaskedTextBox.Location = new System.Drawing.Point(129, 58);
            this.ownerPhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.ownerPhoneMaskedTextBox.Name = "ownerPhoneMaskedTextBox";
            this.ownerPhoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerPhoneMaskedTextBox.TabIndex = 0;
            // 
            // petDOBMaskedTextBox
            // 
            this.petDOBMaskedTextBox.Location = new System.Drawing.Point(129, 56);
            this.petDOBMaskedTextBox.Mask = "00/00/0000";
            this.petDOBMaskedTextBox.Name = "petDOBMaskedTextBox";
            this.petDOBMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.petDOBMaskedTextBox.TabIndex = 1;
            this.petDOBMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.petDOBMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.petDOBMaskedTextBox_MaskInputRejected);
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.totalFeeLabel);
            this.servicesGroupBox.Controls.Add(this.totalFee1Label);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPriceLabel);
            this.servicesGroupBox.Controls.Add(this.nailClippingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPriceLabel);
            this.servicesGroupBox.Controls.Add(this.furTrimmingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.furTrimmingCheckBox);
            this.servicesGroupBox.Controls.Add(this.shampooCheckBox);
            this.servicesGroupBox.Controls.Add(this.nailClippingCheckBox);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalCheckBox);
            this.servicesGroupBox.Location = new System.Drawing.Point(12, 299);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(429, 122);
            this.servicesGroupBox.TabIndex = 2;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            this.servicesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // petOwnerGroupBox
            // 
            this.petOwnerGroupBox.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneLabel);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameLabel);
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneMaskedTextBox);
            this.petOwnerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.petOwnerGroupBox.Name = "petOwnerGroupBox";
            this.petOwnerGroupBox.Size = new System.Drawing.Size(429, 107);
            this.petOwnerGroupBox.TabIndex = 0;
            this.petOwnerGroupBox.TabStop = false;
            this.petOwnerGroupBox.Text = "Pet Owner";
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.typeIfOtherTextBox);
            this.petGroupBox.Controls.Add(this.typeIfOtherLabel);
            this.petGroupBox.Controls.Add(this.otherRadioButton);
            this.petGroupBox.Controls.Add(this.dogRadioButton);
            this.petGroupBox.Controls.Add(this.catRadioButton);
            this.petGroupBox.Controls.Add(this.petTypeLabel);
            this.petGroupBox.Controls.Add(this.petDOBLabel);
            this.petGroupBox.Controls.Add(this.petNameLabel);
            this.petGroupBox.Controls.Add(this.petNameTextBox);
            this.petGroupBox.Controls.Add(this.petDOBMaskedTextBox);
            this.petGroupBox.Location = new System.Drawing.Point(12, 125);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(429, 168);
            this.petGroupBox.TabIndex = 0;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Text = "Pet";
            this.petGroupBox.Enter += new System.EventHandler(this.petGroupBox_Enter);
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(29, 28);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(72, 13);
            this.ownerNameLabel.TabIndex = 2;
            this.ownerNameLabel.Text = "&Owner Name:";
            // 
            // ownerPhoneLabel
            // 
            this.ownerPhoneLabel.AutoSize = true;
            this.ownerPhoneLabel.Location = new System.Drawing.Point(29, 65);
            this.ownerPhoneLabel.Name = "ownerPhoneLabel";
            this.ownerPhoneLabel.Size = new System.Drawing.Size(75, 13);
            this.ownerPhoneLabel.TabIndex = 3;
            this.ownerPhoneLabel.Text = "O&wner Phone:";
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(129, 21);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.ownerNameTextBox.TabIndex = 4;
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(129, 21);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.petNameTextBox.TabIndex = 2;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Location = new System.Drawing.Point(29, 28);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(57, 13);
            this.petNameLabel.TabIndex = 3;
            this.petNameLabel.Text = "&Pet Name:";
            this.petNameLabel.Click += new System.EventHandler(this.petNameLabel_Click);
            // 
            // petDOBLabel
            // 
            this.petDOBLabel.AutoSize = true;
            this.petDOBLabel.Location = new System.Drawing.Point(29, 63);
            this.petDOBLabel.Name = "petDOBLabel";
            this.petDOBLabel.Size = new System.Drawing.Size(88, 13);
            this.petDOBLabel.TabIndex = 4;
            this.petDOBLabel.Text = "P&et Date of Birth:";
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.Location = new System.Drawing.Point(29, 108);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.petTypeLabel.TabIndex = 5;
            this.petTypeLabel.Text = "Pe&t Type:";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(265, 106);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(51, 17);
            this.otherRadioButton.TabIndex = 0;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Location = new System.Drawing.Point(199, 104);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(45, 17);
            this.dogRadioButton.TabIndex = 1;
            this.dogRadioButton.TabStop = true;
            this.dogRadioButton.Text = "Dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            this.dogRadioButton.CheckedChanged += new System.EventHandler(this.dogRadioButton_CheckedChanged);
            // 
            // catRadioButton
            // 
            this.catRadioButton.AutoSize = true;
            this.catRadioButton.Location = new System.Drawing.Point(129, 104);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(41, 17);
            this.catRadioButton.TabIndex = 2;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "Cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeIfOtherLabel
            // 
            this.typeIfOtherLabel.AutoSize = true;
            this.typeIfOtherLabel.Enabled = false;
            this.typeIfOtherLabel.Location = new System.Drawing.Point(167, 136);
            this.typeIfOtherLabel.Name = "typeIfOtherLabel";
            this.typeIfOtherLabel.Size = new System.Drawing.Size(77, 13);
            this.typeIfOtherLabel.TabIndex = 6;
            this.typeIfOtherLabel.Text = "T&ype (if Other):";
            // 
            // typeIfOtherTextBox
            // 
            this.typeIfOtherTextBox.Enabled = false;
            this.typeIfOtherTextBox.Location = new System.Drawing.Point(265, 129);
            this.typeIfOtherTextBox.Name = "typeIfOtherTextBox";
            this.typeIfOtherTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeIfOtherTextBox.TabIndex = 7;
            this.typeIfOtherTextBox.TextChanged += new System.EventHandler(this.typeIfOtherTextBox_TextChanged);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(54, 443);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "T&otal";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(302, 442);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(181, 442);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.AutoSize = true;
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(273, 42);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(86, 17);
            this.furTrimmingCheckBox.TabIndex = 8;
            this.furTrimmingCheckBox.Text = "F&ur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(273, 19);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(71, 17);
            this.shampooCheckBox.TabIndex = 9;
            this.shampooCheckBox.Text = "&Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.AutoSize = true;
            this.nailClippingCheckBox.Location = new System.Drawing.Point(32, 42);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(84, 17);
            this.nailClippingCheckBox.TabIndex = 10;
            this.nailClippingCheckBox.Text = "&Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.AutoSize = true;
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(32, 19);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(91, 17);
            this.fleaRemovalCheckBox.TabIndex = 11;
            this.fleaRemovalCheckBox.Text = "&Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // furTrimmingPriceLabel
            // 
            this.furTrimmingPriceLabel.AutoSize = true;
            this.furTrimmingPriceLabel.Location = new System.Drawing.Point(366, 46);
            this.furTrimmingPriceLabel.Name = "furTrimmingPriceLabel";
            this.furTrimmingPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.furTrimmingPriceLabel.TabIndex = 12;
            this.furTrimmingPriceLabel.Text = "PRICE";
            // 
            // shampooPriceLabel
            // 
            this.shampooPriceLabel.AutoSize = true;
            this.shampooPriceLabel.Location = new System.Drawing.Point(366, 23);
            this.shampooPriceLabel.Name = "shampooPriceLabel";
            this.shampooPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.shampooPriceLabel.TabIndex = 13;
            this.shampooPriceLabel.Text = "PRICE";
            // 
            // nailClippingPriceLabel
            // 
            this.nailClippingPriceLabel.AutoSize = true;
            this.nailClippingPriceLabel.Location = new System.Drawing.Point(135, 46);
            this.nailClippingPriceLabel.Name = "nailClippingPriceLabel";
            this.nailClippingPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.nailClippingPriceLabel.TabIndex = 14;
            this.nailClippingPriceLabel.Text = "PRICE";
            // 
            // fleaRemovalPriceLabel
            // 
            this.fleaRemovalPriceLabel.AutoSize = true;
            this.fleaRemovalPriceLabel.Location = new System.Drawing.Point(135, 23);
            this.fleaRemovalPriceLabel.Name = "fleaRemovalPriceLabel";
            this.fleaRemovalPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.fleaRemovalPriceLabel.TabIndex = 15;
            this.fleaRemovalPriceLabel.Text = "PRICE";
            // 
            // totalFee1Label
            // 
            this.totalFee1Label.AutoSize = true;
            this.totalFee1Label.Location = new System.Drawing.Point(135, 86);
            this.totalFee1Label.Name = "totalFee1Label";
            this.totalFee1Label.Size = new System.Drawing.Size(55, 13);
            this.totalFee1Label.TabIndex = 11;
            this.totalFee1Label.Text = "Total Fee:";
            this.totalFee1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(199, 76);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(56, 23);
            this.totalFeeLabel.TabIndex = 16;
            this.totalFeeLabel.Click += new System.EventHandler(this.totalFeeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 477);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.petOwnerGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.petOwnerGroupBox.ResumeLayout(false);
            this.petOwnerGroupBox.PerformLayout();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ownerPhoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox petDOBMaskedTextBox;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.GroupBox petOwnerGroupBox;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label ownerPhoneLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petDOBLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.TextBox typeIfOtherTextBox;
        private System.Windows.Forms.Label typeIfOtherLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label fleaRemovalPriceLabel;
        private System.Windows.Forms.Label nailClippingPriceLabel;
        private System.Windows.Forms.Label shampooPriceLabel;
        private System.Windows.Forms.Label furTrimmingPriceLabel;
        private System.Windows.Forms.Label totalFee1Label;
        private System.Windows.Forms.Label totalFeeLabel;
    }
}

