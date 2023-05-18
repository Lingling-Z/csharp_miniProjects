namespace CustomerInfo
{
    partial class AddressForm
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
            this.streetLabel = new System.Windows.Forms.Label();
            this.suburbLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.streetText = new System.Windows.Forms.TextBox();
            this.suburbText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.zipCodeText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(90, 58);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(60, 25);
            this.streetLabel.TabIndex = 0;
            this.streetLabel.Text = "Street";
            // 
            // suburbLabel
            // 
            this.suburbLabel.AutoSize = true;
            this.suburbLabel.Location = new System.Drawing.Point(77, 105);
            this.suburbLabel.Name = "suburbLabel";
            this.suburbLabel.Size = new System.Drawing.Size(73, 25);
            this.suburbLabel.TabIndex = 0;
            this.suburbLabel.Text = "Suburb";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(106, 148);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(44, 25);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(62, 199);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(88, 25);
            this.zipCodeLabel.TabIndex = 0;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(176, 55);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(229, 32);
            this.streetText.TabIndex = 1;
            // 
            // suburbText
            // 
            this.suburbText.Location = new System.Drawing.Point(176, 105);
            this.suburbText.Name = "suburbText";
            this.suburbText.Size = new System.Drawing.Size(229, 32);
            this.suburbText.TabIndex = 2;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(176, 148);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(229, 32);
            this.cityText.TabIndex = 3;
            // 
            // zipCodeText
            // 
            this.zipCodeText.Location = new System.Drawing.Point(176, 196);
            this.zipCodeText.Name = "zipCodeText";
            this.zipCodeText.Size = new System.Drawing.Size(229, 32);
            this.zipCodeText.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(224, 277);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.zipCodeText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.suburbText);
            this.Controls.Add(this.streetText);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.suburbLabel);
            this.Controls.Add(this.streetLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label streetLabel;
        private Label suburbLabel;
        private Label cityLabel;
        private Label zipCodeLabel;
        private TextBox streetText;
        private TextBox suburbText;
        private TextBox cityText;
        private TextBox zipCodeText;
        private Button saveButton;
    }
}