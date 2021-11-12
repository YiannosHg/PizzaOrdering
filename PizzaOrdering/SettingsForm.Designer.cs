
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
            this.sizesGroupBox = new System.Windows.Forms.GroupBox();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.saveUsersButton = new System.Windows.Forms.Button();
            this.resetUsersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).BeginInit();
            this.sizesGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            this.usersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
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
            // sizesGroupBox
            // 
            this.sizesGroupBox.Controls.Add(this.pizzaSizeDataGridView);
            this.sizesGroupBox.Controls.Add(this.resetSizesButton);
            this.sizesGroupBox.Controls.Add(this.saveSizesButton);
            this.sizesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sizesGroupBox.Location = new System.Drawing.Point(18, 12);
            this.sizesGroupBox.Name = "sizesGroupBox";
            this.sizesGroupBox.Size = new System.Drawing.Size(436, 301);
            this.sizesGroupBox.TabIndex = 7;
            this.sizesGroupBox.TabStop = false;
            this.sizesGroupBox.Text = "Sizes";
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.pizzaToppingsDataGridView);
            this.toppingsGroupBox.Controls.Add(this.saveToppingsButton);
            this.toppingsGroupBox.Controls.Add(this.resetToppingsButton);
            this.toppingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toppingsGroupBox.Location = new System.Drawing.Point(496, 12);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(436, 301);
            this.toppingsGroupBox.TabIndex = 8;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Toppings";
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.usersDataGridView);
            this.usersGroupBox.Controls.Add(this.saveUsersButton);
            this.usersGroupBox.Controls.Add(this.resetUsersButton);
            this.usersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usersGroupBox.Location = new System.Drawing.Point(150, 331);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(647, 301);
            this.usersGroupBox.TabIndex = 9;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Users";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(23, 23);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(604, 217);
            this.usersDataGridView.TabIndex = 1;
            // 
            // saveUsersButton
            // 
            this.saveUsersButton.Location = new System.Drawing.Point(131, 246);
            this.saveUsersButton.Name = "saveUsersButton";
            this.saveUsersButton.Size = new System.Drawing.Size(92, 38);
            this.saveUsersButton.TabIndex = 6;
            this.saveUsersButton.Text = "Save";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            this.saveUsersButton.Click += new System.EventHandler(this.saveUsersButton_Click);
            // 
            // resetUsersButton
            // 
            this.resetUsersButton.Location = new System.Drawing.Point(403, 257);
            this.resetUsersButton.Name = "resetUsersButton";
            this.resetUsersButton.Size = new System.Drawing.Size(92, 38);
            this.resetUsersButton.TabIndex = 5;
            this.resetUsersButton.Text = "Reset";
            this.resetUsersButton.UseVisualStyleBackColor = true;
            this.resetUsersButton.Click += new System.EventHandler(this.resetUsersButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 655);
            this.Controls.Add(this.usersGroupBox);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.sizesGroupBox);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSizeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaToppingsDataGridView)).EndInit();
            this.sizesGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.ResumeLayout(false);
            this.usersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pizzaSizeDataGridView;
        private System.Windows.Forms.DataGridView pizzaToppingsDataGridView;
        private System.Windows.Forms.Button saveSizesButton;
        private System.Windows.Forms.Button resetSizesButton;
        private System.Windows.Forms.Button resetToppingsButton;
        private System.Windows.Forms.Button saveToppingsButton;
        private System.Windows.Forms.GroupBox sizesGroupBox;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button saveUsersButton;
        private System.Windows.Forms.Button resetUsersButton;
    }
}