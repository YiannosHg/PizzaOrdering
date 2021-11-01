
namespace PizzaOrdering
{
    partial class PizzaOrdering
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
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.IngredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.extraCheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.blackOlivesCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.peperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SizeGroupBox.SuspendLayout();
            this.IngredientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.label1);
            this.SizeGroupBox.Controls.Add(this.largeRadioButton);
            this.SizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.SizeGroupBox.Controls.Add(this.smallRadioButton);
            this.SizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 146);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(235, 144);
            this.SizeGroupBox.TabIndex = 0;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select size";
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(10, 109);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(112, 20);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.Text = "Large - € 15.00";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.largeRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(10, 85);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(125, 20);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.Text = "Medium - € 11.75";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(10, 61);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(104, 20);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.Text = "Small - € 5.50";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // IngredientsGroupBox
            // 
            this.IngredientsGroupBox.Controls.Add(this.ingredientsLabel);
            this.IngredientsGroupBox.Controls.Add(this.extraCheeseCheckBox);
            this.IngredientsGroupBox.Controls.Add(this.pineappleCheckBox);
            this.IngredientsGroupBox.Controls.Add(this.blackOlivesCheckBox);
            this.IngredientsGroupBox.Controls.Add(this.mushroomCheckBox);
            this.IngredientsGroupBox.Controls.Add(this.onionCheckBox);
            this.IngredientsGroupBox.Controls.Add(this.peperoniCheckBox);
            this.IngredientsGroupBox.Enabled = false;
            this.IngredientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IngredientsGroupBox.Location = new System.Drawing.Point(273, 146);
            this.IngredientsGroupBox.Name = "IngredientsGroupBox";
            this.IngredientsGroupBox.Size = new System.Drawing.Size(256, 144);
            this.IngredientsGroupBox.TabIndex = 1;
            this.IngredientsGroupBox.TabStop = false;
            this.IngredientsGroupBox.Text = "Ingredients";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(6, 19);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(159, 16);
            this.ingredientsLabel.TabIndex = 6;
            this.ingredientsLabel.Text = "Please select ingredients";
            // 
            // extraCheeseCheckBox
            // 
            this.extraCheeseCheckBox.AutoSize = true;
            this.extraCheeseCheckBox.Location = new System.Drawing.Point(143, 107);
            this.extraCheeseCheckBox.Name = "extraCheeseCheckBox";
            this.extraCheeseCheckBox.Size = new System.Drawing.Size(105, 20);
            this.extraCheeseCheckBox.TabIndex = 5;
            this.extraCheeseCheckBox.Text = "Extra cheese";
            this.extraCheeseCheckBox.UseVisualStyleBackColor = true;
            this.extraCheeseCheckBox.CheckedChanged += new System.EventHandler(this.extraCheeseCheckBox_CheckedChanged);
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(5, 107);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(89, 20);
            this.pineappleCheckBox.TabIndex = 4;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            this.pineappleCheckBox.CheckedChanged += new System.EventHandler(this.pineappleCheckBox_CheckedChanged);
            // 
            // blackOlivesCheckBox
            // 
            this.blackOlivesCheckBox.AutoSize = true;
            this.blackOlivesCheckBox.Location = new System.Drawing.Point(143, 84);
            this.blackOlivesCheckBox.Name = "blackOlivesCheckBox";
            this.blackOlivesCheckBox.Size = new System.Drawing.Size(102, 20);
            this.blackOlivesCheckBox.TabIndex = 3;
            this.blackOlivesCheckBox.Text = "Black Olives";
            this.blackOlivesCheckBox.UseVisualStyleBackColor = true;
            this.blackOlivesCheckBox.CheckedChanged += new System.EventHandler(this.blackOlivesCheckBox_CheckedChanged);
            // 
            // mushroomCheckBox
            // 
            this.mushroomCheckBox.AutoSize = true;
            this.mushroomCheckBox.Location = new System.Drawing.Point(5, 84);
            this.mushroomCheckBox.Name = "mushroomCheckBox";
            this.mushroomCheckBox.Size = new System.Drawing.Size(90, 20);
            this.mushroomCheckBox.TabIndex = 2;
            this.mushroomCheckBox.Text = "Mushroom";
            this.mushroomCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mushroomCheckBox.UseVisualStyleBackColor = true;
            this.mushroomCheckBox.CheckedChanged += new System.EventHandler(this.mushroomCheckBox_CheckedChanged);
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(143, 61);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(62, 20);
            this.onionCheckBox.TabIndex = 1;
            this.onionCheckBox.Text = "Onion";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // peperoniCheckBox
            // 
            this.peperoniCheckBox.AutoSize = true;
            this.peperoniCheckBox.Location = new System.Drawing.Point(5, 61);
            this.peperoniCheckBox.Name = "peperoniCheckBox";
            this.peperoniCheckBox.Size = new System.Drawing.Size(82, 20);
            this.peperoniCheckBox.TabIndex = 0;
            this.peperoniCheckBox.Text = "Peperoni";
            this.peperoniCheckBox.UseVisualStyleBackColor = true;
            this.peperoniCheckBox.CheckedChanged += new System.EventHandler(this.peperoniCheckBox_CheckedChanged);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderButton.Location = new System.Drawing.Point(157, 397);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(100, 39);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "&Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Enabled = false;
            this.timeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timeMaskedTextBox.Location = new System.Drawing.Point(120, 326);
            this.timeMaskedTextBox.Mask = "00:00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.timeMaskedTextBox.TabIndex = 3;
            this.timeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(8, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delivery Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(363, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Enabled = false;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.priceLabel.ForeColor = System.Drawing.Color.Red;
            this.priceLabel.Location = new System.Drawing.Point(449, 325);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 25);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unic Pizza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrdering.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(376, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(346, 397);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(100, 39);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // PizzaOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 488);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.IngredientsGroupBox);
            this.Controls.Add(this.SizeGroupBox);
            this.Name = "PizzaOrdering";
            this.Text = "PizzaOrdering";
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.IngredientsGroupBox.ResumeLayout(false);
            this.IngredientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.GroupBox IngredientsGroupBox;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.CheckBox extraCheeseCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
        private System.Windows.Forms.CheckBox blackOlivesCheckBox;
        private System.Windows.Forms.CheckBox mushroomCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox peperoniCheckBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingsButton;
    }
}

