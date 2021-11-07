
namespace PizzaOrdering
{
    partial class SettingsForm
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
            this.pizzaSizeDataGridView = new System.Windows.Forms.DataGridView();
            this.pizzaToppingsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveSizesButton = new System.Windows.Forms.Button();
            this.resetSizesButton = new System.Windows.Forms.Button();
            this.resetToppingsButton = new System.Windows.Forms.Button();
            this.saveToppingsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaSizeDataGridView
            // 
            this.pizzaSizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaSizeDataGridView.Location = new System.Drawing.Point(22, 19);
            this.pizzaSizeDataGridView.Name = "pizzaSizeDataGridView";
            this.pizzaSizeDataGridView.Size = new System.Drawing.Size(395, 217);
            this.pizzaSizeDataGridView.TabIndex = 0;
            // 
            // pizzaToppingsDataGridView
            // 
            this.pizzaToppingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzaToppingsDataGridView.Location = new System.Drawing.Point(23, 23);
            this.pizzaToppingsDataGridView.Name = "pizzaToppingsDataGridView";
            this.pizzaToppingsDataGridView.Size = new System.Drawing.Size(395, 217);
            this.pizzaToppingsDataGridView.TabIndex = 1;
            // 
            // saveSizesButton
            // 
            this.saveSizesButton.Location = new System.Drawing.Point(95, 257);
            this.saveSizesButton.Name = "saveSizesButton";
            this.saveSizesButton.Size = new System.Drawing.Size(92, 38);
            this.saveSizesButton.TabIndex = 3;
            this.saveSizesButton.Text = "Save";
            this.saveSizesButton.UseVisualStyleBackColor = true;
            this.saveSizesButton.Click += new System.EventHandler(this.saveSizesButton_Click);
            // 
            // resetSizesButton
            // 
            this.resetSizesButton.Location = new System.Drawing.Point(263, 257);
            this.resetSizesButton.Name = "resetSizesButton";
            this.resetSizesButton.Size = new System.Drawing.Size(92, 38);
            this.resetSizesButton.TabIndex = 4;
            this.resetSizesButton.Text = "Reset";
            this.resetSizesButton.UseVisualStyleBackColor = true;
            this.resetSizesButton.Click += new System.EventHandler(this.resetSizesButton_Click);
            // 
            // resetToppingsButton
            // 
            this.resetToppingsButton.Location = new System.Drawing.Point(275, 257);
            this.resetToppingsButton.Name = "resetToppingsButton";
            this.resetToppingsButton.Size = new System.Drawing.Size(92, 38);
            this.resetToppingsButton.TabIndex = 5;
            this.resetToppingsButton.Text = "Reset";
            this.resetToppingsButton.UseVisualStyleBackColor = true;
            this.resetToppingsButton.Click += new System.EventHandler(this.resetToppingsButton_Click);
            // 
            // saveToppingsButton
            // 
            this.saveToppingsButton.Location = new System.Drawing.Point(57, 257);
            this.saveToppingsButton.Name = "saveToppingsButton";
            this.saveToppingsButton.Size = new System.Drawing.Size(92, 38);
            this.saveToppingsButton.TabIndex = 6;
            this.saveToppingsButton.Text = "Save";
            this.saveToppingsButton.UseVisualStyleBackColor = true;
            this.saveToppingsButton.Click += new System.EventHandler(this.saveToppingsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pizzaSizeDataGridView);
            this.groupBox1.Controls.Add(this.resetSizesButton);
            this.groupBox1.Controls.Add(this.saveSizesButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 301);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sizes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pizzaToppingsDataGridView);
            this.groupBox2.Controls.Add(this.saveToppingsButton);
            this.groupBox2.Controls.Add(this.resetToppingsButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 301);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pizzaSizeDataGridView;
        private System.Windows.Forms.DataGridView pizzaToppingsDataGridView;
        private System.Windows.Forms.Button saveSizesButton;
        private System.Windows.Forms.Button resetSizesButton;
        private System.Windows.Forms.Button resetToppingsButton;
        private System.Windows.Forms.Button saveToppingsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}